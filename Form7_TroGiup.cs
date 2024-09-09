using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_diemB_QLCanBo
{
    public partial class Form7_TroGiup : Form
    {
        public Form7_TroGiup()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
