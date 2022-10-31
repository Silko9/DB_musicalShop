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
        public FormTableMusician()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "ID musician";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].HeaderText = "name";
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].HeaderText = "surname";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "patronymic";
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].HeaderText = "phote";
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].HeaderText = "ID instrument";
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].HeaderText = "ID ensemble";
            dataGridView1.Columns[6].Width = 60;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
