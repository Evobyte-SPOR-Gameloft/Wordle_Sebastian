using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    class Program
    {
        
        //public int cuvinte;
        
        static void Main(string[] args)
        {
            List<string> ListaCuvinte = new List<string>();
            List<char> CuvantTemp = new List<char>();
            List<char> CuvantDeGhicit = new List<char>();
            List<char> CuvantDeReferinta = new List<char>();


            int sanse = 6;
            Text t1 = new Text();
            ListaCuvinte=t1.transferInLista();         
            string guessWord=t1.Aero();

            WordAnalyzer wa = new WordAnalyzer();
            Console.WriteLine("Cheats on: "+guessWord);

            
            Console.WriteLine("Hi there, you have 6 tries. If a character is coloured green, that means it's position is correct. If Red, it's a different position. If it's white, that means it's not part of the word\n") ;

            while (sanse !=0)
            {
                Console.WriteLine("Chances: " + sanse);
                Console.WriteLine("\nEnter a 5 characters word\n");
                Console.WriteLine("_____\n");

                CuvantTemp.Clear();//resets the list for the new input
                var temp = Console.ReadLine();
                

                
                CuvantDeGhicit = guessWord.ToList();
                
                CuvantTemp = wa.Lyzer(temp);


                if (ListaCuvinte.Contains(temp))
                {
                    if(temp==guessWord)
                    {
                        Console.WriteLine("\nCongrats");
                        sanse = 1;
                    }

                    sanse--;


                    for (int x = 0; x < CuvantDeGhicit.Count; x++)
                    {
                        if (CuvantDeGhicit[x] == CuvantTemp[x])
                        {
                            Console.ForegroundColor = System.ConsoleColor.Green;
                            Console.Write(CuvantDeGhicit[x]);
                            Console.ResetColor();

                        }
                        else if (CuvantDeGhicit.Contains(CuvantTemp[x]))
                        {

                            Console.ForegroundColor = System.ConsoleColor.Red;
                            Console.Write(CuvantTemp[x]);
                            Console.ResetColor();
                        }
                        else if (CuvantDeGhicit[x] != CuvantTemp[x])
                        {
                            Console.ForegroundColor = System.ConsoleColor.White;
                            Console.Write(CuvantTemp[x]);
                            Console.ResetColor();
                        }
                        
                    }
                    Console.WriteLine("Press enter to continue\n");
                    Console.ReadLine();

                }

                else
                    Console.WriteLine("Try another word");
            }
        }
    }
}
