using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taqueria_Sistema.Formularios;
namespace Taqueria_Sistema
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            frmDashboard frm = new frmDashboard();
            frm.Show();
            this.Hide();
        }
    }
}
