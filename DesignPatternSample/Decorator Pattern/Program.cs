﻿using DecoratorPattern.Decorator;
using DecoratorPattern.PersonDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();

            //Console.Read();

            Person xc = new Person("阿龍");
            Console.WriteLine("第一種裝扮:");

            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();

            kk.Decorate(xc);
            dtx.Decorate(kk);
            dtx.Show();

            Console.Read();
        }
    }
}
