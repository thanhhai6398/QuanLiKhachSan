using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class KHACHHANG
    {
        MY_DB mdb = new MY_DB();
        public bool ThemKH(string makh, string tenkh, string gioitinh, DateTime ngaysinh, string cmnd, string diachi, string sdt, string ghichu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KhachHang(makh,tenkh,gioitinh,ngaysinh,cmnd,diachi,sdt,ghichu) VALUES (@makh,@tenkh,@gioitinh,@ngaysinh,@cmnd,@diachi,@sdt,@ghichu)", mdb.getConnection);
            command.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            command.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = tenkh;
            command.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            command.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = ghichu;
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
        public DataTable LayTT_KH(SqlCommand command)
        {
            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //xoa = makh
        public bool XoaKH(string makh)
        {
            SqlCommand command = new SqlCommand("DELETE FROM KhachHang WHERE makh = @ma", mdb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = makh;
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
        //cap nhat thong tin
        public bool CapNhatKH(string makh, string tenkh, string gioitinh, DateTime ngaysinh, string cmnd, string diachi, string sdt, string ghichu)
        {
            SqlCommand command = new SqlCommand("UPDATE KhachHang SET tenkh=@tenkh, gioitinh=@gioitinh, ngaysinh=@ngaysinh, cmnd=@cmnd, diachi=@diachi, sdt=@sdt, ghichu=@ghichu WHERE makh=@makh", mdb.getConnection);
            command.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            command.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = tenkh;
            command.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            command.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = ghichu;
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
