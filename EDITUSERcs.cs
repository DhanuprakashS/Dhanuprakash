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
    public partial class EDITUSERcs : Form
    {
        public EDITUSERcs()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt=db.Viewuser();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";
        }
        private void EDITUSERcs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox2.Text=s["pwd"].ToString();
                textBox1.Text =s["utype"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error..." + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.EDITuser(comboBox1.Text, textBox1.Text, textBox2.Text);
            MessageBox.Show(x + "user edited successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
