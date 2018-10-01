using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Cits_Base_Center;

namespace TestCodeCore
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //var _startTime = new DateTime(2018, 3, 23, 6, 9, 0);
            //var _comboboxIndex = 1;
            //var _loopMinute = 6;

            //DateTime myNow = DateTime.Now;

            //DateTime myStartTime = DateTime.Now;

            //myStartTime = new DateTime(myNow.Year, myNow.Month, myNow.Day, _startTime.Hour, _startTime.Minute, 0);

            //if (myStartTime < myNow)
            //{
            //    if (_comboboxIndex == 0)
            //    {
            //        myStartTime = DateTime.Now;
            //    }
            //    else
            //    {
            //        while (myStartTime > myNow)
            //        {
            //            myStartTime = myStartTime.AddMinutes(_loopMinute);
            //        }
            //    }
            //}
            //else
            //{
            //    myStartTime = _startTime;
            //}

            //myStartTime = myStartTime.AddMinutes(_loopMinute);

            //Console.WriteLine(myNow);
            //Console.WriteLine(myStartTime);
            #endregion


            Dictionary<int, test1> test = new Dictionary<int, test1>();



            test.Add(0, new test1 { name = "a", invoice = 1111, date = DateTime.Now, amt = 200 });
            test.Add(1, new test1 { name = "b", invoice = 1112, date = DateTime.Now, amt = 300 });
            test.Add(2, new test1 { name = "c", invoice = 1113, date = DateTime.Now, amt = 400 });
            test.Add(3, new test1 { name = "d", invoice = 1114, date = DateTime.Now, amt = 500 });

            string invoce = "";
            string date = DateTime.Now.AddDays(-1).ToString();
            string amt = default;
            string name = "";

            string result = "";

            for (int i = 0; i < test.Count; i++)
            {
                test1 test11 = test[i];
                name = test11.name + "\n";
                invoce = test11.invoice.ToString() + "\n";
                date = test11.date.ToString() + "\n";
                amt = test11.amt.ToString() + "\n";

                result += name + invoce + date + amt;

            }
            Console.WriteLine(result);

#if DEBUG
            Console.WriteLine("test");
#endif
            Console.ReadLine();
        }
    }
}
class test1
{
    public string name { get; set; }
    public int invoice { get; set; }
    public DateTime date { get; set; }
    public int amt { get; set; }
}
