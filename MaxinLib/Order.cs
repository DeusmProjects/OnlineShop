using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public DateTime DateCreate { get; set; }

        [DataMember]
        public List<string> Goods { get; set; }

        public override string ToString()
        {
            return $"Номер: {Number} | Дата создания: {DateCreate.ToString("d")} | Товары: {string.Join(", ", Goods)}";
        }
    }
}
