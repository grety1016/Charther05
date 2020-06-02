using System;

namespace Packt.Shared
{
    //Class Person 
    public partial class Person
    {
        //property Origin
       // a property defined using C# 1 - 5 syntax
            public string Origin
            {
                get
                {
                    return $"{Name} was born on {HomePlanet}";
                }
            }
            
            public string Greeting => $"{Name} says ' Hello! ' ";
            public int Age => System. DateTime. Today. Year -
            DateOfBirth. Year;
    }


}