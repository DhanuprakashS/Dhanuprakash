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
    public partial class DELETEPRODUCT : Form
    {
        public DELETEPRODUCT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Pid";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.DeleteProduct(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "deleted successfully");
            LoadData();
        }

        private void DELETEPRODUCT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }   
}
