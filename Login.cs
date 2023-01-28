using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string password = Helper.hash(tbPassword.Text);
            if (Helper.CheckRow("select * from employee where nama = '" + nama + "' and password = '" + password + "'"))
            {
                Hide();
                MainForm form1 = new MainForm();  
                form1.ShowDialog();
                Close();
            } else
            {
                MessageBox.Show("no");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
