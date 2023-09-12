using MCare.ShareTKQC.Common;
using System;
using System.Windows.Forms;

namespace MCare.ShareTKQC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is ContextMenuStrip contextMenuStrip1)
            {
                if (contextMenuStrip1.SourceControl is DataGridView dataGridView)
                {
                    EventHandlers evenHandler = new EventHandlers(dtgvViaShare, dtgvViaReceive, dtgvAdAccounts);
                    if (dataGridView == dtgvAdAccounts)
                    {
                        if (contextMenuStrip1.Items.Count == 3)
                        {
                            contextMenuStrip1.Items.RemoveAt(2);
                        }
                        contextMenuStrip1.Items.Add("Load Ads Account");
                        contextMenuStrip1.Items[2].Click += evenHandler.LoadAdsAccount_Click;
                    }else if (dataGridView == dtgvViaShare)
                    {
                        if (contextMenuStrip1.Items.Count == 3)
                        {
                            contextMenuStrip1.Items.RemoveAt(2);
                        }
                        contextMenuStrip1.Tag = dtgvViaShare;
                        contextMenuStrip1.Items.Add("Import Via");
                        contextMenuStrip1.Items[2].Click += evenHandler.ImportAccount_Click;
                        bôiĐenToolStripMenuItem.Click += evenHandler.BôiĐenToolStripMenuItem1_Click;
                        tấtCảToolStripMenuItem.Click += evenHandler.TấtCảToolStripMenuItem_Click;
                        bôiĐenToolStripMenuItem1.Click += evenHandler.BôiĐenToolStripMenuItem1_Click1;
                        tấtCảToolStripMenuItem1.Click += evenHandler.TấtCảToolStripMenuItem1_Click;
                    }
                    else if (dataGridView == dtgvViaReceive)
                    {
                        if (contextMenuStrip1.Items.Count == 3)
                        {
                            contextMenuStrip1.Items.RemoveAt(2);
                        }
                        contextMenuStrip1.Items.Add("Import Via");
                        contextMenuStrip1.Tag = dtgvViaReceive;
                        contextMenuStrip1.Items[2].Click += evenHandler.ImportAccount2_Click;
                        bôiĐenToolStripMenuItem.Click += evenHandler.BôiĐenToolStripMenuItem2_Click;
                        tấtCảToolStripMenuItem.Click += evenHandler.TấtCảToolStripMenuItem_Click1;
                        bôiĐenToolStripMenuItem1.Click += evenHandler.BôiĐenToolStripMenuItem1_Click2;
                        tấtCảToolStripMenuItem1.Click += evenHandler.TấtCảToolStripMenuItem1_Click1;
                    }
                }
            }
        }
    }
}
