using MCare.ShareTKQC.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MCare.ShareTKQC.Common
{
    public static class Common
    {
        public static void OnChoseDatagridview(DataGridView dgv, string modeChose)
        {
            switch (modeChose)
            {
                case "ToggleCheck":
                    {
                        for (int k = 0; k < dgv.SelectedRows.Count; k++)
                        {
                            int index = dgv.SelectedRows[k].Index;
                            SetCellAccount(dgv, index, 0, !Convert.ToBoolean(GetCellAccount(dgv, index, 0)));
                        }
                        break;
                    }
                case "SelectHighline":
                    {
                        DataGridViewSelectedRowCollection selectedRows = dgv.SelectedRows;
                        for (int j = 0; j < selectedRows.Count; j++)
                        {
                            SetCellAccount(dgv, selectedRows[j].Index, 0, true);
                        }

                        break;
                    }
                case "UnAll":
                    {
                        for (int l = 0; l < dgv.RowCount; l++)
                        {
                            SetCellAccount(dgv, l, 0, false);
                        }
                        break;
                    }
                case "All":
                    {
                        for (int i = 0; i < dgv.RowCount; i++)
                        {
                            SetCellAccount(dgv, i, 0, true);
                        }
                        break;
                    }
                case "UnSelectHighline":
                    {
                        DataGridViewSelectedRowCollection selectedRows = dgv.SelectedRows;
                        for (int j = 0; j < selectedRows.Count; j++)
                        {
                            SetCellAccount(dgv, selectedRows[j].Index, 0, false);
                        }

                        break;
                    }
            }
        }

        public static void SetCellAccount(DataGridView dgv, int indexRow, string column, object value, bool isAllowEmptyValue = true)
        {
            if (isAllowEmptyValue || !(value.ToString().Trim() == ""))
            {
                DatagridviewHelper.SetStatusDataGridView(dgv, indexRow, column, value);
            }
        }

        public static void SetCellAccount(DataGridView dgv, int indexRow, int column, object value, bool isAllowEmptyValue = true)
        {
            if (isAllowEmptyValue || !(value.ToString().Trim() == ""))
            {
                DatagridviewHelper.SetStatusDataGridView(dgv, indexRow, column, value);
            }
        }

        public static string GetCellAccount(DataGridView dgv, int indexRow, string column)
        {
            return DatagridviewHelper.GetStatusDataGridView(dgv, indexRow, column);
        }

        public static string GetCellAccount(DataGridView dgv, int indexRow, int column)
        {
            return DatagridviewHelper.GetStatusDataGridView(dgv, indexRow, column);
        }

        public static void ImportAccountCommon(DataGridView dgv, string clipboard)
        {
            dgv.Rows.Clear();
            int add = 0;
            var accounts = clipboard.Split('\n');
            foreach ( var account in accounts )
            {
                add = dgv.Rows.Add();
                DataGridViewRow row = dgv.Rows[add];

                var accountSplit = account.Split('|');
                row.Cells[1].Value = (add + 1).ToString();
                row.Cells[2].Value = accountSplit[0];
                row.Cells[3].Value = accountSplit[1];
                row.Cells[4].Value = accountSplit[2];
            }
            MessageBox.Show(string.Format("Import thành công {0}/{1}", add, accounts.Count()), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
