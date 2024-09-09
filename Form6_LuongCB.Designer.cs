namespace BTL_diemB_QLCanBo
{
    partial class Form6_LuongCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_LuongCB));
            this.label1 = new System.Windows.Forms.Label();
            this.qlycanBoDataSet = new BTL_diemB_QLCanBo.qlycanBoDataSet();
            this.cANBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cANBOTableAdapter = new BTL_diemB_QLCanBo.qlycanBoDataSetTableAdapters.CANBOTableAdapter();
            this.tableAdapterManager = new BTL_diemB_QLCanBo.qlycanBoDataSetTableAdapters.TableAdapterManager();
            this.cANBODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bảngLươngTheoKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bộMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.qlycanBoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBODataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(395, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG LƯƠNG CÁN BỘ";
            // 
            // qlycanBoDataSet
            // 
            this.qlycanBoDataSet.DataSetName = "qlycanBoDataSet";
            this.qlycanBoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.BOMONTableAdapter = null;
            this.tableAdapterManager.CANBOTableAdapter = this.cANBOTableAdapter;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BTL_diemB_QLCanBo.qlycanBoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cANBODataGridView
            // 
            this.cANBODataGridView.AutoGenerateColumns = false;
            this.cANBODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cANBODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.cANBODataGridView.DataSource = this.cANBOBindingSource;
            this.cANBODataGridView.Location = new System.Drawing.Point(38, 148);
            this.cANBODataGridView.Name = "cANBODataGridView";
            this.cANBODataGridView.RowHeadersWidth = 51;
            this.cANBODataGridView.RowTemplate.Height = 24;
            this.cANBODataGridView.Size = new System.Drawing.Size(928, 220);
            this.cANBODataGridView.TabIndex = 2;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "NgaySinh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPrint.Location = new System.Drawing.Point(830, 94);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 33);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngLươngTheoKhoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bảngLươngTheoKhoaToolStripMenuItem
            // 
            this.bảngLươngTheoKhoaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bảngLươngTheoKhoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoaToolStripMenuItem,
            this.bộMônToolStripMenuItem});
            this.bảngLươngTheoKhoaToolStripMenuItem.Name = "bảngLươngTheoKhoaToolStripMenuItem";
            this.bảngLươngTheoKhoaToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.bảngLươngTheoKhoaToolStripMenuItem.Text = "Bảng Lương theo từng Đơn vị";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // bộMônToolStripMenuItem
            // 
            this.bộMônToolStripMenuItem.Name = "bộMônToolStripMenuItem";
            this.bộMônToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bộMônToolStripMenuItem.Text = "Bộ môn";
            this.bộMônToolStripMenuItem.Click += new System.EventHandler(this.bộMônToolStripMenuItem_Click);
            // 
            // Form6_LuongCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 496);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cANBODataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6_LuongCB";
            this.Text = "Form6_LuongCB";
            this.Load += new System.EventHandler(this.Form6_LuongCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlycanBoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBODataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private qlycanBoDataSet qlycanBoDataSet;
        private System.Windows.Forms.BindingSource cANBOBindingSource;
        private qlycanBoDataSetTableAdapters.CANBOTableAdapter cANBOTableAdapter;
        private qlycanBoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cANBODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bảngLươngTheoKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bộMônToolStripMenuItem;
    }
}