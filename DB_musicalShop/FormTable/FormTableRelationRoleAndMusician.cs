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
    public partial class FormTableRelationRoleAndMusician : Form
    {
        ManagerDB managerDB;
        public FormTableRelationRoleAndMusician(ManagerDB managerDB)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("", "ID Музыкант");
            dataGridView1.Columns.Add("", "ID Роль");
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            UpdateTable();
        }
        private string GetInitials(string name, string surname, string patronymic)
        {
            return $"{surname} {name[0]}. {patronymic[0]}.";
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable musician = managerDB.SelectTable("SELECT * FROM musician;");
            DataRow row;
            DataRow rowMusician;
            DataRow rowRole;
            DataTable role = managerDB.SelectTable("SELECT * FROM role");
            string currentItemM = boxMusician.Text;
            string currentItemR = boxRole.Text;
            boxMusician.Items.Clear();
            boxRole.Items.Clear();
            boxMusician.Items.Add("");
            boxRole.Items.Add("");
            if (boxRole.Text != "")
                SelectMusician();
            else
                for (int i = 0; i < musician.Rows.Count; i++)
                {
                    row = musician.Rows[i];
                    boxMusician.Items.Add(Convert.ToString($"{GetInitials(row["name_musician"].ToString(), row["surname_musician"].ToString(), row["patronymic_musician"].ToString())} [id{row["id_musician"]}]"));
                }
            if (boxRole.Text != "")
                SelectRole();
            else
                for (int i = 0; i < role.Rows.Count; i++)
                {
                    rowRole = role.Rows[i];
                    boxRole.Items.Add(Convert.ToString($"{rowRole["name_role"]} [id{rowRole["id_role"]}]"));
                }
            DataTable table = managerDB.SelectTable("SELECT * FROM relation_musician_role");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowMusician = musician.Rows[0];
                    for (int j = 0; j < musician.Rows.Count; j++)
                    {
                        rowMusician = musician.Rows[j];
                        if (rowMusician["id_musician"].ToString() == row["id_musician"].ToString())
                            break;
                    }
                    rowRole = role.Rows[0];
                    for (int j = 0; j < role.Rows.Count; j++)
                    {
                        rowRole = role.Rows[j];
                        if (rowRole["id_role"].ToString() == row["id_role"].ToString())
                            break;
                    }
                    dataGridView1.Rows.Add($"{GetInitials(rowMusician["name_musician"].ToString(), rowMusician["surname_musician"].ToString(), rowMusician["patronymic_musician"].ToString())} [id{rowMusician["id_musician"]}]", $"{rowRole["name_role"]} [id{rowRole["id_role"]}]");
                }
                catch
                {
                    dataGridView1.Rows.Add(" ", " ");
                }
            }
            boxMusician.Text = currentItemM;
            boxRole.Text = currentItemR;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxMusician.Text != "" && boxRole.Text != "")
            {
                string commandText = $"INSERT INTO relation_musician_role (id_musician, id_role)" +
                $"VALUES(\"{managerDB.GetID(boxMusician.Text)}\", \"{managerDB.GetID(boxRole.Text)}\");";
                Query(commandText);
                SelectRole();
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxMusician.Text != "" && boxRole.Text != "")
            {
                string commandText = $"UPDATE relation_musician_role SET " +
                $"id_musician = {managerDB.GetID(boxMusician.Text)}, " +
                $"id_role = {managerDB.GetID(boxRole.Text)} " +
                $"WHERE id_musician = {managerDB.GetID(dataGridView1.CurrentRow.Cells[0].Value.ToString())} AND " +
                $"id_role = {managerDB.GetID(dataGridView1.CurrentRow.Cells[1].Value.ToString())};";
                Query(commandText);
                SelectRole();
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string commandText = $"DELETE FROM relation_musician_role " +
                $"WHERE id_musician = {managerDB.GetID(dataGridView1.CurrentRow.Cells[0].Value.ToString())} AND " +
                $"id_role = {managerDB.GetID(dataGridView1.CurrentRow.Cells[1].Value.ToString())};";
            Query(commandText);
            SelectRole();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count < 0) return;
            boxMusician.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            boxRole.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        private void SelectRole()
        {
            string currentItem = boxRole.Text;
            boxRole.Items.Clear();
            boxRole.Items.Add("");
            DataTable table = managerDB.SelectTable("SELECT * FROM relation_musician_role " +
                $"WHERE id_musician = {managerDB.GetID(boxMusician.Text)};");
            DataTable role = managerDB.SelectTable("SELECT * FROM role");
            DataRow row;
            DataRow rowRole;
            bool flag;
            for (int i = 0; i < role.Rows.Count; i++)
            {
                rowRole = role.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (row["id_role"].ToString() == rowRole["id_role"].ToString())
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    boxRole.Items.Add($"{rowRole["name_role"]} [id{rowRole["id_role"]}]");
            }
            boxRole.Text = currentItem;
        }
        private void SelectMusician()
        {
            string currentItemM = boxMusician.Text;
            boxMusician.Items.Clear();
            boxMusician.Items.Add("");
            DataTable table = managerDB.SelectTable("SELECT * FROM relation_musician_role " +
                $"WHERE id_role = {managerDB.GetID(boxRole.Text)};");
            DataTable musicial = managerDB.SelectTable("SELECT * FROM musician");
            DataRow row;
            DataRow rowMusician;
            bool flag;
            for (int i = 0; i < musicial.Rows.Count; i++)
            {
                rowMusician = musicial.Rows[i];
                flag = true;
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    row = table.Rows[j];
                    if (row["id_musician"].ToString() == rowMusician["id_musician"].ToString())
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    boxMusician.Items.Add($"{GetInitials(rowMusician["name_musician"].ToString(), rowMusician["surname_musician"].ToString(), rowMusician["patronymic_musician"].ToString())} [id{rowMusician["id_musician"]}]");
                }
            }
            boxMusician.Text = currentItemM;
        }
        private void boxMusician_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectRole();
        }

        private void boxRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectMusician();
        }
    }
}
