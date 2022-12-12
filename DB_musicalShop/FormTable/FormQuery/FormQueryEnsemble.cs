using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop.FormTable.FormQuery
{
    public partial class FormQueryEnsemble : Form
    {
        ManagerDB managerDB;
        string[] data;
        DataTable table;
        DataRow row;
        public FormQueryEnsemble(ManagerDB managerDB, string[] data)
        {
            Initialize(managerDB);
            this.data = data;
            this.Text = "Изменение";
            button.Text = "Изменить";
            boxName.Text = data[1];
            boxTypeEnsemble.Text = data[2];
        }
        public FormQueryEnsemble(ManagerDB managerDB)
        {
            Initialize(managerDB);
            this.Text = "Добавление";
            button.Text = "Добавить";
        }
        private void Initialize(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            DataTable type = managerDB.SelectTable("SELECT * FROM [type_ensemble];");
            DataRow row;
            for (int i = 0; i < type.Rows.Count; i++)
            {
                row = type.Rows[i];
                boxTypeEnsemble.Items.Add(Convert.ToString(row["name_type_ensemble"]));
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                if (CheckRecord()) return;
                table = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE name_ensemble = \"{boxName.Text}\"");
                if (table.Rows.Count != 0)
                {
                    MessageBox.Show("Уже есть такой Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO ensemble (name_ensemble, id_type_ensemble)" +
                $"VALUES(\"{boxName.Text}\", {row["id_type_ensemble"]});";
                managerDB.Query(commandText);
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                if (CheckRecord()) return;
                if (data[1] != boxName.Text)
                {
                    table = managerDB.SelectTable("SELECT * FROM ensemble WHERE " +
                        $"name_ensemble = \"{boxName.Text}\";");
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Уже есть такой Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                string commandText = $"UPDATE [ensemble] SET " +
                $"name_ensemble = \"{boxName.Text}\", " +
                $"id_type_ensemble = {row["id_type_ensemble"]} " +
                $"WHERE id_ensemble = {data[0]};";
                managerDB.Query(commandText);
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private bool CheckRecord()
        {
            if (boxName.Text == "" || boxTypeEnsemble.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            table = managerDB.SelectTable($"SELECT * FROM type_ensemble WHERE name_type_ensemble = \"{boxTypeEnsemble.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нету такого типа ансамбля, выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            row = table.Rows[0];
            return false;
        }
    }
}
