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
    public partial class Form6_LuongCB : Form
    {
        public Form6_LuongCB()
        {
            InitializeComponent();
        }

        private void cANBOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cANBOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlycanBoDataSet);

        }

        private void Form6_LuongCB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlycanBoDataSet.CANBO' table. You can move, or remove it, as needed.
            this.cANBOTableAdapter.Fill(this.qlycanBoDataSet.CANBO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }

        
        Bitmap memoryImage;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);

        }

        private void bộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6_BoMon_Luong form6_BoMon  = new Form6_BoMon_Luong();
            form6_BoMon.Show();
            this.Hide();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5_Khoa_Luong form5_Khoa_Luong = new Form5_Khoa_Luong();
            form5_Khoa_Luong.Show();
            this.Hide();
        }
    }
}
