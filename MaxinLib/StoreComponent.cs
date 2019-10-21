using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MaxinLib
{
    public partial class StoreComponent : Component
    {
        public StoreComponent()
        {
            InitializeComponent();
        }

        public StoreComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SaveData<T>(T data, string path)
        {
            var attr = (DataContractAttribute)Attribute.GetCustomAttribute(data.GetType(), typeof(DataContractAttribute));

            if (attr == null)
            {
                throw new Exception("Serrialize error");
            }

            var jsonFormatter = new DataContractJsonSerializer(typeof(T));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, data);
            }
        }

        public T LoadData<T>(string path)
        {
            T data;

            var attr = (DataContractAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(DataContractAttribute));

            if (attr == null)
            {
                throw new Exception("Deserialize error");
            }

            var jsonFormatter = new DataContractJsonSerializer(typeof(T));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                data = (T)jsonFormatter.ReadObject(fs);
            }

            return data;
        }
    }
}
