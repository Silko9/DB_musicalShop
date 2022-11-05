using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop.FormTable
{
    public partial class FormReplacementTypeOfEnsemble : Form
    {
        public DataTable type = new DataTable();
        public string id;
        ManagerDB managerDB;
        public FormReplacementTypeOfEnsemble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
        }
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (boxTypeOfEnsemble.Text != "")
            {
                managerDB.Query($"UPDATE ensemble SET id_type_ensemble = {managerDB.GetID(boxTypeOfEnsemble.Text)} WHERE id_type_ensemble = {id};");
                managerDB.Query($"DELETE FROM type_ensemble WHERE id_type_ensemble = {id};");
                Close();
            }
            else
                MessageBox.Show("Выберите тип ансамбля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                managerDB.Query($"INSERT INTO type_ensemble (name_type_ensemble) VALUES (\"{boxName.Text}\");");
                managerDB.Query($"DELETE FROM type_ensemble WHERE id_type_ensemble = {id};");
                DataTable table = managerDB.SelectTable("SELECT id_type_ensemble FROM type_ensemble ORDER BY rowid DESC LIMIT 1;");
                DataRow row = table.Rows[0];
                string idNew = row["id_type_ensemble"].ToString();
                managerDB.Query($"UPDATE ensemble SET id_type_ensemble = {idNew} WHERE id_type_ensemble = {id};");
                Close();
            }
            else
                MessageBox.Show("Введите название типа ансамбля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormReplacementTypeOfEnsemble_Load(object sender, EventArgs e)
        {
            DataRow row = type.Rows[0];
            for (int i = 0; i < type.Rows.Count; i++)
            {
                row = type.Rows[i];
                if(id != row["id_type_ensemble"].ToString())
                    boxTypeOfEnsemble.Items.Add($"{row["name_type_ensemble"]} [id{row["id_type_ensemble"]}]");
            }
        }
    }
}
