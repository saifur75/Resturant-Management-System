using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System.Data_Access_Layer
{
    class MenuDataAccess
    {
        DataAccess dataAccess;
        public MenuDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Menu1> GetAllFood()
        {
            string query = "SELECT * FROM Menu";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<Menu1> menus = new List<Menu1>();

            while(reader.Read())
            {
                Menu1 menu = new Menu1();
                menu.FoodId = (int)reader["FoodId"];
                menu.FoodName = reader["FoodName"].ToString();
                menu.Price =Convert.ToDouble( reader["Price"]);
                menu.Status = reader["Status"].ToString();
                menu.CategoryId = (int)reader["CategoryId"];
                menus.Add(menu);
                
            }
            return menus;
        }
    }
}
