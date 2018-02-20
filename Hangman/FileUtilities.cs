using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hangman
{
    public class FileUtilities
    {
        public List<string> temp = new List<string>();
        public string word { get; set; }
        public char[] wordSplit { get; set; }
        public void LoadWordData()
        {
            string reader;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Rob\source\repos\Hangman\Hangman\words.txt");
            while ((reader = file.ReadLine()) != null)
            {
                temp.Add(reader);
            }

        }

        public void ChooseRandmWord(List<string> sl)
        {
            Random rand = new Random();
            int randnum = rand.Next(0, temp.Count);
            word = temp[randnum];
            wordSplit = word.ToCharArray();

        }
    }
}