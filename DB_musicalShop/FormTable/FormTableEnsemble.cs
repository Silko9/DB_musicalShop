using DB_musicalShop.FormTable.FormQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DB_musicalShop
{
    public partial class FormTableEnsemble : Form
    {
        ManagerDB managerDB = new ManagerDB();
        FormQueryEnsemble formQueryEnsemble;
        FormQueryRelationEnsembleMusician formQueryRelationEnsembleMusician;
        public FormTableEnsemble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataEnsemble.Rows.Clear();
            DataTable type = managerDB.SelectTable("SELECT * FROM [type_ensemble];");
            DataRow row;
            DataRow rowType;
            DataTable table = managerDB.SelectTable("SELECT * FROM [ensemble]");
            DataRow performanceRow;
            DataTable performance;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowType = type.Rows[0];
                    for (int j = 0; j < type.Rows.Count; j++)
                    {
                        rowType = type.Rows[j];
                        if (rowType["id_type_ensemble"].ToString() == row["id_type_ensemble"].ToString())
                            break;
                    }
                    performance = managerDB.SelectTable("SELECT COUNT(id_performance) AS count_performance FROM performance " +
                        $"WHERE id_ensemble = {row["id_ensemble"]}");
                    performanceRow = performance.Rows[0];
                    dataEnsemble.Rows.Add(row["id_ensemble"], row["name_ensemble"], rowType["name_type_ensemble"], performanceRow["count_performance"]);
                }
                catch
                {
                    dataEnsemble.Rows.Add(row["id_ensemble"], row["name_ensemble"], "");
                }
            }
            dataMusician.Rows.Clear();
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
            formQueryEnsemble = new FormQueryEnsemble(managerDB);
            formQueryEnsemble.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
            LoadData();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataEnsemble.RowCount == 0) return;
            string[] data = new string[3];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataEnsemble.CurrentRow.Cells[i].Value.ToString();
            formQueryEnsemble = new FormQueryEnsemble(managerDB, data);
            formQueryEnsemble.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataEnsemble.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string id = dataEnsemble.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM relation_musician_ensemble WHERE id_ensemble = {id};";
            Query(commandText);
            commandText = $"DELETE FROM ensemble WHERE id_ensemble = {id};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (dataEnsemble.Rows.Count == 0) return;
            dataMusician.Rows.Clear();//загрузка музыкантов в data
            DataTable table = managerDB.SelectTable($"SELECT id_musician FROM relation_musician_ensemble WHERE id_ensemble = {dataEnsemble.CurrentRow.Cells[0].Value}");
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
            dataPerformance.Rows.Clear();//загрузка исполнений в data
            table = managerDB.SelectTable($"SELECT id_composition, date_performance FROM performance WHERE id_ensemble = {dataEnsemble.CurrentRow.Cells[0].Value}");
            DataTable composition = managerDB.SelectTable("SELECT * FROM composition");
            DataRow rowComposition;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                for (int j = 0; j < composition.Rows.Count; j++)
                {
                    rowComposition = composition.Rows[j];
                    if (row["id_composition"].ToString() == rowComposition["id_composition"].ToString())
                        dataPerformance.Rows.Add(rowComposition["name_composition"], row["date_performance"]);
                }
            }
        }

        private void buttonAddMusician_Click(object sender, EventArgs e)
        {
            if (dataEnsemble.Rows.Count == 0) return;
            string[] data = new string[4];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataEnsemble.CurrentRow.Cells[i].Value.ToString();
            formQueryRelationEnsembleMusician = new FormQueryRelationEnsembleMusician(managerDB, data, true);
            formQueryRelationEnsembleMusician.ShowDialog();
            LoadData();
        }

        private void buttonDeleteMusician_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataEnsemble.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            DataTable table = managerDB.SelectTable("SELECT * FROM musician WHERE " +
                $"name_musician = \"{dataMusician.CurrentRow.Cells[0].Value}\" AND " +
                $"surname_musician = \"{dataMusician.CurrentRow.Cells[1].Value}\" AND " +
                $"patronymic_musician = \"{dataMusician.CurrentRow.Cells[2].Value}\";");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_ensemble WHERE id_ensemble = {dataEnsemble.CurrentRow.Cells[0].Value} AND id_musician = {row["id_musician"]};";
            Query(commandText);
        }
        private void FormTableEnsemble_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
        private void buttonUpdateTable_Click_1(object sender, EventArgs e)
        {
            UpdateTable();
            LoadData();
        }
    }
}