using System.Windows.Forms;
using System;

namespace MCare.ShareTKQC.Common
{
    public class EventHandlers
    {
        private DataGridView dtgvViaShare { get; set; }
        private DataGridView dtgvViaReceive { get; set; }
        private DataGridView dtgvAdAccounts { get; set; }

        public EventHandlers(DataGridView dtgvViaShare, DataGridView dtgvViaReceive, DataGridView dtgvAdAccounts)
        {
            this.dtgvViaShare = dtgvViaShare;
            this.dtgvViaReceive = dtgvViaReceive;
            this.dtgvAdAccounts = dtgvAdAccounts;
        }
        public void TấtCảToolStripMenuItem1_Click1(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaReceive, "UnAll");
        }

        public void TấtCảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaShare, "UnAll");
        }

        public void BôiĐenToolStripMenuItem1_Click2(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaReceive, "UnSelectHighline");
        }

        public void BôiĐenToolStripMenuItem1_Click1(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaShare, "UnSelectHighline");
        }

        public void TấtCảToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaReceive, "All");
        }

        public void TấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaShare, "All");
        }

        public void BôiĐenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaShare, "SelectHighline");
        }

        public void BôiĐenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Common.OnChoseDatagridview(dtgvViaReceive, "SelectHighline");
        }

        public void ImportAccount_Click(object sender, EventArgs e)
        {
            var clipboard = Clipboard.GetText();
            Common.ImportAccountCommon(dtgvViaShare, clipboard);
        }

        public void ImportAccount2_Click(object sender, EventArgs e)
        {
            var clipboard = Clipboard.GetText();
            Common.ImportAccountCommon(dtgvViaReceive, clipboard);
        }

        public void LoadAdsAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abc");
        }
    }
}
