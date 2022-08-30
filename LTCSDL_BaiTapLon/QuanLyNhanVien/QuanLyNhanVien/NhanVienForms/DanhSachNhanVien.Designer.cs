namespace QuanLyNhanVien.NhanVienForms
{
    partial class DanhSachNhanVien
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
            this.txtBTimKiem = new System.Windows.Forms.TextBox();
            this.dGVDSNV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBTimKiem
            // 
            this.txtBTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTimKiem.Location = new System.Drawing.Point(481, 44);
            this.txtBTimKiem.Name = "txtBTimKiem";
            this.txtBTimKiem.ReadOnly = true;
            this.txtBTimKiem.Size = new System.Drawing.Size(198, 24);
            this.txtBTimKiem.TabIndex = 4;
            this.txtBTimKiem.TextChanged += new System.EventHandler(this.txtBTimKiem_TextChanged);
            // 
            // dGVDSNV
            // 
            this.dGVDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVDSNV.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dGVDSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDSNV.Location = new System.Drawing.Point(0, 86);
            this.dGVDSNV.Name = "dGVDSNV";
            this.dGVDSNV.RowHeadersWidth = 51;
            this.dGVDSNV.RowTemplate.Height = 24;
            this.dGVDSNV.Size = new System.Drawing.Size(691, 324);
            this.dGVDSNV.TabIndex = 1;
            this.dGVDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.Items.AddRange(new object[] {
            "Theo mã NV",
            "Theo họ tên",
            "Theo chức vụ"});
            this.cbTimKiem.Location = new System.Drawing.Point(543, 12);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(136, 26);
            this.cbTimKiem.TabIndex = 3;
            this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
            this.cbTimKiem.SelectedValueChanged += new System.EventHandler(this.cbTimKiem_SelectedValueChanged);
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(691, 410);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVDSNV);
            this.Controls.Add(this.txtBTimKiem);
            this.Name = "DanhSachNhanVien";
            this.Text = "DanhSachNhanVien";
            this.Load += new System.EventHandler(this.DanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBTimKiem;
        private System.Windows.Forms.DataGridView dGVDSNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimKiem;
    }
}