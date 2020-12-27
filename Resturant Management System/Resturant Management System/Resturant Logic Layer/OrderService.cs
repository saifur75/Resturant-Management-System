using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class OrderService
    {
        OrderDataAccess orderDataAccess;
        public OrderService()
        {
            this.orderDataAccess = new OrderDataAccess();
        }
        public List<Order> GetAllOrder()
        {
            return this.orderDataAccess.GetAllOrder();
        }
        public int AddOrder(string foodName,string quantity,string totalAmmount,string date)
        {
            Order order = new Order()
            {
                Food_Name = foodName,
                Quantity = Convert.ToInt32(quantity),
                Total_Amount = Convert.ToDouble(totalAmmount),
                Date = date
            };
            orderDataAccess = new OrderDataAccess();
            return this.orderDataAccess.AddOrder(order);
        }
    }
}
