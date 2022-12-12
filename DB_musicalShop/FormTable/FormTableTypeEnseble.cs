using DB_musicalShop.FormTable.FormQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop
{
    public partial class FormTableTypeEnseble : Form
    {
        ManagerDB managerDB = new ManagerDB();
        FormQueryTypeEnsemble formQueryTypeEnsemble;
        public FormTableTypeEnseble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataTypeEnsemble.Rows.Clear();
            DataTable table = managerDB.SelectTable("SELECT * FROM type_ensemble;");
            DataRow row;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataTypeEnsemble.Rows.Add(row["id_type_ensemble"], row["name_type_ensemble"]);
            }
            dataEnsemble.Rows.Clear();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
            LoadData();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formQueryTypeEnsemble = new FormQueryTypeEnsemble(managerDB);
            formQueryTypeEnsemble.ShowDialog();
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
            if (dataTypeEnsemble.RowCount == 0) return;
            string[] data = new string[2];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataTypeEnsemble.CurrentRow.Cells[i].Value.ToString();
            formQueryTypeEnsemble = new FormQueryTypeEnsemble(managerDB, data);
            formQueryTypeEnsemble.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataTypeEnsemble.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string id = dataTypeEnsemble.CurrentRow.Cells[0].Value.ToString();
            DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE id_type_ensemble = {id};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"тип ансамбля\", пока она используется хотя бы в одной записи таблицы \"Ансамбли\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
                LoadData();
                return;
            }
            string commandText = $"DELETE FROM type_ensemble WHERE id_type_ensemble = {id};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (dataEnsemble.Rows.Count == 0) return;
            dataEnsemble.Rows.Clear();//загрузка ансамблей в data
            DataTable table = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE id_type_ensemble = {dataTypeEnsemble.CurrentRow.Cells[0].Value}");
            DataRow row;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataEnsemble.Rows.Add(row["name_ensemble"]);
            }
        }

        private void FormTableTypeEnseble_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
