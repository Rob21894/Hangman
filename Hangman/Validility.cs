using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hangman
{
    public class Validility
    {
        public bool IsLetter(TextBox t)
        {
            if (IsEmpty(t))
            {

            }
            else
            {
                if (char.IsLetter(t.Text[0]))
                    return true;
                else
                {
                    MessageBox.Show("Invalid Input!: Non-Letter Detected!");
                    t.Clear(); ;
                    return false;
                }
            }

            return false;
        }

        public bool IsEmpty(TextBox t)
        {
            if (string.IsNullOrEmpty(t.Text))
            {
                MessageBox.Show("Invalid Input: Empty field!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsNumber(TextBox t)
        {
            if (!Regex.IsMatch(t.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Answer Contains invalid characters answer removed!");
                t.Clear();
                return true;
            }
            return false;

        }
    }
}