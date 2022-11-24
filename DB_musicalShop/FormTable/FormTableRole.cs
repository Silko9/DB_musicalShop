using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop
{
    public partial class FormTableRole : Form
    {
        ManagerDB managerDB;
        Table[] dataTable = new Table[2] {  new Table("ID Роли", 60), new Table("Название", 140)};
        public FormTableRole(ManagerDB managerDB)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            this.managerDB = managerDB;
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckRecord()) return;
            string commandText = $"INSERT INTO role (name_role) VALUES(\"{boxName.Text}\");";
            Query(commandText);
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void UpdateTable()
        {
            DataTable table = managerDB.SelectTable("SELECT * FROM role;");
            dataGridView1.DataSource = table;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = dataTable[i].name;
                dataGridView1.Columns[i].Width = dataTable[i].width;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM role WHERE id_role = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (CheckRecord()) return;
            string commandText = $"UPDATE role SET name_role = \"{boxName.Text}\" WHERE id_role = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private bool CheckRecord()
        {
            if (boxName.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            DataTable table = managerDB.SelectTable($"SELECT * FROM role WHERE name_role = \"{boxName.Text}\"");
            if (table.Rows.Count != 0)
            {
                MessageBox.Show("Такая роль уже есть.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
