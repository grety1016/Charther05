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
            (string Name,int Number) = bob.GetFruit();
            
            WriteLine($"There are {fruit.Number} {fruit.Name}.");
            WriteLine($"Deconstructed: {Name},{Number}");

            var thing1 = ("Neville", 4) ;
            WriteLine($"{thing1.Item1} has {thing1.Item2} children. ") ;
            var thing2 = (bob.Name, bob.Children.Count) ;
            WriteLine($"{thing2.Name} has {thing2.Count} children. ") ;

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("Emily"));

            WriteLine(bob.OptionalParameters());
            WriteLine(bob.OptionalParameters("jump",98.5));
            WriteLine(bob.OptionalParameters(number:52.9,command:"Hide!"));
            WriteLine(bob.OptionalParameters("Poke!",active:true));

            int a = 10,b = 20, c = 30;
            WriteLine("a = {0},b = {1},c = {2},",a,b,c);
            bob.PassingParameters(a,ref b,out c);            
            WriteLine("a = {0},b = {1},c = {2},",a,b,c);

            int d = 10,e = 20;            
            WriteLine($"Before: d = {d}, e = {e}, f doesn' t exist yet! ") ;
            // simplified C# 7. 0 syntax for the out parameter
            bob. PassingParameters(d, ref e, out int f) ;
            WriteLine($"After: d = {d}, e = {e}, f = {f}") ;

           
            var sam = new Person
            {
            Name = "Sam",
            DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);
             

        }
    }
}
