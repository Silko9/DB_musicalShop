using DB_musicalShop.FormTable;
using DB_musicalShop.FormTable.FormAddOrUpdate;
using DB_musicalShop.FormTable.FormQuery;
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
        FormQueryRecord formQueryRecord;
        FormQueryRelationRecordPerformance formQueryRelationRecordPerformance;
        FormTopSell formTopSell;
        public FormTableRecord(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataRecord.Rows.Clear();
            DataTable composition = managerDB.SelectTable("SELECT * FROM composition;");
            DataRow row;
            DataRow rowComposition;
            DataTable count;
            int sellLast;
            int sellCurrent;
            int sell;
            int receipts;
            int sum;
            DataRow countRow;
            DataTable table = managerDB.SelectTable("SELECT * FROM record");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                rowComposition = composition.Rows[0];
                for (int j = 0; j < composition.Rows.Count; j++)
                {
                    rowComposition = composition.Rows[j];
                    if (rowComposition["id_composition"].ToString() == row["id_composition"].ToString())
                        break;
                }
                try
                {
                    int year = DateTime.Now.Year;
                    count = managerDB.SelectTable("SELECT * FROM logging WHERE " +
                        $"number_record = \"{row["number_record"]}\" AND " +
                        "id_operation = 2");
                    sum = 0;
                    for (int j = 0; j < count.Rows.Count; j++)
                    {
                        countRow = count.Rows[j];
                        if (countRow["date_log"].ToString().Split(' ')[2] == (year - 1).ToString())
                            sum += Convert.ToInt32(countRow["amount"].ToString());
                    }
                    sellLast = sum;
                    sum = 0;
                    for (int j = 0; j < count.Rows.Count; j++)
                    {
                        countRow = count.Rows[j];
                        if (countRow["date_log"].ToString().Split(' ')[2] == (year).ToString())
                            sum += Convert.ToInt32(countRow["amount"].ToString());
                    }
                    sellCurrent = sum;
                    count = managerDB.SelectTable("SELECT SUM(amount) AS receipts FROM logging WHERE " +
                        $"number_record = \"{row["number_record"]}\" AND " +
                        "id_operation = 1");
                    countRow = count.Rows[0];
                    if (countRow["receipts"] != DBNull.Value)
                        receipts = Convert.ToInt32(countRow["receipts"].ToString());
                    else receipts = 0;
                    count = managerDB.SelectTable("SELECT SUM(amount) AS sell FROM logging WHERE " +
                        $"number_record = \"{row["number_record"]}\" AND " +
                        "id_operation = 2");
                    countRow = count.Rows[0];
                    if (countRow["sell"] != DBNull.Value)
                        sell = Convert.ToInt32(countRow["sell"].ToString());
                    else sell = 0;
                    dataRecord.Rows.Add(row["number_record"], row["retail_price"], row["wholesale_price"], rowComposition["name_composition"], sellLast, sellCurrent, receipts - sell);
                }
                catch
                {
                    dataRecord.Rows.Add(row["number_record"], row["retail_price"], row["wholesale_price"], rowComposition["name_composition"]);
                }
            }
            dataPerformance.Rows.Clear();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
            LoadData();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formQueryRecord = new FormQueryRecord(managerDB);
            formQueryRecord.ShowDialog();
            UpdateTable();
            LoadData();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataRecord.RowCount == 0) return;
            string[] data = new string[4];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataRecord.CurrentRow.Cells[i].Value.ToString();
            formQueryRecord = new FormQueryRecord(managerDB, data);
            formQueryRecord.ShowDialog();
            UpdateTable();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataRecord.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string id = dataRecord.CurrentRow.Cells[0].Value.ToString();
            DataTable log = managerDB.SelectTable($"SELECT * FROM logging WHERE number_record = \"{id}\";");
            if (log.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Пластинка\", пока она используется хотя бы в одной записи таблиц \"Учет\" и \"Отношения пластинок и исполнений\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
                LoadData();
                return;
            }
            string commandText = $"DELETE FROM record WHERE number_record = \"{id}\";";
            Query(commandText);
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        private void buttonAddPerformance_Click(object sender, EventArgs e)
        {
            if (dataRecord.Rows.Count == 0) return;
            string[] data = new string[4];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataRecord.CurrentRow.Cells[i].Value.ToString();
            formQueryRelationRecordPerformance = new FormQueryRelationRecordPerformance(managerDB, data, true);
            formQueryRelationRecordPerformance.ShowDialog();
            LoadData();
        }
        private void buttonDeletePerformance_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataRecord.RowCount == 0 || dataPerformance.RowCount == 0) return;
                if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
                DataTable ensemble = managerDB.SelectTable($"SELECT id_ensemble FROM ensemble WHERE name_ensemble = \"{dataPerformance.CurrentRow.Cells[0].Value}\"");
                DataRow rowEnsemble = ensemble.Rows[0];
                DataTable table = managerDB.SelectTable("SELECT id_performance FROM performance WHERE " +
                    $"id_ensemble = {rowEnsemble["id_ensemble"]} AND " +
                    $"date_performance = \"{dataPerformance.CurrentRow.Cells[1].Value}\";");
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
        private void LoadData()
        {
            if (dataRecord.Rows.Count == 0) return;
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
                        dataPerformance.Rows.Add(rowEnsemble["name_ensemble"], rowPerformance["date_performance"]);
                    }
                }
            }
        }

        private void FormTableRecord_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonTopSell_Click(object sender, EventArgs e)
        {
            formTopSell = new FormTopSell(managerDB);
            formTopSell.ShowDialog();
        }
    }
}
