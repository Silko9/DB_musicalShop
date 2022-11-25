using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop
{
    public partial class FormTableTypeEnseble : Form
    {
        ManagerDB managerDB = new ManagerDB();
        Table[] dataTable = new Table[2] { new Table("ID Тип ансамбля", 70), new Table("Название", 130) };
        public FormTableTypeEnseble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataTypeEnsemble.RowHeadersVisible = false;
            dataTypeEnsemble.AllowUserToAddRows = false;
            dataEnsemble.RowHeadersVisible = false;
            dataEnsemble.AllowUserToAddRows = false;
            dataEnsemble.Columns.Add("", "Ансамбли");
            dataEnsemble.Columns[0].Width = 130;
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
            DataTable table = managerDB.SelectTable("SELECT * FROM [type_ensemble];");
            dataTypeEnsemble.DataSource = table;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataTypeEnsemble.Columns[i].HeaderText = dataTable[i].name;
                dataTypeEnsemble.Columns[i].Width = dataTable[i].width;
            }
            dataEnsemble.Rows.Clear();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckRecord()) return;
            string commandText = $"INSERT INTO type_ensemble (name_type_ensemble) VALUES(\"{boxName.Text}\");";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataTypeEnsemble.RowCount == 0) return;
            if (CheckRecord()) return;
            string commandText = $"UPDATE type_ensemble SET name_type_ensemble = \"{boxName.Text}\" WHERE id_type_ensemble = {dataTypeEnsemble.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataTypeEnsemble.RowCount == 0) return;
            string id = dataTypeEnsemble.CurrentRow.Cells[0].Value.ToString();
            DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE id_type_ensemble = {id};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"тип ансамбля\", пока она используется хотя бы в одной записи таблицы \"Ансамбли\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
                return;
            }
            string commandText = $"DELETE FROM type_ensemble WHERE id_type_ensemble = {id};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataTypeEnsemble.Rows.Count > 0)
                boxName.Text = dataTypeEnsemble.CurrentRow.Cells[1].Value.ToString();
            dataEnsemble.Rows.Clear();//загрузка ансамблей в data
            DataTable table = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE id_type_ensemble = {dataTypeEnsemble.CurrentRow.Cells[0].Value}");
            DataRow row;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataEnsemble.Rows.Add(row["name_ensemble"]);
            }
        }
        private bool CheckRecord()
        {
            if (boxName.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            DataTable table = managerDB.SelectTable($"SELECT * FROM type_ensemble WHERE name_type_ensemble = \"{boxName.Text}\"");
            if (table.Rows.Count != 0)
            {
                MessageBox.Show("Уже есть такой тип ансамбля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
