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

namespace QLHotel
{
    public partial class DatPhongForm : Form
    {
        public DatPhongForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        KHACHHANG kh = new KHACHHANG();
        PHONG phong = new PHONG();
        DATPHONG datP = new DATPHONG();
        DataTable LayThongTin(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void LoadComboKH()
        {
            cbMaKH.DataSource = kh.LayTT_KH(new System.Data.SqlClient.SqlCommand("SELECT * FROM KhachHang"));
            cbMaKH.DisplayMember = "tenkh";
            cbMaKH.ValueMember = "makh";

        }


        private void DatPhongForm_Load(object sender, EventArgs e)
        {
            LoadComboKH();
            gvPhongTrong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT phong.maphong as 'Mã phòng', LoaiPhong.loai as 'Loại phòng', LoaiPhong.songuoi as 'Số người', LoaiPhong.gia as 'Giá' FROM phong, LoaiPhong WHERE phong.maloai=LoaiPhong.maloai and phong.tinhtrang = N'Trống'"));
            gvPhieuDatPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT mapdp as 'Mã phiếu đặt phòng',makh as 'Mã khách hàng',maphong as 'Mã phòng',ngayden as 'Ngày đến',ngaydi as 'Ngày đi' FROM PhieuDatPhong"));
        }
        private void gvPhongTrong_Click(object sender, EventArgs e)
        {
            txtMaP.Text = gvPhongTrong.CurrentRow.Cells[0].Value.ToString();
        }
        private void btnDatphong_Click(object sender, EventArgs e)
        {
            string MaPD = txtMPDat.Text;
            string Makh = (string)cbMaKH.SelectedValue;
            string MaP = txtMaP.Text;
            DateTime NgayDen = dateTimeNgayDen.Value;
            DateTime NgayDi = dateTimeNgayDi.Value;
            if (verif())
            {
                if (datP.Dat_Phong(MaPD, Makh, MaP, NgayDen, NgayDi))
                {
                    MessageBox.Show("Đã đặt phòng", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phong.CapNhatTTPhong(MaP, "Có khách");
                    gvPhongTrong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT phong.maphong as 'Mã phòng', LoaiPhong.loai as 'Loại phòng', LoaiPhong.songuoi as 'Số người', LoaiPhong.gia as 'Giá' FROM phong, LoaiPhong WHERE phong.maloai=LoaiPhong.maloai and phong.tinhtrang = N'Trống'"));
                    gvPhieuDatPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT mapdp as 'Mã phiếu đặt phòng',makh as 'Mã khách hàng',maphong as 'Mã phòng',ngayden as 'Ngày đến',ngaydi as 'Ngày đi' FROM PhieuDatPhong"));
                }
                else
                {
                    MessageBox.Show("Lỗi", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Trống", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((txtMPDat.Text.Trim() == "") || (txtMaP.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaPD = txtMPDat.Text;
            string Makh = (string)cbMaKH.SelectedValue;
            string MaP = txtMaP.Text;
            DateTime NgayDen = dateTimeNgayDen.Value;
            DateTime NgayDi = dateTimeNgayDi.Value;
            if (verif())
            {
                try
                {
                    if (datP.CapNhatTTPhongDat(MaPD, Makh, MaP, NgayDen, NgayDi))
                    {
                        MessageBox.Show("Cập nhật thông tin phòng đặt", "Sửa thông tin phòng đặt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gvPhieuDatPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT mapdp as 'Mã phiếu đặt phòng',makh as 'Mã khách hàng',maphong as 'Mã phòng',ngayden as 'Ngày đến',ngaydi as 'Ngày đi' FROM PhieuDatPhong"));
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Sửa thông tin phòng đặt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sửa thông tin phòng đặt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Trống", "Sửa thông tin phòng đặt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                string maP = txtMaP.Text;
                // message before the delete
                if ((MessageBox.Show("Bạn muốn hủy phiếu đặt này?", "Hủy phiếu đặt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (datP.HuyPhong(maP))
                    {
                        //MaNV,HoTenNV,NgaySinh,GioiTinh,DiaChi,NgayVaoLam,SoDT,ChucVu,TaiKhoan,MatKhau,HinhAnh
                        MessageBox.Show("Đã hủy phiếu đặt", "Hủy phiếu đặt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear fields after delete                       
                        txtMPDat.Text = "";
                        txtMaP.Text = "";
                        dateTimeNgayDen.Value = DateTime.Now;
                        dateTimeNgayDi.Value = DateTime.Now;
                        phong.CapNhatTTPhong(maP, "Trống");
                        gvPhongTrong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT phong.maphong as 'Mã phòng', LoaiPhong.loai as 'Loại phòng', LoaiPhong.songuoi as 'Số người', LoaiPhong.gia as 'Giá' FROM phong, LoaiPhong WHERE phong.maloai=LoaiPhong.maloai and phong.tinhtrang = N'Trống'"));
                        gvPhieuDatPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT mapdp as 'Mã phiếu đặt phòng',makh as 'Mã khách hàng',maphong as 'Mã phòng',ngayden as 'Ngày đến',ngaydi as 'Ngày đi' FROM PhieuDatPhong"));
                    }
                    else
                    {
                        MessageBox.Show("Không hủy phiếu đặt", "Hủy phiếu đặt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hãy nhập đúng phòng!", "Hủy phiếu đặt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT phong.maphong as 'Mã phòng', LoaiPhong.loai as 'Loại phòng', LoaiPhong.songuoi as 'Số người', LoaiPhong.gia as 'Giá' FROM phong, LoaiPhong WHERE phong.maloai = LoaiPhong.maloai and phong.tinhtrang = N'Trống'");
            gvPhongTrong.ReadOnly = true; // nap lai du lieu len datagridview
            gvPhongTrong.DataSource = LayThongTin(command);
            gvPhongTrong.AllowUserToAddRows = false;
        }

        private void gvPhieuDatPhong_Click(object sender, EventArgs e)
        {
            txtMPDat.Text = gvPhieuDatPhong.CurrentRow.Cells[0].Value.ToString();
            txtMaP.Text = gvPhieuDatPhong.CurrentRow.Cells[2].Value.ToString();

            cbMaKH.SelectedValue= gvPhieuDatPhong.CurrentRow.Cells[1].Value.ToString();
        }

       
    }
}
