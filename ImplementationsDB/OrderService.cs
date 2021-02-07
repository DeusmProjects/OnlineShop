using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationsDB
{
    public class OrderService
    {
        private OrderContext db = new OrderContext();
        private static OrderService instance;

        private OrderService()
        { }

        public static OrderService GetInstance()
        {
            if (instance == null)
            {
                instance = new OrderService();
            }
            return instance;
        }

        public List<Order> GetOrders()
        {
            var list = db.Orders.ToList();
            return list;
        }

        public Order CreateOrder(Order order)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    order = db.Orders.Add(order);
                    db.SaveChanges();
                    transaction.Commit();
                    return order;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void UpdateOrder(Order order)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var currentOrder = db.Orders.First(element => element.Id == order.Id);
                    currentOrder.Status = order.Status;
                    currentOrder.Count = order.Count;
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
