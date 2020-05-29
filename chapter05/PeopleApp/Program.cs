﻿using System;
using static System.Console;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            var bob = new Person();
            bob.Name = "Bob smith";
            bob.DateOfBirth = new DateTime(1965,12,22);
            WriteLine(format: "{0} was born on {1: dddd, d MMMM yyyy}",arg0: bob. Name,arg1: bob.DateOfBirth);
            bob.FavoriteAncientWonder =  WondersOfTheAncientWorld.StatueOfZeusAtOlympia; 

            WriteLine(format:"{0}'s FavoriteAncientWonder is {1},It's integer is {2}.",arg0:bob.Name,arg1:bob.FavoriteAncientWonder,arg2:(int)WondersOfTheAncientWorld.StatueOfZeusAtOlympia);
            

            

           var alice = new Person()
           {
               Name = "Alice Jones",
               DateOfBirth = new DateTime(1984,7,3)

           };

           WriteLine(format:"{0} was born on {1:dd MMM yy}",arg0:alice.Name,arg1:alice.DateOfBirth);
                      
        }
    }
}