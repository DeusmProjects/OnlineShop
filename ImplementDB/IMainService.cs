using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDB
{
    public interface IMainService
    {
        List<Main> GetList();

        Main GetElement(int id);

        void AddElement(Main model);
    }
}
