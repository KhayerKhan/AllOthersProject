using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreDemo.Code
{
    public class SQLServerData
    {
        public string GetStudentsNames()
        {
            string message="";
            
            SqlConnection connection = new SqlConnection("Server=KHAYER_KHAN;Database=Asp.NetCore;User Id=DevSkill;Password =123456;");
            try
            {
                SqlCommand command = new SqlCommand("insert into Student(name) values('Abir')", connection);
                connection.Open();

                 message = command.ExecuteNonQuery().ToString();

            }

            catch (Exception ex)
            {
                message = ex.Message;

            }
            finally
            {
                if(connection.State==System.Data.ConnectionState.Open)
                connection.Close();

            }
            return message;
        }

    }
}
