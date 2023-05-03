using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many different animals will you enter? ");
            int animalCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < animalCount; i++)
            {
                var animal = new Animal();
                // Printing the result to the screen
                Console.WriteLine("Answer for " + animal.Name + " : " + animal.CalculateNuts());
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
