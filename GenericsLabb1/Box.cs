using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericsLabb1
{
    public class Box : IEquatable<Box>
    {
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public Box (int height, int length, int width)
        {
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }
        public bool Equals([AllowNull] Box other)
        {
            if (new BoxSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
