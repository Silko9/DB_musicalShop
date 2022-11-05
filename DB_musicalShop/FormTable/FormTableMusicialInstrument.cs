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
    public partial class FormTableMusicialInstrument : Form
    {
        ManagerDB managerDB = new ManagerDB();
        public FormTableMusicialInstrument(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            UpdateTable();
        }
        private void UpdateTable()
        {
            DataTable table = managerDB.SelectTable("SELECT * FROM [musicial_instrument];");
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID Инструмента";
            dataGridView1.Columns[1].HeaderText = "Название";
        }
        private void Query(string command)
        {
            managerDB.Query(command);
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
                string commandText = $"INSERT INTO [musicial_instrument] ([name_instrument]) VALUES(\"{boxName.Text}\");";
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
            if (boxName.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text))
                {
                    MessageBox.Show("В поле должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"UPDATE [musicial_instrument] SET name_instrument = \"{boxName.Text}\" WHERE id_instrument = {dataGridView1.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string commandText = $"DELETE FROM [musicial_instrument] WHERE id_instrument = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
