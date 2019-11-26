using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationsDB
{
    public class OrderService
    {
        OrderContext db = new OrderContext();

        public List<Order> GetOrders()
        {
            var list = db.Orders.ToList();
            return list;
        }

        public void CreateOrder(Order order)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void RemoveAll()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Orders.RemoveRange(db.Orders);
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
