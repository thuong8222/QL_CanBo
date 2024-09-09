namespace BTL_diemB_QLCanBo
{
    partial class Form6_BoMon_Luong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_BoMon_Luong));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bOMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlycanBoDataSet = new BTL_diemB_QLCanBo.qlycanBoDataSet();
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.LỌC = new System.Windows.Forms.Button();
            this.cANBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cANBOTableAdapter = new BTL_diemB_QLCanBo.qlycanBoDataSetTableAdapters.CANBOTableAdapter();
            this.tableAdapterManager = new BTL_diemB_QLCanBo.qlycanBoDataSetTableAdapters.TableAdapterManager();
            this.bOMONTableAdapter = new BTL_diemB_QLCanBo.qlycanBoDataSetTableAdapters.BOMONTableAdapter();
            this.cANBODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bOMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlycanBoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lọc theo";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bOMONBindingSource;
            this.comboBox1.DisplayMember = "TenBoMon";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "BoMon_ID";
            // 
            // bOMONBindingSource
            // 
            this.bOMONBindingSource.DataMember = "BOMON";
            this.bOMONBindingSource.DataSource = this.qlycanBoDataSet;
            // 
            // qlycanBoDataSet
            // 
            this.qlycanBoDataSet.DataSetName = "qlycanBoDataSet";
            this.qlycanBoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnIn.Location = new System.Drawing.Point(583, 124);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(199, 29);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In danh sách";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(217, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH  LƯƠNG CÁN BỘ THEO BỘ MÔN";
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(21, 24);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(46, 39);
            this.btnPre.TabIndex = 10;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // LỌC
            // 
            this.LỌC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LỌC.Location = new System.Drawing.Point(337, 131);
            this.LỌC.Name = "LỌC";
            this.LỌC.Size = new System.Drawing.Size(75, 23);
            this.LỌC.TabIndex = 13;
            this.LỌC.Text = "Lọc";
            this.LỌC.UseVisualStyleBackColor = false;
            this.LỌC.Click += new System.EventHandler(this.LỌC_Click);
            // 
            // cANBOBindingSource
            // 
            this.cANBOBindingSource.DataMember = "CANBO";
            this.cANBOBindingSource.DataSource = this.qlycanBoDataSet;
            // 
            // cANBOTableAdapter
            // 
            this.cANBOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOMONTableAdapter = this.bOMONTableAdapter;
            this.tableAdapterManager.CANBOTableAdapter = this.cANBOTableAdapter;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BTL_diemB_QLCanBo.qlycanBoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bOMONTableAdapter
            // 
            this.bOMONTableAdapter.ClearBeforeFill = true;
            // 
            // cANBODataGridView
            // 
            this.cANBODataGridView.AutoGenerateColumns = false;
            this.cANBODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cANBODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.cANBODataGridView.DataSource = this.cANBOBindingSource;
            this.cANBODataGridView.Location = new System.Drawing.Point(12, 240);
            this.cANBODataGridView.Name = "cANBODataGridView";
            this.cANBODataGridView.RowHeadersWidth = 51;
            this.cANBODataGridView.RowTemplate.Height = 24;
            this.cANBODataGridView.Size = new System.Drawing.Size(903, 220);
            this.cANBODataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaCB";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaCB";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LuongCB";
            this.dataGridViewTextBoxColumn13.HeaderText = "LuongCB";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SoGioLV";
            this.dataGridViewTextBoxColumn14.HeaderText = "SoGioLV";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PhuCap";
            this.dataGridViewTextBoxColumn15.HeaderText = "PhuCap";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ThucLinh";
            this.dataGridViewTextBoxColumn16.HeaderText = "ThucLinh";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form6_BoMon_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 468);
            this.Controls.Add(this.cANBODataGridView);
            this.Controls.Add(this.LỌC);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Name = "Form6_BoMon_Luong";
            this.Text = "Form6_BoMon";
            this.Load += new System.EventHandler(this.Form6_BoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bOMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlycanBoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button LỌC;
        private qlycanBoDataSet qlycanBoDataSet;
        private System.Windows.Forms.BindingSource cANBOBindingSource;
        private qlycanBoDataSetTableAdapters.CANBOTableAdapter cANBOTableAdapter;
        private qlycanBoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cANBODataGridView;
        private qlycanBoDataSetTableAdapters.BOMONTableAdapter bOMONTableAdapter;
        private System.Windows.Forms.BindingSource bOMONBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}