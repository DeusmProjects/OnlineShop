using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDB
{
    public class MainServiceDB : IMainService
    {
        private AbstractDB context;

        public MainServiceDB(AbstractDB context)
        {
            this.context = context;
        }

        public List<Main> GetList()
        {
            return context.Main.ToList();
        }

        public void AddElement(Main model)
        {
            context.Main.Add(new Main
            {
                City = model.City,
                Email = model.Email
            });
            context.SaveChanges();
        }

        public Main GetElement(int id)
        {
            Main element = context.Main.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Main
                {
                    Id = element.Id,
                    City = element.City,
                    Email = element.Email
                };
            }
            throw new Exception("Элемент не найден");
        }


    }
}
