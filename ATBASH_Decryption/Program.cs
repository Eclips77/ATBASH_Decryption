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
         
                
    }
}
