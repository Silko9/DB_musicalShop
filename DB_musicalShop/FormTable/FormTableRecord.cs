using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DB_musicalShop
{
    public partial class FormTableRecord : Form
    {
        ManagerDB managerDB = new ManagerDB();
        Table[] dataTable = new Table[4] {  new Table("Номер пластинки", 90), new Table("Розничная цена", 70),
                                            new Table("Оптовая цена", 70), new Table("Произведения", 200) };
        public FormTableRecord(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataRecord.RowHeadersVisible = false;
            dataTopRecord.RowHeadersVisible = false;
            dataPerformance.RowHeadersVisible = false;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataRecord.Columns.Add("", dataTable[i].name);
                dataRecord.Columns[i].Width = dataTable[i].width;
            }
            dataRecord.AllowUserToAddRows = false;
            dataTopRecord.AllowUserToAddRows = false;
            dataPerformance.AllowUserToAddRows = false;
            dataTopRecord.Columns.Add("", "Номер пластинки");
            dataTopRecord.Columns.Add("", "Продано");
            dataTopRecord.Columns[0].Width = 150;
            dataTopRecord.Columns[1].Width = 70;
            dataPerformance.Columns.Add("", "Исполнения");
            dataPerformance.Columns[0].Width = 300;
            UpdateTable();
        }
        private struct Table
        {
            public string name;
            public int width;
            public Table(string name, int width)
            {
                this.name = name;
                this.width = width;
            }
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
                boxComposition.Items.Add(Convert.ToString(row["name_composition"]));
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
                    dataRecord.Rows.Add(row["number_record"], row["retail_price"], row["wholesale_price"], rowComposition["name_composition"]);
                }
                catch
                {
                    dataRecord.Rows.Add(row["number_record"], row["retail_price"], row["wholesale_price"], row["id_composition"]);
                }
            }
            boxComposition.Text = currentItem;
            dataPerformance.Rows.Clear();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxComposition.Text == "" || numericRetailPrice.Text == "" || numericWholesalePrice.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table = managerDB.SelectTable($"SELECT * FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пластинка с таким номером уже есть.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            table = managerDB.SelectTable($"SELECT id_composition FROM composition WHERE name_composition = \"{boxComposition.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого произведения нету в базе данных, добавте его или выберите из списка существующих", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            table = managerDB.SelectTable($"SELECT id_composition FROM composition WHERE name_composition = \"{boxComposition.Text}\"");
            DataRow row = table.Rows[0];
            string commandText = $"INSERT INTO record (number_record, retail_price, wholesale_price, id_composition)" +
                $"VALUES(\"{boxNumberRecord.Text}\", {numericRetailPrice.Text.Replace(",", ".")}, {numericWholesalePrice.Text.Replace(",", ".")}, {row["id_composition"]});";
            Query(commandText);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataRecord.RowCount == 0) return;
            if (boxNumberRecord.Text == "" || numericRetailPrice.Text == "" || numericWholesalePrice.Text == "" || boxComposition.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table = managerDB.SelectTable($"SELECT * FROM record WHERE number_record = \"{boxNumberRecord.Text}\"");
            if (boxNumberRecord.Text != dataRecord.CurrentRow.Cells[0].Value.ToString()) 
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Пластинка с таким номером уже есть.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            table = managerDB.SelectTable($"SELECT id_composition FROM composition WHERE name_composition = \"{boxComposition.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого произведения нету в базе данных, добавте его или выберите из списка существующих", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            table = managerDB.SelectTable($"SELECT id_composition FROM composition WHERE name_composition = \"{boxComposition.Text}\"");
            DataRow row = table.Rows[0];
            Query("UPDATE record SET " +
                $"number_record = \"{boxNumberRecord.Text}\", " +
                $"retail_price = {numericRetailPrice.Text.Replace(",", ".")}, " +
                $"wholesale_price = {numericWholesalePrice.Text.Replace(",", ".")}, " +
                $"id_composition = {row["id_composition"]} " +
                $"WHERE number_record = \"{dataRecord.CurrentRow.Cells[0].Value}\";");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataRecord.RowCount == 0) return;
            string id = dataRecord.CurrentRow.Cells[0].Value.ToString();
            DataTable log = managerDB.SelectTable($"SELECT * FROM logging WHERE number_record = \"{id}\";");
            if (log.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Пластинка\", пока она используется хотя бы в одной записи таблиц \"Учет\" и \"Отношения пластинок и исполнений\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
                return;
            }
            string commandText = $"DELETE FROM record WHERE number_record = \"{id}\";";
            Query(commandText);
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
            dataPerformance.Rows.Clear(); //загрузка исполнений в data
            DataTable table = managerDB.SelectTable($"SELECT id_performance FROM relation_record_performance WHERE number_record = \"{dataRecord.CurrentRow.Cells[0].Value}\"");
            DataTable performance = managerDB.SelectTable("SELECT * FROM performance");
            DataRow row;
            DataRow rowPerformance;
            DataTable ensemble;
            DataRow rowEnsemble;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                for (int j = 0; j < performance.Rows.Count; j++)
                {
                    rowPerformance = performance.Rows[j];
                    if (row["id_performance"].ToString() == rowPerformance["id_performance"].ToString())
                    {
                        ensemble = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE id_ensemble = {rowPerformance["id_ensemble"]}");
                        rowEnsemble = ensemble.Rows[0];
                        dataPerformance.Rows.Add($"{rowEnsemble["name_ensemble"]},{rowPerformance["date_performance"]}");
                    }
                }
            }
            boxPerformance.Items.Clear(); //загрузка исполнений в box
            bool flag;
            for (int i = 0; i < performance.Rows.Count; i++)
            {
                rowPerformance = performance.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (rowPerformance["id_performance"].ToString() == row["id_performance"].ToString())
                        flag = false;
                }
                if (flag)
                {
                    ensemble = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE id_ensemble = {rowPerformance["id_ensemble"]}");
                    rowEnsemble = ensemble.Rows[0];
                    boxPerformance.Items.Add($"{rowEnsemble["name_ensemble"]},{rowPerformance["date_performance"]}");
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //DataTable table = managerDB.SelectTable($"SELECT id_record, number_record, SUM(SELECT amount FROM logging WHERE id_operation = 1 AND logging.number_record = record.number_record) AS top FROM record;");
            dataTopRecord.Rows.Clear();
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
                    countT = managerDB.SelectTable($"SELECT SUM(amount) AS top FROM logging WHERE id_operation = 2 AND number_record = \"{row["number_record"]}\" AND year = {numericYear.Text}");
                    rowCount = countT.Rows[0];
                    count = Convert.ToInt32(rowCount["top"].ToString());
                    dataTopRecord.Rows.Add(row["number_record"], count);
                }catch{}
            }
            dataTopRecord.Sort(dataTopRecord.Columns[1], ListSortDirection.Descending);
        }

        private void buttonAddPerformance_Click(object sender, EventArgs e)
        {
            try
            {
                string[] performance = boxPerformance.Text.Split(',');
                DataTable ensemble = managerDB.SelectTable($"SELECT id_ensemble FROM ensemble WHERE name_ensemble = \"{performance[0]}\"");
                DataRow rowEnsemble = ensemble.Rows[0];
                DataTable table = managerDB.SelectTable("SELECT id_performance FROM performance WHERE " +
                    $"id_ensemble = {rowEnsemble["id_ensemble"]} AND " +
                    $"date_performance = \"{performance[1]}\";");
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такого исполнения нет в базе данных, добавьте его или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = table.Rows[0];
                table = managerDB.SelectTable("SELECT * FROM relation_record_performance WHERE " +
                    $"number_record = \"{dataRecord.CurrentRow.Cells[0].Value}\" AND " +
                    $"id_performance = {row["id_performance"]}");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("У данной пластинки уже есть данное исполнение.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Query("INSERT INTO relation_record_performance " +
                    "(number_record, id_performance) " +
                    $"VALUES (\"{dataRecord.CurrentRow.Cells[0].Value}\", {row["id_performance"]})");
            }
            catch
            {
                MessageBox.Show("Такого исполнения нет в базе данных, добавьте его или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonDeletePerformance_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataRecord.RowCount == 0 || dataPerformance.RowCount == 0) return;
                string[] performance = dataPerformance.CurrentRow.Cells[0].Value.ToString().Split(',');
                DataTable ensemble = managerDB.SelectTable($"SELECT id_ensemble FROM ensemble WHERE name_ensemble = \"{performance[0]}\"");
                DataRow rowEnsemble = ensemble.Rows[0];
                DataTable table = managerDB.SelectTable("SELECT id_performance FROM performance WHERE " +
                    $"id_ensemble = {rowEnsemble["id_ensemble"]} AND " +
                    $"date_performance = \"{performance[1]}\";");
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такого исполнения нет в базе данных, добавьте его или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = table.Rows[0];
                string commandText = "DELETE FROM relation_record_performance WHERE " +
                    $"number_record = \"{dataRecord.CurrentRow.Cells[0].Value}\" AND " +
                    $"id_performance = {row["id_performance"]};";
                Query(commandText);
            }
            catch
            {
                MessageBox.Show("Такого исполнения нет в базе данных, добавьте его или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
