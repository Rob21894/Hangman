using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Hangman
{
    public class GameplayMechanics
    {
        public int currentNumber = 0;
        public int livesLeft { get; set; }
        public List<string> guessedWords = new List<string>();
        public List<char> guessedLetters = new List<char>();
        public enum difficultySetting
        {
            ChooseDifficulty = 0,
            Easy = 1,
            Medium = 2,
            Hard = 3,
            VeryHard = 4
        }

        public bool CheckWord(string answer, string correctAnswer)
        {
            return String.Equals(answer, correctAnswer, StringComparison.CurrentCultureIgnoreCase);
        }

        public bool CheckCurrentLetters(TextBox t)
        {
            if (guessedLetters.Contains(t.Text[0]))
            {
               MessageBox.Show(@"You have already guessed the letter " + t.Text + "!");
               return true;
            }

            return false;

        }
        public bool CheckLetter(char answer, string correctAnswer, List<Label> labels)
        {

            guessedLetters.Add(answer);
            string tempanswer = correctAnswer; // store answer
            if (correctAnswer.ToLower().Contains(answer.ToString().ToLower()))
            {
                for (int i = 0; i < correctAnswer.Length; i++)
                {
                    if (correctAnswer.ToLower()[i] == answer)
                    {
                        if (char.IsUpper(tempanswer[i]))
                        {
                            labels[i].Text = answer.ToString().ToUpper();
                        }
                        else
                            labels[i].Text = answer.ToString();
                    }

                }

                return true;

            }
            else
            {

                MessageBox.Show("Incorrect guess: " + answer);
            }

            return false;
        }


        public bool WinGame(string answer, List<Label> labels)
        {
            string temp = "";
            for (int i = 0; i < labels.Count; i++)
            {
                temp += labels[i].Text;
            }
            if (String.Equals(temp, answer, StringComparison.CurrentCultureIgnoreCase))
            {
                MessageBox.Show("You Have Won!");
                return true;
            }


            return false;
        }

        public void CurrentGuesses(Label l)
        {
            string guesses = string.Join(" ", guessedLetters.ToArray());
            l.Text = new Label().Text = "Current Guesses:" + guesses.ToUpper();

        }

    }
}