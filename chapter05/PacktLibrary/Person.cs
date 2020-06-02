using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person:object
    {

        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated; 

        public Person()
        {
            Name = "Unknow";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName,string homePlanet)
        {
            Name = initialName;

            HomePlanet = homePlanet;

            Instantiated = DateTime.Now;
        }
        public const string Species = "Homo Sapien";
        public List<Person> Children = new List<Person>();
           
        public string Name;
        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public WondersOfTheAncientWorld BucketList; 

        public void WriteToConsole()
        {            
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
           return   $"{Name} was born on {HomePlanet}.";
        }

        public (string Name,int Number) GetFruit()
        {
            return(Name : "Apple",Number : 5);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello！'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello!{name}!'";
        }

    }
}
