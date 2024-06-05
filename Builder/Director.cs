using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildBasicPizza()
        {
            _builder.AddDough();
            _builder.AddCheese();
            _builder.AddSauce();
        }

        public void BuildFullFituredPizza()
        {
            _builder.AddDough();
            _builder.AddCheese();
            _builder.AddSauce();
            _builder.AddMeat();
            _builder.AddToppings();
        }
    }
}
