using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodina9Zvirata
{
    internal class Had : Zviratko
    {
        public Had(string jmeno) : base(jmeno)
        {
        }
        public override string OzviSe()
        {
            return base.OzviSe() + "ssssssssss";
        }
    }
}
