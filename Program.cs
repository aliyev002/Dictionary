using System.Collections.Generic;
using System.Diagnostics.Tracing;

class Program
{
    class Word
    {
        public Word(string word_aze,string word_eng)
        {
            this.word_aze = word_aze;
            this.word_eng = word_eng;
        }

        public string word_aze { get; set; }
        public string word_eng { get; set; }
        public override string ToString()
        {
            return "Azerbaycanca: " + word_aze + "-----" + "Ingilisce: " + word_eng;
        }
    }
    class dictionary
    {
        public dictionary(int dictionary_id, List<Word> words)
        {
            this.dictionary_id = dictionary_id;
            this.words= words;
        }

        public int dictionary_id { get; set; }
        
        


        public List<Word> words { get; set; }
        public Word this[int index]
        {
            get
            {
                if (index >= 0 || index < words.Count)
                {
                    return words[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                words[index] = value;
            }
        }
        

    }
    static void Main(string[] args)
    {

        Word word1 = new Word("alma", "Apple");
        Word word2 = new Word("armud", "Pear");
        List<Word> words = new List<Word>{ word1, word2};
        
        dictionary dictionary = new dictionary(1, words);
        Console.WriteLine(dictionary[0]);
        Console.WriteLine(dictionary[1]);
        

    }




}
