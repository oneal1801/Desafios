using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
       
        string text = @"As the weeks went by, my interest in him and
            my curiosity as to his aims in life, gradually deepened and increased. His very person and appearance were such as to strike the attention of the most
            casual observer. In height he was rather over six
            feet, and so excessively lean that he seemed to be
            considerably taller. His eyes were sharp and piercing, save during those intervals of torpor to which I
            have alluded; and his thin, hawk-like nose gave his
            whole expression an air of alertness and decision.
            His chin, too, had the prominence and squareness
            which mark the man of determination. His hands
            were invariably blotted with ink and stained with
            chemicals, yet he was possessed of extraordinary
            delicacy of touch, as I frequently had occasion to observe when I watched him manipulating his fragile
            philosophical instruments.";

        char[] delimiters = new char[] {' ', '\r', '\n'};

        var Textplitted = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        text.ToCharArray();

        Console.WriteLine($"This paragraph has {Textplitted.Length} words");

        Dictionary<string, int> RepeatedWords = new Dictionary<string, int>();

        foreach (var word in Textplitted) {

            if (RepeatedWords.ContainsKey(word))
            {
                RepeatedWords[word] += 1;
            }
            else {
                RepeatedWords.Add(word,1);
            }

        }

        foreach (var item in RepeatedWords.ToList())
        {
            if (item.Value > 1)
            {
                Console.WriteLine($"la palabra se repite:{item.Key}: se repite: {item.Value}");
            }
        }





    }
}