using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    public class CHECK
    {
        MY_DB mydb = new MY_DB();

        public bool insertCheckIn(string id, DateTime check)
        {
            SqlCommand command = new SqlCommand("INSERT INTO timework (Id,start_time,end_time) VALUES (@ID,@start,@start)", mydb.getConnection);


            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@start", SqlDbType.DateTime).Value = check;
            
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
        public bool updateCheckOut(string id, DateTime start)
        {
            SqlCommand command = new SqlCommand("UPDATE timework SET  end_time =@end WHERE Id=@ID AND" +
                " YEAR(timework.start_time) = YEAR(@day) AND MONTH(start_time) = MONTH(@day)  " +
                " AND DAY(start_time) = DAY(@day) ", mydb.getConnection);


            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = start ;
            command.Parameters.Add("@end", SqlDbType.DateTime).Value = DateTime.Now;

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
