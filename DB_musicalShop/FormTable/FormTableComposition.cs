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
        public FormTableComposition(ManagerDB managerDB)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            DataTable table = managerDB.SelectTable("SELECT * FROM composition;");
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID Произведения";
            dataGridView1.Columns[1].HeaderText = "Название произведения";
            dataGridView1.Columns[2].HeaderText = "Имя автора";
            dataGridView1.Columns[3].HeaderText = "Фамилия автора";
            dataGridView1.Columns[4].HeaderText = "Отчество автора";
            dataGridView1.Columns[5].HeaderText = "Дата создания";
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 110;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text != "" && boxNameAuthor.Text != "" && boxSurname.Text != "" && dateCreate.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text) || !managerDB.IsMatch(boxNameAuthor.Text) || !managerDB.IsMatch(boxSurname.Text))
                {
                    MessageBox.Show("В полях должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO composition " +
                    "(name_composition, name_author, surname_author, patronymic_author, date_create)" +
                    $"VALUES(\"{boxName.Text}\",\"{boxNameAuthor.Text}\",\"{boxSurname.Text}\", \"{boxPatronymic.Text}\", \"{dateCreate.Text}\");";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните поля: Название произведения, Имя автора, Фамилия автора", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string commandText = $"UPDATE composition SET name_composition = \"{boxName.Text}\", name_author = \"{boxNameAuthor.Text}\", surname_author = \"{boxSurname.Text}\", patronymic_author = \"{boxPatronymic.Text}\", date_create = \"{dateCreate.Text}\" WHERE id_composition = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //DataTable table = managerDB.SelectTable($"SELECT * FROM composition WHERE id_composition = {id};");
            //if (table.Rows.Count > 0)
            //{
            //    MessageBox.Show("Невозможно удалить запись \"тип данных\", пока она используется хотя бы в одной записи таблицы \"Ансамбли\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    UpdateTable();
            //}
            //else
            //{
                string commandText = $"DELETE FROM composition WHERE id_composition = {id};";
                Query(commandText);
            //} доделать когда будут таблицы исполнение и пластинки
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
    }
}
