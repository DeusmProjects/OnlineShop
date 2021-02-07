using ImplementationsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOperation
    {
        string Name { get; }

        Order Operate(Order order);
    }
}
