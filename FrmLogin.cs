using prjCustomSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCustomSystem
{
    public partial class FrmLogin : Form
    {
        bool isClosed = true;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cstaff c = (new CstaffManager()).queryByEmail(txtEmail.Text);
            if (c != null)
            {
                if (c.password == txtPassword.Text)
                {
                    isClosed = false;
                    Close();
                    return;
                }
            }
            MessageBox.Show("帳號與密碼不符");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
