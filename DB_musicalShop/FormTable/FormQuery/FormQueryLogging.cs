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
    public partial class FormQueryLogging : Form
    {
        ManagerDB managerDB;
        string[] data;
        DataTable table;
        int idOperation;
        public FormQueryLogging(ManagerDB managerDB, string[] data)
        {
            Initialize(managerDB);
            this.data = data;
            this.Text = "Изменение";
            button.Text = "Изменить";
            boxTypeOfAction.Enabled = false;
            boxNumberRecord.Text = data[1];
            boxTypeOfAction.Text = data[2];
            dateCreate.Text = data[3];
            numericAmount.Text = data[4];
        }
        public FormQueryLogging(ManagerDB managerDB)
        {
            Initialize(managerDB);
            this.Text = "Добавление";
            button.Text = "Добавить";
        }
        private void Initialize(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            DataTable record = managerDB.SelectTable("SELECT * FROM record;");
            DataTable operation = managerDB.SelectTable("SELECT * FROM operation;");
            DataRow row;
            for (int i = 0; i < record.Rows.Count; i++)
            {
                row = record.Rows[i];
                boxNumberRecord.Items.Add(Convert.ToString(row["number_record"]));
            }
            for (int i = 0; i < operation.Rows.Count; i++)
            {
                row = operation.Rows[i];
                boxTypeOfAction.Items.Add(Convert.ToString(row["name_operation"]));
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                if (CheckRecord()) return;
                string commandText = $"INSERT INTO logging (number_record, id_operation, date_log, amount)" +
                $"VALUES(\"{boxNumberRecord.Text}\", {idOperation}, \"{dateCreate.Text}\", {numericAmount.Value});";
                managerDB.Query(commandText);
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                if (CheckRecord()) return;
                string commandText = $"UPDATE logging SET " +
                $"number_record = \"{boxNumberRecord.Text}\", " +
                $"id_operation = {idOperation}, " +
                $"date_log = \"{dateCreate.Text}\", " +
                $"amount = {numericAmount.Value} " +
                $"WHERE id_log = {data[0]};";
                managerDB.Query(commandText);
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private bool CheckRecord()
        {
            if (boxNumberRecord.Text == "" || boxTypeOfAction.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            table = managerDB.SelectTable($"SELECT number_record FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такой пластинки нет в базе данных. Создайте ее или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            DataRow row = table.Rows[0];
            DataRow operation;
            if (boxTypeOfAction.Text == "Поступление") idOperation = 1;
            else
            {
                idOperation = 2;
                int[] record = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    table = managerDB.SelectTable("SELECT SUM(amount) AS count_record FROM logging WHERE " +
                        $"number_record = \"{row["number_record"]}\" AND " +
                        $"id_operation = {i + 1};");
                    operation = table.Rows[0];
                    if (operation["count_record"] == DBNull.Value)
                        record[i] = 0;
                    else
                        record[i] = Convert.ToInt32(operation["count_record"]);
                }
                if (record[0] < (record[1] + numericAmount.Value))
                {
                    MessageBox.Show("На складе недостаточно пластинок с данным номером.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
    }
}
