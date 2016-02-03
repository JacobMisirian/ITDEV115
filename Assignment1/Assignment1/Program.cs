using System;

namespace Assignment1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args.Length <= 0)
                new BaseBallPlayerUI().MainMethod(2);
            else
                new BaseBallPlayerUI().MainMethod(Convert.ToInt32(args[0]));
        }
    }
}
