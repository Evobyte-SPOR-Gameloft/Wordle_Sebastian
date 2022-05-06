using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    internal class WordAnalyzer
    {
        List<char> caractere=new List<char>();  
        public List<char> Lyzer(string arg)
        {
            foreach (char x in arg)
                caractere.Add(x);
            return caractere;
        }

    }
}
