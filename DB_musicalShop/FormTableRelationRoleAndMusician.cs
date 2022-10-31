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
    public partial class FormTableRelationRoleAndMusician : Form
    {
        public FormTableRelationRoleAndMusician()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "ID Musician";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].HeaderText = "ID role";
            dataGridView1.Columns[1].Width = 70;
        }
    }
}
