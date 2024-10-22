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
    public partial class DAILYSALESREPORTcs : Form
    {
        public DAILYSALESREPORTcs()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        private void DAILYSALESREPORTcs_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.dailysalesreport();
            dataGridView1.DataSource = dt;
        }
    }
}
