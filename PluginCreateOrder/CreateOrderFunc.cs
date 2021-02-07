using ImplementationsDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewForm;

namespace PluginCreateOrder
{
    [Export(typeof(IOperation))]
    public class CreateOrderFunc : IOperation
    {
        public string Name => "CreateOrder";

        public void Operate(Order order)
        {
            //OrderContext db = new OrderContext();
            //using (var transaction = db.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        db.Orders.Add(order);
            //        db.SaveChanges();
            //        transaction.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        transaction.Rollback();
            //        throw ex;
            //    }
            //}
        }
    }
}
