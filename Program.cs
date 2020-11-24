using System;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whisky = new Animal()
            {
                Name = "Whisky",
                Sound = "Miow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Meeeh",
                Sound2 = "Grrr"
            };

            grover.Sound = "Wooooof";

            whisky.MakeSound();
            grover.MakeSound();

            whisky.SetAnimalIDInfo(1234, "Sally Smith");

            whisky.GetAnimalIDInfo();

            Console.ReadLine();
        }
    }
}
