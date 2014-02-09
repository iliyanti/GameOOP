namespace Game.Engine
{
    using System;

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
