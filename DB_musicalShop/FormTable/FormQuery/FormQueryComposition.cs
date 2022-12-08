using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop.FormTable.FormAddOrUpdate
{
    public partial class FormQueryComposition : Form
    {
        ManagerDB managerDB;
        string[] data;
        public FormQueryComposition(ManagerDB managerDB, string[] data)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            this.data = data;
            if (data == null)
            {
                this.Text = "Добавление";
                button.Text = "Добавить";
            }
            else
            {
                this.Text = "Изменение";
                button.Text = "Изменить";
                boxName.Text = data[1];
                boxNameAuthor.Text = data[2];
                boxSurname.Text = data[3];
                boxPatronymic.Text = data[4];
                dateCreate.Text = data[5];
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                if (CheckRecord()) return;
                managerDB.Query("INSERT INTO composition " +
                    "(name_composition, name_author, surname_author, patronymic_author, date_create)" +
                    $"VALUES(\"{boxName.Text}\",\"{boxNameAuthor.Text}\",\"{boxSurname.Text}\", \"{boxPatronymic.Text}\", \"{dateCreate.Text}\");");
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                if (CheckRecord()) return;
                managerDB.Query("UPDATE composition SET " +
                    $"name_composition = \"{boxName.Text}\", " +
                    $"name_author = \"{boxNameAuthor.Text}\", " +
                    $"surname_author = \"{boxSurname.Text}\", " +
                    $"patronymic_author = \"{boxPatronymic.Text}\", " +
                    $"date_create = \"{dateCreate.Text}\" " +
                    $"WHERE id_composition = {data[0]};");
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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