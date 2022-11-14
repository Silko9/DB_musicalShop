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
    public partial class FormTableRelationRecordAndPerformance : Form
    {
        ManagerDB managerDB;
        public FormTableRelationRecordAndPerformance(ManagerDB managerDB)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            DataTable record = managerDB.SelectTable("SELECT * FROM record;");
            DataRow rowRecord;
            DataRow rowPerformance;
            DataTable performance = managerDB.SelectTable("SELECT * FROM performance");
            string currentItemR = boxRecord.Text;
            string currentItemP = boxPerformance.Text;
            boxRecord.Items.Clear();
            boxPerformance.Items.Clear();
            boxRecord.Items.Add("");
            boxPerformance.Items.Add("");
            if (boxPerformance.Text != "")
                SelectRecord();
            else
                for (int i = 0; i < record.Rows.Count; i++)
                {
                    rowRecord = record.Rows[i];
                    boxRecord.Items.Add(rowRecord["number_record"]);
                }
            if (boxRecord.Text != "")
                SelectPerformance();
            else
                for (int i = 0; i < performance.Rows.Count; i++)
                {
                    rowPerformance = performance.Rows[i];
                    boxPerformance.Items.Add(rowPerformance["id_performance"]);
                }
            DataTable table = managerDB.SelectTable("SELECT * FROM relation_record_performance");
            dataGridView1.DataSource = table;
            if (currentItemR != "") boxRecord.Text = currentItemR;
            if (currentItemP != "") boxPerformance.Text = currentItemP;
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[0].HeaderText = "Номер пластинки";
            dataGridView1.Columns[1].HeaderText = "ID исполнения";
        }
        private void SelectRecord()
        {
            string currentItem = boxRecord.Text;
            boxRecord.Items.Clear();
            boxRecord.Items.Add("");
            int idPerformance;
            if (boxPerformance.Text == "") idPerformance = 0;
            else idPerformance = Convert.ToInt32(boxPerformance.Text);
            DataTable table = managerDB.SelectTable("SELECT * FROM relation_record_performance " +
                $"WHERE id_performance = {idPerformance};");
            DataTable record = managerDB.SelectTable("SELECT number_record FROM record");
            DataRow row;
            DataRow rowRecord;
            bool flag;
            for (int i = 0; i < record.Rows.Count; i++)
            {
                rowRecord = record.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (row["number_record"].ToString() == rowRecord["number_record"].ToString())
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    boxRecord.Items.Add(rowRecord["number_record"]);
            }
            boxRecord.Text = currentItem;
        }
        private void SelectPerformance()
        {
            string currentItem = boxPerformance.Text;
            boxPerformance.Items.Clear();
            boxPerformance.Items.Add("");
            
            DataTable table = managerDB.SelectTable("SELECT * FROM relation_record_performance " +
                $"WHERE number_record = \"{boxRecord.Text}\";");
            DataTable performance = managerDB.SelectTable("SELECT id_performance FROM performance;");
            DataRow row;
            DataRow rowPerformance;
            bool flag;
            for (int i = 0; i < performance.Rows.Count; i++)
            {
                rowPerformance = performance.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (row["id_performance"].ToString() == rowPerformance["id_performance"].ToString())
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    boxPerformance.Items.Add(rowPerformance["id_performance"]);
            }
            boxPerformance.Text = currentItem;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxRecord.Text != "" && boxPerformance.Text != "")
            {
                string commandText = $"INSERT INTO relation_record_performance (number_record, id_performance)" +
                $"VALUES(\"{boxRecord.Text}\", {boxPerformance.Text});";
                Query(commandText);
                SelectPerformance();
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxRecord.Text != "" && boxPerformance.Text != "")
            {
                string commandText = $"UPDATE relation_record_performance SET " +
                $"number_record = \"{boxRecord.Text}\", " +
                $"id_performance = {boxPerformance.Text} " +
                $"WHERE number_record = \"{dataGridView1.CurrentRow.Cells[0].Value}\" AND " +
                $"id_performance = {dataGridView1.CurrentRow.Cells[1].Value};";
                Query(commandText);
                SelectPerformance();
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string commandText = $"DELETE FROM relation_record_performance " +
                $"WHERE number_record = \"{dataGridView1.CurrentRow.Cells[0].Value}\" AND " +
                $"id_performance = {dataGridView1.CurrentRow.Cells[1].Value};";
            Query(commandText);
            SelectPerformance();
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void boxRecord_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectPerformance();
        }

        private void boxPerformance_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            boxRecord.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            boxPerformance.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
