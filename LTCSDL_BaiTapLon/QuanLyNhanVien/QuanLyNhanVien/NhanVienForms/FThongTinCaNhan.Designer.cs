namespace QuanLyNhanVien.NhanVienForms
{
    partial class FThongTinCaNhan
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
            this.panelStoreLbl = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.panelStoreBtn = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBoxCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.txtBoxHo = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtBoxMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtBoxDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtBoxTen = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.panelStoreLbl.SuspendLayout();
            this.panelStoreBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStoreLbl
            // 
            this.panelStoreLbl.Controls.Add(this.closeBtn);
            this.panelStoreLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStoreLbl.Location = new System.Drawing.Point(0, 0);
            this.panelStoreLbl.Name = "panelStoreLbl";
            this.panelStoreLbl.Size = new System.Drawing.Size(800, 66);
            this.panelStoreLbl.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.Snow;
            this.closeBtn.Location = new System.Drawing.Point(750, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(50, 50);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lblMain
            // 
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(12, 69);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(304, 33);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Thông tin nhân viên:";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStoreBtn
            // 
            this.panelStoreBtn.Controls.Add(this.btnConfirm);
            this.panelStoreBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStoreBtn.Location = new System.Drawing.Point(0, 385);
            this.panelStoreBtn.Name = "panelStoreBtn";
            this.panelStoreBtn.Size = new System.Drawing.Size(800, 65);
            this.panelStoreBtn.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(154)))), ((int)(((byte)(52)))));
            this.btnConfirm.BackgroundImage = global::QuanLyNhanVien.Properties.Resources.GreenGradient1;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirm.Location = new System.Drawing.Point(318, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(165, 50);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtBoxCMND
            // 
            this.txtBoxCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCMND.Location = new System.Drawing.Point(559, 117);
            this.txtBoxCMND.Name = "txtBoxCMND";
            this.txtBoxCMND.Size = new System.Drawing.Size(187, 28);
            this.txtBoxCMND.TabIndex = 6;
            this.txtBoxCMND.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCMND
            // 
            this.lblCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(406, 120);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(147, 23);
            this.lblCMND.TabIndex = 14;
            this.lblCMND.Text = "CMND:";
            // 
            // lblNS
            // 
            this.lblNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNS.Location = new System.Drawing.Point(27, 289);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(140, 23);
            this.lblNS.TabIndex = 12;
            this.lblNS.Text = "Ngày sinh:";
            // 
            // txtBoxHo
            // 
            this.txtBoxHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHo.Location = new System.Drawing.Point(173, 174);
            this.txtBoxHo.Name = "txtBoxHo";
            this.txtBoxHo.Size = new System.Drawing.Size(187, 28);
            this.txtBoxHo.TabIndex = 2;
            // 
            // lblHo
            // 
            this.lblHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHo.Location = new System.Drawing.Point(27, 177);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(140, 23);
            this.lblHo.TabIndex = 10;
            this.lblHo.Text = "Họ:";
            // 
            // txtBoxMaNV
            // 
            this.txtBoxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMaNV.Location = new System.Drawing.Point(173, 117);
            this.txtBoxMaNV.Name = "txtBoxMaNV";
            this.txtBoxMaNV.Size = new System.Drawing.Size(187, 28);
            this.txtBoxMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(27, 120);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(140, 23);
            this.lblMaNV.TabIndex = 8;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // txtBoxDiaChi
            // 
            this.txtBoxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDiaChi.Location = new System.Drawing.Point(173, 336);
            this.txtBoxDiaChi.Name = "txtBoxDiaChi";
            this.txtBoxDiaChi.Size = new System.Drawing.Size(573, 28);
            this.txtBoxDiaChi.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(27, 339);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(140, 23);
            this.lblDiaChi.TabIndex = 16;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSDT.Location = new System.Drawing.Point(559, 174);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(187, 28);
            this.txtBoxSDT.TabIndex = 7;
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(406, 177);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(147, 23);
            this.lblSDT.TabIndex = 18;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(406, 233);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(147, 23);
            this.lblChucVu.TabIndex = 20;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(27, 235);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(140, 23);
            this.lblTen.TabIndex = 24;
            this.lblTen.Text = "Tên:";
            // 
            // txtBoxTen
            // 
            this.txtBoxTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTen.Location = new System.Drawing.Point(173, 232);
            this.txtBoxTen.Name = "txtBoxTen";
            this.txtBoxTen.Size = new System.Drawing.Size(187, 28);
            this.txtBoxTen.TabIndex = 3;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(173, 289);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(202, 24);
            this.dtp.TabIndex = 4;
            // 
            // cbChucVu
            // 
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(559, 228);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(187, 30);
            this.cbChucVu.TabIndex = 8;
            // 
            // FThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtBoxTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.txtBoxSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtBoxDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtBoxCMND);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblNS);
            this.Controls.Add(this.txtBoxHo);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.txtBoxMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.panelStoreBtn);
            this.Controls.Add(this.panelStoreLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThongTinCaNhan";
            this.Text = "FThongTinCaNhan";
            this.Activated += new System.EventHandler(this.FThongTinCaNhan_Activated);
            this.Load += new System.EventHandler(this.FThongTinCaNhan_Load);
            this.panelStoreLbl.ResumeLayout(false);
            this.panelStoreBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStoreLbl;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel panelStoreBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtBoxCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.TextBox txtBoxHo;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtBoxMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtBoxDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtBoxTen;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cbChucVu;
    }
}