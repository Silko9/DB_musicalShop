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
    public partial class FormQueryTypeEnsemble : Form
    {
        ManagerDB managerDB;
        string[] data;
        public FormQueryTypeEnsemble(ManagerDB managerDB, string[] data)
        {
            Initialize(managerDB);
            this.data = data;
            this.Text = "Изменение";
            button.Text = "Изменить";
            boxName.Text = data[1];
        }
        public FormQueryTypeEnsemble(ManagerDB managerDB)
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
            string commandText;
            if (CheckRecord()) return;
            if (data == null)
            {
                managerDB.Query($"INSERT INTO type_ensemble (name_type_ensemble) VALUES(\"{boxName.Text}\");");
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                managerDB.Query($"UPDATE type_ensemble SET name_type_ensemble = \"{boxName.Text}\" WHERE id_type_ensemble = {data[0]};");
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
            DataTable table = managerDB.SelectTable($"SELECT * FROM type_ensemble WHERE name_type_ensemble = \"{boxName.Text}\"");
            if (table.Rows.Count != 0)
            {
                MessageBox.Show("Уже есть такой тип ансамбля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
