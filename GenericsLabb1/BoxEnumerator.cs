using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsLabb1
{
    public class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection Boxes;
        private int curindex;
        private Box curbox;

        public BoxEnumerator(BoxCollection boxes)
        {
            this.Boxes = boxes;
            this.curindex = -1;
            this.curbox = default(Box);
        }
        public Box Current { get { return curbox; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (++curindex >= Boxes.Count)
            {
                return false;
            }
            else
            {
                curbox = Boxes[curindex];
                return true;
            }
        }

        public void Reset() { curindex = -1; }
    }
}
