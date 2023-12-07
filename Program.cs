using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodina9Zvirata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zviratko>zoo = new List<Zviratko>();
            Krajta had = new Krajta("Hadicka", 3);
            Console.WriteLine(had.OzviSe());
            zoo.Add(had);   
            foreach (Zviratko zviratko in zoo)
            {
                Console.WriteLine(zviratko.OzviSe());
            }
        }
    }
}
