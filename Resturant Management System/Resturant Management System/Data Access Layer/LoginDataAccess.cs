using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class LoginDataAccess
    {
        DataAccess dataAccess;
        public LoginDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public bool Login(string username,string password)
        {
            string query = "SELECT * FROM Users WHERE Username='" + username + "' and Password='" + password + "'";
            SqlDataReader reader = this.dataAccess.GetData(query);

            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetPost(string username)
        {
            string query = "SELECT * FROM Users WHERE Username='" + username + "' ";
            dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(query);
            reader.Read();
            return reader["Post"].ToString();
        }
    }
}
