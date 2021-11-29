using System;
using System.Linq;

namespace SpinWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed
            // (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than
            // one word is present.

            // Examples:

            //spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
            // spinWords( "This is a test") => returns "This is a test" 
            // spinWords( "This is another test" )=> returns "This is rehtona test"

            //This is the first option!

            string challenge = @"Write a function that takes in a string of one or more words, and returns the same string, 
            but with all five or more letter words reversed Strings passed in will consist of only letters and spaces. 
            Spaces will be included only when more than one word is present.";            

            Console.WriteLine(challenge);

            Console.WriteLine("==============================================================");
            Console.WriteLine('\n');

            string globaltext = "This is another test from my challenge section";

            static string SpinWords(string sentence) => string.Join(" ", sentence.Split().Select(RotateIfLongerOrEqualTo5));

            static string RotateIfLongerOrEqualTo5(string word) => word.Length >= 5 ? Reverse(word) : word;

            static string Reverse(string s) => new string(s.Reverse().ToArray());
            
            var backwords = SpinWords(globaltext);
            Console.WriteLine("this is from function #1: ===> " + backwords);

            Console.WriteLine("==============================================================");

            //This is the second way to solve it

            static string SpinWords2(string sentence)
            {
                string[] words = sentence.Split();

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length >= 5)
                    {
                        words[i] = new string(words[i].Reverse().ToArray());
                    }
                }

                return string.Join(" ", words);
            }

            var backwords2 = SpinWords2(globaltext);
            Console.WriteLine("This is from function #2 ===> " + backwords2);

            Console.WriteLine("==============================================================");

            //This is the 3rd way to solve it
            static string SpinWords3(string sentence)
            {
                string NewText = "";
                var arrayText = sentence.Split(' ');

                for (int i = 0; i < arrayText.Length; i++)
                {
                    char[] array = arrayText[i].ToCharArray();

                    if (array.Length >= 5)
                    {
                        Array.Reverse(array);
                        var reverseText = new string(array);
                        NewText = NewText + " " + reverseText;
                    }
                    else
                    {
                        NewText = NewText + " " + arrayText[i];
                    }

                }
                return NewText.Trim();
            }

            var backwords3 = SpinWords3(globaltext);
            Console.WriteLine("this is from function #3 ===> "+ backwords3);

        }
    }
}
