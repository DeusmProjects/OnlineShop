using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementationsDB;
using Interfaces;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace PluginCreateOrderCard
{
    [Export(typeof(IOperation))]
    public class CreateOrderCardFunc : IOperation
    {
        public string Name => "CreateOrderCard";

        public Order Operate(Order order)
        {
            Microsoft.Office.Interop.Word.Application application;
            Microsoft.Office.Interop.Word.Document document;
            Object missingObj = System.Reflection.Missing.Value;
            Object trueObj = true;
            Object falseObj = false;

            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return null;

            application = new Microsoft.Office.Interop.Word.Application();
            document = application.Documents.Add();

            application.Visible = true;
            var par = document.Content.Paragraphs.Add();

            Object path = saveFileDialog.FileName;
            par.Range.Text = "Уведомление о заказе №" + order.Id + ". Статус: " + order.Status + ". Кол-во единиц товара: " + order.Count + ".";
            document.SaveAs(ref path, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument,
                ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                ref missingObj, ref missingObj, ref missingObj,
                ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                ref missingObj, ref missingObj, ref missingObj);
            document.Close(ref falseObj, ref missingObj, ref missingObj);
            application.Quit(ref missingObj, ref missingObj, ref missingObj);

            return null;
        }
    }
}
