using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PizzaBuilder : IBuilder
    {
        private Pizza _pizza = new Pizza();
        public void AddDough()
        {
            _pizza.AddIngredient("Dough");
        }
        public void AddCheese()
        {
            _pizza.AddIngredient("Mozzarella");
        }
        public void AddSauce()
        {
            _pizza.AddIngredient("Tomato Sauce");
        }
        public void AddMeat()
        {
            _pizza.AddIngredient("Bekon");
        }
        public void AddToppings()
        {
            _pizza.AddIngredient("Olives");
            _pizza.AddIngredient("Tomatoes");
        }
        public Pizza GetPizza()
        {
            return _pizza;
        }
    }  
}
