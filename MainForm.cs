using Laundry_Management.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management
{
    public partial class MainForm : Form
    {
        DataTable dtOrder = Helper.MakeDataTable(new string[] { "Kode Jenis Layanan", "Jenis Layanan", "Jumlah Unit", "Biaya", "Total Biaya" });
        bool newCustomer = false;
        bool newLayanan = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtOrder.Rows.Add();
            dgvOrder.DataSource = dtOrder;
            dgvOrder.RowHeadersVisible = false;
            tbPhone.Focus();
        }

        private void dgvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtOrder.Rows.Add();
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Apakah anda yakin akan menghapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtOrder.Rows.Remove(dtOrder.Rows[dgvOrder.CurrentRow.Index]);
                } 
            }
        }

        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvOrder.CurrentRow.Cells[0].Value as string;
            string query = "select * from layanan where id = '" + id + "'";
            if (Helper.CheckRow(query))
            {
                DataTable dtLayanan = Helper.GetDataTable("select * from layanan where id = '" + id + "'");
                DataRow rowLayanan = dtLayanan.Rows[0];
                DataRow rowOrder = dtOrder.Rows[dgvOrder.CurrentRow.Index];
                if (e.ColumnIndex == 0) // layanan id
                {
                    rowOrder["Biaya"] = rowLayanan["biaya"];
                    rowOrder["Jenis Layanan"] = rowLayanan["jenis"];
                    rowOrder["Jumlah Unit"] = 1;
                    rowOrder["Total Biaya"] = Convert.ToInt32(dtOrder.Rows[dgvOrder.CurrentRow.Index]["Jumlah Unit"]) * Convert.ToInt32(rowLayanan["biaya"]);
                }
                if (e.ColumnIndex == 2) // qty
                {
                    dtOrder.Rows[dgvOrder.CurrentRow.Index]["Total Biaya"] = Convert.ToInt32(dtOrder.Rows[dgvOrder.CurrentRow.Index]["Jumlah Unit"]) * Convert.ToInt32(rowLayanan["biaya"]);
                }
            } else
            {
                newLayanan = true;
            }
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            string phone = tbPhone.Text;
            string query = "select * from pelanggan where phone = '" + phone + "'";
            if (Helper.CheckRow(query))
            {
                DataTable dtPelanggan = Helper.GetDataTable(query);
                DataRow row = dtPelanggan.Rows[0];
                tbName.Text = row["nama"] as string;
                tbAlamat.Text = row["alamat"] as string;
            } else
            {
                newCustomer= true;
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            double days = ((Math.Ceiling((dtpTo.Value - dtpFrom.Value).TotalDays)));
            if (days < 0)
            {
                Helper.ShowErrorMessage("Tanggal yang dimasukan tidak valid");
                return;
            }
            tbDays.Text = days.ToString();
        }

        private void tbDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
