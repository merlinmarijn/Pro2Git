using System;

namespace WhatsMyName
{
    class Program
    {
      static string name;
      static string age;
      static string eyecolor;
      static string codewoonplaats;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello my name is WALLE, Whats your name?");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Well hi there " + name + " how old are you?");
            age = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("ahh i see, if i may what color of eyes do you have?");
            eyecolor = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("and what is your postal code and residence?");
            codewoonplaats = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Well hi there "+name+" i heard you are "+age+" years old and you live at "+codewoonplaats+" and you have "+eyecolor+" eyes");
        }
    }
}
