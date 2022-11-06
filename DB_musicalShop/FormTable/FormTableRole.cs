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
        public FormTableRole(ManagerDB managerDB)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text))
                {
                    MessageBox.Show("В поле должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO role (name_role) VALUES(\"{boxName.Text}\");";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dataGridView1.Columns[0].HeaderText = "ID Роли";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 140;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string commandText = $"DELETE FROM role WHERE id_role = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxName.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text))
                {
                    MessageBox.Show("В поле должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"UPDATE role SET name_role = \"{boxName.Text}\" WHERE id_role = {dataGridView1.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
