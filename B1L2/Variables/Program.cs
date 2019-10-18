using System;

namespace B1L2
{
    class Program
    {
        static char[] character = new char[1];
        static float floater = 1.5f;
        static bool Bool1 = true;
        static bool Bool2;

        static int integer1 = 15;
        static int integer2 = 7;
        static int integer3;

        static string Text = "Hello ";
        static string Text2 = "World";
        static string Text3;
        static void Main(string[] args)
        {
            character[0] = 'a';
            Bool2 = Bool1;
            integer3 = integer1 - integer2;
            Text3 = Text + Text2;
            Console.WriteLine(character);
            Console.WriteLine(floater);
            Console.WriteLine(Bool2);
            Console.WriteLine(integer3);
            Console.WriteLine(Text3);
        }
    }
}
