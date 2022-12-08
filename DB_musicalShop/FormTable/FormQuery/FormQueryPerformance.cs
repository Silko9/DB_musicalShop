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

namespace DB_musicalShop.FormTable.FormQuery
{
    public partial class FormQueryPerformance : Form
    {
        ManagerDB managerDB;
        string[] data;
        DataRow rowComposition = null;
        DataRow rowEnsemble = null;
        public FormQueryPerformance(ManagerDB managerDB, string[] data)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            this.data = data;
            DataTable ensemble = managerDB.SelectTable("SELECT * FROM ensemble;");
            DataTable composition = managerDB.SelectTable("SELECT * FROM composition;");
            DataRow row;
            for (int i = 0; i < ensemble.Rows.Count; i++)
            {
                row = ensemble.Rows[i];
                boxEnsemble.Items.Add(Convert.ToString(row["name_ensemble"]));
            }
            for (int i = 0; i < composition.Rows.Count; i++)
            {
                row = composition.Rows[i];
                boxComposition.Items.Add(Convert.ToString(row["name_composition"]));
            }
            if (data == null)
            {
                this.Text = "Добавление";
                button.Text = "Добавить";
            }
            else
            {
                this.Text = "Изменение";
                button.Text = "Изменить";
                boxEnsemble.Text = data[2];
                boxComposition.Text = data[3];
                dateCreate.Text = data[1];
                boxCircumstances_execution.Text = data[4];
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                if (CheckRecord()) return;
                string commandText = $"INSERT INTO performance (date_performance, id_ensemble, id_composition, circumstances_execution)" +
                $"VALUES(\"{dateCreate.Text}\", {rowEnsemble["id_ensemble"]},{rowComposition["id_composition"]}, \"{boxCircumstances_execution.Text}\");";
                managerDB.Query(commandText);
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                if (CheckRecord()) return;
                string commandText = $"UPDATE performance SET " +
                $"id_ensemble = \"{rowEnsemble["id_ensemble"]}\", " +
                $"id_composition = {rowComposition["id_composition"]}, " +
                $"date_performance = \"{dateCreate.Text}\", " +
                $"circumstances_execution = \"{boxCircumstances_execution.Text}\" " +
                $"WHERE id_performance = {data[0]};";
                managerDB.Query(commandText);
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private bool CheckRecord()
        {
            if (boxComposition.Text == "" || boxEnsemble.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE name_ensemble = \"{boxEnsemble.Text}\";");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого ансамбля нет. Добавьте его или выберите из списка существующий", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            rowEnsemble = table.Rows[0];
            table = managerDB.SelectTable($"SELECT * FROM composition WHERE name_composition = \"{boxComposition.Text}\";");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого произведения нет. Добавьте его или выберите из списка существующий", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            rowComposition = table.Rows[0];
            table = managerDB.SelectTable("SELECT * FROM performance WHERE " +
                $"date_performance = \"{dateCreate.Text}\" AND " +
                $"id_ensemble = {rowEnsemble["id_ensemble"]} AND " +
                $"id_composition = {rowComposition["id_composition"]};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Уже есть исполнение с такими параметрами.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
