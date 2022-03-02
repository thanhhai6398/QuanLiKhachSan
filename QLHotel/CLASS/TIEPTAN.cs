using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class TIEPTAN
    {
        MY_DB mydb = new MY_DB();
        public bool ThemTT(string id, string ho, string ten, string sdt, string gt, DateTime ngsinh, string diachi, DateTime ngfirst)
        {
            SqlCommand command = new SqlCommand("INSERT INTO tieptan(tieptan_id, ho, ten, sdt, gioitinh, ngaysinh, diachi, ngayfirst)" +
                "VALUES (@ID, @ho, @ten,  @sdt, @gt, @ngsinh,  @diachi, @ngfirst)", mydb.getConnection);
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
        public bool updateTT(string id, string ho, string ten, string sdt, string gt, DateTime ngsinh, string diachi, DateTime ngfirst)
        {
            SqlCommand command = new SqlCommand("UPDATE tieptan SET ho = @ho, ten =@ten , sdt =@sdt, gioitinh = @gt ,ngaysinh = @ngsinh , diachi =@diachi , ngayfirst=@ngfirst  WHERE tieptan_id =@ID", mydb.getConnection);

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
        public bool deleteTT(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM tieptan WHERE tieptan_id =@ID", mydb.getConnection);

            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
     

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
        public DataTable getTiepTan()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT * FROM tieptan";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        // nhan vien lao cong lam viec trong ngay
        public double totalLaoViecTrongNgay(DateTime day)
        {

            SqlCommand command = new SqlCommand("select   count(Id)  from timework,tieptan" +
                " WHERE YEAR(timework.start_time) = YEAR(@day) AND MONTH(start_time) = MONTH(@day)" +
                " AND DAY(start_time) = DAY(@day) AND tieptan_id = Id   ", mydb.getConnection);
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = day;


            mydb.openConnection();
            Int32 count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;

        }
        //lay nhan vien Lao cong lam viec trong 1 ngay
        public DataTable layNhanvienLamViec(DateTime day)
        {

            SqlCommand command = new SqlCommand("SELECT tieptan.tieptan_id,ho,ten,timework.start_time,timework.end_time " +
                " FROM timework,tieptan" +
                " WHERE YEAR(timework.start_time) = YEAR(@day) AND MONTH(start_time) = MONTH(@day) " +
                " AND DAY(start_time) = DAY(@day) AND tieptan_id = Id   ");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = day;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Lay thong tinh nhan vien
        public DataTable layNhanvien()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM tieptan");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public double totalNhanVien()
        {

            SqlCommand command = new SqlCommand("select   count(tieptan_id) FROM tieptan ", mydb.getConnection);


            mydb.openConnection();
            Int32 count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;

        }
    }
}
