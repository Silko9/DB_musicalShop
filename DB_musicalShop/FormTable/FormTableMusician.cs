using DB_musicalShop.FormTable.FormAddOrUpdate;
using DB_musicalShop.FormTable.FormQuery;
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
        FormQueryMusician formQueryMusician;
        FormQueryRelationEnsembleMusician formQueryRelationEnsembleMusician;
        FormQueryRelationMusicianRole formQueryRelationMusicianRole;
        public FormTableMusician(ManagerDB managerDB)
        {
            InitializeComponent();
            this.managerDB = managerDB;
            image = new Bitmap(pictureBox1.Image);
            UpdateTable();
        }
        private void UpdateTable()
        {
            DataTable table = managerDB.SelectTable("SELECT id_musician, name_musician, surname_musician, patronymic_musician FROM musician");
            DataRow row;
            dataMusician.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                row = table.Rows[i];
                dataMusician.Rows.Add(row["id_musician"], row["name_musician"], row["surname_musician"], row["patronymic_musician"]);
            }
            dataRole.Rows.Clear();
            dataEnsemble.Rows.Clear();
        }
        private void Query(string command)
        {
            managerDB.Query(command);
            UpdateTable();
            LoadData();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formQueryMusician = new FormQueryMusician(managerDB);
            formQueryMusician.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0) return;
            string[] data = new string[4];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataMusician.CurrentRow.Cells[i].Value.ToString();
            formQueryMusician = new FormQueryMusician(managerDB, data, (Bitmap)pictureBox1.Image);
            formQueryMusician.ShowDialog();
            UpdateTable();
            LoadData();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            string id = dataMusician.CurrentRow.Cells[0].Value.ToString();
            string commandText = $"DELETE FROM musician WHERE id_musician = {id};";
            Query(commandText);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
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
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
            LoadData();
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            if (dataMusician.Rows.Count == 0) return;
            string[] data = new string[4];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataMusician.CurrentRow.Cells[i].Value.ToString();
            formQueryRelationMusicianRole = new FormQueryRelationMusicianRole(managerDB, data, true);
            formQueryRelationMusicianRole.ShowDialog();
            LoadData();
        }

        private void buttonDeleteRole_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataRole.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            DataTable table = managerDB.SelectTable($"SELECT * FROM role WHERE name_role = \"{dataRole.CurrentRow.Cells[0].Value}\"");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_role WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value} AND id_role = {row["id_role"]};";
            Query(commandText);
        }

        private void buttonAddEnsemble_Click(object sender, EventArgs e)
        {
            if (dataMusician.Rows.Count == 0) return;
            string[] data = new string[4];
            for (int i = 0; i < data.Length; i++)
                data[i] = dataMusician.CurrentRow.Cells[i].Value.ToString();
            formQueryRelationEnsembleMusician = new FormQueryRelationEnsembleMusician(managerDB, data, false);
            formQueryRelationEnsembleMusician.ShowDialog();
            LoadData();
        }

        private void buttonDeleteEnsemble_Click(object sender, EventArgs e)
        {
            if (dataMusician.RowCount == 0 || dataEnsemble.RowCount == 0) return;
            if (MessageBox.Show("Удалить запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            DataTable table = managerDB.SelectTable($"SELECT * FROM ensemble WHERE name_ensemble = \"{dataEnsemble.CurrentRow.Cells[0].Value}\"");
            DataRow row = table.Rows[0];
            string commandText = $"DELETE FROM relation_musician_ensemble WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value} AND id_ensemble = {row["id_ensemble"]};";
            Query(commandText);
        }
        private void LoadData()
        {
            if (dataMusician.Rows.Count == 0) return;
            //загрузка картинки
            byte[] bytes = managerDB.rgbytedreaderExecute(managerDB.Path, $"SELECT phote_musician FROM musician WHERE id_musician = {dataMusician.CurrentRow.Cells[0].Value};");
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
        }

        private void FormTableMusician_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}