using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DB_musicalShop
{
    public partial class FormTableLogging : Form
    {
        ManagerDB managerDB = new ManagerDB();

        public FormTableLogging(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("", "ID Записи");
            dataGridView1.Columns.Add("", "Номер Пластинки");
            dataGridView1.Columns.Add("", "Операции");
            dataGridView1.Columns.Add("", "Дата");
            dataGridView1.Columns.Add("", "Количество");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.AllowUserToAddRows = false;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable record = managerDB.SelectTable("SELECT * FROM record;");
            DataTable operation = managerDB.SelectTable("SELECT * FROM operation;");
            DataRow row;
            DataRow rowOperation;
            string currentItemR = boxNumberRecord.Text;
            string currentItemO = boxTypeOfAction.Text;
            boxNumberRecord.Items.Clear();
            boxTypeOfAction.Items.Clear();
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
            DataTable table = managerDB.SelectTable("SELECT * FROM logging");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowOperation = operation.Rows[0];
                    for (int j = 0; j < operation.Rows.Count; j++)
                    {
                        rowOperation = operation.Rows[j];
                        if (rowOperation["id_operation"].ToString() == row["id_operation"].ToString())
                            break;
                    }
                    dataGridView1.Rows.Add(row["id_log"], row["number_record"], rowOperation["name_operation"], row["date_log"], row["amount"]);
                }
                catch
                {
                    dataGridView1.Rows.Add(row["id_log"], row["number_record"], row["id_operation"], row["date_log"], row["amount"]);
                }
            }
            boxNumberRecord.Text = currentItemR;
            boxTypeOfAction.Text = currentItemO;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxNumberRecord.Text == "" || boxTypeOfAction.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table = managerDB.SelectTable($"SELECT number_record FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
            if(table.Rows.Count == 0)
            {
                MessageBox.Show("Такой пластинки нет в базе данных. Создайте ее или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string[] year = dateCreate.Text.Split(' ');
            int idOperation;
            if (boxTypeOfAction.Text == "Поступление") idOperation = 1;
            else idOperation = 2;
            string commandText = $"INSERT INTO logging (number_record, id_operation, date_log, year, amount)" +
            $"VALUES(\"{boxNumberRecord.Text}\", {idOperation}, \"{dateCreate.Text}\", \"{year[2]}\", {numericAmount.Value});";
            Query(commandText);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxNumberRecord.Text == "" || boxTypeOfAction.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table = managerDB.SelectTable($"SELECT number_record FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такой пластинки нет в базе данных. Создайте ее или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idOperation;
            if (boxTypeOfAction.Text == "Поступление") idOperation = 1;
            else idOperation = 2;
            string[] year = dateCreate.Text.Split(' ');
            string commandText = $"UPDATE logging SET " +
            $"number_record = \"{boxNumberRecord.Text}\", " +
            $"id_operation = {idOperation}, " +
            $"date_log = \"{dateCreate.Text}\", " +
            $"year = \"{year[2]}\", " +
            $"amount = {numericAmount.Value} " +
            $"WHERE id_log = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string commandText = $"DELETE FROM logging WHERE id_log = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            boxNumberRecord.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxTypeOfAction.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateCreate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericAmount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
