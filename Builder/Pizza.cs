using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        private List<string> _ingredients = new List<string>();

        public void AddIngredient(string ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public string ListIngredients()
        {
            // Преобразование списка в массив строк
            string[] ingredientsArray = _ingredients.ToArray();
            // Использование метода Join для объединения элементов массива в одну строку
            return $"Pizza ingredients: {string.Join(", ", ingredientsArray)}\n";
        }
    }
}
