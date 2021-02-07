using ImplementationsDB;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChangeCount
{
    [Export(typeof(IOperation))]
    public class ChangeCountFunc : IOperation
    {
        public string Name => "ChangeCount";

        public Order Operate(Order order)
        {
            if (order.Count == -1)
            {
                order.Count = 1;
            }
            else
            {
                order.Count *= 2;
            }
            return order;
        }
    }
}
