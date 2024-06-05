using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void AddDough(); 
        void AddSauce();
        void AddCheese(); 
        void AddMeat();
        void AddToppings();
    }
}
