using System;

namespace WIRWAR
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Clear();
            Console.WriteLine("Goedemorgen wie ben jij eigenlijk?");
            Console.WriteLine("Wat is je naam?");
            string name = Console.ReadLine().ToLower();

            if(name == "erwin"){
                Console.WriteLine("goedemorgen Erwin!");
            }else if(name == "erik"){
                Console.WriteLine("goedemorgen Erik");}
            else if(name=="alex"){
              Console.WriteLine("Goedemorgen Alex");
            }

            }
        }
    }
