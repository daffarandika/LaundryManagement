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
    public partial class CourierSelection : Form
    {
        public CourierSelection()
        {
            InitializeComponent();
        }

        private void CourierSelection_Load(object sender, EventArgs e)
        {
            comboBox1.Fill("select * from petugasAntar", "nama", "id");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Vars.petugasAntarID = comboBox1.SelectedValue.ToString();
        }
    }
}
