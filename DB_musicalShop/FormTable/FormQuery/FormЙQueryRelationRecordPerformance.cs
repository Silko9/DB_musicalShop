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
using System.Xml.Linq;

namespace DB_musicalShop.FormTable.FormQuery
{
    public partial class FormЙQueryRelationRecordPerformance : Form
    {
        ManagerDB managerDB;
        string[] data;
        public FormЙQueryRelationRecordPerformance(ManagerDB managerDB, string[] data, bool isRecord)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            this.data = data;
            if (isRecord)
            {
                boxRecord.Text = data[0];
                boxRecord.Enabled = false;
            }
            else
            {
                boxPerformance.Text = $"{data[0]} {data[1]}";
                boxPerformance.Enabled = false;
                DataTable table = managerDB.SelectTable($"SELECT number_record FROM relation_record_performance WHERE id_performance = {data}");
                DataRow row;
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
        }

        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}
