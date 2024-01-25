using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    public class Complex
    {
        public int Real { get; set; }
        public int Image { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Image}i";
        }
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) + (Right?.Real??0),
                Image = (Left?.Image ?? 0) + (Right?.Image ?? 0)
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Image = (Left?.Image??0) - (Right?.Image ?? 0)
            };
        }

        public static Complex operator +(Complex Left, int Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) + Right ,
                Image = (Left?.Image ?? 0)
            };
        }

        public static Complex operator +(int Left, Complex Right)
        {
            return new Complex
            {
                Real = (Right?.Real ?? 0) + Left,
                Image = (Right?.Image ?? 0)
            };
        }

        public static Complex operator -(Complex Left, int Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) - Right,
                Image = (Left?.Image ?? 0)
            };
        }

        public static Complex operator -(int Left, Complex Right)
        {
            return new Complex
            {
                Real = (Right?.Real ?? 0) - Left,
                Image = (Right?.Image ?? 0)
            };
        }
        public static Complex operator ++(Complex complex)
        {
            return new Complex
            {
                Real = (complex?.Real ?? 0) + 1,
                Image = (complex?.Image ?? 0)
            };
        }
        public static Complex operator --(Complex complex)
        {
            return new Complex
            {
                Real = (complex?.Real ?? 0) - 1,
                Image = (complex?.Image ?? 0)
            };
        }
        public static bool operator ==(Complex left , Complex Right)
        {
            if (left.Real == Right.Real && left.Image == Right.Image)
                return true;
            return false;

        }
        public static bool operator !=(Complex left, Complex Right)
        {
            if (left.Real != Right.Real || left.Image != Right.Image)
                return true;
            return false;

        }
    }
}
