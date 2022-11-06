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
    public partial class FormTableMusician : Form
    {
        ManagerDB managerDB;
        public FormTableMusician(ManagerDB managerDB)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("", "ID Музыканта");
            dataGridView1.Columns.Add("", "Имя");
            dataGridView1.Columns.Add("", "Фамилия");
            dataGridView1.Columns.Add("", "Отчество");
            dataGridView1.Columns.Add("", "Фото");
            dataGridView1.Columns.Add("", "Ансамбль");
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.AllowUserToAddRows = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.managerDB = managerDB;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable type = managerDB.SelectTable("SELECT * FROM ensemble;");
            DataRow row;
            DataRow rowType;
            string currentItem = boxEnsemble.Text;
            boxEnsemble.Items.Clear();
            for (int i = 0; i < type.Rows.Count; i++)
            {
                row = type.Rows[i];
                boxEnsemble.Items.Add(Convert.ToString($"{row["name_ensemble"]} [id{row["id_ensemble"]}]"));
            }
            DataTable table = managerDB.SelectTable("SELECT * FROM musician");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowType = type.Rows[0];
                    for (int j = 0; j < type.Rows.Count; j++)
                    {
                        rowType = type.Rows[j];
                        if (rowType["id_ensemble"].ToString() == row["id_ensemble"].ToString())
                            break;
                    }
                    dataGridView1.Rows.Add(row["id_musician"], row["name_musician"], row["surname_musician"], row["patronymic_musician"], row["phote_musician"], $"{rowType["name_ensemble"]} [id{rowType["id_ensemble"]}]");
                }
                catch
                {
                    dataGridView1.Rows.Add(row["id_musician"], row["name_musician"], row["surname_musician"], row["patronymic_musician"], row["phote_musician"], row["id_ensemble"]);
                }
            }
            boxEnsemble.Text = currentItem;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text != "" && boxSurname.Text != "" && boxEnsemble.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text) || !managerDB.IsMatch(boxSurname.Text) || !managerDB.IsMatch(boxPatronymic.Text))
                {
                    MessageBox.Show("В полях должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO musician " +
                    "(name_musician, surname_musician, patronymic_musician, id_ensemble)" +
                    $"VALUES(\"{boxName.Text}\",\"{boxSurname.Text}\",\"{boxPatronymic.Text}\",\"{managerDB.GetID(boxEnsemble.Text)}\");";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (boxName.Text != "" && boxSurname.Text != "" && boxEnsemble.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text) || !managerDB.IsMatch(boxSurname.Text) || !managerDB.IsMatch(boxPatronymic.Text))
                {
                    MessageBox.Show("В полях должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"UPDATE musician SET " +
                $"name_musician = \"{boxName.Text}\", " +
                $"surname_musician = \"{boxSurname.Text}\", " +
                $"patronymic_musician = \"{boxPatronymic.Text}\", " +
                $"id_ensemble = {managerDB.GetID(boxEnsemble.Text)} " +
                $"WHERE id_musician = {dataGridView1.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните все поля.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string commandText = $"DELETE FROM musician WHERE id_musician = {dataGridView1.CurrentRow.Cells[0].Value};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count < 0)
                return;
            boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boxPatronymic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            boxEnsemble.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() != "")
            {
                DataRow row;
                DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE id_ensemble = {managerDB.GetID(dataGridView1.CurrentRow.Cells[5].Value.ToString())};");
                if (table.Rows.Count > 0)
                {
                    row = table.Rows[0];
                    boxEnsemble.Text = Convert.ToString($"{row["name_ensemble"]} [id{row["id_ensemble"]}]");
                }
            }
            else boxEnsemble.Text = "";
        }
    }
}
