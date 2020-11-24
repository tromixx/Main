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




using System;
using System.Collections.Generic;
using System.Text;

namespace One
{
    class AnimalIDInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No Owner";
    }
}



using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace One
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrr";

        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound 2")
            :base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace One
{
    class Animal
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} had the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {sound}");
        }

        public Animal()
            : this("No Name", "No Sound") { }

        public Animal(string name)
            :this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    name = "No Sound";
                }
                name = value;
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }

    }
}


