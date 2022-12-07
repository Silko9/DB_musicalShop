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
        Table[] dataTable = new Table[] { new Table("ID Ансамбль", 60), new Table("Название", 170), new Table("Тип Ансамбля", 160), new Table("Кол-во исполнений", 70) };
        public FormTableEnsemble(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            dataEnsemble.RowHeadersVisible = false;
            dataEnsemble.AllowUserToAddRows = false;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataEnsemble.Columns.Add("", dataTable[i].name);
                dataEnsemble.Columns[i].Width = dataTable[i].width;
            }
            dataMusician.RowHeadersVisible = false;
            dataMusician.AllowUserToAddRows = false;
            dataMusician.Columns.Add("", "ФИО");
            dataMusician.Columns[0].Width = 200;
            dataPerformance.RowHeadersVisible = false;
            dataPerformance.AllowUserToAddRows = false;
            dataPerformance.Columns.Add("", "Произведение и дата");
            dataPerformance.Columns[0].Width = 200;
            UpdateTable();
        }
        private struct Table
        {
            public string name;
            public int width;
            public Table(string name, int width)
            {
                this.name = name;
                this.width = width;
            }
        }
        private void UpdateTable()
        {
            dataEnsemble.Rows.Clear();
            DataTable type = managerDB.SelectTable("SELECT * FROM [type_ensemble];");
            DataRow row;
            DataRow rowType;
            string currentItem = boxTypeEnsemble.Text;
            boxTypeEnsemble.Items.Clear();
            for (int i = 0; i < type.Rows.Count; i++)
            {
                row = type.Rows[i];
                boxTypeEnsemble.Items.Add(Convert.ToString(row["name_type_ensemble"]));
            }
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
            boxTypeEnsemble.Text = currentItem;
            dataMusician.Rows.Clear();
            dataPerformance.Rows.Clear();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text == "" || boxTypeEnsemble.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE name_ensemble = \"{boxName.Text}\"");
            if (table.Rows.Count != 0)
            {
                MessageBox.Show("Уже есть такой Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            table = managerDB.SelectTable($"SELECT * FROM type_ensemble WHERE name_type_ensemble = \"{boxTypeEnsemble.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нету такого типа ансамбля, выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            string commandText = $"INSERT INTO ensemble (name_ensemble, id_type_ensemble)" +
            $"VALUES(\"{boxName.Text}\", {row["id_type_ensemble"]});";
            Query(commandText);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataEnsemble.RowCount == 0) return;
            if (boxName.Text == "" || boxTypeEnsemble.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable table;
            if (dataEnsemble.CurrentRow.Cells[1].Value.ToString() != boxName.Text)
            {
                table = managerDB.SelectTable("SELECT * FROM ensemble WHERE " +
                    $"name_ensemble = \"{boxName.Text}\";");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Уже есть такой Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            table = managerDB.SelectTable($"SELECT * FROM type_ensemble WHERE name_type_ensemble = \"{boxTypeEnsemble.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нету такого типа ансамбля, выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            string commandText = $"UPDATE [ensemble] SET " +
            $"name_ensemble = \"{boxName.Text}\", " +
            $"id_type_ensemble = {row["id_type_ensemble"]} " +
            $"WHERE id_ensemble = {dataEnsemble.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataEnsemble.RowCount == 0) return;
            string id = dataEnsemble.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM relation_musician_ensemble WHERE id_ensemble = {id};";
            Query(commandText);
            commandText = $"DELETE FROM ensemble WHERE id_ensemble = {id};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataEnsemble.Rows.Count == 0) return;
            boxName.Text = dataEnsemble.CurrentRow.Cells[1].Value.ToString();
            boxTypeEnsemble.Text = dataEnsemble.CurrentRow.Cells[2].Value.ToString();
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
                        dataMusician.Rows.Add($"{rowMusician["name_musician"]} {rowMusician["surname_musician"]} {rowMusician["patronymic_musician"]}");
                }
            }
            boxMusician.Items.Clear();//загрузка музыкантов в box
            bool flag;
            for (int i = 0; i < musician.Rows.Count; i++)
            {
                rowMusician = musician.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (rowMusician["id_musician"].ToString() == row["id_musician"].ToString())
                        flag = false;
                }
                if (flag) boxMusician.Items.Add($"{rowMusician["name_musician"]} {rowMusician["surname_musician"]} {rowMusician["patronymic_musician"]}");
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
                        dataPerformance.Rows.Add($"{rowComposition["name_composition"]} {row["date_performance"]}");
                }
            }
            boxComposition.Items.Clear();//загрузка происзведений в box
            for (int i = 0; i < composition.Rows.Count; i++)
            {
                rowComposition = composition.Rows[i];
                boxComposition.Items.Add(rowComposition["name_composition"]);
            }
        }

        private void buttonAddMusician_Click(object sender, EventArgs e)
        {
            string[] musician = boxMusician.Text.Split(' ');
            DataTable table = managerDB.SelectTable("SELECT * FROM musician WHERE " +
                $"name_musician = \"{musician[0]}\" AND " +
                $"surname_musician = \"{musician[1]}\" AND " +
                $"patronymic_musician = \"{musician[2]}\";");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого музыканта нет в базе данных, добавьте его или выберите из списка существующего.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            table = managerDB.SelectTable($"SELECT * FROM relation_musician_ensemble WHERE id_ensemble = {dataEnsemble.CurrentRow.Cells[0].Value} AND id_musician = {row["id_musician"]}");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный музыкант уже состоит в этом ансамбле.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Query("INSERT INTO relation_musician_ensemble " +
                "(id_ensemble, id_musician) " +
                $"VALUES ({dataEnsemble.CurrentRow.Cells[0].Value}, {row["id_musician"]})");
        }

        private void buttonDeleteMusician_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataEnsemble.RowCount == 0) return;
            string[] musician = dataMusician.CurrentRow.Cells[0].Value.ToString().Split(' ');
            DataTable table = managerDB.SelectTable("SELECT * FROM musician WHERE " +
                $"name_musician = \"{musician[0]}\" AND " +
                $"surname_musician = \"{musician[1]}\" AND " +
                $"patronymic_musician = \"{musician[2]}\";");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_ensemble WHERE id_ensemble = {dataEnsemble.CurrentRow.Cells[0].Value} AND id_musician = {row["id_musician"]};";
            Query(commandText);
        }

        private void buttonAddPerformance_Click(object sender, EventArgs e)
        {
            DataTable table = managerDB.SelectTable("SELECT * FROM composition WHERE " +
                $"name_composition = \"{boxComposition.Text}\";");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого произведения нет в базе данных, добавьте его или выберите из списка существующего.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            table = managerDB.SelectTable("SELECT * FROM performance WHERE " +
                $"date_performance = \"{datePerformance.Text}\" AND " +
                $"id_ensemble = {dataEnsemble.CurrentRow.Cells[0].Value} AND " +
                $"id_composition = {row["id_composition"]};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Уже есть исполнение с такими параметрами.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Query("INSERT INTO performance " +
                "(id_ensemble, date_performance, id_composition) " +
                $"VALUES ({dataEnsemble.CurrentRow.Cells[0].Value}, \"{datePerformance.Text}\", {row["id_composition"]})");
        }

        private void buttonDeletePerformance_Click(object sender, EventArgs e)
        {
            if (dataPerformance.RowCount == 0 || dataEnsemble.RowCount == 0) return;
            string[] performance = dataPerformance.CurrentRow.Cells[0].Value.ToString().Split(' ');
            DataTable table = managerDB.SelectTable($"SELECT id_composition FROM composition WHERE name_composition = \"{performance[0]}\"");
            DataRow row = table.Rows[0];
            table = managerDB.SelectTable("SELECT * FROM performance WHERE " +
                $"id_ensemble = \"{dataEnsemble.CurrentRow.Cells[0].Value}\" AND " +
                $"id_composition = \"{row["id_composition"]}\";");
            row = table.Rows[0];
            string commandText = $"DELETE FROM performance WHERE id_performance = {row["id_performance"]};";
            Query(commandText);
        }
    }
}