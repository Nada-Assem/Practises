using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Refree
    {
        public string Name { get; set; }

        public void Look(Location location) 
            => Console.WriteLine($"{this} is Looking at -> {location}") ;
        public override string ToString() => $"Refree Name: {Name}";
    }
}
