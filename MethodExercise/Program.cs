using System;

namespace Method_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Zach";
            string lastName = "Haggerty";
            string favoriteColor = "Blue";
            string favoriteAnimal = "Jaguar";
            string favoriteArtist = "Chris Brown";
            string name = $"My name is {firstName} {lastName}";
            string Color = $" my favorite color is {favoriteColor},";
            string Animal = $" my favorite animal is a {favoriteAnimal},";
            string Artist = $" and lastly my favorite music artist is {favoriteArtist}.";
            Console.WriteLine(name + Color + Animal + Artist);

            Add();
            Subtract();
            Multiply();
            Divide();
            Modulus();
          

        }
        static void Add()
        {
            Console.WriteLine(2 + 4);
            Console.ReadLine();
            Console.WriteLine(2 + 4 + 6);
            Console.ReadLine();
            Console.WriteLine(1 + 1 + 1 + 1 + 1);
            Console.ReadLine();
            

        }
        static void Subtract()
        {
            Console.WriteLine(6 - 4);
            Console.ReadLine();
            Console.WriteLine(6 - 4 - 2);
            Console.ReadLine();
        }
        static void Multiply()
        {
            Console.WriteLine(2 * 4);
            Console.ReadLine();
            Console.WriteLine(2 * 4 * 6);
            Console.ReadLine();
        }
        static void Divide()
        {
            Console.WriteLine(6 / 4);
            Console.ReadLine();
            Console.WriteLine(6 / 4 / 2);
            Console.ReadLine();
        }
        static void Modulus()
        {
            int a = 4;
            int b = 3;
            Console.WriteLine(a % b);
            Console.ReadLine();

        }

    }
}    