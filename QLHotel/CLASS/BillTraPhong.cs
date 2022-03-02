using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class BillTraPhong
    {
        MY_DB mdb = new MY_DB();

        public bool CapNhatTraPhong(string phieu, string maKH, string maphong, int thoigian, int tientra, DateTime ngaytraphong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO traphong(matraphong,makh,maphong,thoigian,tien,ngaytraphong) VALUES(@matp,@makh, @maph,@tg,@tientra,@ngaytra) ", mdb.getConnection);
            command.Parameters.Add("@maph", SqlDbType.NVarChar).Value = maphong;
            command.Parameters.Add("@matp", SqlDbType.NVarChar).Value = phieu;
            command.Parameters.Add("@makh", SqlDbType.NVarChar).Value = maKH;
            command.Parameters.Add("@tg", SqlDbType.Int).Value = thoigian;
            command.Parameters.Add("@tientra", SqlDbType.Int).Value = tientra;
            command.Parameters.Add("@ngaytra", SqlDbType.DateTime).Value = ngaytraphong;
            mdb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mdb.closeConnection();
                return true;
            }
            else
            {
                mdb.closeConnection();
                return false;
            }
        }
    }
}
