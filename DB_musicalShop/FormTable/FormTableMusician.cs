using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

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
            dataMusician.RowHeadersVisible = false;
            dataMusician.AllowUserToAddRows = false;
            dataRole.RowHeadersVisible = false;
            dataRole.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            image = new Bitmap(pictureBox1.Image);
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP; *.JPG;*.GIF; *.PNG | All files(*.*) | *.* ";
            ImageConverter converter = new ImageConverter();
            imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
            UpdateTable();
        }
        private void UpdateTable()
        {
            dataMusician.Rows.Clear();
            DataTable table = managerDB.SelectTable("SELECT id_musician, name_musician, surname_musician, patronymic_musician FROM musician");
            dataMusician.DataSource = table;
            dataRole.Columns.Add("", "Название");
            dataMusician.Columns[0].HeaderText = "ID Музыканта";
            dataMusician.Columns[1].HeaderText = "Имя";
            dataMusician.Columns[2].HeaderText = "Фамилия";
            dataMusician.Columns[3].HeaderText = "Отчество";
            dataMusician.Columns[0].Width = 70;
            dataMusician.Columns[1].Width = 130;
            dataMusician.Columns[2].Width = 130;
            dataMusician.Columns[3].Width = 130;
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
        }
        private void Query(string command, byte[] imagesBytes)
        {
            managerDB.QueryImg(command, imagesBytes);
            UpdateTable();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text != "" && boxSurname.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text) || !managerDB.IsMatch(boxSurname.Text))
                {
                    MessageBox.Show("В полях должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"INSERT INTO musician " +
                    "(name_musician, surname_musician, patronymic_musician, phote_musician)" +
                    $"VALUES(\"{boxName.Text}\",\"{boxSurname.Text}\",\"{boxPatronymic.Text}\", @phote);";
                Query(commandText, imageBytes); 
            }
            else
                MessageBox.Show("Заполните поля: Имя, Фамилия", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0) return;
            if (boxName.Text != "" && boxSurname.Text != "")
            {
                if (!managerDB.IsMatch(boxName.Text) || !managerDB.IsMatch(boxSurname.Text))
                {
                    MessageBox.Show("В полях должны быть только буквы и цифры.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string commandText = $"UPDATE musician SET " +
                $"name_musician = \"{boxName.Text}\", " +
                $"surname_musician = \"{boxSurname.Text}\", " +
                $"patronymic_musician = \"{boxPatronymic.Text}\", " +
                $"phote_musician = @phote " +
                $"WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value};";
                Query(commandText, imageBytes);
            }
            else
                MessageBox.Show("Заполните поля: Имя, Фамилия, Отчество", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0) return;
            string id = dataMusician.CurrentRow.Cells[0].Value.ToString();
            DataTable table = managerDB.SelectTable($"SELECT * FROM relation_musician_role WHERE id_musician = {id};");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить запись \"Музыкант\", пока она используется хотя бы в одной записи таблицы \"Отношения музыкантов и ролей\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable();
            }
            else
            {
                string commandText = $"DELETE FROM musician WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value};";
                Query(commandText);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMusician.Rows.Count == 0) return;
            boxName.Text = dataMusician.CurrentRow.Cells[1].Value.ToString();
            boxSurname.Text = dataMusician.CurrentRow.Cells[2].Value.ToString();
            boxPatronymic.Text = dataMusician.CurrentRow.Cells[3].Value.ToString();
            byte[] bytes = managerDB.rgbytedreaderExecute(managerDB.path, $"SELECT phote_musician FROM musician WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value};");
            pictureBox1.Image = ToImage(bytes);
            dataRole.Rows.Clear();
            DataTable table = managerDB.SelectTable($"SELECT id_role FROM relation_musician_role WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value}");
            DataTable role = managerDB.SelectTable("SELECT * FROM role");
            DataRow row;
            DataRow rowRole;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                for (int j = 0; j < role.Rows.Count; j++)
                {
                    rowRole = role.Rows[j];
                    if (row["id_role"].ToString() == rowRole["id_role"].ToString())
                        dataRole.Rows.Add(rowRole["name_role"]);
                }
            }
        }
        public static Image ToImage(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            Image img;
            using (MemoryStream stream = new MemoryStream(data))
            {
                using (Image temp = Image.FromStream(stream))
                {
                    img = new Bitmap(temp);
                }
            }
            return img;
        }
        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    ImageConverter converter = new ImageConverter();
                    imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}