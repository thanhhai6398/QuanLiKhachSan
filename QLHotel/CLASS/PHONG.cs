using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class PHONG
    {
        MY_DB mdb = new MY_DB();
        public bool ThemPhong(string maphong, string maloai, string tinhtrang)
        {
            SqlCommand command = new SqlCommand("INSERT INTO phong(maphong, maloai,tinhtrang) VALUES (@maphong, @maloai,@tinhtrang)", mdb.getConnection);
            command.Parameters.Add("@maphong", SqlDbType.NVarChar).Value = maphong;
            command.Parameters.Add("@maloai", SqlDbType.NVarChar).Value = maloai;
            command.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;

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
        public bool ThemLoaiPhong(string maloai, string loai, string songuoi, int gia)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LoaiPhong(maloai, loai, songuoi, gia) VALUES (@maloai, @loai, @songuoi, @gia)", mdb.getConnection);
            command.Parameters.Add("@maloai", SqlDbType.NVarChar).Value = maloai;
            command.Parameters.Add("@loai", SqlDbType.NVarChar).Value = loai;
            command.Parameters.Add("@songuoi", SqlDbType.NVarChar).Value = songuoi;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;

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
        public DataTable LayThongTin(SqlCommand command)
        {
            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //xoa = maphong
        public bool XoaPhong(string maphong)
        {
            SqlCommand command = new SqlCommand("DELETE FROM phong WHERE maphong = @ma", mdb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maphong;
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
        public bool XoaLoaiPhong(string maloai)
        {
            SqlCommand command = new SqlCommand("DELETE FROM LoaiPhong WHERE maloai = @ma", mdb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maloai;
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
        public bool CapNhatPhong(string maphong, string maloai, string tinhtrang)
        {
            SqlCommand command = new SqlCommand("UPDATE phong SET maloai=@maloai, tinhtrang=@tinhtrang WHERE maphong=@maphong", mdb.getConnection);
            command.Parameters.Add("@maphong", SqlDbType.NVarChar).Value = maphong;
            command.Parameters.Add("@maloai", SqlDbType.NVarChar).Value = maloai;
            command.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
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
        public bool CapNhatLoaiPhong(string maloai, string loai, string songuoi, int gia)
        {
            SqlCommand command = new SqlCommand("UPDATE LoaiPhong SET loai=@loai, songuoi=@songuoi, gia=@gia WHERE maloai=@maloai", mdb.getConnection);
            command.Parameters.Add("@maloai", SqlDbType.NVarChar).Value = maloai;
            command.Parameters.Add("@loai", SqlDbType.NVarChar).Value = loai;
            command.Parameters.Add("@songuoi", SqlDbType.NVarChar).Value = songuoi;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
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
        public bool CapNhatTTPhong(string maphong, string tinhtrang)
        {
            SqlCommand command = new SqlCommand("UPDATE phong SET tinhtrang=@tinhtrang WHERE maphong=@maphong", mdb.getConnection);
            command.Parameters.Add("@maphong", SqlDbType.NVarChar).Value = maphong;
            command.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
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
        //lay gia tien
        public DataTable LayGiaTien(string maph)
        {
            SqlCommand command = new SqlCommand("SELECT LoaiPhong.gia FROM LoaiPhong,phong WHERE LoaiPhong.maloai = phong.maloai AND maphong=@map");
            command.Parameters.Add("@map", SqlDbType.NVarChar).Value = maph;

            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
