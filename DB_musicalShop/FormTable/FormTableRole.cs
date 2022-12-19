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

namespace DB_musicalShop
{
    public partial class FormTableRole : Form
    {
        ManagerDB managerDB;
        FormQueryRole formQueryRole;
        FormQueryRelationMusicianRole formQueryRelationMusicianRole;
        public FormTableRole(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formQueryRole = new FormQueryRole(managerDB);
            formQueryRole.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
            LoadData();
        }
        private void UpdateTable()
        {
            DataTable table = managerDB.SelectTable("SELECT * FROM role;");
            DataRow row;
            dataRole.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataRole.Rows.Add(row["id_role"], row["name_role"]);
            }
            dataMusician.Rows.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataRole.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string id = dataRole.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM role WHERE id_role = {dataRole.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataRole.RowCount == 0) return;
            string[] data = new string[2];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataRole.CurrentRow.Cells[i].Value.ToString();
            formQueryRole = new FormQueryRole(managerDB, data);
            formQueryRole.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void LoadData()
        {
            if (dataRole.Rows.Count == 0) return;
            dataMusician.Rows.Clear();//загрузка музыкантов в data
            DataTable table = managerDB.SelectTable($"SELECT id_musician FROM relation_musician_role WHERE id_role = {dataRole.CurrentRow.Cells[0].Value}");
            DataTable musician = managerDB.SelectTable("SELECT * FROM musician");
            DataRow row;
            DataRow rowMusician;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                for (int j = 0; j < musician.Rows.Count; j++)
                {
                    rowMusician = musician.Rows[j];
                    if (row["id_musician"].ToString() == rowMusician["id_musician"].ToString())
                        dataMusician.Rows.Add(rowMusician["name_musician"], rowMusician["surname_musician"], rowMusician["patronymic_musician"]);
                }
            }
        }
        private void FormTableRole_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAddMusician_Click_1(object sender, EventArgs e)
        {
            if (dataRole.Rows.Count == 0) return;
            string[] data = new string[2];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataRole.CurrentRow.Cells[i].Value.ToString();
            formQueryRelationMusicianRole = new FormQueryRelationMusicianRole(managerDB, data, false);
            formQueryRelationMusicianRole.ShowDialog();
            LoadData();
        }

        private void buttonDeleteMusician_Click_1(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataRole.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            DataTable table = managerDB.SelectTable("SELECT * FROM musician WHERE " +
                $"name_musician = \"{dataMusician.CurrentRow.Cells[0].Value}\" AND " +
                $"surname_musician = \"{dataMusician.CurrentRow.Cells[1].Value}\" AND " +
                $"patronymic_musician = \"{dataMusician.CurrentRow.Cells[2].Value}\";");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_role WHERE id_role = {dataRole.CurrentRow.Cells[0].Value} AND id_musician = {row["id_musician"]};";
            Query(commandText);
        }
    }
}
