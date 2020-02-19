using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    static class RastgeleSayiUret
    {
        public static Random rnd = new Random();
        public static int Uret(int a,int b)
        {
            return rnd.Next(a,b);
        }
    }
}
