using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "10:00|16:58";
            string startTime = test.Substring(0, 5);
            string endTime = test.Substring(6, 5);

            Console.WriteLine(DateTime.Now.ToString("HH:mm"));

            TimeSpan hourMinute = DateTime.Now.TimeOfDay;

            TimeSpan sTime = TimeSpan.Parse(startTime);
            TimeSpan eTime = TimeSpan.Parse(endTime);

            Console.WriteLine(hourMinute);

            if(hourMinute >= sTime && hourMinute <= eTime)
            {
                Console.WriteLine("Start Time:"+sTime);
                Console.WriteLine("End Time:"+eTime);
                Console.WriteLine("Time is "+hourMinute+" and it is valid to run the serivce");
            }
            else
            {
                Console.WriteLine("Service is idle");
                Console.WriteLine("Testing the changes commit");
                Console.WriteLine("new branch test");
                Console.WriteLine("Testing new cmmit");
            }

        }
    }
}
