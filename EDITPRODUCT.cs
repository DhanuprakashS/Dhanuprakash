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
    public partial class EDITPRODUCT : Form
    {
        public EDITPRODUCT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }
        private void EDITPRODUCT_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        public void clear()
        {

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.Editproduct(int.Parse(comboBox1.Text), textBox1.Text, textBox2.Text);
            MessageBox.Show(x + "product updated successfully");
            clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox1.Text = s["pname"].ToString();
                textBox2.Text = s["pdesc"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex.ToString());
            }
        }
    }
}

