using MCare.ShareTKQC.Helpers;
using System;
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
                            SetCellAccount(dgv, index, "cChose", !Convert.ToBoolean(GetCellAccount(dgv, index, "cChose")));
                        }
                        break;
                    }
                case "SelectHighline":
                    {
                        DataGridViewSelectedRowCollection selectedRows = dgv.SelectedRows;
                        for (int j = 0; j < selectedRows.Count; j++)
                        {
                            SetCellAccount(dgv, selectedRows[j].Index, "cChose", true);
                        }

                        break;
                    }
                case "UnAll":
                    {
                        for (int l = 0; l < dgv.RowCount; l++)
                        {
                            SetCellAccount(dgv, l, "cChose", false);
                        }
                        break;
                    }
                case "All":
                    {
                        for (int i = 0; i < dgv.RowCount; i++)
                        {
                            SetCellAccount(dgv, i, "cChose", true);
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

        public static string GetCellAccount(DataGridView dgv, int indexRow, string column)
        {
            return DatagridviewHelper.GetStatusDataGridView(dgv, indexRow, column);
        }
    }
}
