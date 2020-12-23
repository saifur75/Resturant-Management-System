﻿using Resturant_Management_System.Entities;
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
        public int InsertCategory(Category category)
        {
            string query= "INSERT INTO Categories(CategoryName) VALUES('" + category.CategoryName + "')";
            return this.dataAccess.ExecuteQuery(query);
        }
        public int DeleteCategory(int id)
        {
            string sql = "DELETE FROM Categories WHERE CategoryId=" + id;
            return this.dataAccess.ExecuteQuery(sql);           
        }
        public int UpdateCategory(Category category)
        {
            string query = "UPDATE Categories SET CategoryName='" + category.CategoryName + "' WHERE CategoryId=" + category.CategoryId;
            return this.dataAccess.ExecuteQuery(query);            
        }
        public List<string> GetCategoryNames()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> categories = new List<string>();
            while (reader.Read())
            {
                categories.Add(reader["CategoryName"].ToString());
            }
            return categories;
        }
    }
}
