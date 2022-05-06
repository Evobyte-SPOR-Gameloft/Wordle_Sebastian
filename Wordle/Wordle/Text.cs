using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    internal class Text
    {
        public List<string> cuvinte = File.ReadAllLines("Dictionar.txt").ToList();
        public List<string> transferInLista()
        {
            return cuvinte;
        }
        public string Aero()//Gets a random index for the words from the dictionary
        {
            Random r = new Random();
            int a=r.Next(0, 5750);

            return cuvinte[a];
        }
    }
}
