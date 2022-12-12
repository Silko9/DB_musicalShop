using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_musicalShop.FormTable.FormQuery
{
    public partial class FormQueryRelationEnsembleMusician : Form
    {
        ManagerDB managerDB;
        string[] data;
        bool isEnsemble;
        DataTable table;
        public FormQueryRelationEnsembleMusician(ManagerDB managerDB, string[] data, bool isEnsemble)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            this.data = data;
            this.isEnsemble = isEnsemble;
            bool flag;
            DataRow row;
            if (isEnsemble)
            {
                DataTable table = managerDB.SelectTable($"SELECT id_musician FROM relation_musician_ensemble WHERE id_ensemble = {data[0]}");
                DataTable musician = managerDB.SelectTable("SELECT * FROM musician");
                DataRow rowMusician;
                boxEnsemble.Text = data[1];
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
            }
            else
            {
                DataTable table = managerDB.SelectTable($"SELECT id_ensemble FROM relation_musician_ensemble WHERE id_musician = {data[0]}");
                DataTable ensemble = managerDB.SelectTable("SELECT * FROM ensemble");
                DataRow rowEnsemble;
                boxMusician.Text = $"{data[1]} {data[2]} {data[3]}";
                for (int i = 0; i < ensemble.Rows.Count; i++)
                {
                    rowEnsemble = ensemble.Rows[i];
                    flag = true;
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        row = table.Rows[j];
                        if (rowEnsemble["id_ensemble"].ToString() == row["id_ensemble"].ToString())
                            flag = false;
                    }
                    if (flag) boxEnsemble.Items.Add(rowEnsemble["name_ensemble"].ToString());
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isEnsemble)
            {
                string[] musician = boxMusician.Text.Split(' ');
                try
                {
                    table = managerDB.SelectTable("SELECT * FROM musician WHERE " +
                        $"name_musician = \"{musician[0]}\" AND " +
                        $"surname_musician = \"{musician[1]}\" AND " +
                        $"patronymic_musician = \"{musician[2]}\";");
                }
                catch
                {
                    MessageBox.Show("Такого музыканта нет в базе данных, добавьте его или выберите из списка существующего.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такого музыканта нет в базе данных, добавьте его или выберите из списка существующего.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = table.Rows[0];
                table = managerDB.SelectTable($"SELECT * FROM relation_musician_ensemble WHERE id_ensemble = {data[0]} AND id_musician = {row["id_musician"]}");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Данный музыкант уже состоит в этом ансамбле.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                managerDB.Query("INSERT INTO relation_musician_ensemble " +
                    "(id_ensemble, id_musician) " +
                    $"VALUES ({data[0]}, {row["id_musician"]})");
            }
            else
            {
                DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE name_ensemble = \"{boxEnsemble.Text}\"");
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такого ансамбля нет в базе данных, добавьте его или выберите из списка существующих.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = table.Rows[0];
                table = managerDB.SelectTable($"SELECT * FROM relation_musician_ensemble WHERE id_musician = {data[0]} AND id_ensemble = {row["id_ensemble"]}");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("У данного музыканта уже есть данный ансамбль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                managerDB.Query("INSERT INTO relation_musician_ensemble " +
                    "(id_musician, id_ensemble) " +
                    $"VALUES ({data[0]}, {row["id_ensemble"]})");
            }
            if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                this.Close();
        }
    }
}
