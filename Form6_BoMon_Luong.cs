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
    public partial class Form6_BoMon_Luong : Form
    {
        public Form6_BoMon_Luong()
        {
            InitializeComponent();
        }

        private void cANBOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cANBOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlycanBoDataSet);

        }

        private void Form6_BoMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlycanBoDataSet.BOMON' table. You can move, or remove it, as needed.
            this.bOMONTableAdapter.Fill(this.qlycanBoDataSet.BOMON);
            // TODO: This line of code loads data into the 'qlycanBoDataSet.CANBO' table. You can move, or remove it, as needed.
            this.cANBOTableAdapter.Fill(this.qlycanBoDataSet.CANBO);

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
                string query = "SELECT * FROM CANBO WHERE BoMon_ID = '" + key + "'";
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        Bitmap memoryImage;
        private void btnIn_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialog1.ShowDialog();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            Form6_LuongCB form6_LuongCB = new Form6_LuongCB();
            form6_LuongCB.Show();
            this.Hide();
        }
    }
}
