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
            public int Age => System. DateTime. Today. Year -  DateOfBirth. Year;


            //property FavoriteIceCream
            public string FavoriteIceCream { get;set; }

            //Property FavoritePrimaryColor
            private string favoritePrimaryColor;
            public string FavoritePrimaryColor
            {
                get
                {
                    return favoritePrimaryColor;
                }

                set
                {
                    switch(value.ToLower())
                    {
                        case "red":
                        case "green":
                        case "blue":
                            this.favoritePrimaryColor = value;
                            break;
                        default:
                            throw new System.ArgumentException(
                                $"{value} is not primary color." 
                                +"choose from 'red','green','blue'.");
                    }
                }
            }



            //Create Indexers
            public Person this[int index]
            {
                get
                {
                    return Children[index];
                }
                set
                {
                    Children[index] = value;
                }
            }

           
     }


}