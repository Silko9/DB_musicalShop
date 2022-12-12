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
    public partial class FormTableLogging : Form
    {
        ManagerDB managerDB = new ManagerDB();
        FormQueryLogging formQueryLogging;
        public FormTableLogging(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable operation = managerDB.SelectTable("SELECT * FROM operation;");
            DataRow row;
            DataRow rowOperation;
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
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formQueryLogging = new FormQueryLogging(managerDB);
            formQueryLogging.ShowDialog();
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            string[] data = new string[5];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataGridView1.CurrentRow.Cells[i].Value.ToString();
            formQueryLogging = new FormQueryLogging(managerDB, data);
            formQueryLogging.ShowDialog();
            UpdateTable();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string commandText = $"DELETE FROM logging WHERE id_log = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
