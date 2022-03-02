using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class QUANLY
    {
        MY_DB mydb = new MY_DB();
        //Lay thong tinh nhan vien
        public DataTable layNhanvien()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM quanly");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public double totalNhanVien()
        {

            SqlCommand command = new SqlCommand("select   count(quanly_id) FROM quanly ", mydb.getConnection);


            mydb.openConnection();
            Int32 count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;

        }

        public double totalLaoViecTrongNgay(DateTime day)
        {

            SqlCommand command = new SqlCommand("select   count(Id)  from timework,quanly" +
                " WHERE YEAR(timework.start_time) = YEAR(@day) AND MONTH(start_time) = MONTH(@day)" +
                " AND DAY(start_time) = DAY(@day) AND quanly_id = Id   ", mydb.getConnection);
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = day;


            mydb.openConnection();
            Int32 count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;

        }
        //lay nhan vien Lao cong lam viec trong 1 ngay
        public DataTable layNhanvienLamViec(DateTime day)
        {

            SqlCommand command = new SqlCommand("SELECT quanly.quanly_id,ho,ten,timework.start_time,timework.end_time " +
                " FROM timework,quanly" +
                " WHERE YEAR(timework.start_time) = YEAR(@day) AND MONTH(start_time) = MONTH(@day) " +
                " AND DAY(start_time) = DAY(@day) AND quanly_id = Id   ");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = day;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool updateQL(string id, string ho, string ten, string sdt, string gt, DateTime ngsinh, string diachi, DateTime ngfirst)
        {
            SqlCommand command = new SqlCommand("UPDATE quanly SET ho = @ho, ten =@ten , SDT =@sdt, gioitinh = @gt ,ngaysinh = @ngsinh , diachi =@diachi , ngayfirst=@ngfirst  WHERE quanly_id =@ID", mydb.getConnection);

            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@ho", SqlDbType.NVarChar).Value = ho;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gt;
            command.Parameters.Add("@ngsinh", SqlDbType.DateTime).Value = ngsinh;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@ngfirst", SqlDbType.DateTime).Value = ngfirst;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
    }
}
