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
    public partial class TongThu : Form
    {
        public TongThu()
        {
            InitializeComponent();
        }
        BillTraPhong bill = new BillTraPhong();
        MY_DB db = new MY_DB();
        DataTable LayThongTin(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
       
        private void TongThu_Load(object sender, EventArgs e)
        {
            DateTime ngayHT = DateTime.Now.Date;
            SqlCommand command = new SqlCommand("SELECT matraphong as 'Mã phiếu trả phòng', tien as 'Tiền thanh toán' FROM traphong WHERE  traphong.ngaytraphong = @NgayHT", db.getConnection);
            command.Parameters.Add("@NgayHT", SqlDbType.VarChar).Value = ngayHT;
            gvTongThu.DataSource = LayThongTin(command);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command1 = new SqlCommand("SELECT sum(tien) as Tong FROM traphong WHERE ngaytraphong = @NgayHT GROUP BY ngaytraphong", db.getConnection);
            command1.Parameters.Add("@NgayHT", SqlDbType.VarChar).Value = ngayHT;
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                labelTongThu.Text = ("Tổng thu: " + table.Rows[0]["Tong"].ToString());
            }
            else
            {
                labelTongThu.Text = ("Tổng thu: 0");
            }
            labelNgay.Text = ("Ngày: " + DateTime.Now.Date.ToString());
        }
    }
}
