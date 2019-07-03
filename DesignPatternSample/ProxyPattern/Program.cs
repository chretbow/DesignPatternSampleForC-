using ProxyPattern.GiftProxy;
//using ProxyPattern.ProxyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proxy proxy = new Proxy();
            //proxy.Request();

            //Console.Read();

            SchoolGirl along = new SchoolGirl();
            along.Name = "阿龍";

            Proxy daili = new Proxy(along);

            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();

            Console.Read();
        }
    }
}
