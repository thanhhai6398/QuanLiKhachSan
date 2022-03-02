using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class DATPHONG
    {
        MY_DB mdb = new MY_DB();

        public bool Dat_Phong(string MPDat, string Makh, string MaP, DateTime NgayDen, DateTime NgayDi)
        {
            SqlCommand command = new SqlCommand("INSERT INTO PhieuDatPhong(mapdp, makh, maphong, ngayden, ngaydi)" +
                "VALUES (@mapdp,@makh, @maphong,  @ngayden,@ngaydi)", mdb.getConnection);
            command.Parameters.Add("@mapdp", SqlDbType.VarChar).Value = MPDat;
            command.Parameters.Add("@makh", SqlDbType.VarChar).Value = Makh;
            command.Parameters.Add("@maphong", SqlDbType.VarChar).Value = MaP;
            command.Parameters.Add("@ngayden", SqlDbType.DateTime).Value = NgayDen;
            command.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = NgayDi;
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
        public DataTable LayTTPhieu(SqlCommand command)
        {
            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //xoa = maphong
        public bool HuyPhong(string MaP)
        {
            SqlCommand command = new SqlCommand("DELETE FROM PhieuDatPhong WHERE maphong = @ma", mdb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = MaP;
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
        public bool CapNhatTTPhongDat(string MPDat, string Makh, string MaP, DateTime NgayDen, DateTime NgayDi)
        {
            SqlCommand command = new SqlCommand("UPDATE PhieuDatPhong SET makh=@makh, maphong=@maphong, ngayden=@ngayden, ngaydi=@ngaydi WHERE mapdp=@mapdp", mdb.getConnection);
            command.Parameters.Add("@mapdp", SqlDbType.VarChar).Value = MPDat;
            command.Parameters.Add("@makh", SqlDbType.VarChar).Value = Makh;
            command.Parameters.Add("@maphong", SqlDbType.VarChar).Value = MaP;
            command.Parameters.Add("@ngayden", SqlDbType.DateTime).Value = NgayDen;
            command.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = NgayDi;

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
        string dem(string query)
        {
            SqlCommand command = new SqlCommand(query, mdb.getConnection);
            mdb.openConnection();
            string sl = command.ExecuteScalar().ToString();
            mdb.closeConnection();
            return sl;
        }
    }
}
