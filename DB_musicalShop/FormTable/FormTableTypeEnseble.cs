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
    public partial class FormTableTypeEnseble : Form
    {
        ManagerDB managerDB = new ManagerDB();
        public FormTableTypeEnseble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataGridView1.RowHeadersVisible = false;
            UpdateTable();
        }
        private void UpdateTable()
        {
            DataTable table = managerDB.Select("SELECT * FROM [type_ensemble];");
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID Тип ансамбля";
            dataGridView1.Columns[1].HeaderText = "Название";
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string commandText = $"INSERT INTO [type_ensemble] ([name_type_ensemble]) VALUES(\"{boxName.Text}\");";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            string commandText = $"UPDATE [type_ensemble] SET name_type_ensemble = \"{boxName.Text}\" WHERE id_type_ensemble = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string commandText = $"DELETE FROM [type_ensemble] WHERE id_type_ensemble = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
