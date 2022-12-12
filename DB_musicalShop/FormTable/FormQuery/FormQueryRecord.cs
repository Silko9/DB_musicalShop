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
    public partial class FormQueryRecord : Form
    {
        ManagerDB managerDB;
        string[] data;
        DataRow row;
        public FormQueryRecord(ManagerDB managerDB, string[] data)
        {
            Initialize(managerDB);
            this.data = data;
            this.Text = "Изменение";
            button.Text = "Изменить";
            boxNumberRecord.Text = data[0];
            numericRetailPrice.Text = data[1];
            numericWholesalePrice.Text = data[2];
            boxComposition.Text = data[3];
        }
        public FormQueryRecord(ManagerDB managerDB)
        {
            Initialize(managerDB);
            this.Text = "Добавление";
            button.Text = "Добавить";
        }
        private void Initialize(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            DataTable composition = managerDB.SelectTable("SELECT * FROM composition;");
            DataRow row;
            for (int i = 0; i < composition.Rows.Count; i++)
            {
                row = composition.Rows[i];
                boxComposition.Items.Add(Convert.ToString(row["name_composition"]));
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                if (CheckRecord()) return;
                DataTable table = managerDB.SelectTable($"SELECT * FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Пластинка с таким номером уже есть.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO record (number_record, retail_price, wholesale_price, id_composition)" +
                    $"VALUES(\"{boxNumberRecord.Text}\", {numericRetailPrice.Text.Replace(",", ".")}, {numericWholesalePrice.Text.Replace(",", ".")}, {row["id_composition"]});";
                managerDB.Query(commandText);
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                if (CheckRecord()) return;
                DataTable table = managerDB.SelectTable($"SELECT * FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
                if (boxNumberRecord.Text != data[0])
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Пластинка с таким номером уже есть.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                managerDB.Query("UPDATE record SET " +
                    $"number_record = \"{boxNumberRecord.Text}\", " +
                    $"retail_price = {numericRetailPrice.Text.Replace(",", ".")}, " +
                    $"wholesale_price = {numericWholesalePrice.Text.Replace(",", ".")}, " +
                    $"id_composition = {row["id_composition"]} " +
                    $"WHERE number_record = \"{data[0]}\";");
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private bool CheckRecord()
        {
            if (boxComposition.Text == "" || numericRetailPrice.Text == "" || numericWholesalePrice.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            DataTable table = managerDB.SelectTable($"SELECT id_composition FROM composition WHERE name_composition = \"{boxComposition.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого произведения нету в базе данных, добавте его или выберите из списка существующих", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            table = managerDB.SelectTable($"SELECT id_composition FROM composition WHERE name_composition = \"{boxComposition.Text}\"");
            row = table.Rows[0];
            return false;
        }
    }
}
