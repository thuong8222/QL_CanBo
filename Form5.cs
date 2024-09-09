using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_diemB_QLCanBo
{
    public partial class Form5_InDsv : Form
    {
        public Form5_InDsv()
        {
            InitializeComponent();
        }

        private void Form5_InDsv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlycanBoDataSet.CANBO' table. You can move, or remove it, as needed.
            this.cANBOTableAdapter.Fill(this.qlycanBoDataSet.CANBO);
            // TODO: This line of code loads data into the 'qlycanBoDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qlycanBoDataSet.KHOA);

        }
        public static string ConnectionString = "Data Source=LAPTOP-Q5R2N5N2\\SQLL;Initial Catalog=qlycanBo;Integrated Security=True";

        private void LỌC_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Open();
                }
                string key = comboBox1.SelectedValue.ToString();
                string query = "SELECT * FROM CANBO WHERE Khoa_ID = '" + key + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cANBODataGridView.DataSource = ds.Tables[0];

                }
                else
                {
                    cANBODataGridView.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Bitmap memoryImage;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialog1.ShowDialog();
        }
    }
}
