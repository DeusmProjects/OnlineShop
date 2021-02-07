using ImplementationsDB;
using Interfaces;
using System.ComponentModel.Composition;

namespace PluginChangeStatus
{
    [Export(typeof(IOperation))]
    public class ChangeStatusFunc : IOperation
    {
        public string Name => "ChangeStatus";

        public Order Operate(Order order)
        {
            if (order.Status < 3)
            {
                order.Status++;
            }
            return order;
        }
    }
}
