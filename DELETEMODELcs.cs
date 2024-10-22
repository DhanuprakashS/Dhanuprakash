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
    public partial class DELETEMODELcs : Form
    {
        public DELETEMODELcs()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = db.Viewmodel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
            
        }
        private void DELETEMODELcs_Load(object sender, EventArgs e)
        {
            LoadData();
        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.DeleteMODEL(int.Parse(comboBox1.Text));
            MessageBox.Show(x + " model deleted sucessfully");
            LoadData();
        }
    }
}
