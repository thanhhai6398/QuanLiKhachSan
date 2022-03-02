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
    public partial class QL_Phong : Form
    {
        public QL_Phong()
        {
            InitializeComponent();
        }
        
        PHONG phong = new PHONG();
        private void btnThemLP_Click(object sender, EventArgs e)
        {
            string maloai = txtMaloai.Text;
            string loai = txtLoai.Text;
            string songuoi = txtSonguoi.Text;
            int gia = Convert.ToInt32(txtGia.Text);
            if (verif())
            {
                if (phong.ThemLoaiPhong(maloai, loai, songuoi, gia))
                {
                    MessageBox.Show("Đã thêm loại phòng", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvLoaiPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maloai as 'Mã loại',loai as 'Loại',songuoi as 'Số người',gia as 'Giá' FROM LoaiPhong"));
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Trống", "Thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((txtMaloai.Text.Trim() == "") || (txtLoai.Text.Trim() == "") || (txtSonguoi.Text.Trim() == "") || (txtGia.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSuaLP_Click(object sender, EventArgs e)
        {
            string maloai = txtMaloai.Text;
            string loai = txtLoai.Text;
            string songuoi = txtSonguoi.Text;
            int gia = Convert.ToInt32(txtGia.Text);
            if (verif())
            {
                try
                {
                    if (phong.CapNhatLoaiPhong(maloai, loai, songuoi, gia))
                    {
                        MessageBox.Show("Cập nhật thông tin loại phòng", "Sửa thông tin loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gvLoaiPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maloai as 'Mã loại',loai as 'Loại',songuoi as 'Số người',gia as 'Giá' FROM LoaiPhong"));
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Sửa thông tin loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sửa thông tin loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Trống", "Sửa thông tin loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            try
            {
                string maloai = txtMaloai.Text;
                // message before the delete
                if ((MessageBox.Show("Bạn muốn xóa loại phòng này?", "Xóa loại phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (phong.XoaLoaiPhong(maloai))
                    {
                        MessageBox.Show("Đã xóa loại phòng", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear fields after delete
                        txtMaloai.Text = "";
                        txtLoai.Text = "";
                        txtSonguoi.Text = "";
                        txtGia.Text = "";
                        gvLoaiPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maloai as 'Mã loại',loai as 'Loại',songuoi as 'Số người',gia as 'Giá' FROM LoaiPhong"));
                    }
                    else
                    {
                        MessageBox.Show("Không xóa loại phòng", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hãy nhập đúng mã loại phòng cần xóa!", "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            try
            {
                string maphong = txtMaphong.Text;
                string maloai = (string)cbLoaiPhong.SelectedValue;
                string tinhtrang = "Trống";
                if (rdCoKhach.Checked)
                {
                    tinhtrang = "Có khách";
                }
                // check if the score is already set for this student on this score
                if (phong.ThemPhong(maphong, maloai, tinhtrang))
                {
                    MessageBox.Show("Đã thêm phòng", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maphong as 'Mã phòng', maloai as 'Mã loại', tinhtrang as 'tinhtrang' FROM phong"));
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            try
            {
                string maphong = txtMaphong.Text;
                string maloai = (string)cbLoaiPhong.SelectedValue;
                string tinhtrang = "Trống";
                if (rdCoKhach.Checked)
                {
                    tinhtrang = "Có khách";
                }
                // check if the score is already set for this student on this score
                if (phong.CapNhatPhong(maphong, maloai, tinhtrang))
                {
                    MessageBox.Show("Đã cập nhật phòng", "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maphong as 'Mã phòng', maloai as 'Mã loại', tinhtrang as 'tinhtrang' FROM phong"));
                }
                else
                {
                    MessageBox.Show("Lỗi", "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            try
            {
                string maphong = (string)txtMaphong.Text;
                // message before the delete
                if ((MessageBox.Show("Bạn muốn xóa phòng này?", "Xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (phong.XoaPhong(maphong))
                    {
                        MessageBox.Show("Đã xóa phòng", "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear fields after delete
                        txtMaphong.Text = "";
                        txtLoai.Text = "";
                        gvPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maphong as 'Mã phòng', maloai as 'Mã loại', tinhtrang as 'tinhtrang' FROM phong"));
                    }
                    else
                    {
                        MessageBox.Show("Không xóa phòng", "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvPhong_Click(object sender, EventArgs e)
        {
            txtMaphong.Text = gvPhong.CurrentRow.Cells[0].Value.ToString();
            if (gvPhong.CurrentRow.Cells[2].Value.ToString().Trim() == "Trống")
            {
                rdTrong.Checked = true;
            }
            else
            {
                rdCoKhach.Checked = true;
            }
        }

        private void gvLoaiPhong_Click(object sender, EventArgs e)
        {
            txtMaloai.Text = gvLoaiPhong.CurrentRow.Cells[0].Value.ToString();
            txtLoai.Text = gvLoaiPhong.CurrentRow.Cells[1].Value.ToString();
            txtSonguoi.Text = gvLoaiPhong.CurrentRow.Cells[2].Value.ToString();
            txtGia.Text = gvLoaiPhong.CurrentRow.Cells[3].Value.ToString();
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            //danh sach loai phong
            cbLoaiPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maloai as 'Mã loại',loai as 'Loại',songuoi as 'Số người',gia as 'Giá' FROM LoaiPhong"));
            cbLoaiPhong.DisplayMember = "Loại";
            cbLoaiPhong.ValueMember = "Mã loại";

            //danh sach phong
            gvPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maphong as 'Mã phòng', maloai as 'Mã loại', tinhtrang as 'tinhtrang' FROM phong"));

            //danh sach loai phong
            gvLoaiPhong.DataSource = phong.LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT maloai as 'Mã loại',loai as 'Loại',songuoi as 'Số người',gia as 'Giá' FROM LoaiPhong"));
        }
    }
}
