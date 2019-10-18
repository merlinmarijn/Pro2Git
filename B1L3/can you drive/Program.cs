using System;

namespace can_you_drive
{
    class Program
    {
      static int age;
      static string naam;
      static bool rijbewijsauto;
      static bool rijbewijsscooter;
        static void Main()
        {
          Console.Clear();
          //vraag voor naam
            Console.WriteLine("Hallo, Wat is je naam?");
            naam = Console.ReadLine();
            Console.Clear();
            //vraag voor leeftijd
            Console.WriteLine("Hoe oud ben je?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //als je 18 bent vraag of je een auto/scooter rijbewijs al hebt of niet
            if (age>=18){
              Console.WriteLine("heb je een auto rijbewijs?");
              if (Console.ReadLine().ToLower()=="y"){
                rijbewijsauto=true;
              } else {rijbewijsauto=false;}
              Console.Clear();
              Console.WriteLine("heb je een scooter rijbewijs?");
              if (Console.ReadLine().ToLower()=="y"){
                rijbewijsscooter=true;
              } else {rijbewijsscooter=false;}
              //als je 16 bent vraag of je een scooter rijbewijs al hebt of niet
            } else if (age>=16){
              Console.WriteLine("heb je een scooter rijbewijs?");
              if (Console.ReadLine().ToLower()=="y"){
                rijbewijsscooter=true;
              } else {rijbewijsscooter=false;}
            }
            Console.Clear();
            //check leeftijd om de correcte response te geven
            if (age>=18){
              if (rijbewijsauto==true){
                Console.WriteLine("Je hebt een auto rijbewijs en mag rijden");
              } else {Console.WriteLine("Je mag een auto rijbewijs halen");}
              if (rijbewijsscooter==true){
                Console.WriteLine("Je hebt een scooter rijbewijs en mag rijden");
              } else {Console.WriteLine("Je mag een scooter rijbewijs halen");}
            } else if (age>=16){
              Console.WriteLine("Je hebt een scooter rijbewijs en mag rijden");
            }else {Console.WriteLine("Je mag een scooter rijbewijs halen");}
        }
    }
}
