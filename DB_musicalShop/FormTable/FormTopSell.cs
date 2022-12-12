using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DB_musicalShop.FormTable
{
    public partial class FormTopSell : Form
    {
        ManagerDB managerDB;
        public FormTopSell(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            if (numericYear.Value == 0) return;
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
                }
                catch { }
            }
            dataTopRecord.Sort(dataTopRecord.Columns[1], ListSortDirection.Descending);
        }
        private void numericYear_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
