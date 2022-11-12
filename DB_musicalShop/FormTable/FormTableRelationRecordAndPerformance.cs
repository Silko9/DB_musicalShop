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
            dataGridView1.Columns.Add("", "ID Музыкант");
            dataGridView1.Columns.Add("", "ID Инструмент");
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            //UpdateTable();
        }
        //private string GetInitials(string name, string surname, string patronymic)
        //{
        //    return $"{surname} {name[0]}. {patronymic[0]}.";
        //}
        //private void UpdateTable()
        //{
        //    dataGridView1.Rows.Clear();
        //    DataTable musician = managerDB.SelectTable("SELECT * FROM musician;");
        //    DataRow row;
        //    DataRow rowMusician;
        //    DataRow row;
        //    DataTable role = managerDB.SelectTable("SELECT * FROM role");
        //    string currentItemM = boxMusician.Text;
        //    string currentItemR = boxRole.Text;
        //    boxMusician.Items.Clear();
        //    boxRole.Items.Clear();
        //    boxMusician.Items.Add("");
        //    boxRole.Items.Add("");
        //    if (boxRole.Text != "")
        //        SelectMusician();
        //    else
        //        for (int i = 0; i < musician.Rows.Count; i++)
        //        {
        //            row = musician.Rows[i];
        //            boxMusician.Items.Add(Convert.ToString($"{GetInitials(row["name_musician"].ToString(), row["surname_musician"].ToString(), row["patronymic_musician"].ToString())} [id{row["id_musician"]}]"));
        //        }
        //    if (boxRole.Text != "")
        //        SelectRole();
        //    else
        //        for (int i = 0; i < role.Rows.Count; i++)
        //        {
        //            rowRole = role.Rows[i];
        //            boxRole.Items.Add(Convert.ToString($"{rowRole["name_role"]} [id{rowRole["id_role"]}]"));
        //        }
        //    DataTable table = managerDB.SelectTable("SELECT * FROM relation_musician_role");
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        row = table.Rows[i];
        //        try
        //        {
        //            rowMusician = musician.Rows[0];
        //            for (int j = 0; j < musician.Rows.Count; j++)
        //            {
        //                rowMusician = musician.Rows[j];
        //                if (rowMusician["id_musician"].ToString() == row["id_musician"].ToString())
        //                    break;
        //            }
        //            rowRole = role.Rows[0];
        //            for (int j = 0; j < role.Rows.Count; j++)
        //            {
        //                rowRole = role.Rows[j];
        //                if (rowRole["id_role"].ToString() == row["id_role"].ToString())
        //                    break;
        //            }
        //            dataGridView1.Rows.Add($"{GetInitials(rowMusician["name_musician"].ToString(), rowMusician["surname_musician"].ToString(), rowMusician["patronymic_musician"].ToString())} [id{rowMusician["id_musician"]}]", $"{rowRole["name_role"]} [id{rowRole["id_role"]}]");
        //        }
        //        catch
        //        {
        //            dataGridView1.Rows.Add(" ", " ");
        //        }
        //    }
        //    boxMusician.Text = currentItemM;
        //    boxRole.Text = currentItemR;
        //}
        private void Query(string command)
        {
            managerDB.Query(command);
            //UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {

        }
    }
}
