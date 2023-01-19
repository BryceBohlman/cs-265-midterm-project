using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265midterm
{
    public class Word
    {
        private string word;

        public Word()
        {
            word = null;
        }

        public Word(string word)
        {
            this.word = word;
        }

        public void SetWord(string word)
        {
            this.word = word;
        }
        
        public void SetWord(Word word)
        {
            this.word = word.word;
        }

        public string GetWord()
        {
            return word;
        }

        public void Display()
        {
            System.Console.WriteLine(word);
        }
    }
}
