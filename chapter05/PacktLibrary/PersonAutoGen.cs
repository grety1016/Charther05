using System;

namespace Packt. Shared
{
    //Class Person 
    public partial class Person
    {
        //property Origin
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        //property Greting
        public string Greeting() => $"{Name} says 'Hello!'";

        //property Age
        public int Age => DateTime.Today.Year - DateOfBirth.Year;
    }


}