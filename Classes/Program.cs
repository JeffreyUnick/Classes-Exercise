namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Toyota",
                Model = "Rav 4",
                Year = 2023
            };
            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} {myCar.Year}");

        }
    }
}
