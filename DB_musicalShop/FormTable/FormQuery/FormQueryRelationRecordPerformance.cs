using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DB_musicalShop.FormTable.FormQuery
{
    public partial class FormQueryRelationRecordPerformance : Form
    {
        ManagerDB managerDB;
        string[] data;
        bool isRecord;
        public FormQueryRelationRecordPerformance(ManagerDB managerDB, string[] data, bool isRecord)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            this.data = data;
            this.isRecord = isRecord;
            if (isRecord)
            {
                boxRecord.Text = data[0];
                boxPerformance.Items.Clear(); //загрузка исполнений в box
                DataTable table = managerDB.SelectTable($"SELECT id_performance FROM relation_record_performance WHERE number_record = \"{data[0]}\"");
                DataTable performance = managerDB.SelectTable("SELECT * FROM performance");
                DataRow row;
                DataRow rowPerformance;
                DataTable ensemble;
                DataRow rowEnsemble;
                bool flag;
                for (int i = 0; i < performance.Rows.Count; i++)
                {
                    rowPerformance = performance.Rows[i];
                    flag = true;
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        row = table.Rows[j];
                        if (rowPerformance["id_performance"].ToString() == row["id_performance"].ToString())
                            flag = false;
                    }
                    if (flag)
                    {
                        ensemble = managerDB.SelectTable($"SELECT name_ensemble FROM ensemble WHERE id_ensemble = {rowPerformance["id_ensemble"]}");
                        rowEnsemble = ensemble.Rows[0];
                        boxPerformance.Items.Add($"{rowEnsemble["name_ensemble"]},{rowPerformance["date_performance"]}");
                    }
                }
            }
            else
            {
                boxPerformance.Text = $"{data[2]} {data[3]} {data[1]}";
                DataTable table = managerDB.SelectTable($"SELECT number_record FROM relation_record_performance WHERE id_performance = {data[0]}");
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
            if (isRecord)
            {
                try
                {
                    string[] performance = boxPerformance.Text.Split(',');
                    DataTable ensemble = managerDB.SelectTable($"SELECT id_ensemble FROM ensemble WHERE name_ensemble = \"{performance[0]}\"");
                    DataRow rowEnsemble = ensemble.Rows[0];
                    DataTable table = managerDB.SelectTable("SELECT id_performance FROM performance WHERE " +
                        $"id_ensemble = {rowEnsemble["id_ensemble"]} AND " +
                        $"date_performance = \"{performance[1]}\";");
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Такого исполнения нет в базе данных, добавьте его или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    DataRow row = table.Rows[0];
                    table = managerDB.SelectTable("SELECT * FROM relation_record_performance WHERE " +
                        $"number_record = \"{data[0]}\" AND " +
                        $"id_performance = {row["id_performance"]}");
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("У данной пластинки уже есть данное исполнение.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    managerDB.Query("INSERT INTO relation_record_performance " +
                        "(number_record, id_performance) " +
                        $"VALUES (\"{data[0]}\", {row["id_performance"]})");
                }
                catch
                {
                    MessageBox.Show("Такого исполнения нет в базе данных, добавьте его или выберите из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                DataTable table = managerDB.SelectTable($"SELECT * FROM record WHERE number_record = \"{boxRecord.Text}\"");
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такой пластинки нет в базе данных, добавьте ее или выберите из списка существующие.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = table.Rows[0];
                table = managerDB.SelectTable($"SELECT * FROM relation_record_performance WHERE id_performance = {data[0]} AND number_record = \"{row["number_record"]}\"");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Данное исполнение уже записана на этой пластинке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                managerDB.Query("INSERT INTO relation_record_performance " +
                    "(id_performance, number_record) " +
                    $"VALUES ({data[0]}, \"{row["number_record"]}\")");
            }
            if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                this.Close();
        }
    }
}
