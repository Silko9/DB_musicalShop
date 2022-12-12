using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DB_musicalShop.FormTable.FormQuery
{
    public partial class FormQueryMusician : Form
    {
        ManagerDB managerDB;
        Bitmap image;
        byte[] imageBytes;
        string[] data;
        public FormQueryMusician(ManagerDB managerDB, string[] data, Bitmap image)
        {
            Initialize(managerDB);
            this.data = data;
            this.Text = "Изменение";
            button.Text = "Изменить";
            boxName.Text = data[1];
            boxSurname.Text = data[2];
            boxPatronymic.Text = data[3];
            this.image = image;
            pictureBox1.Image = image;
            InitializeImg();
        }
        public FormQueryMusician(ManagerDB managerDB)
        {
            Initialize(managerDB);
            image = new Bitmap(pictureBox1.Image);
            this.Text = "Добавление";
            button.Text = "Добавить";
            InitializeImg();
        }
        private void Initialize(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
        }
        private void InitializeImg()
        {
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP; *.JPG;*.GIF; *.PNG | All files(*.*) | *.* ";
            ImageConverter converter = new ImageConverter();
            imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
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

        private void button_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                if (CheckRecord()) return;
                string commandText = $"INSERT INTO musician " +
                    "(name_musician, surname_musician, patronymic_musician, phote_musician)" +
                    $"VALUES(\"{boxName.Text}\",\"{boxSurname.Text}\",\"{boxPatronymic.Text}\", @phote);";
                managerDB.QueryImg(commandText, imageBytes);
                if (MessageBox.Show("Запись добавлена.\nДобавить еще?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    this.Close();
            }
            else
            {
                if (CheckRecord()) return;
                string commandText = $"UPDATE musician SET " +
                    $"name_musician = \"{boxName.Text}\", " +
                    $"surname_musician = \"{boxSurname.Text}\", " +
                    $"patronymic_musician = \"{boxPatronymic.Text}\", " +
                    $"phote_musician = @phote " +
                    $"WHERE id_musician = {data[0]};";
                managerDB.QueryImg(commandText, imageBytes);
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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
