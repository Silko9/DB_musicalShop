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
        public FormTableEnsemble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("", "ID Ансамбль");
            dataGridView1.Columns.Add("", "Название");
            dataGridView1.Columns.Add("", "Тип Ансамбля");
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 160;
            dataGridView1.AllowUserToAddRows = false;
            UpdateTable();
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
                boxTypeEnsemble.Items.Add(Convert.ToString($"{row["name_type_ensemble"]} [id{row["id_type_ensemble"]}]"));
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
                    dataGridView1.Rows.Add(row["id_ensemble"], row["name_ensemble"], $"{rowType["name_type_ensemble"]} [id{rowType["id_type_ensemble"]}]");
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
            if (boxName.Text != "" && boxTypeEnsemble.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text))
                {
                    MessageBox.Show("В поле должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO [ensemble] ([name_ensemble], [id_type_ensemble])" +
                $"VALUES(\"{boxName.Text}\",\"{managerDB.GetID(boxTypeEnsemble.Text)}\");";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxName.Text != "" && boxTypeEnsemble.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text))
                {
                    MessageBox.Show("В поле должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"UPDATE [ensemble] SET " +
                $"name_ensemble = \"{boxName.Text}\", " +
                $"id_type_ensemble = {managerDB.GetID(boxTypeEnsemble.Text)} " +
                $"WHERE id_ensemble = {dataGridView1.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataTable table = managerDB.SelectTable($"SELECT * FROM musician WHERE id_ensemble = {id};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Ансамбль\", пока она используется хотя бы в одной записи таблицы \"Музыкант\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
            }
            else
            {
                string commandText = $"DELETE FROM ensemble WHERE id_ensemble = {id};";
                Query(commandText);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxTypeEnsemble.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}