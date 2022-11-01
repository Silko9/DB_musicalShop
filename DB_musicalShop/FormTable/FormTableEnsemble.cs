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
    public partial class FormTableEnsemble : Form
    {
        ManagerDB managerDB = new ManagerDB();
        public FormTableEnsemble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("", "ID Ансамбл");
            dataGridView1.Columns.Add("", "Название");
            dataGridView1.Columns.Add("", "Тип Ансамбля");
            dataGridView1.Columns[1].Width = 150;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable type = managerDB.Select("SELECT * FROM [type_ensemble];");
            DataRow row;
            DataRow rowType;
            boxTypeEnsemble.Items.Clear();
            for (int i = 0; i < type.Rows.Count; i++)
            {
                row = type.Rows[i];
                boxTypeEnsemble.Items.Add(Convert.ToString($"{row["name_type_ensemble"]} [id{row["id_type_ensemble"]}]"));
            }
            DataTable table = managerDB.Select("SELECT * FROM [ensemble]");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                rowType = type.Rows[Convert.ToInt32(row["id_type_ensemble"]) - 1];
                dataGridView1.Rows.Add(row["id_ensemble"], row["name_ensemble"], $"{rowType["name_type_ensemble"]} [id{rowType["id_type_ensemble"]}]");
            }
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private int GetID(string str)
        {
            string id = "";
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '[')
                {
                    i += 3;
                    while (str[i] != ']')
                    {
                        id += str[i];
                        i++;
                    }
                }
            return Convert.ToInt32(id);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string commandText = $"INSERT INTO [ensemble] ([name_ensemble], [id_type_ensemble])" +
                $"VALUES(\"{boxName.Text}\",\"{GetID(boxTypeEnsemble.Text)}\");";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            string commandText = $"UPDATE [ensemble] SET name_ensemble = \"{boxName.Text}\", " +
                $"id_type_ensemble = {GetID(boxTypeEnsemble.Text)} " +
                $"WHERE id_ensemble = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string commandText = $"DELETE FROM [ensemble] WHERE id_ensemble = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DataRow row;
            DataTable table = managerDB.Select($"SELECT * FROM [type_ensemble] WHERE id_type_ensemble = {GetID(dataGridView1.CurrentRow.Cells[2].Value.ToString())};");
            row = table.Rows[0];
            boxTypeEnsemble.Text = Convert.ToString($"{row["name_type_ensemble"]} [id{row["id_type_ensemble"]}]");
        }
    }
}