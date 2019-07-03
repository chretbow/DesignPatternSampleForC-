using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.PersonDecorator
{
    /// <summary>
    /// ConcreteComponent
    /// </summary>
    class Person
    {
        private string name;

        public Person()
        {
        }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"裝扮的{name}");
        }
    }
}
