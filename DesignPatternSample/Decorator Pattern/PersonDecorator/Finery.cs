using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.PersonDecorator
{
    /// <summary>
    /// Decorator
    /// </summary>
    class Finery : Person
    {
        protected Person person;

        public void Decorate(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}
