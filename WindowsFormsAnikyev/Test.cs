using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAnikyev
{
    [DataContract]
    public class Test
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public int price { get; set; }

        public Test(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
