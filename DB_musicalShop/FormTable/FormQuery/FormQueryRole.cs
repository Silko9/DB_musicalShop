using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop.FormTable.FormQuery
{
    public partial class FormQueryRole : Form
    {
        ManagerDB managerDB;
        string[] data;
        public FormQueryRole(ManagerDB managerDB, string[] data)
        {
            Initialize(managerDB);
            this.data = data;
            this.Text = "Изменение";
            button.Text = "Изменить";
            boxName.Text = data[1];
        }
        public FormQueryRole(ManagerDB managerDB)
        {
            Initialize(managerDB);
            this.Text = "Добавление";
            button.Text = "Добавить";
        }
        private void Initialize(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                if (CheckRecord()) return;
                string commandText = $"INSERT INTO role (name_role) VALUES(\"{boxName.Text}\");";
                managerDB.Query(commandText);
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                if (CheckRecord()) return;
                string commandText = $"UPDATE role SET name_role = \"{boxName.Text}\" WHERE id_role = {data[0]};";
                managerDB.Query(commandText);
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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
