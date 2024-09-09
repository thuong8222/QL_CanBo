using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_diemB_QLCanBo
{
    public partial class Form6_HoSoCB : Form
    {
        public string macb;
        public Form6_HoSoCB(string maCB)
        {
            InitializeComponent();
            macb = maCB;
        }

              public static string ConnectionString = "Data Source=LAPTOP-Q5R2N5N2\\SQLL;Initial Catalog=qlycanBo;Integrated Security=True";
        private void Form6_HoSoCB_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM CANBO where MaCB='"+ macb + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    label7.Text = ds.Tables[0].Rows[0]["HoTen"].ToString();
                    label8.Text = ds.Tables[0].Rows[0]["NgaySinh"].ToString();
                    label9.Text = ds.Tables[0].Rows[0]["GioiTinh"].ToString();
                    label10.Text = ds.Tables[0].Rows[0]["DiaChi"].ToString();
                    label11.Text = ds.Tables[0].Rows[0]["SDT"].ToString();
                }
                else
                {
                    label1.Text  = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Bitmap memoryImage;
        private void button1_Click(object sender, EventArgs e)
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

        private void btnPre_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
