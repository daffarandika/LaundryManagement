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
        bool fastService = false;
        bool pickUp = false;
        bool deliver = false;
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
            setTotal();
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
            if (Convert.ToInt32(tbDays.Text) < 3)
            {
                fastService = true;
                tbHari.Text = Helper.GetDataTable("select * from biayaTambahan where keterangan = 'cepat'").Rows[0]["biaya"].ToString();
                return;
            }
            tbHari.Text = "0";
            fastService = false;
            setTotal();
        }
        void setTotal()
        {
            int total = 0;
            int fastServiceFee = Convert.ToInt32(Helper.GetDataTable("select * from biayaTambahan where keterangan = 'cepat'").Rows[0]["biaya"]);
            int pickUpFee = Convert.ToInt32(Helper.GetDataTable("select * from biayaTambahan where keterangan = 'dijemput'").Rows[0]["biaya"]);
            int deliverFee = Convert.ToInt32(Helper.GetDataTable("select * from biayaTambahan where keterangan = 'diantar'").Rows[0]["biaya"]);
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells["Total Biaya"].Value.ToString() != "")
                {
                    total += Convert.ToInt32(row.Cells["Total Biaya"].Value.ToString());
                }
            }
            if (fastService)
            {
                total += fastServiceFee;
            }
            if (deliver)
            {
                total += deliverFee;
            }
            if (pickUp)
            {
                total += pickUpFee;
            }
            tbTotal.Text = total.ToString();
        }

        private void cbJemput_CheckedChanged(object sender, EventArgs e)
        {
            int pickUpFee = Convert.ToInt32(Helper.GetDataTable("select * from biayaTambahan where keterangan = 'dijemput'").Rows[0]["biaya"].ToString());
            int deliverFee = Convert.ToInt32(Helper.GetDataTable("select * from biayaTambahan where keterangan = 'diantar'").Rows[0]["biaya"].ToString());
            if (cbJemput.Checked)
            {
                pickUp = true;
                tbJemput.Text = pickUpFee.ToString();
                setTotal();
                return;
            }
            pickUp = false;
            tbJemput.Text = "0";
                setTotal();
        }

        private void cbAntar_CheckedChanged(object sender, EventArgs e)
        {
            int pickUpFee = Convert.ToInt32(Helper.GetDataTable("select * from biayaTambahan where keterangan = 'dijemput'").Rows[0]["biaya"].ToString());
            int deliverFee = Convert.ToInt32(Helper.GetDataTable("select * from biayaTambahan where keterangan = 'diantar'").Rows[0]["biaya"].ToString());
            if (cbAntar.Checked)
            {
                deliver = true;
                setTotal();
                tbAntar.Text = deliverFee.ToString();
                return;
            }
            deliver = false;
            tbAntar.Text = "0";
                setTotal();
        }

        private void dgvOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            setTotal();
        }

        private void button1_Click(object sender, EventArgs e) // btnSave
        {
            CourierSelection courierSelection = new CourierSelection();
            string phone = tbPhone.Text;
            if (courierSelection.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (newCustomer)
            {
                string nama = tbName.Text;
                string alamat = tbAlamat.Text;
                Helper.RunQuery("insert into pelanggan (nama, phone, alamat) values ('" + nama + "', '" + phone + "', '" + alamat + "')");
            }
            if (newLayanan)
            {
                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    string layananID = row.Cells["Kode Jenis Layanan"].Value.ToString();
                    if (!Helper.CheckRow("select * from layanan where id = '" + layananID + "'"))
                    {
                        string jenis = row.Cells["Jenis Layanan"].Value.ToString();
                        string biaya = row.Cells["Biaya"].Value.ToString();
                        Helper.RunQuery("insert into layanan (jenis, biaya) values ('" + jenis + "', '" + biaya + "')");
                    }
                }
            }
            string petugasAntarID = (Vars.petugasAntarID);
            string orderDate = dtpFrom.Value.ToString("yyyy-MM-dd");
            string finishDate = dtpTo.Value.ToString("yyyy-MM-dd");
            string biayaAntar = tbAntar.Text;
            string biayaJemput = tbJemput.Text;
            string biayaHari = tbHari.Text;
            string status = "progress";
            Helper.RunQuery("insert into headorder (phone, orderDate, finishDate, biayaAntar, biayaJemput, biayaHari, petugasAntarID, status) values ('" + phone + "', '" + orderDate + "', '" + finishDate + "', '" + biayaAntar + "', '" + biayaJemput + "', '" + biayaHari + "', '" + petugasAntarID + "', '" + status + "')");
            string headorderID = Helper.GetValueFromQuery("select max(id) as max from headorder", "max");
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                string layananID = row.Cells["Kode Jenis Layanan"].Value.ToString();
                string jumlahUnit = row.Cells["Jumlah Unit"].Value.ToString();
                string total = row.Cells["Total Biaya"].Value.ToString();
                Helper.RunQuery("insert into detailorder (headorderID, layananID, jumlahUnit, total) values ('" + headorderID + "', '" + layananID + "', '" + jumlahUnit + "', '" + total + "')");
            }
            MessageBox.Show("reset here"); // TODO: Make reset
        }
    }
}
