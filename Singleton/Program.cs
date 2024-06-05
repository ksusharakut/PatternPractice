using Singleton;

President president1 = President.GetInstance();
President president2 = President.GetInstance();

if (president1 == president2)
{
    Console.WriteLine("Singleton pattern works, failed to create a second instance of the class, try again in 5 years");
}
else
{
    Console.WriteLine("the pattern didn't work");   
}