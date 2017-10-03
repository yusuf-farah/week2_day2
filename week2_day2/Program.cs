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
            //string[] words = greeting.Split();
            //for(int i= 0; i<words.Length; i ++)
            //{
            //    Console.WriteLine(words[i]);
            //}
            /* Create an array called days with the elements Monday, Tuesday, and Wednesday. Using a For Loop, print the elements of the days array*/

            //String[] daysOfWeek = { "monday", "Tuesday", "Wednesday" };

            //for(int i= 0; i< daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine(daysOfWeek[i]);
            //}

            //string[] months = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct",  };

            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            //string[] bands = { "new", "the fleix culpa", "twice" };
            //foreach(string name in bands)
            //{
            //    Console.WriteLine(name);
            //}

            /*Write a program that takes your favorite foods and prints them out one at a time. (Use a foreach loop*/

            String[] favoriteFood = { "rice", "pasta", "chiken wings", "pitza", "pritzels", };
            foreach(string food in favoriteFood)
            {
                Console.WriteLine(food);
            }
            int[] luckyNumber = { 3, 5, 7, 11, 13 };
            foreach(int luckynum in luckyNumber)

            {
                Console.WriteLine(luckynum);
            }
        }
    }
}
