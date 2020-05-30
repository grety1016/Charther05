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
 
            //bob.FavoriteAncientWonder =  WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.BucketList = WondersOfTheAncientWorld. HangingGardensOfBabylon | WondersOfTheAncientWorld. MausoleumAtHalicarnassus;
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
                      
        }
    }
}
