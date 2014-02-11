using System.Collections.Generic;
using Name.Characters.Common;

namespace Name.Environment
{
    public class Room
    {
        private HashSet<Element> elements;

        public Room()
        {
            
        }

        public HashSet<Element> Elements
        {
            get { return elements; }
            set { elements = value; }
        }
    }
}
