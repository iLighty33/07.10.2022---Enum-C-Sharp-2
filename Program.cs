using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._10._2022___Enum_C_Sharp_2
{
    public class myDate
    {
        public int year { get; set; }
        private int myVar;
        public int MyProperty 
        {get 
            { return myVar; }
         set 
            {
                if (value >= 1970)
                {
                    year = value;
                }
                else
                {
                    year = 1970;
                }
             } 
        }


        //private int myVar;
        public int month
        {
            get
            { return month; }
            set
            {
                if (value > 0 | value <= 12)
                {
                    month = value;
                }
                else
                {
                    month = 1;
                }
            }
        }

        public int day
        {
            get
            { return day; }
            set
            {
                if (value > 0 | value <= DayOfMonthArr.month[this.month - 1])
                {
                    day = value;
                }
                else
                {
                    day = 1;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"{this.year}.{this.month}.{this.day}");
           // Console.WriteLine("{0}.{1}.{2}", this.year, this.month, this.day);
        }
    }
    class Program
    {
        static bool LeapYear()
        {
            bool _result = true;
            return _result;
        }
        static void Main(string[] args)
        {
            int startDay = 3; // 1970.1.1 day of week
                              // 2022.10.7

            var date = new myDate();
            try 
            {
                date.year = int.Parse(args[0].Split('.')[0].ToString());
                date.month = int.Parse(args[0].Split('.')[1].ToString());
                date.day = int.Parse(args[0].Split('.')[2].ToString());

                //for (int i = 0; i < 3; i++)
                //{
                //    //switch (i)
                //    //{
                //    //    case 0:
                //    //        date.year = int.Parse(args[0].Split('.').ToString());
                //    //        break;
                //    //    case 1:
                //    //        date.month = int.Parse(args[0].Split('.').ToString());
                //    //        break;
                //    //    case 2:
                //    //        date.day = int.Parse(args[0].Split('.').ToString());
                //    //        break;
                //    //    default:
                //    //        break;
                //    //}
                //    args[i].Split('.');
                //}
                //foreach (var item in args[0].Split('.'))
                //{
                //    Console.WriteLine(item);
                //}
                //Console.WriteLine(args[0].Split('.').ToString());
                //args[0];
            }
            catch (Exception)
            {
                Console.WriteLine("Операция не удалась"); ;
            }
            date.Print();
            Console.ReadKey();
            //Console.WriteLine("");
        }
    }
}
