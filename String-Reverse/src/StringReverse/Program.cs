using System;
using StringReverse.lib;

namespace Stringreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            StringUtility utils = new StringUtility();
            Console.WriteLine(utils.Reverse("Hello"));
        }
    }
}
