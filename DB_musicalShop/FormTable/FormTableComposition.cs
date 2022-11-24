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
    public partial class FormTableComposition : Form
    {
        ManagerDB managerDB;
        Table[] dataTable = new Table[6] {  new Table("ID Произведения", 90), new Table("Название произведения", 170), new Table("Имя автора", 130), 
                                            new Table("Фамилия автора", 130), new Table("Отчество автора", 130), new Table("Дата создания", 110) };
        public FormTableComposition(ManagerDB managerDB)
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
        private void UpdateTable()
        {
            DataTable table = managerDB.SelectTable("SELECT * FROM composition;");
            dataGridView1.DataSource = table;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = dataTable[i].name;
                dataGridView1.Columns[i].Width = dataTable[i].width;
            }
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckRecord()) return;
            Query("INSERT INTO composition " +
                "(name_composition, name_author, surname_author, patronymic_author, date_create)" +
                $"VALUES(\"{boxName.Text}\",\"{boxNameAuthor.Text}\",\"{boxSurname.Text}\", \"{boxPatronymic.Text}\", \"{dateCreate.Text}\");");
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (CheckRecord()) return;
            Query("UPDATE composition SET " +
                $"name_composition = \"{boxName.Text}\", " +
                $"name_author = \"{boxNameAuthor.Text}\", " +
                $"surname_author = \"{boxSurname.Text}\", " +
                $"patronymic_author = \"{boxPatronymic.Text}\", " +
                $"date_create = \"{dateCreate.Text}\" " +
                $"WHERE id_composition = {dataGridView1.CurrentRow.Cells[0].Value};");
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataTable performance = managerDB.SelectTable($"SELECT * FROM performance WHERE id_composition = {id};");
            DataTable record = managerDB.SelectTable($"SELECT * FROM record WHERE id_composition = {id};");
            if (performance.Rows.Count > 0 || record.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Произведение\", пока она используется хотя бы в одной записи таблиц \"Исполнения\" и \"Пластинки\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
                return;
            }
            Query($"DELETE FROM composition WHERE id_composition = {id};");
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                boxNameAuthor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                boxSurname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                boxPatronymic.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateCreate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }
        private bool CheckRecord()
        {
            if (boxName.Text == "" || boxNameAuthor.Text == "" || boxSurname.Text == "" || dateCreate.Text == "")
            {
                MessageBox.Show("Заполните поля: Название произведения, Имя автора, Фамилия автора", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            DataTable table = managerDB.SelectTable("SELECT * FROM composition WHERE " +
                $"name_composition = \"{boxName.Text}\" AND " +
                $"name_author = \"{boxNameAuthor.Text}\" AND " +
                $"surname_author = \"{boxSurname.Text}\" AND " +
                $"patronymic_author = \"{boxPatronymic.Text}\" AND " +
                $"date_create = \"{dateCreate.Text}\"");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Уже есть запись с такими данными.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
