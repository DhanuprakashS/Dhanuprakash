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
    public partial class DELETEUSER : Form
    {
        public DELETEUSER()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = db.Viewuser();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.DELETEUSER(comboBox1.Text);
            MessageBox.Show(x + "deleted successfully");
            LoadData();
        }

        private void DELETEUSER_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
