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
    public partial class AdminMDI : Form
    {
        public AdminMDI()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDPRODUCT A = new ADDPRODUCT();
            A.Show();
           
        }

        private void eDITPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITPRODUCT B = new EDITPRODUCT();
            B.Show();
        }

        private void dELETEPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEPRODUCT C = new DELETEPRODUCT();
            C.Show();
        }

        private void vIEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWPRODUCT d = new VIEWPRODUCT();
            d.Show();
        }

        private void aDDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDMODEL AA = new ADDMODEL();
            AA.Show();

        }

        private void eDITMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITMODELcs BB = new EDITMODELcs();
            BB.Show();
        }

        private void dELETEMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEMODELcs CC = new DELETEMODELcs();
            CC.Show();
        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWMODEL DD = new VIEWMODEL();
            DD.Show();
        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDUSER EE = new ADDUSER();
            EE.Show();
        }

        private void eDITUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITUSERcs FF = new EDITUSERcs();
            FF.Show();
        }

        private void dELETEUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEUSER GG = new DELETEUSER();
            GG.Show();

        }

        private void vIEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWUSER HH = new VIEWUSER();
            HH.Show();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAILYSALESREPORTcs II = new DAILYSALESREPORTcs();
            II.Show();
        }

        private void dateBetween2DatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DATEBETWEEN2DATE JJ = new DATEBETWEEN2DATE();
            JJ.Show();
        }

        private void productWiseSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODUCTWISERPT KK = new PRODUCTWISERPT();
            KK.Show();
        }

        private void modelWiseRPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODELWISERPT LL = new MODELWISERPT();
            LL.Show();
        }

        private void AdminMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
