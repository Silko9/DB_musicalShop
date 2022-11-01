using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace DB_musicalShop
{
    public partial class FormMain : Form
    {
        ManagerDB managerDB = new ManagerDB();
        FormTableMusician formTableMusician;
        FormTableRole formTableRole;
        FormTableRelationRoleAndMusician formTableRelationRoleAndMusician;
        FormTableMusicialInstrument formTableMusicialInstrument;
        FormTableEnsemble formTableEnsemble;
        FormTableTypeEnseble formTableTypeEnseble;
        FormTableComposition formTableComposition;
        FormTablePerformance formTablePerformance;
        FormTableRecord formTableRecord;
        FormTableRelationRecordAndPerformance formTableRelationRecordAndPerformance;
        FormTableLogging formTableLogging;
        FormTableTypeOfOperation formTableTypeOfOperation;
        public FormMain()
        {
            InitializeComponent();
            saveFileDialog1.DefaultExt = ".db";
            saveFileDialog1.Title = "Выберите куда сохранить файл базы данных";
            saveFileDialog1.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            ButtonEnabled(false);
            //для теста
            if (!managerDB.CheckDB("C:\\SQLite\\data.db"))
            {
                ButtonEnabled(false);
                MessageBox.Show("Файл не соотвествует требованию приложения.\nВыберите другую или создайте новую базу данных.");
                return;
            }
            label2.Text = "C:\\SQLite\\data.db";
            ButtonEnabled(true);
            //
        }
        private void ButtonEnabled(bool enabled)
        {
            buttonViewTableComposition.Enabled = enabled;
            buttonViewTableEnsemble.Enabled = enabled;
            buttonViewTableLogging.Enabled = enabled;
            buttonViewTableMusicialInstrument.Enabled = enabled;
            buttonViewTableMusician.Enabled = enabled;
            buttonViewTablePerformance.Enabled = enabled;
            buttonViewTableRecord.Enabled = enabled;
            buttonViewTableRelationRecordAndPerformance.Enabled = enabled;
            buttonViewTableRelationRoleAndMusician.Enabled = enabled;
            buttonViewTableRole.Enabled = enabled;
            buttonTypeEnseble.Enabled = enabled;
            buttonViewTableTypeOfAction.Enabled = enabled;
        }
        private void buttonCreateNewDB_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (managerDB.CreateDB(saveFileDialog1.FileName))
                {
                    case 1:
                        ButtonEnabled(false);
                        MessageBox.Show("Файл занят другим процессом.\nВыберите другое расположение.");
                        return;
                    case 2:
                        ButtonEnabled(false);
                        MessageBox.Show("Ошибка создания базы данных.");
                        return;
                }
                label2.Text = saveFileDialog1.FileName;
                ButtonEnabled(true);
            }
        }
        private void buttonOpenDB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK || !managerDB.CheckDB(openFileDialog1.FileName))
            {
                ButtonEnabled(false);
                MessageBox.Show("Файл не соотвествует требованию приложения.\nВыберите другую или создайте новую базу данных.");
                return;
            }
            label2.Text = openFileDialog1.FileName;
            ButtonEnabled(true);
        }
        private void buttonViewTableMusician_Click(object sender, EventArgs e)
        {
            if (formTableMusician != null)
                formTableMusician.Close();
            formTableMusician = new FormTableMusician();
            formTableMusician.Show();
        }
        private void buttonViewTableRole_Click(object sender, EventArgs e)
        {
            if (formTableRole != null)
                formTableRole.Close();
            formTableRole = new FormTableRole();
            formTableRole.Show();
        }
        private void buttonViewTableRelationRoleAndMusician_Click(object sender, EventArgs e)
        {
            if (formTableRelationRoleAndMusician != null)
                formTableRelationRoleAndMusician.Close();
            formTableRelationRoleAndMusician = new FormTableRelationRoleAndMusician();
            formTableRelationRoleAndMusician.Show();
        }
        private void buttonViewTableMusicialInstrument_Click(object sender, EventArgs e)
        {
            if (formTableMusicialInstrument != null)
                formTableMusicialInstrument.Close();
            formTableMusicialInstrument = new FormTableMusicialInstrument(managerDB);
            formTableMusicialInstrument.Show();
        }
        private void buttonViewTableEnsemble_Click(object sender, EventArgs e)
        {
            if (formTableEnsemble != null)
                formTableEnsemble.Close();
            formTableEnsemble = new FormTableEnsemble(managerDB);
            formTableEnsemble.Show();
        }
        private void buttonTypeEnseble_Click(object sender, EventArgs e)
        {
            if (formTableTypeEnseble != null)
                formTableTypeEnseble.Close();
            formTableTypeEnseble = new FormTableTypeEnseble(managerDB);
            formTableTypeEnseble.Show();
        }
        private void buttonViewTablePerformance_Click(object sender, EventArgs e)
        {
            if (formTablePerformance != null)
                formTablePerformance.Close();
            formTablePerformance = new FormTablePerformance();
            formTablePerformance.Show();
        }
        private void buttonViewTableComposition_Click(object sender, EventArgs e)
        {
            if (formTableComposition != null)
                formTableComposition.Close();
            formTableComposition = new FormTableComposition();
            formTableComposition.Show();
        }
        private void buttonViewTableRecord_Click(object sender, EventArgs e)
        {
            if (formTableRecord != null)
                formTableRecord.Close();
            formTableRecord = new FormTableRecord();
            formTableRecord.Show();
        }
        private void buttonViewTableRelationRecordAndPerformance_Click(object sender, EventArgs e)
        {
            if (formTableRelationRecordAndPerformance != null)
                formTableRelationRecordAndPerformance.Close();
            formTableRelationRecordAndPerformance = new FormTableRelationRecordAndPerformance();
            formTableRelationRecordAndPerformance.Show();
        }
        private void buttonViewTableLogging_Click(object sender, EventArgs e)
        {
            if (formTableLogging != null)
                formTableLogging.Close();
            formTableLogging = new FormTableLogging();
            formTableLogging.Show();
        }
        private void buttonViewTableTypeOfAction_Click(object sender, EventArgs e)
        {
            if (formTableTypeOfOperation != null)
                formTableTypeOfOperation.Close();
            formTableTypeOfOperation = new FormTableTypeOfOperation();
            formTableTypeOfOperation.Show();
        }
    }
}
