using System;
using System.Collections.Generic;

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


    }
}
