using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodina9Zvirata
{
    internal abstract class Zviratko
    {
        public readonly string Jmeno;
        public Zviratko(string jmeno)
        {
            Jmeno = jmeno;
            
        }
        public virtual string OzviSe()
        {
            return "Zdar!";
        }
    }
}
