using ImplementationsDB;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;

namespace ViewForm
{
    public class Manager
    {
        [ImportMany(typeof(IOperation))]
        IEnumerable<IOperation> Plugins { get; set; }

        public readonly Dictionary<string, Func<Order, Order>> Operations = new Dictionary<string, Func<Order, Order>>();

        public string[] Headers { get; private set; }

        public Manager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory));
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));

            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            if (Plugins.Count() != 0)
            {
                Plugins.ToList().ForEach(p => Operations.Add(p.Name, (i) => p.Operate(i)));
                Headers = Operations.Keys.ToArray();
            }
        }
    }
}
