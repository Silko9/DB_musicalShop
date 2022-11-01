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
    public partial class FormTablePerformance : Form
    {
        public FormTablePerformance()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "ID performance";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].HeaderText = "ID composition";
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].HeaderText = "ID ensemble";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "date create";
            dataGridView1.Columns[3].Width = 70;
        }
    }
}
