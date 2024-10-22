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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.CHKLOGIN(textBox1.Text, textBox2.Text, comboBox1.Text);
            if(x>=1)
            {
                if (comboBox1.Text=="ADMIN")
                {
                    AdminMDI a = new AdminMDI();
                    a.Show();
                }
                else
                {
                    UserMDI u = new UserMDI();
                    u.Show();
                }
            }
            else
            {
                MessageBox.Show("invalid user id / pwd");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}
