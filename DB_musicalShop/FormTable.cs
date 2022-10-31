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
    public partial class FormTable : Form
    {
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
        public FormTable()
        {
            InitializeComponent();
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
            formTableMusicialInstrument = new FormTableMusicialInstrument();
            formTableMusicialInstrument.Show();
        }
        private void buttonViewTableEnsemble_Click(object sender, EventArgs e)
        {
            if (formTableEnsemble != null)
                formTableEnsemble.Close();
            formTableEnsemble = new FormTableEnsemble();
            formTableEnsemble.Show();
        }
        private void buttonTypeEnseble_Click(object sender, EventArgs e)
        {
            if (formTableTypeEnseble != null)
                formTableTypeEnseble.Close();
            formTableTypeEnseble = new FormTableTypeEnseble();
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
