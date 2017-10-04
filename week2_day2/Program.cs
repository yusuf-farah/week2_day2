using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 10; i++)
            //{
            //Console.Write(i);
            //}
            //    for (int counter= 50; counter<=100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}


            //string greetings = "my name is yusuf";
            //string[] words = greetings.Split();
            //for(int i = 0; i<greetings.Length-1; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            //for(int i =1; i<= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int counter= 50; counter<=100; counter++)
            //{
            //    Console.WriteLine (counter);
            //}

            //  string greeting = "my name is little yusuf";

            //Console.WriteLine("do you want to play the (yes or no");
            //string playAgain = Console.ReadLine();

            //while (playAgain=="yes")

            //{

            //    Console.WriteLine("it is a rematch!");
            //    Console.WriteLine("do you want to play again (YES/NO");
            //    playAgain = Console.ReadLine();
            //}


            Console.WriteLine("do you want to check in your appointment (YES/NO");
            string checkAppont = Console.ReadLine().ToUpper();
            while(checkAppont=="NO")
            {
                Console.WriteLine("patient check system");

                Console.WriteLine("what is your full name?");
                String fullName = Console.ReadLine().ToLower();
                Console.WriteLine("what is your 6-digit patient ID?");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("what time is your appointment?");
                checkAppont = Console.ReadLine();
                
            }

            string playAgain;
            do
            {
                Console.WriteLine("Do you want to play the game?(YES/NO)");
                Console.WriteLine("great game!");
                Console.WriteLine("Do you want to play again? (YES/NO)");
                playAgain = Console.ReadLine();
            }


            while (playAgain == "YES");
            Console.WriteLine("Thanks for playing you lost the game");





            }

        }

 
    }

