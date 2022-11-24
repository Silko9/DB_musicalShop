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
    public partial class FormTableRecord : Form
    {
        ManagerDB managerDB = new ManagerDB();
        public FormTableRecord(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataRecord.RowHeadersVisible = false;
            dataTopRecord.RowHeadersVisible = false;
            dataRecord.Columns.Add("", "Номер пластинки");
            dataRecord.Columns.Add("", "Розничная цена");
            dataRecord.Columns.Add("", "Оптовая цена");
            dataRecord.Columns.Add("", "ID Произведения");
            dataRecord.Columns[0].Width = 90;
            dataRecord.Columns[1].Width = 70;
            dataRecord.Columns[2].Width = 70;
            dataRecord.Columns[3].Width = 200;
            dataRecord.AllowUserToAddRows = false;
            dataTopRecord.AllowUserToAddRows = false;
            dataTopRecord.Columns.Add("", "Номер пластинки");
            dataTopRecord.Columns.Add("", "Продано");
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataRecord.Rows.Clear();
            DataTable composition = managerDB.SelectTable("SELECT * FROM composition;");
            DataRow row;
            DataRow rowComposition;
            string currentItem = boxComposition.Text;
            boxComposition.Items.Clear();
            for (int i = 0; i < composition.Rows.Count; i++)
            {
                row = composition.Rows[i];
                boxComposition.Items.Add(Convert.ToString($"{row["name_composition"]} [id{row["id_composition"]}]"));
            }
            DataTable table = managerDB.SelectTable("SELECT * FROM record");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowComposition = composition.Rows[0];
                    for (int j = 0; j < composition.Rows.Count; j++)
                    {
                        rowComposition = composition.Rows[j];
                        if (rowComposition["id_composition"].ToString() == row["id_composition"].ToString())
                            break;
                    }
                    dataRecord.Rows.Add(row["number_record"], row["retail_price"], row["wholesale_price"], $"{rowComposition["name_composition"]} [id{rowComposition["id_composition"]}]");
                }
                catch
                {
                    dataRecord.Rows.Add(row["number_record"], row["retail_price"], row["wholesale_price"], row["id_composition"]);
                }
            }
            boxComposition.Text = currentItem;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxComposition.Text != "" && numericRetailPrice.Text != "" && numericWholesalePrice.Text != "")
            {
                DataTable table = managerDB.SelectTable($"SELECT * FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
                if(table.Rows.Count == 0)
                {
                    string commandText = $"INSERT INTO record (number_record, retail_price, wholesale_price, id_composition)" +
                    $"VALUES(\"{boxNumberRecord.Text}\", {numericRetailPrice.Text.Replace(",", ".")}, {numericWholesalePrice.Text.Replace(",", ".")}, {managerDB.GetID(boxComposition.Text)});";
                    Query(commandText);
                }
                else
                    MessageBox.Show("Пластинка с таким номером уже есть.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataRecord.RowCount == 0) return;
            if (boxNumberRecord.Text != "" && numericRetailPrice.Text != "" && numericWholesalePrice.Text != "" && boxComposition.Text != "")
            {
                try
                {
                    string commandText = $"UPDATE record SET " +
                    $"number_record = \"{boxNumberRecord.Text}\", " +
                    $"retail_price = {numericRetailPrice.Text.Replace(",", ".")}, " +
                    $"wholesale_price = {numericWholesalePrice.Text.Replace(",", ".")}, " +
                    $"id_composition = {managerDB.GetID(boxComposition.Text)} " +
                    $"WHERE number_record = \"{dataRecord.CurrentRow.Cells[0].Value}\";";
                    Query(commandText);
                }
                catch
                {
                    MessageBox.Show("Пластинка с таким номером уже есть.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataRecord.RowCount == 0) return;
            string id = dataRecord.CurrentRow.Cells[0].Value.ToString();
            DataTable log = managerDB.SelectTable($"SELECT * FROM logging WHERE number_record = \"{id}\";");
            DataTable relation = managerDB.SelectTable($"SELECT * FROM relation_record_performance WHERE number_record = \"{id}\";");
            if (log.Rows.Count > 0 || relation.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Пластинка\", пока она используется хотя бы в одной записи таблиц \"Учет\" и \"Отношения пластинок и исполнений\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
            }
            else
            {
                string commandText = $"DELETE FROM record WHERE number_record = \"{id}\";";
            Query(commandText);
            }
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRecord.Rows.Count == 0) return;
            boxNumberRecord.Text = dataRecord.CurrentRow.Cells[0].Value.ToString();
            numericRetailPrice.Text = dataRecord.CurrentRow.Cells[1].Value.ToString();
            numericWholesalePrice.Text = dataRecord.CurrentRow.Cells[2].Value.ToString();
            boxComposition.Text = dataRecord.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //DataTable table = managerDB.SelectTable($"SELECT id_record, number_record, SUM(SELECT amount FROM logging WHERE id_operation = 1 AND logging.number_record = record.number_record) AS top FROM record;");
            DataTable table = managerDB.SelectTable("SELECT number_record FROM record;");
            DataTable countT;
            DataRow row;
            DataRow rowCount;
            int count;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                try
                {
                    row = table.Rows[i];
                    countT = managerDB.SelectTable($"SELECT SUM(amount) AS top FROM logging WHERE id_operation = 2 AND number_record = \"{row["number_record"]}\"");
                    rowCount = countT.Rows[0];
                    count = Convert.ToInt32(rowCount["top"].ToString());
                    dataTopRecord.Rows.Add(row["number_record"], count);
                }
                catch
                {

                }
            }
        }
    }
}
