using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString() => $"Location => {X} , {Y} , {Z}";

        public static bool operator ==(Location Left, Location Right)
        => Left.Equals(Right);

        public static bool operator !=(Location Left, Location Right)
        => !Left.Equals(Right);
    }
}
