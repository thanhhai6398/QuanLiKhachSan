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
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        MY_DB db = new MY_DB();
        DataTable LayThongTin(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void ThongBao_Load(object sender, EventArgs e)
        {
            DateTime ngayHT = DateTime.Now.Date;
            SqlCommand command = new SqlCommand("SELECT PhieuDatPhong.maphong as 'Mã phòng', KhachHang.tenkh as 'Tên khách hàng' FROM PhieuDatPhong, KhachHang WHERE PhieuDatPhong.makh = KhachHang.makh AND ngaydi <= @NgayHT", db.getConnection);
            command.Parameters.Add("@NgayHT", SqlDbType.VarChar).Value = ngayHT;
            gvTB.DataSource = LayThongTin(command);
        }
    }
}
