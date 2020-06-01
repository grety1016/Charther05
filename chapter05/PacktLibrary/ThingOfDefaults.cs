using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingOfDefaults
    {
        public int Population; 
        public DateTime When;
        public string Name;
        public List<Person> Peopel;

        public ThingOfDefaults()
        {
            Population = default;

            When = default;

            Name = default;

            Peopel = default;

        }

    }
}