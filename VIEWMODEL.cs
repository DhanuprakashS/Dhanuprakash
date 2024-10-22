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
    public partial class VIEWMODEL : Form
    {
        public VIEWMODEL()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Viewmodel();
            dataGridView1.DataSource = dt;

        }

        private void VIEWMODEL_Load(object sender, EventArgs e)
        {
            
            
                DataTable dt = new DataTable();
                dt = db.Viewmodel();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "mid";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewmodelBYMID(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;

        }
    }
}
