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
    public partial class FormQueryRelationMusicianRole : Form
    {
        ManagerDB managerDB;
        string[] data;
        bool isRole;
        public FormQueryRelationMusicianRole(ManagerDB managerDB, string[] data, bool isRole)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            this.data = data;
            this.isRole = isRole;
            bool flag;
            DataRow row;
            if (isRole)
            {
                boxMusician.Text = $"{data[1]} {data[2]} {data[3]}";
                DataTable table = managerDB.SelectTable($"SELECT id_role FROM relation_musician_role WHERE id_musician = {data[0]}");
                DataTable role = managerDB.SelectTable("SELECT * FROM role");
                DataRow rowRole;
                for (int i = 0; i < role.Rows.Count; i++)
                {
                    rowRole = role.Rows[i];
                    flag = true;
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        row = table.Rows[j];
                        if (rowRole["id_role"].ToString() == row["id_role"].ToString())
                            flag = false;
                    }
                    if (flag) boxRole.Items.Add(rowRole["name_role"].ToString());
                }
            }
            else
            {
                boxRole.Text = data[1];
                DataTable table = managerDB.SelectTable($"SELECT id_musician FROM relation_musician_role WHERE id_role = {data[0]}");
                DataTable musician = managerDB.SelectTable($"SELECT * FROM musician");
                DataRow rowMusician;
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
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isRole)
            {
                DataTable table = managerDB.SelectTable($"SELECT * FROM role WHERE name_role = \"{boxRole.Text}\"");
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такой роли нет в базе данных, добавьте ее или выберите из списка существующие.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = table.Rows[0];
                table = managerDB.SelectTable($"SELECT * FROM relation_musician_role WHERE id_musician = {data[0]} AND id_role = {row["id_role"]}");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("У данного музыканта уже есть данная роль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                managerDB.Query("INSERT INTO relation_musician_role " +
                    "(id_musician, id_role) " +
                    $"VALUES ({data[0]}, {row["id_role"]})");
            }
            else
            {
                string[] musician = boxMusician.Text.Split(' ');
                if(boxMusician.Text == "" && musician.Length < 3)
                {
                    MessageBox.Show("Такого музыканта нет в базе данных, добавьте его или выберите из списка существующего.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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
                table = managerDB.SelectTable($"SELECT * FROM relation_musician_role WHERE id_role = {data[0]} AND id_musician = {row["id_musician"]}");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("У данного музыканта уже есть данная роль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                managerDB.Query("INSERT INTO relation_musician_role " +
                    "(id_role, id_musician) " +
                    $"VALUES ({data[0]}, {row["id_musician"]})");
            }
            if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                this.Close();
        }
    }
}
