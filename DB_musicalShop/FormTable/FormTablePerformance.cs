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
    public partial class FormTablePerformance : Form
    {
        ManagerDB managerDB = new ManagerDB();

        public FormTablePerformance(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("", "ID Исполнения");
            dataGridView1.Columns.Add("", "Дата исполнения");
            dataGridView1.Columns.Add("", "ID Ансамбля");
            dataGridView1.Columns.Add("", "ID Произведения");
            dataGridView1.Columns.Add("", "Обстоятельства исполнения");
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.AllowUserToAddRows = false;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable ensemble = managerDB.SelectTable("SELECT * FROM ensemble;");
            DataTable composition = managerDB.SelectTable("SELECT * FROM composition;");
            DataRow row;
            DataRow rowEnsemble;
            DataRow rowComposition;
            string currentItemE = boxEnsemble.Text;
            string currentItemC = boxComposition.Text;
            boxComposition.Items.Clear();
            boxEnsemble.Items.Clear();
            for (int i = 0; i < ensemble.Rows.Count; i++)
            {
                row = ensemble.Rows[i];
                boxEnsemble.Items.Add(Convert.ToString($"{row["name_ensemble"]} [id{row["id_ensemble"]}]"));
            }
            for (int i = 0; i < composition.Rows.Count; i++)
            {
                row = composition.Rows[i];
                boxComposition.Items.Add(Convert.ToString($"{row["name_composition"]} [id{row["id_composition"]}]"));
            }
            DataTable table = managerDB.SelectTable("SELECT * FROM performance");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowEnsemble = ensemble.Rows[0];
                    rowComposition = composition.Rows[0];
                    for (int j = 0; j < ensemble.Rows.Count; j++)
                    {
                        rowEnsemble = ensemble.Rows[j];
                        if (rowEnsemble["id_ensemble"].ToString() == row["id_ensemble"].ToString())
                            break;
                    }
                    for (int j = 0; j < composition.Rows.Count; j++)
                    {
                        rowComposition = composition.Rows[j];
                        if (rowComposition["id_composition"].ToString() == row["id_composition"].ToString())
                            break;
                    }
                    dataGridView1.Rows.Add(row["id_performance"], row["date_performance"], $"{rowEnsemble["name_ensemble"]} [id{rowEnsemble["id_ensemble"]}]", $"{rowComposition["name_composition"]} [id{rowComposition["id_composition"]}]", row["circumstances_execution"]);
                }
                catch
                {
                    dataGridView1.Rows.Add(row["id_performance"], row["date_performance"], row["id_ensemble"], row["id_composition"], row["circumstances_execution"]);
                }
            }
            boxEnsemble.Text = currentItemE;
            boxComposition.Text = currentItemC;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxComposition.Text != "" && boxEnsemble.Text != "")
            {
                string commandText = $"INSERT INTO performance (date_performance, id_ensemble, id_composition, circumstances_execution)" +
                $"VALUES(\"{dateCreate.Text}\", {managerDB.GetID(boxEnsemble.Text)},{managerDB.GetID(boxComposition.Text)}, \"{boxCircumstances_execution.Text}\");";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxEnsemble.Text != "" && boxEnsemble.Text != "")
            {
                string commandText = $"UPDATE performance SET " +
                $"id_ensemble = \"{managerDB.GetID(boxEnsemble.Text)}\", " +
                $"id_composition = {managerDB.GetID(boxComposition.Text)}, " +
                $"date_performance = \"{dateCreate.Text}\", " +
                $"circumstances_execution = \"{boxCircumstances_execution.Text}\" " +
                $"WHERE id_performance = {dataGridView1.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataTable table = managerDB.SelectTable($"SELECT * FROM relation_record_performance WHERE id_performance = {id};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Исполнение\", пока она используется хотя бы в одной записи таблицы \"Отношения пластинок и исполнений\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
            }
            else
            {
                string commandText = $"DELETE FROM performance WHERE id_performance = {id};";
                Query(commandText);
            }
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            boxEnsemble.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boxComposition.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateCreate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxCircumstances_execution.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
