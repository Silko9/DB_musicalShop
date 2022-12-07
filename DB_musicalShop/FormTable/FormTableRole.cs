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
            dataRole.RowHeadersVisible = false;
            dataRole.AllowUserToAddRows = false;
            dataMusician.RowHeadersVisible = false;
            dataMusician.AllowUserToAddRows = false;
            dataMusician.Columns.Add("", "Музыкант");
            dataMusician.Columns[0].Width = 130;
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
            dataRole.DataSource = table;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataRole.Columns[i].HeaderText = dataTable[i].name;
                dataRole.Columns[i].Width = dataTable[i].width;
            }
            dataMusician.Rows.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRole.Rows.Count > 0)
                boxName.Text = dataRole.CurrentRow.Cells[1].Value.ToString();
            dataMusician.Rows.Clear();//загрузка музыкантов в data
            DataTable table = managerDB.SelectTable($"SELECT id_musician FROM relation_musician_role WHERE id_role = {dataRole.CurrentRow.Cells[0].Value}");
            DataTable musician = managerDB.SelectTable("SELECT * FROM musician");
            DataRow row;
            DataRow rowMusician;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                for (int j = 0; j < musician.Rows.Count; j++)
                {
                    rowMusician = musician.Rows[j];
                    if (row["id_musician"].ToString() == rowMusician["id_musician"].ToString())
                        dataMusician.Rows.Add($"{rowMusician["name_musician"]} {rowMusician["surname_musician"]} {rowMusician["patronymic_musician"]}");
                }
            }
            boxMusician.Items.Clear();//загрузка музыкантов в box
            bool flag;
            for (int i = 0; i < musician.Rows.Count; i++)
            {
                rowMusician = musician.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (rowMusician["id_musician"].ToString() == row["id_musician"].ToString())
                        flag = false;
                }
                if (flag) boxMusician.Items.Add($"{rowMusician["name_musician"]} {rowMusician["surname_musician"]} {rowMusician["patronymic_musician"]}");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataRole.RowCount == 0) return;
            string id = dataRole.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM role WHERE id_role = {dataRole.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataRole.RowCount == 0) return;
            if (CheckRecord()) return;
            string commandText = $"UPDATE role SET name_role = \"{boxName.Text}\" WHERE id_role = {dataRole.CurrentRow.Cells[0].Value};";
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

        private void buttonAddMusician_Click(object sender, EventArgs e)
        {
            try
            {
                string[] musician = boxMusician.Text.Split(' ');
                DataTable table = managerDB.SelectTable("SELECT * FROM musician WHERE " +
                    $"name_musician = \"{musician[0]}\" AND " +
                    $"surname_musician = \"{musician[1]}\" AND " +
                    $"patronymic_musician = \"{musician[2]}\";");
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такого музыканта нет в базе данных, добавьте его или выберите из списка существующего.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = table.Rows[0];
                table = managerDB.SelectTable($"SELECT * FROM relation_musician_role WHERE id_role = {dataRole.CurrentRow.Cells[0].Value} AND id_musician = {row["id_musician"]}");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("У данного музыканта уже есть данная роль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Query("INSERT INTO relation_musician_role " +
                    "(id_role, id_musician) " +
                    $"VALUES ({dataRole.CurrentRow.Cells[0].Value}, {row["id_musician"]})");
            }
            catch{
                MessageBox.Show("Такого музыканта нет в базе данных, добавьте его или выберите из списка существующего.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonDeleteMusician_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataRole.RowCount == 0) return;
            string[] musician = dataMusician.CurrentRow.Cells[0].Value.ToString().Split(' ');
            DataTable table = managerDB.SelectTable("SELECT * FROM musician WHERE " +
                $"name_musician = \"{musician[0]}\" AND " +
                $"surname_musician = \"{musician[1]}\" AND " +
                $"patronymic_musician = \"{musician[2]}\";");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_role WHERE id_role = {dataRole.CurrentRow.Cells[0].Value} AND id_musician = {row["id_musician"]};";
            Query(commandText);
        }
    }
}
