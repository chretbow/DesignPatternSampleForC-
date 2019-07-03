using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.PersonDecorator
{
    /// <summary>
    /// ConcreteDecorator
    /// </summary>
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T薛 ");
            base.Show();
        }
    }
}
