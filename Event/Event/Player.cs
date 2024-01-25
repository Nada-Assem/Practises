using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Event
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }

        public void Running(Location location) => Console.WriteLine($"{this} is Running towords -> {location} ");
        
        public override string ToString() => $"{Name}";
    
    }
}
