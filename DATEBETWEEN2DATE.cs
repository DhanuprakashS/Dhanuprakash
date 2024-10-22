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
    public partial class DATEBETWEEN2DATE : Form
    {
        public DATEBETWEEN2DATE()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DBCon db = new DBCon();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=db.datebetween2dates(DateTime.Parse(dateTimePicker1.Text),DateTime.Parse(dateTimePicker2.Text));
            dataGridView1.DataSource = dt;
        }
    }
}
