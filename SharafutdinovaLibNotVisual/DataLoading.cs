using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace SharafutdinovaLibNotVisual
{
    public partial class DataLoading : Component
    {
        public DataLoading()
        {
            InitializeComponent();
        }

        public DataLoading(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public T LoadObject<T>(string zipPath)
        {
            string path="";
            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        path = Path.GetFullPath(Path.Combine(zipPath, entry.FullName));
                    }
                }
            }
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(path)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(T));
                T myTest = (T)deserializer.ReadObject(ms);
                var type = myTest.GetType();
                var attr = (DataContractAttribute)Attribute.GetCustomAttribute(type, typeof(DataContractAttribute));
                if (attr == null)
                {
                    throw new Exception("Класс нельзя десериализовать");
                }
                return myTest;
            }        
        }
    }
}
