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

            Console.WriteLine(decrypt("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb\r\n"));
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
