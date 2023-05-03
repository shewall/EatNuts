using System;
namespace consoleapp
{
    public class Animal
    {
        public string Name { get; }
        public double AnimalCount { get; }
        public double NutCount { get; }
        public double FeedingTime { get; }
        public double SecondPerNut { get; }

        public Animal()
        {
            Console.WriteLine("First you will enter the animal's attributes.");
            //  Getting the name attribute : sincap
            Console.WriteLine("Enter animal name");
            Name = Console.ReadLine();
            //  Obtaining animal quantity attribute  : 1.5
            Console.WriteLine("Enter animal count");
            AnimalCount = Convert.ToDouble(Console.ReadLine());
            //  Obtaining hazelnut quantity quality : 1.5
            Console.WriteLine("Enter nut count");
            NutCount = Convert.ToDouble(Console.ReadLine());
            //  Fındıkların yenme süresinin alınması : 90seconds
            Console.WriteLine("Enter feeding time");
            FeedingTime = Convert.ToDouble(Console.ReadLine());
            // Calculating the time it takes a soldering iron to eat a nut
            SecondPerNut = FeedingTime / (NutCount / AnimalCount);
        }

        // Calculation of the number of hazelnuts eaten by the given animal within the given time
        public double CalculateNuts()
        {
            // Getting the given time in minutes from the console
            Console.WriteLine("Enter the total time in minute version of the" + Name + "'s feeding time:");
            // Converting the given time to seconds
            double givenFeedingTime = double.Parse(Console.ReadLine()) * 60;
            // Receiving the total number of animals
            Console.WriteLine("Enter the total animal count:");
            double givenAnimalCount = double.Parse(Console.ReadLine());
            // Calculation of the total number of nuts eaten
            return givenAnimalCount * (givenFeedingTime / SecondPerNut);
        }
    }
}
