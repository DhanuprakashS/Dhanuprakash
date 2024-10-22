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
    public partial class USERVIEWMODELcs : Form
    {
        public USERVIEWMODELcs()
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



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)

        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox1.Text = s["pid"].ToString();
                textBox2.Text = s["spec"].ToString();
                textBox4.Text = s["pname"].ToString();
                textBox5.Text = s["mname"].ToString();
                textBox6.Text = s["uprice"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.ToString());

            }
           
            
               
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.Text = (int.Parse(textBox3.Text) * int.Parse(textBox6.Text)).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int x = db.InsertUSERVIEWMODEL(int.Parse(textBox1.Text), textBox4.Text, int.Parse(comboBox1.Text), textBox5.Text, textBox2.Text, int.Parse(textBox6.Text), int.Parse(textBox3.Text), int.Parse(textBox7.Text));
            MessageBox.Show(x + "product purchased sucessfully");
        }

        private void USERVIEWMODELcs_Load(object sender, EventArgs e)
        {
            

        }

        private void USERVIEWMODELcs_Load_1(object sender, EventArgs e)
        {
            
        }

        private void USERVIEWMODELcs_Load_2(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}