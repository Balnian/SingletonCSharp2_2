using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SingletonCSharp2_2
{
    sealed class Fichier
    {
        private static StreamWriter file = new StreamWriter("UnFichier.txt");

        static Fichier Instance =new Fichier();

        private Fichier()
        {

        }

        public static Fichier getInstance()
        {
           return Instance;
        }

        public void write(String str)
        {
            file.WriteLineAsync(str);
            file.Flush();
        }
    }
}
