using System;

namespace GenericsLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxCollection box = new BoxCollection();
            box.Add(new Box(3, 6, 2));
            box.Add(new Box(8, 5, 7));
            box.Add(new Box(1, 1, 1));
            box.Add(new Box(9, 10, 12));
            box.Add(new Box(4, 11, 9));

            box.Add(new Box(4, 11, 9));
            Display(box);

            Console.WriteLine("\nDoes the object 1x1x1 exist in the list? " + box.Contains(new Box(1, 1, 1)));

            Console.WriteLine("\nRemoving 3x6x2 from the list.");
            box.Remove(new Box(3, 6, 2));
            Display(box);

            Console.ReadKey();
        }
        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("\nHeight\tLength\tWidth\tHashcode");
            foreach (Box item in boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    item.Height, item.Length, item.Width, item.GetHashCode());
            }
        }
    }
}
