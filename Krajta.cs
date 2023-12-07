using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodina9Zvirata
{
    internal class Krajta : Had
    {
        public  readonly int  delka;
        public Krajta(string jmeno) : base(jmeno)
        {
            Console.WriteLine(delka);
            delka = 5;
            Console.WriteLine(delka);

        }
        public Krajta (string jmeno, int delka):this(jmeno)
        {
            Console.WriteLine(delka);
        }
        public override string OzviSe()
        {
            return "Aj ta krajta"+base.OzviSe();
        }
    }
}
