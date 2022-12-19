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
                count = 0;
                row = table.Rows[i];
                countT = managerDB.SelectTable($"SELECT * FROM logging WHERE id_operation = 2 AND number_record = \"{row["number_record"]}\"");
                for (int j = 0; j < countT.Rows.Count; j++)
                {
                    rowCount = countT.Rows[j];
                    if (rowCount["date_log"].ToString().Split(' ')[2] == numericYear.Value.ToString())
                        count += Convert.ToInt32(rowCount["amount"].ToString());
                }
                if(count > 0)
                    dataTopRecord.Rows.Add(row["number_record"], count);
            }
            dataTopRecord.Sort(dataTopRecord.Columns[1], ListSortDirection.Descending);
        }
        private void numericYear_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

    }
}
