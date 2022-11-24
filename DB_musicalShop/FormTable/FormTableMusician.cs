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
        Table[] dataTable = new Table[4] {  new Table("ID Музыканта", 70), new Table("Имя", 130),
                                            new Table("Фамилия", 130), new Table("Отчество", 130) };
        public FormTableMusician(ManagerDB managerDB)
        {
            InitializeComponent();
            dataMusician.RowHeadersVisible = false;
            dataMusician.AllowUserToAddRows = false;
            dataRole.RowHeadersVisible = false;
            dataRole.AllowUserToAddRows = false;
            dataEnsemble.RowHeadersVisible = false;
            dataEnsemble.AllowUserToAddRows = false;
            this.managerDB = managerDB;
            image = new Bitmap(pictureBox1.Image);
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP; *.JPG;*.GIF; *.PNG | All files(*.*) | *.* ";
            ImageConverter converter = new ImageConverter();
            imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
            UpdateTable();
            dataRole.Columns.Add("", "Роль");
            dataRole.Columns[0].Width = 130;
            dataEnsemble.Columns.Add("", "Ансамбль");
            dataEnsemble.Columns[0].Width = 130;
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
            DataTable table = managerDB.SelectTable("SELECT id_musician, name_musician, surname_musician, patronymic_musician FROM musician");
            dataMusician.DataSource = table;
            for (int i = 0; i < dataTable.Length; i++)
            {
                dataMusician.Columns[i].HeaderText = dataTable[i].name;
                dataMusician.Columns[i].Width = dataTable[i].width;
            }
            dataRole.Rows.Clear();
            dataEnsemble.Rows.Clear();
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
            if (CheckRecord()) return;
            string commandText = $"INSERT INTO musician " +
                "(name_musician, surname_musician, patronymic_musician, phote_musician)" +
                $"VALUES(\"{boxName.Text}\",\"{boxSurname.Text}\",\"{boxPatronymic.Text}\", @phote);";
            Query(commandText, imageBytes);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0) return;
            if (CheckRecord()) return;
            string commandText = $"UPDATE musician SET " +
                $"name_musician = \"{boxName.Text}\", " +
                $"surname_musician = \"{boxSurname.Text}\", " +
                $"patronymic_musician = \"{boxPatronymic.Text}\", " +
                $"phote_musician = @phote " +
                $"WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value};";
            Query(commandText, imageBytes);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0) return;
            string id = dataMusician.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM musician WHERE id_musician = {id};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMusician.Rows.Count == 0) return;
            boxName.Text = dataMusician.CurrentRow.Cells[1].Value.ToString();
            boxSurname.Text = dataMusician.CurrentRow.Cells[2].Value.ToString();
            boxPatronymic.Text = dataMusician.CurrentRow.Cells[3].Value.ToString();
            //загрузка картинки
            byte[] bytes = managerDB.rgbytedreaderExecute(managerDB.path, $"SELECT phote_musician FROM musician WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value};");
            pictureBox1.Image = ToImage(bytes);
            //загрузка ролей в data
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
            //загрузка ролей в box
            boxRole.Items.Clear();
            bool flag;
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

            //загрузка асамблей в data
            dataEnsemble.Rows.Clear();
            table = managerDB.SelectTable($"SELECT id_ensemble FROM relation_musician_ensemble WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value}");
            DataTable ensemble = managerDB.SelectTable("SELECT * FROM ensemble");
            DataRow rowEnsemble;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                for (int j = 0; j < ensemble.Rows.Count; j++)
                {
                    rowEnsemble = ensemble.Rows[j];
                    if (row["id_ensemble"].ToString() == rowEnsemble["id_ensemble"].ToString())
                        dataEnsemble.Rows.Add(rowEnsemble["name_ensemble"]);
                }
            }
            //загрузка ансамблей в box
            boxEnsemble.Items.Clear();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            DataTable table = managerDB.SelectTable($"SELECT * FROM role WHERE name_role = \"{boxRole.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такой роли нет в базе данных, добавьте ее или выберите из списка существующие.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            table = managerDB.SelectTable($"SELECT * FROM relation_musician_role WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value} AND id_role = {row["id_role"]}");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("У данного музыканта уже есть данная роль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Query("INSERT INTO relation_musician_role " + 
                "(id_musician, id_role) " +
                $"VALUES ({dataMusician.CurrentRow.Cells[0].Value}, {row["id_role"]})");
        }

        private void buttonDeleteRole_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataRole.RowCount == 0) return;
            DataTable table = managerDB.SelectTable($"SELECT * FROM role WHERE name_role = \"{dataRole.CurrentRow.Cells[0].Value}\"");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_role WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value} AND id_role = {row["id_role"]};";
            Query(commandText);
        }

        private void buttonAddEnsemble_Click(object sender, EventArgs e)
        {
            DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE name_ensemble = \"{boxEnsemble.Text}\"");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого ансамбля нет в базе данных, добавьте его или выберите из списка существующих.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = table.Rows[0];
            table = managerDB.SelectTable($"SELECT * FROM relation_musician_ensemble WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value} AND id_ensemble = {row["id_ensemble"]}");
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("У данного музыканта уже есть данный ансамбль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Query("INSERT INTO relation_musician_ensemble " +
                "(id_musician, id_ensemble) " +
                $"VALUES ({dataMusician.CurrentRow.Cells[0].Value}, {row["id_ensemble"]})");
        }

        private void buttonDeleteEnsemble_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataEnsemble.RowCount == 0) return;
            DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE name_ensemble = \"{dataEnsemble.CurrentRow.Cells[0].Value}\"");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_ensemble WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value} AND id_ensemble = {row["id_ensemble"]};";
            Query(commandText);
        }
        private bool CheckRecord()
        {
            if (boxName.Text == "" || boxSurname.Text == "")
            {
                MessageBox.Show("Заполните поля: Имя, Фамилия", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}