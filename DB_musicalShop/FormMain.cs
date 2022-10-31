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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            saveFileDialog1.DefaultExt = ".db";
            saveFileDialog1.Title = "Выберите куда сохранить файл базы данных";
        }

        private void buttonCreateNewDB_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
            else
                MessageBox.Show("Ошибка");
        }
    }
}
