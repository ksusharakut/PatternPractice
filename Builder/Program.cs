using Builder;

var director = new Director();
var builder = new PizzaBuilder();

director.Builder = builder;

Console.WriteLine("Standard basic pizza:");
director.BuildBasicPizza();
Console.WriteLine(builder.GetPizza().ListIngredients());

Console.WriteLine("Full featured pizza:");
director.BuildFullFituredPizza();
Console.WriteLine(builder.GetPizza().ListIngredients());

// Custom pizza example
Console.WriteLine("Custom pizza:");
builder.AddDough();
builder.AddCheese();
builder.AddSauce();
builder.AddMeat();
Console.WriteLine(builder.GetPizza().ListIngredients());