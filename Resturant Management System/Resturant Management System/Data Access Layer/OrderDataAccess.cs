using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class OrderDataAccess
    {
        DataAccess dataAccess;
        public OrderDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public int AddOrder(Order order)
        {
            string query = "INSERT INTO Orders (Food_Name,Quantity,Total_Amount,Date) VALUES('"+order.Food_Name+"','"+order.Quantity+"','"+order.Total_Amount+"','"+order.Date+"')";
            return this.dataAccess.ExecuteQuery(query);
        }
    }
}
