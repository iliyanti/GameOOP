using System.Collections.Generic;
using Name.Engine.Scripts.Characters.Common;

namespace Name.Engine.Scripts.Environment
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
