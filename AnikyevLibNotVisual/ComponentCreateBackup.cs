using System.IO;
using System.IO.Compression;
using System.ComponentModel;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System;

namespace AnikyevLibNotVisual
{
    public partial class ComponentCreateBackup : Component
    {
        public string OutputPath { get; set; }

        public void Save<T>(T[] items, string name)
        {
            if((DataContractAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(DataContractAttribute)) == null)
            {
                throw new Exception("Класс не имеет соответствующих атрибутов");
            }
            var serializer = new DataContractJsonSerializer(items.GetType());
            var jsonpath = Path.Combine(new[] { OutputPath, $"info/{name}.json" });
            var jsonfolderpath = Path.Combine(new[] { OutputPath, $"info" });
            var zippath = Path.Combine(new[] { OutputPath, $"{name}.zip" });

            if (!Directory.Exists(jsonfolderpath)) Directory.CreateDirectory(jsonfolderpath);
            using (var fs = new FileStream(jsonpath, FileMode.OpenOrCreate))
            {
                serializer.WriteObject(fs, items);
            }
            File.Delete(zippath);
            
            ZipFile.CreateFromDirectory(jsonfolderpath, zippath);
            File.Delete(jsonpath);
            Directory.Delete(jsonfolderpath);
        }

        public ComponentCreateBackup()
        {
            InitializeComponent();
        }

        public ComponentCreateBackup(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
