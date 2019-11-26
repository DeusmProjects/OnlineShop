using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Main
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Email { get; set; }

    }
}
