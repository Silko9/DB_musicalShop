using DB_musicalShop.FormTable.FormAddOrUpdate;
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
    public partial class FormTableComposition : Form
    {
        ManagerDB managerDB;
        FormQueryComposition formQueryComposition;
        public FormTableComposition(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataComposition.Rows.Clear();
            DataTable table = managerDB.SelectTable("SELECT * FROM composition;");
            DataRow row;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataComposition.Rows.Add(row["id_composition"], row["name_composition"], row["name_author"], row["surname_author"], row["patronymic_author"], row["date_create"]);
            }
            dataRecord.Rows.Clear();
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
            formQueryComposition = new FormQueryComposition(managerDB);
            formQueryComposition.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataComposition.RowCount == 0) return;
            string[] data = new string[6];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataComposition.CurrentRow.Cells[i].Value.ToString();
            formQueryComposition = new FormQueryComposition(managerDB, data);
            formQueryComposition.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataComposition.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string id = dataComposition.CurrentRow.Cells[0].Value.ToString();
            DataTable performance = managerDB.SelectTable($"SELECT * FROM performance WHERE id_composition = {id};");
            DataTable record = managerDB.SelectTable($"SELECT * FROM record WHERE id_composition = {id};");
            if (performance.Rows.Count > 0 || record.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Произведение\", пока она используется хотя бы в одной записи таблиц \"Исполнения\" и \"Пластинки\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
                LoadData();
                return;
            }
            Query($"DELETE FROM composition WHERE id_composition = {id};");
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
            LoadData();
        }

        private void dataComposition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //загрузка пластинки в data
            dataRecord.Rows.Clear();
            DataTable table = managerDB.SelectTable($"SELECT number_record FROM record WHERE id_composition = {dataComposition.CurrentRow.Cells[0].Value}");
            DataRow row;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataRecord.Rows.Add(row["number_record"]);
            }
            //загрузка исполнений в data
            dataPerformance.Rows.Clear();
            table = managerDB.SelectTable($"SELECT id_ensemble, date_performance FROM performance WHERE id_composition = {dataComposition.CurrentRow.Cells[0].Value}");
            DataRow ensembleRow;
            DataTable ensemble;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                ensemble = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE id_ensemble = {row["id_ensemble"]}");
                ensembleRow = ensemble.Rows[0];
                dataPerformance.Rows.Add($"{ensembleRow["name_ensemble"]} {row["date_performance"]}");
            }
        }

        private void FormTableComposition_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}