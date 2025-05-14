using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH_Decryption
{
    internal class Program
    {

        static void Main(string[] args)
        {   
            string input = Console.ReadLine();
            Console.WriteLine(CheckForDanger(input));
        }


        static char getAtBash(char c)
        {
            int allChars = ((int)'a') + ((int)'z');
            int newC = allChars - (int)c;
            return (char)newC;
        }



        static string decrypt(string str)
        {
            string decreptedMassege = "";
            char bashC;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    bashC = getAtBash(char.ToLower(c));
                    if (char.ToUpper(c) == c)
                    {
                        decreptedMassege += char.ToUpper(bashC);
                    }
                    else
                    {
                        decreptedMassege += bashC;
                    }
                }
                else
                {
                    decreptedMassege += c;
                }
                
            }
            return decreptedMassege;
        }
        static int CheckForDanger(string str)
        {
            string[] DangersWords = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            string[] massage = str.Split(' ');
            int pointsCounter = 0;
            foreach (string word in massage)
            {
                if (DangersWords.Contains(word.ToLower()))
                
                    pointsCounter++;
                
            }
            return pointsCounter;
        }

        static string GetWarning(int points)
        {
            string Warning = "";
            if (points > 10)
            {
                Warning = "ULTRA ALERT!";
            }
            else if (points > 5)
            {
                Warning = "DANGER";
            }
            else
            {
                Warning = "WARNING";
            }
            return Warning;
        }


    }
}
