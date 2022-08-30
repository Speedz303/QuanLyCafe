using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyNhanVien.BUS;

namespace QuanLyNhanVien.NhanVienForms
{
    public partial class FThongTinCaNhan : Form
    {
        private BUS_NhanVien bus_NhanVien;
        private BUS_TTChucVu bus_TTChucVu;
        public NhanVienForms.QuanLyNhanVien parentForm;
        public int signal;
        public String MaNV, Ho, Ten, DiaChi, SoDienThoai, TenChucVu, dtpNS;
        public int CMND, MaChucVu;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (signal)
            {
                case 2: // Them
                    if (isTxtBoxNotEmpty())
                    {
                        if (this.txtBoxMaNV.Text.StartsWith("NV"))
                        {
                            if (!bus_NhanVien.isMaNhanVienExist(this.txtBoxMaNV.Text))
                            {
                                QLNhanVien QLNV = new QLNhanVien();
                                QLNV.MaNhanVien = this.txtBoxMaNV.Text;
                                QLNV.Ho = this.txtBoxHo.Text;
                                QLNV.Ten = this.txtBoxTen.Text;
                                QLNV.CMND = int.Parse(this.txtBoxCMND.Text);

                                if (!bus_NhanVien.isNhanVienExist(QLNV))
                                {
                                    //Them NVien
                                    
                                    QLNV.NgaySinh = this.dtp.Value;
                                    QLNV.DiaChi = this.txtBoxDiaChi.Text;
                                    QLNV.SoDienThoai = this.txtBoxSDT.Text;
                                    QLNV.MaChucVu = Convert.ToInt32(cbChucVu.SelectedValue);

                                    if (bus_NhanVien.InsertNhanVien(QLNV))
                                    {
                                        MessageBox.Show("Thêm thành công");
                                        parentForm.refreshDGV();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm thất bại");
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Nhân viên này đã tồn tại.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã nhân viên này đã tồn tại!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã nhân viên phải đúng quy tắc: NV[Số]");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    }     
                    break;

                case 3: // Sua
                    if (isTxtBoxNotEmpty())
                    {
                        QLNhanVien QLNV = new QLNhanVien();
                        QLNV.MaNhanVien = this.txtBoxMaNV.Text;
                        QLNV.Ho = this.txtBoxHo.Text;
                        QLNV.Ten = this.txtBoxTen.Text;
                        QLNV.CMND = int.Parse(this.txtBoxCMND.Text);
                        QLNV.NgaySinh = this.dtp.Value;
                        QLNV.DiaChi = this.txtBoxDiaChi.Text;
                        QLNV.SoDienThoai = this.txtBoxSDT.Text;
                        QLNV.MaChucVu = Convert.ToInt32(cbChucVu.SelectedValue);

                        if (bus_NhanVien.EditNhanVien(QLNV))
                        {
                            MessageBox.Show("Sửa thành công");
                            parentForm.refreshDGV();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    }
                    break;
                case 4: // Xoa
                    if (bus_NhanVien.DeleteNhanVien(this.txtBoxMaNV.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        parentForm.refreshDGV();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    break;
            }
            
        }

        private void FThongTinCaNhan_Activated(object sender, EventArgs e)
        {
            if (signal != 2)
            {
                this.txtBoxMaNV.Text = MaNV;
                this.txtBoxHo.Text = Ho;
                this.txtBoxTen.Text = Ten;
                this.dtp.Text = dtpNS;
                this.txtBoxSDT.Text = SoDienThoai;
                this.cbChucVu.Text = TenChucVu;
                bus_NhanVien.getCMNDByMaNV(this.txtBoxCMND, MaNV);
                bus_NhanVien.getDiaChiByMaNV(this.txtBoxDiaChi, MaNV);
            }
            

            switch (signal)
            {


                case 1: //Xem Chi Tiet
                    disableAllTxtBox();
                    this.btnConfirm.Hide();
                    break;
                case 2: //Them
                    bus_TTChucVu.ListTTChucVu(this.cbChucVu);
                    break;
                case 3: //Sua
                    bus_TTChucVu.ListTTChucVu(this.cbChucVu);
                    this.cbChucVu.Text = TenChucVu;

                    this.txtBoxMaNV.Enabled = false;
                    this.txtBoxCMND.Enabled = false;
                    break;
                    
                case 4: //Xoa
                    disableAllTxtBox();
                    break;

            }
        }

        public FThongTinCaNhan()
        {
            InitializeComponent();
            bus_NhanVien = new BUS_NhanVien();
            bus_TTChucVu = new BUS_TTChucVu();
            this.dtp.Format = DateTimePickerFormat.Custom;
            this.dtp.CustomFormat = "dd/MM/yyyy";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FThongTinCaNhan_Load(object sender, EventArgs e)
        {
            
        }

        private void disableAllTxtBox()
        {
            this.txtBoxMaNV.Enabled = false;
            this.txtBoxHo.Enabled = false;
            this.txtBoxTen.Enabled = false;
            this.dtp.Enabled = false;
            this.txtBoxDiaChi.Enabled = false;
            this.txtBoxSDT.Enabled = false;
            this.txtBoxCMND.Enabled = false;
            this.cbChucVu.Enabled = false;
        }

        private bool isTxtBoxNotEmpty()
        {
            if (this.txtBoxMaNV.Text.Trim() == "" || this.txtBoxHo.Text.Trim() == "" || this.txtBoxTen.Text.Trim() == ""
             || this.dtp.Text.Trim() == "" || this.txtBoxDiaChi.Text.Trim() == "" || this.txtBoxCMND.Text.Trim() == ""
             || this.txtBoxSDT.Text.Trim() == "" || this.cbChucVu.Text == "")
                return false;
            return true;
        }
    }
}
