using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DB_musicalShop
{
    public partial class FormTableMusician : Form
    {
        ManagerDB managerDB;
        Bitmap image;
        byte[] imageBytes;
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
            dataGridView1.Columns.Add("", "Инструмент");
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].Width = 200;
            dataGridView1.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            image = new Bitmap(pictureBox1.Image);
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP; *.JPG;*.GIF; *.PNG | All files(*.*) | *.* ";
            ImageConverter converter = new ImageConverter();
            imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DataTable type = managerDB.SelectTable("SELECT * FROM ensemble;");
            DataTable instrument = managerDB.SelectTable("SELECT * FROM musicial_instrument;");
            DataRow row;
            DataRow rowType;
            DataRow rowInstrument;
            string currentItemE = boxEnsemble.Text;
            string currentItemI = boxInstrument.Text;
            boxEnsemble.Items.Clear();
            boxInstrument.Items.Clear();
            boxInstrument.Items.Add("");
            for (int i = 0; i < type.Rows.Count; i++)
            {
                row = type.Rows[i];
                boxEnsemble.Items.Add(Convert.ToString($"{row["name_ensemble"]} [id{row["id_ensemble"]}]"));
            }
            for (int i = 0; i < instrument.Rows.Count; i++)
            {
                row = instrument.Rows[i];
                boxInstrument.Items.Add(Convert.ToString($"{row["name_instrument"]} [id{row["id_instrument"]}]"));
            }
            DataTable table = managerDB.SelectTable("SELECT * FROM musician");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                try
                {
                    rowType = type.Rows[0];
                    rowInstrument = instrument.Rows[0];
                    for (int j = 0; j < type.Rows.Count; j++)
                    {
                        rowType = type.Rows[j];
                        if (rowType["id_ensemble"].ToString() == row["id_ensemble"].ToString())
                            break;
                    }
                    bool flag = true;
                    for (int j = 0; j < instrument.Rows.Count; j++)
                    {
                        rowInstrument = instrument.Rows[j];
                        if (rowInstrument["id_instrument"].ToString() == row["id_instrument"].ToString())
                            break;
                        if (j == instrument.Rows.Count - 1)
                            flag = false;
                    }
                    if(flag)
                        dataGridView1.Rows.Add(row["id_musician"], row["name_musician"], row["surname_musician"], row["patronymic_musician"], row["phote_musician"], $"{rowType["name_ensemble"]} [id{rowType["id_ensemble"]}]", $"{rowInstrument["name_instrument"]} [id{rowInstrument["id_instrument"]}]");
                    else
                        dataGridView1.Rows.Add(row["id_musician"], row["name_musician"], row["surname_musician"], row["patronymic_musician"], row["phote_musician"], $"{rowType["name_ensemble"]} [id{rowType["id_ensemble"]}]", "");

                }
                catch
                {
                    dataGridView1.Rows.Add(row["id_musician"], row["name_musician"], row["surname_musician"], row["patronymic_musician"], row["phote_musician"], row["id_ensemble"], row["id_instrument"]);
                }
            }
            boxEnsemble.Text = currentItemE;
            boxInstrument.Text = currentItemI;
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
                if (!managerDB.IsMatch(boxName.Text) || !managerDB.IsMatch(boxSurname.Text))
                {
                    MessageBox.Show("В полях должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO musician " +
                    "(name_musician, surname_musician, patronymic_musician, id_ensemble, id_instrument)" +
                    $"VALUES(\"{boxName.Text}\",\"{boxSurname.Text}\",\"{boxPatronymic.Text}\",{managerDB.GetID(boxEnsemble.Text)}, {managerDB.GetID(boxInstrument.Text)});";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните поля: Имя, Фамилия, Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                $"id_ensemble = {managerDB.GetID(boxEnsemble.Text)}, " +
                $"id_instrument = {managerDB.GetID(boxInstrument.Text)} " +
                $"WHERE id_musician = {dataGridView1.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
            else
                MessageBox.Show("Заполните поля: Имя, Фамилия, Отчество, Ансамбль", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataTable table = managerDB.SelectTable($"SELECT * FROM relation_musician_role WHERE id_musician = {id};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Музыкант\", пока она используется хотя бы в одной записи таблицы \"Отношения музыкантов и ролей\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
            }
            else
            {
                string commandText = $"DELETE FROM musician WHERE id_musician = {dataGridView1.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boxPatronymic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            boxEnsemble.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            boxInstrument.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    ImageConverter converter = new ImageConverter();
                    imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
