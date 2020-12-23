using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class CategoryDataAccess
    {
        DataAccess dataAccess;
        public CategoryDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Category> GetAllCategories()
        {
            string query = "SELECT * FROM Categories";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                categories.Add(category);
            }
            return categories;
        }
    }
}
