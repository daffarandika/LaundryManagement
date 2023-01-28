using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management.utils
{
    internal static class Extenstions
    {
        public static void Fill(this DataGridView dgv, string[] columns)
        {
            DataTable dt = Helper.MakeDataTable(columns);
            dgv.DataSource= dt;
            dgv.RowHeadersVisible= false;
        }
    }
}
