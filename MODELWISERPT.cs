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
    public partial class MODELWISERPT : Form
    {
        public MODELWISERPT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.modelwisereport(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void MODELWISERPT_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.mLoadsales();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
