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
    public partial class FormTableComposition : Form
    {
        public FormTableComposition()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "ID composition";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].HeaderText = "name composition";
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].HeaderText = "name author";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "surname author";
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].HeaderText = "patronymic author";
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].HeaderText = "date create";
            dataGridView1.Columns[5].Width = 60;
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
