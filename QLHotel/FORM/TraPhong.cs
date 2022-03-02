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
    public partial class TraPhong : Form
    {
        MY_DB db = new MY_DB();
        KHACHHANG kh = new KHACHHANG();
        PHONG phong = new PHONG();
        DATPHONG datP = new DATPHONG();
        BillTraPhong bill = new BillTraPhong();
        public TraPhong()
        {
            InitializeComponent();
        }
        DataTable LayThongTin(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void TraPhong_Load(object sender, EventArgs e)
        {
            LoadComboKH();
            gvPhieuDatPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT mapdp as 'Mã phiếu đặt phòng',makh as 'Mã khách hàng',maphong as 'Mã phòng',ngayden as 'Ngày đến',ngaydi as 'Ngày đi' FROM PhieuDatPhong"));
            gvPhieuTraPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT matraphong as 'Mã trả phòng', makh as 'Mã khách hàng', maphong as 'Mã phòng', thoigian as 'Thời gian', tien as 'Tiền', ngaytraphong as 'Ngày thanh toán' FROM traphong"));
        }
        private void LoadComboKH()
        {
            cbMaKH.DataSource = kh.LayTT_KH(new System.Data.SqlClient.SqlCommand("SELECT * FROM KhachHang"));
            cbMaKH.DisplayMember = "tenkh";
            cbMaKH.ValueMember = "makh";

        }

        private void gvPhieuDatPhong_Click(object sender, EventArgs e)
        {
            txtMPDat.Text = gvPhieuDatPhong.CurrentRow.Cells[0].Value.ToString();
            txtMaP.Text = gvPhieuDatPhong.CurrentRow.Cells[2].Value.ToString();
            dateTimeNgayDen.Value = (DateTime)gvPhieuDatPhong.CurrentRow.Cells[3].Value;
            dateTimeNgayDi.Value = (DateTime)gvPhieuDatPhong.CurrentRow.Cells[4].Value;

            cbMaKH.SelectedValue = gvPhieuDatPhong.CurrentRow.Cells[1].Value.ToString();
            maPhongTextBox.Text = gvPhieuDatPhong.CurrentRow.Cells[2].Value.ToString();
            ngaydendateTimePicker.Value = (DateTime)gvPhieuDatPhong.CurrentRow.Cells[3].Value;
            ngaydidateTimePicker.Value = DateTime.Now;

            tenKHtextBox.Text = cbMaKH.Text;

        }

        private void xacnhanButton_Click(object sender, EventArgs e)
        {
            string matraphong = ptraphongTextBox.Text;
            string Makh = (string)cbMaKH.SelectedValue;
            string maphong = maPhongTextBox.Text;
            DateTime ngayden = ngaydendateTimePicker.Value;
            TimeSpan tg =  DateTime.Now.Date - ngayden.Date ;
            int thoigian = tg.Days;
            DataTable table = phong.LayGiaTien(maphong);
            int giatien = Convert.ToInt32(table.Rows[0]["gia"].ToString());
            DateTime ngaytraphong = DateTime.Now.Date;
            int tientra = giatien * thoigian;
            if (bill.CapNhatTraPhong(matraphong,Makh,maphong,thoigian,tientra,ngaytraphong) == true)
            {
                MessageBox.Show("Xác Nhận Thành Công", "Bill Trả Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if ( phong.CapNhatTTPhong(maphong, "Trống") == true)
                {
                    MessageBox.Show("Trả Phòng Thành Công", "Bill Trả Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Thông Tin Điền Không Đầy Đủ", "Bill Trả Phòng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            datP.HuyPhong(maphong);
            gvPhieuDatPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT mapdp as 'Mã phiếu đặt phòng',makh as 'Mã khách hàng',maphong as 'Mã phòng',ngayden as 'Ngày đến',ngaydi as 'Ngày đi' FROM PhieuDatPhong"));

            gvPhieuTraPhong.AllowUserToAddRows = false;

            gvPhieuTraPhong.AllowUserToDeleteRows = false;

            gvPhieuTraPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvPhieuTraPhong.RowTemplate.Height = 30;
            gvPhieuTraPhong.DataSource = LayThongTin(new System.Data.SqlClient.SqlCommand("SELECT matraphong as 'Mã phiếu trả phòng', makh as 'Mã khách hàng', maphong as 'Mã phòng', thoigian as 'Thời gian', tien as 'Tiền', ngaytraphong as 'Ngày thanh toán' FROM traphong"));

        }
    }
}
