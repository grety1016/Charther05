using System;
using static System.Console;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
           
           
            //声明变量，初始化变化，输出变量信息。
            var bob = new Person();
            bob.Name = "Bob smith";
            bob.DateOfBirth = new DateTime(1965,12,22);
            WriteLine(format: "{0} was born on {1: dddd, d MMMM yyyy}",arg0: bob. Name,arg1: bob.DateOfBirth);
            //新增bob变量的FavoriteAncientWonder的值。 

            bob.Children.Add(new Person {Name = "Alfred"}) ;
            bob.Children.Add(new Person {Name = "Zoe"}) ;
            WriteLine($"{bob.Name} has {bob.Children.Count} children:") ;
            foreach(Person p1 in bob.Children)
            {
                WriteLine($"{p1.Name}");
            }
            // for (int child = 0; child < bob.Children.Count; child++)
            // {
            // WriteLine($" {bob.Children[child].Name}") ;
            // }
 
            //bob.FavoriteAncientWonder =  WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            WriteLine($"{bob. Name}' s bucket list is {bob. BucketList}");
     
            //输出
            WriteLine(format:"{0}'s FavoriteAncientWonder is {1},It's integer is {2}.",arg0:bob.Name,arg1:bob.FavoriteAncientWonder,arg2:(int)WondersOfTheAncientWorld.StatueOfZeusAtOlympia);
           
            //新增alice变量
            var alice = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1984,7,3)
            };

            WriteLine(format:"{0} was born on {1:dd MMM yy}",arg0:alice.Name,arg1:alice.DateOfBirth);
            BankAccount.InterestRate = 0.012M;
            
            
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs jones";
            jonesAccount.Balance = 2400M;
            WriteLine(format:"{0} earned {1:C} interest rate.",arg0 : jonesAccount.AccountName,arg1 : jonesAccount.Balance * BankAccount.InterestRate);

            var gerrierAccount = new  BankAccount();
            gerrierAccount.AccountName = "Mr gerrier";
            gerrierAccount.Balance = 98M;
            WriteLine(format: "{0} earned {1:C} interest rate.",arg0 : gerrierAccount.AccountName,arg1 : gerrierAccount.Balance * BankAccount.InterestRate);

            WriteLine($"{bob.Name} is a {Person.Species}");
            WriteLine($"{bob.Name}  was born in {bob.HomePlanet}");

            var blankPerson = new Person();

            WriteLine(format:"{0} of {1} was create at {2:hh:mm:ss} on a {2:dddd}.",arg0:blankPerson.Name,arg1 :blankPerson.HomePlanet,arg2:blankPerson.Instantiated);

            var gunny = new Person("gunny","Mars");

            WriteLine(format:"{0} of {1} was create at {2:hh:mm:ss} on a {2:dddd}.",arg0:gunny.Name,arg1:gunny.HomePlanet,arg2:gunny.Instantiated);

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());
            
            (string Name,int Number) fruit = bob.GetFruit();
            WriteLine($"There are {fruit.Number} {fruit.Name}.");

        }
    }
}
