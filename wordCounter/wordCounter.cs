using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordCounter
{
    class wordCounter
    {
        public wordCounter(string word, int frequency)
        {
            this.word = word;
            this.frequency = frequency;
        }

        public string word { get; set; }
        public int frequency { get; set; }

    }
}
