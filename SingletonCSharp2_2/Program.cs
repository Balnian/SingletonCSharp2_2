using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonCSharp2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fichier f = Fichier.getInstance();
            f.write("dfdfdfdfdfssdf");
        }
    }
}
