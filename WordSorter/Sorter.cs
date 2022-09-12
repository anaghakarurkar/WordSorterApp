using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSorter
{
    public class Sorter
    {
        public string Sentence { get; set; }

        public Sorter(string? sentence)
        {
            Sentence = sentence;
        }

        public string[] ArrangeWords()
        {
            string[] words;
            if (Sentence == null)
            {
                return null;
            }
            words = Sentence.Split(' ');

            return words;
                
            
        }



    }
}
