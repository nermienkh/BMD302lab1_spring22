using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoredConsole;

namespace ConsoleApp2
{
    enum WeekDays {Sat,Sund }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine( "Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            
            ColorConsole.WriteLine("Heeloo".Red());


            List<string> ayhaga = new List<string>() {"K","lm","m" };

            List<NeDataTypeX> neDataTypeXes = new List<NeDataTypeX>();


            neDataTypeXes.Add(new NeDataTypeX() {  value=5,xvalue="", WeekDays= WeekDays.Sund});

            var c =ayhaga.Select(x => x == "lm").First();

            ayhaga.Select(x => x == "lm").First();

             Console.ReadKey();
        }


    }
}
