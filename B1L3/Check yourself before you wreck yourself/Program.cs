using System;

namespace Check_yourself_before_you_wreck_yourself
{
    class Program
    {
      static int incval = 0;
      static int decval = 0;
      static int check;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Clear();
            add1();
        }

        static void add1(){
          incval+=1;
          add2();
        }
        static void add2(){
          incval++;
          add3();
        }
        static void add3(){
          ++incval;
          dec1();
        }
        static void dec1(){
          decval-=1;
          dec2();
        }
        static void dec2(){
          decval--;
          dec3();
        }
        static void dec3(){
          --decval;
          Sum();
        }

        static void Sum(){
          Console.WriteLine("Num A is: "+incval);
          Console.WriteLine("Num B is: "+decval);
          if (incval==3 && decval==-3){
            Console.WriteLine("Waardes A en B zijn correct");
          } else if (incval==3 && decval!=-3){
            Console.WriteLine("Alleen variable A is correct");
          } else if (incval!=3 && decval!=-3){
            Console.WriteLine("Alleen variable B is correct");
          } else if (incval!=3 && decval!=-3){
            Console.WriteLine("Geen van de variable zijn correct");
          }
        }
    }
}
