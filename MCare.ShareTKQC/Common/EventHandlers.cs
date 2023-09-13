using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using MCare.ShareTKQC.Dtos;
using MCare.ShareTKQC.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Threading.Tasks;

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
            Task.Run(async() =>
            {
                int i = 0;
                while (i < dtgvViaShare.Rows.Count)
                {
                    DataGridViewRow row = dtgvViaShare.Rows[i];
                    if (Convert.ToBoolean(row.Cells["cChoseShare"].Value) == true)
                    {
                        Common.SetStatusAccount(dtgvViaShare, row.Index, "cStatusShare", "Bắt đầu");

                        FacebookDto fbDto = new FacebookDto
                        {
                            Uid = row.Cells[2].Value.ToString(),
                            Password = row.Cells[3].Value.ToString(),
                            Key2Fa = row.Cells[4].Value.ToString(),
                        };

                        RequestHelpers helper = new RequestHelpers(fbDto);
                        var cookie = await helper.LoginFacebook();

                        if (cookie.Contains("c_user"))
                        {
                            Common.SetStatusAccount(dtgvViaShare, row.Index, "cStatusShare", "Account Live");
                            fbDto.Cookie = cookie;
                            row.Cells["cCookieShare"].Value = cookie;
                            var token = await helper.GetTokenEAAb();
                            if (!string.IsNullOrEmpty(token))
                            {
                                Common.SetStatusAccount(dtgvViaShare, row.Index, "cStatusShare", "Get Token Ok");
                                fbDto.Token = token;
                                row.Cells["cTokenShare"].Value = token;

                                var jArray = await helper.LoadAdAccounts(token);
                                int num = 0;
                                foreach (var item in (dynamic)jArray)
                                {
                                    Common.SetCellAccount(dtgvAdAccounts, row.Index, 0, false);
                                    Common.SetCellAccount(dtgvAdAccounts, row.Index, 1, (num + 1).ToString());
                                    Common.SetCellAccount(dtgvAdAccounts, row.Index, 2, item["id"].ToString().Replace("act_", ""));
                                    Common.SetCellAccount(dtgvAdAccounts, row.Index, 3, item["name"]);
                                    Common.SetCellAccount(dtgvAdAccounts, row.Index, 4, item["currency"]);
                                    Common.SetCellAccount(dtgvAdAccounts, row.Index, 5, item["timezone_name"]);

                                    if (item["account_status"].ToString() == "1")
                                    {
                                        DatagridviewHelper.SetColorDataGridView(row, 0);
                                        Common.SetCellAccount(dtgvAdAccounts, row.Index, 6, "Live");
                                    }
                                    else if (item["account_status"].ToString() == "2")
                                    {
                                        DatagridviewHelper.SetColorDataGridView(row, 1);
                                        Common.SetCellAccount(dtgvAdAccounts, row.Index, 6, "Die");
                                    }
                                    else if (item["account_status"].ToString() == "3")
                                    {
                                        Common.SetCellAccount(dtgvAdAccounts, row.Index, 6, "Nợ");
                                    }
                                }
                            }
                            else
                            {
                                Common.SetStatusAccount(dtgvViaShare, row.Index, "cStatusShare", "Get token thất bại");
                            }
                        }
                        else
                        {
                            Common.SetStatusAccount(dtgvViaShare, row.Index, "cStatusShare", "Account Die");
                        }
                    }
                    i++;
                }
            });
        }
    }
}
