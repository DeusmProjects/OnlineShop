using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace MaxinLib
{
    class TestData
    {
        public string name { get; set; }
        public int value { get; set; }

        private static List<TestData> GetTestDataFirst()
        {
            List<TestData> testDataFirst = new List<TestData>();

            testDataFirst.Add(new TestData() { name = "1", value = 1 });
            testDataFirst.Add(new TestData() { name = "10", value = 10 });
            testDataFirst.Add(new TestData() { name = "5", value = 5 });
            testDataFirst.Add(new TestData() { name = "8", value = 8 });
            testDataFirst.Add(new TestData() { name = "5", value = 5 });

            return testDataFirst;
        }

        private static List<TestData> GetTestDataSecond()
        {
            List<TestData> testDataSecond = new List<TestData>();

            testDataSecond.Add(new TestData() { name = "12", value = 12 });
            testDataSecond.Add(new TestData() { name = "3", value = 3 });
            testDataSecond.Add(new TestData() { name = "8", value = 8 });
            testDataSecond.Add(new TestData() { name = "15", value = 15 });
            testDataSecond.Add(new TestData() { name = "1", value = 1 });

            return testDataSecond;
        }

        public static Series GetSeriesFirst()
        {
            // создаём набор данных
            Series seriesFirst = new Series("First");

            // заполняем данными
            seriesFirst.Bind(TestData.GetTestDataFirst(), "name", "value");
            return seriesFirst;
        }

        public static Series GetSeriesSecond()
        {
            // создаём набор данных
            Series seriesSecond = new Series("Second");
            // заполняем данными
            seriesSecond.Bind(TestData.GetTestDataSecond(), "name", "value");
            return seriesSecond;
        }
    }
}
