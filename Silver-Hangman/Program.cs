using System;

namespace Silver_Hangman
{
    class Program
    {
      static string[] words = new string[10];
      static int RandomNum;
      static string CurrentWord;
      static string HiddenWord;
      static string viewedword;
      static string Letter;
      static string LettersTried;
      static string Message;
      static string LetterPos;
      static int Lives;
        static void Main(string[] args)
        {
          Console.Clear();
          words[0]="school";
          words[1]="patat";
          words[2]="huiswerk";
          words[3]="gamen";
          words[4]="nederland";
          words[5]="aardappel";
          words[6]="gek";
          words[7]="computer";
          words[8]="lamp";
          words[9]="auto";
          Start();
        }

        static void Start(){
          var random = new Random();
          var text = random.Next(0,9);
          RandomNum = random.Next(0,9);
          CurrentWord = words[RandomNum];
          Lives=5;
          HiddenWord=null;
          viewedword=null;
          Message=null;
          LettersTried=null;
          Letter=null;
          InstructionScreen();
        }

        static void InstructionScreen(){
          Console.WriteLine("##############################################################");
          Console.WriteLine("#A random word will be selected,                             #");
          Console.WriteLine("#You have to guess the letters that are contained in the word#");
          Console.WriteLine("#you have 5 lives to win                                     #");
          Console.WriteLine("##############################################################");
          Console.WriteLine("#to exit yourself type in 'quit/exit or stop' to quit out of #");
          Console.WriteLine("#the game                                                    #");
          Console.WriteLine("##############################################################");
          Console.WriteLine("Press Enter to start the game");
          Console.ReadLine();
          GenerateHiddenWord();
        }

        static void GenerateHiddenWord(){
          Console.Clear();
          for (int i=0;i<CurrentWord.Length; i++){
                      viewedword+="_";
          }
          WaitForinput(Message);
        }


        static void WaitForinput(string message){
          Message=null;
          //Console.WriteLine("this is the letter he sees "+Letter);
          if (Lives==0){
            Lose();
            return;
          }
          if (LettersTried!=null){
            viewedword=CurrentWord;
            foreach (char item in CurrentWord){
            if (LettersTried.Contains(item)){
              HiddenWord+=item;
            } else {HiddenWord+="_";}
          }
          viewedword=HiddenWord;
          HiddenWord=null;
          if(!viewedword.Contains("_")){
            Won();
            return;
          }
          }
          Console.WriteLine(viewedword);
          Console.WriteLine("Current Lives: "+Lives);
          Console.WriteLine(LettersTried);
          Console.WriteLine(message);
          Letter = Console.ReadLine().ToLower();
          Console.WriteLine(Letter);
          if (Letter=="quit"||Letter=="exit"||Letter=="stop"){
            Console.Clear();
            Environment.Exit(-1);
          }
          if(LettersTried==null){
            if(!CurrentWord.Contains(Letter)){
              if(Letter.Length!=1){
                Message="Only 1 letter per try";
              } else {LoseHealth();}
            }
          }
          if(LettersTried!=null){
            if(!LettersTried.Contains(Letter)){
              Console.WriteLine("DIDNT CONTAIN");
              Message="";
              if(Letter.Length==1){LettersTried+=Letter;if(!CurrentWord.Contains(Letter)){
                LoseHealth();
                Console.WriteLine("DEBUG");
                }} else {Message="Only 1 letter per try";}
              //LettersTried+=Letter;
            } else {Message="Already tried: " +Letter;}
          } else {if(Letter.Length==1){LettersTried+=Letter;} else {Console.WriteLine("Only 1 letter per try");}}
          Console.Clear();
          WaitForinput(Message);
        }
        static void LoseHealth(){
          Lives-=1;
        }
        static void Won(){
          Console.Clear();
          Console.WriteLine("You've Won!!!!");
          Console.WriteLine("The word was: "+CurrentWord);
          Console.WriteLine("Want to restart? Y/N");
          var choice1 = Console.ReadLine().ToLower();
          if (choice1=="y"){
            Console.Clear();
            Start();
          } else {
            if(choice1=="n"){
              Console.Clear();
              Environment.Exit(-1);
            }
          }
        }
        static void Lose(){
          Console.WriteLine("########################");
          Console.WriteLine("You've lost");
          Console.WriteLine("The word was: "+CurrentWord);
          Console.WriteLine("########################");
          Console.WriteLine("Want to restart? Y/N");
          var choice2 = Console.ReadLine().ToLower();
          if (choice2=="y"){
            Console.Clear();
            Start();
          } else {
            if(choice2=="n"){
              Console.Clear();
              Environment.Exit(-1);
            }
          }
        }
    }
}
