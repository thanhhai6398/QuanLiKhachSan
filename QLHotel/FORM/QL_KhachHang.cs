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
    public partial class QL_KhachHang : Form
    {
        public QL_KhachHang()
        {
            InitializeComponent();
        }
        KHACHHANG kh = new KHACHHANG();
        MY_DB db = new MY_DB();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaKH = textBoxMaKH.Text;
            string TenKH = textBoxTenKH.Text;
            string CMND = textBoxCMND.Text;
            DateTime NgaySinh = dateTimePickerNgaySinh.Value;
            string DiaChi = textBoxDiaChi.Text;
            string SDT = textBoxSDT.Text;
            string GhiChu = textBoxGhiChu.Text;
            string GioiTinh = "Nam";
            if (radioButtonNu.Checked)
            {
                GioiTinh = "Nu";
            }
            if (verif())
            {
                if (kh.ThemKH(MaKH, TenKH, GioiTinh, NgaySinh, CMND, DiaChi, SDT, GhiChu))
                {
                    MessageBox.Show("Đã thêm Khách Hàng", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewKH.DataSource = kh.LayTT_KH(new System.Data.SqlClient.SqlCommand("SELECT makh as 'Mã KH', tenkh as 'Tên KH', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', cmnd as 'CMND', diachi as 'Địa chỉ', sdt as 'Số ĐT', ghichu as 'Ghi chú' FROM KhachHang"));
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Trống", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxMaKH.Text.Trim() == "") || (textBoxTenKH.Text.Trim() == "") || (textBoxCMND.Text.Trim() == "")
                || (textBoxDiaChi.Text.Trim() == "") || (textBoxSDT.Text.Trim() == ""))
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
            string MaKH = textBoxMaKH.Text;
            string TenKH = textBoxTenKH.Text;
            string CMND = textBoxCMND.Text;
            DateTime NgaySinh = dateTimePickerNgaySinh.Value;
            string DiaChi = textBoxDiaChi.Text;
            string SDT = textBoxSDT.Text;
            string GhiChu = textBoxGhiChu.Text;
            string GioiTinh = "Nam";
            if (radioButtonNu.Checked)
            {
                GioiTinh = "Nữ";
            }
            if (verif())
            {
                try
                {
                    if (kh.CapNhatKH(MaKH, TenKH, GioiTinh, NgaySinh, CMND, DiaChi, SDT, GhiChu))
                    {
                        MessageBox.Show("Cập nhật thông tin Khách Hàng", "Sửa thông tin Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewKH.DataSource = kh.LayTT_KH(new System.Data.SqlClient.SqlCommand("SELECT makh as 'Mã KH', tenkh as 'Tên KH', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', cmnd as 'CMND', diachi as 'Địa chỉ', sdt as 'Số ĐT', ghichu as 'Ghi chú' FROM KhachHang"));

                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Sửa thông tin Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sửa thông tin Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Trống", "Sửa thông tin Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaKH = textBoxMaKH.Text;
                // message before the delete
                if ((MessageBox.Show("Bạn muốn xóa Khách Hàng này?", "Xóa Khách Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (kh.XoaKH(MaKH))
                    {
                        MessageBox.Show("Đã xóa Khách Hàng", "Xóa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear fields after delete
                        textBoxMaKH.Text = "";
                        textBoxTenKH.Text = "";
                        dateTimePickerNgaySinh.Value = DateTime.Now;
                        textBoxCMND.Text = "";
                        textBoxDiaChi.Text = "";
                        textBoxSDT.Text = "";
                        textBoxGhiChu.Text = "";
                        dataGridViewKH.DataSource = kh.LayTT_KH(new System.Data.SqlClient.SqlCommand("SELECT makh as 'Mã KH', tenkh as 'Tên KH', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', cmnd as 'CMND', diachi as 'Địa chỉ', sdt as 'Số ĐT', ghichu as 'Ghi chú' FROM KhachHang"));

                    }
                    else
                    {
                        MessageBox.Show("Không xóa Khách Hàng", "Xóa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hãy nhập đúng mã Khách Hàng cần xóa!", "Xóa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewKH_Click(object sender, EventArgs e)
        {
            //MaKH, TenKH, GioiTinh, NgaySinh, CMND, DiaChi, SDT, GhiChu
            textBoxMaKH.Text = dataGridViewKH.CurrentRow.Cells[0].Value.ToString();
            textBoxTenKH.Text = dataGridViewKH.CurrentRow.Cells[1].Value.ToString();
            // gioitinh
            if (dataGridViewKH.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            dateTimePickerNgaySinh.Value = (DateTime)dataGridViewKH.CurrentRow.Cells[3].Value;
            textBoxCMND.Text = dataGridViewKH.CurrentRow.Cells[4].Value.ToString();
            textBoxDiaChi.Text = dataGridViewKH.CurrentRow.Cells[5].Value.ToString();
            textBoxSDT.Text = dataGridViewKH.CurrentRow.Cells[6].Value.ToString();
            textBoxGhiChu.Text = dataGridViewKH.CurrentRow.Cells[7].Value.ToString();
        }

        private void QL_KhachHang_Load(object sender, EventArgs e)
        {
            dataGridViewKH.DataSource = kh.LayTT_KH(new System.Data.SqlClient.SqlCommand("SELECT makh as 'Mã KH', tenkh as 'Tên KH', gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', cmnd as 'CMND', diachi as 'Địa chỉ', sdt as 'Số ĐT', ghichu as 'Ghi chú' FROM KhachHang"));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string name = textBoxTimKiem.Text;
            SqlCommand command = new SqlCommand("SELECT KhachHang.makh as 'Mã KH',gioitinh as 'Giới tính', ngaysinh as 'Ngày sinh', cmnd as 'CMND', diachi as 'Địa chỉ', sdt as 'Số ĐT', ghichu as 'Ghi chú',PhieuDatPhong.maphong as 'Mã Phòng' FROM KhachHang, PhieuDatPhong WHERE KhachHang.makh = PhieuDatPhong.makh AND tenkh = @name", db.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            DataTable table = kh.LayTT_KH(command);
            if (table.Rows.Count > 0)
            {
                dataGridViewKH.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Tìm kiếm KH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
