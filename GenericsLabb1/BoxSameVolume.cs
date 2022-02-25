using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericsLabb1
{
    public class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals([AllowNull] Box B1, [AllowNull] Box B2)
        {
            if (B1.Height == B2.Height && B1.Length == B2.Length && B1.Width == B2.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Box b)
        {
            var hCode = b.Height ^ b.Length ^ b.Width;
            Console.WriteLine("HC: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}
