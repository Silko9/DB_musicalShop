using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DB_musicalShop
{
    public partial class FormTableEnsemble : Form
    {
        ManagerDB managerDB = new ManagerDB();
        Table[] dataTable = new Table[3] { new Table("ID Ансамбль", 60), new Table("Название", 170), new Table("Тип Ансамбля", 160) };
        public FormTableEnsemble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataGridView1.Columns.Add("", dataTable[i].name);
                dataGridView1.Columns[i].Width = dataTable[i].width;
            }
            UpdateTable();
        }
        private struct Table
        {
            public string name;
            public int width;
            public Table(string name, int width)
            {
                this.name = name;
                this.width = width;
            }
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable type = managerDB.SelectTable("SELECT * FROM [type_ensemble];");
            DataRow row;
            DataRow rowType;
            string currentItem = boxTypeEnsemble.Text;
            boxTypeEnsemble.Items.Clear();
            for (int i = 0; i < type.Rows.Count; i++)
            {
                row = type.Rows[i];
                boxTypeEnsemble.Items.Add(Convert.ToString(row["name_type_ensemble"]));
            }
            DataTable table = managerDB.SelectTable("SELECT * FROM [ensemble]");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowType = type.Rows[0];
                    for (int j = 0; j < type.Rows.Count; j++)
                    {
                        rowType = type.Rows[j];
                        if (rowType["id_type_ensemble"].ToString() == row["id_type_ensemble"].ToString())
                            break;
                    }
                    dataGridView1.Rows.Add(row["id_ensemble"], row["name_ensemble"], rowType["name_type_ensemble"]);
                }
                catch
                {
                    dataGridView1.Rows.Add(row["id_ensemble"], row["name_ensemble"], "");
                }
            }
            boxTypeEnsemble.Text = currentItem;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text == "" || boxTypeEnsemble.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE name_ensemble = \"{boxName.Text}\"");
            if (table.Rows.Count != 0)
            {
                MessageBox.Show("Уже есть такой Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            table = managerDB.SelectTable($"SELECT * FROM type_ensemble WHERE name_type_ensemble = \"{boxTypeEnsemble.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нету такого типа ансамбля, выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            string commandText = $"INSERT INTO ensemble (name_ensemble, id_type_ensemble)" +
            $"VALUES(\"{boxName.Text}\", {row["id_type_ensemble"]});";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxName.Text == "" || boxTypeEnsemble.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table = managerDB.SelectTable($"SELECT * FROM type_ensemble WHERE name_type_ensemble = \"{boxTypeEnsemble.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нету такого типа ансамбля, выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            table = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE name_ensemble = \"{boxName.Text}\"");
            if (table.Rows.Count != 0)
            {
                MessageBox.Show("Уже есть такой Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            string commandText = $"UPDATE [ensemble] SET " +
            $"name_ensemble = \"{boxName.Text}\", " +
            $"id_type_ensemble = {row["id_type_ensemble"]} " +
            $"WHERE id_ensemble = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM relation_musician_ensemble WHERE id_ensemble = {id};";
            Query(commandText);
            commandText = $"DELETE FROM ensemble WHERE id_ensemble = {id};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxTypeEnsemble.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}