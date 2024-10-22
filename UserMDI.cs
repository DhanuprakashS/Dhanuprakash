using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPROJ
{
    public partial class UserMDI : Form
    {
        public UserMDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vIEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERVIEWPRODUCT vc = new USERVIEWPRODUCT();
            vc.Show();
        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERVIEWMODELcs vm = new USERVIEWMODELcs();
            vm.Show();
        }
    }
}
