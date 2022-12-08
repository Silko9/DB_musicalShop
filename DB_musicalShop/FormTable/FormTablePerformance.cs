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
using System.Xml.Linq;

namespace DB_musicalShop
{
    public partial class FormTablePerformance : Form
    {
        ManagerDB managerDB = new ManagerDB();
        FormQueryPerformance formQueryPerformance;
        public FormTablePerformance(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataPerformance.Rows.Clear();
            DataTable ensemble = managerDB.SelectTable("SELECT * FROM ensemble;");
            DataTable composition = managerDB.SelectTable("SELECT * FROM composition;");
            DataRow row;
            DataRow rowEnsemble;
            DataRow rowComposition;
            DataTable table = managerDB.SelectTable("SELECT * FROM performance");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowEnsemble = ensemble.Rows[0];
                    rowComposition = composition.Rows[0];
                    for (int j = 0; j < ensemble.Rows.Count; j++)
                    {
                        rowEnsemble = ensemble.Rows[j];
                        if (rowEnsemble["id_ensemble"].ToString() == row["id_ensemble"].ToString())
                            break;
                    }
                    for (int j = 0; j < composition.Rows.Count; j++)
                    {
                        rowComposition = composition.Rows[j];
                        if (rowComposition["id_composition"].ToString() == row["id_composition"].ToString())
                            break;
                    }
                    dataPerformance.Rows.Add(row["id_performance"], row["date_performance"], rowEnsemble["name_ensemble"], rowComposition["name_composition"], row["circumstances_execution"]);
                }
                catch
                {
                    dataPerformance.Rows.Add(row["id_performance"], row["date_performance"], row["id_ensemble"], row["id_composition"], row["circumstances_execution"]);
                }
            }
            dataRecord.Rows.Clear();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formQueryPerformance = new FormQueryPerformance(managerDB, null);
            formQueryPerformance.ShowDialog();
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataPerformance.RowCount == 0) return;
            string[] data = new string[5];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataPerformance.CurrentRow.Cells[i].Value.ToString();
            formQueryPerformance = new FormQueryPerformance(managerDB, data);
            formQueryPerformance.ShowDialog();
            UpdateTable();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataPerformance.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string id = dataPerformance.CurrentRow.Cells[0].Value.ToString();
            DataTable table = managerDB.SelectTable($"SELECT * FROM relation_record_performance WHERE id_performance = {id};");
            if (table.Rows.Count > 0)
                Query($"DELETE FROM relation_record_performance WHERE id_performance = {id};");
            string commandText = $"DELETE FROM performance WHERE id_performance = {id};";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataPerformance.Rows.Count == 0) return;
            boxCircumstances_execution.Text = dataPerformance.CurrentRow.Cells[4].Value.ToString();
            //загрузка пластинки в data
            dataRecord.Rows.Clear();
            DataTable table = managerDB.SelectTable($"SELECT number_record FROM relation_record_performance WHERE id_performance = {dataPerformance.CurrentRow.Cells[0].Value}");
            DataRow row;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataRecord.Rows.Add(row["number_record"]);
            }
            //загрузка пластики в box
            boxRecord.Items.Clear();
            DataTable record = managerDB.SelectTable($"SELECT number_record FROM record");
            DataRow rowRecord;
            bool flag;
            for (int i = 0; i < record.Rows.Count; i++)
            {
                rowRecord = record.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (rowRecord["number_record"].ToString() == row["number_record"].ToString())
                        flag = false;
                }
                if (flag) boxRecord.Items.Add(rowRecord["number_record"].ToString());
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            //DataTable table = managerDB.SelectTable($"SELECT * FROM record WHERE number_record = \"{boxRecord.Text}\"");
            //if (table.Rows.Count == 0)
            //{
            //    MessageBox.Show("Такой пластинки нет в базе данных, добавьте ее или выберите из списка существующие.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //DataRow row = table.Rows[0];
            //table = managerDB.SelectTable($"SELECT * FROM relation_record_performance WHERE id_performance = {dataPerformance.CurrentRow.Cells[0].Value} AND number_record = \"{row["number_record"]}\"");
            //if (table.Rows.Count > 0)
            //{
            //    MessageBox.Show("Данное исполнение уже записана на этой пластинке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //Query("INSERT INTO relation_record_performance " +
            //    "(id_performance, number_record) " +
            //    $"VALUES ({dataPerformance.CurrentRow.Cells[0].Value}, \"{row["number_record"]}\")");
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            if (dataPerformance.RowCount == 0 || dataRecord.RowCount == 0) return;
            string commandText = $"DELETE FROM relation_record_performance WHERE id_performance = {dataPerformance.CurrentRow.Cells[0].Value} AND number_record = {dataRecord.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
    }
}
