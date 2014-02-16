using System;

namespace RPG.GameSystem
{
    public class ExceptionSample : Exception
    {
        public ExceptionSample() :
            base("Some string")
        {
            // do something
            // log to a file
        }
    }
}
