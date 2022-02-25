using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsLabb1
{
    public class BoxCollection : ICollection<Box>
    {
        private List<Box> BoxList;
        public BoxCollection()
        {
            BoxList = new List<Box>();
        }
        public int Count { get { return BoxList.Count; } }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                BoxList.Add(item);
            }
            else
            {
                Console.WriteLine("The box with the dimentions {0}x{1}x{2} exists already.",
                    item.Height, item.Length, item.Width);
            }
        }

        public void Clear()
        {
            BoxList.Clear();
        }

        public bool Contains(Box item)
        {
            bool result = false;
            foreach (Box b in BoxList)
            {
                if (b.Equals(item))
                {
                    result = true;
                }
            }
            return result;
        }

        public bool Contains(Box item, EqualityComparer<Box> ec)
        {
            bool result = false;
            foreach (Box b in BoxList)
            {
                if (ec.Equals(b, item))
                {
                    result = true;
                }
            }
            return result;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array cannot be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArithmeticException("The destination array has fewer elements than the collection.");
            }
        }
        public bool Remove(Box item)
        {
            bool result = false;
            for (int i = 0; i < BoxList.Count; i++)
            {
                Box curBox = BoxList[i];
                if (new BoxSameDimensions().Equals(item, curBox))
                {
                    BoxList.RemoveAt(i);
                    result = true;
                }
            }
            return result;
        }

        public Box this[int index]
        {
            get { return (Box)BoxList[index]; }
            set { BoxList[index] = value; }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
