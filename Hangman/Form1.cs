using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private readonly Validility _validility = new Validility();
        private readonly FileUtilities _fileUtilities = new FileUtilities();
        private readonly GameplayMechanics _gameplayMechanics = new GameplayMechanics();
        private GameplayMechanics.difficultySetting difficulty;

        private readonly List<Label> _labels = new List<Label>(); //creating a list of labels
        public Form1()
        {
            InitializeComponent();
            difficultySetting.DataSource = Enum.GetValues(typeof(GameplayMechanics.difficultySetting));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _fileUtilities.LoadWordData(); // load words


        }
        private void submitLetter_Click(object sender, EventArgs e)
        {
            if (_validility.IsLetter(letterSelectionText) &&
                !_gameplayMechanics.CheckCurrentLetters(letterSelectionText))
            {
                if (_gameplayMechanics.CheckLetter(letterSelectionText.Text[0], _fileUtilities.word, _labels))
                {
                    if (!_gameplayMechanics.WinGame(_fileUtilities.word, _labels))
                        letterSelectionText.Clear();
                    else
                    {
                        Reset();
                    }
                }
                else
                {
                    _gameplayMechanics.livesLeft--;
                    livesRemaining.Text = @"Lives Remaining: " + _gameplayMechanics.livesLeft;
                    letterSelectionText.Clear();
                }
            }

            _gameplayMechanics.CurrentGuesses(currentGuesses);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        public void DrawHangman(int n)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            switch (n)
            {
                case 0:
                    g.DrawLine(p, new Point(0, 310), new Point(198, 310)); // floor
                    break;
                case 1:
                    g.DrawLine(p, new Point(150, 321), new Point(198, 280)); // left stand
                    break;
                case 2:
                    g.DrawLine(p, new Point(198, 321), new Point(198, 5)); // main pole
                    break;
                case 3:
                    g.DrawLine(p, new Point(203, 5), new Point(80, 5)); // second pole
                    break;
                case 4:
                    g.DrawLine(p, new Point(80, 0), new Point(80, 70)); // noose
                    break;
                case 5:
                    g.DrawEllipse(p, 55, 70, 55, 55); // head
                    break;
                case 6:
                    SolidBrush s = new SolidBrush(Color.Black);
                    g.FillEllipse(s, 70, 85, 5, 5); // eye 
                    break;
                case 7:
                    SolidBrush s1 = new SolidBrush(Color.Black);
                    g.FillEllipse(s1, 90, 85, 5, 5); // eye 
                    break;
                case 8:
                    SolidBrush s2 = new SolidBrush(Color.Black);
                    g.FillEllipse(s2, 80, 100, 5, 5); // mouth
                    break;
                case 9:
                    g.DrawLine(p, new Point(83, 127), new Point(83, 240)); // body
                    break;
                case 10:
                    g.DrawLine(p, new Point(83, 150), new Point(53, 180)); // left arm
                    break;
                case 11:
                    g.DrawLine(p, new Point(83, 150), new Point(112, 180)); // right arm
                    break;
                case 12:
                    g.DrawLine(p, new Point(83, 240), new Point(62, 275)); // left leg
                    break;
                case 13:
                    g.DrawLine(p, new Point(83, 240), new Point(105, 275)); // right leg // END GAME
                    MessageBox.Show("Hangman died! please try again!");
                    Reset();
                    break;
            }
        }

        private void difficultySetting_SelectedIndexChanged(object sender, EventArgs e)
        {
           difficulty = (GameplayMechanics.difficultySetting) difficultySetting.SelectedItem;
        }

        private void generateWord_Click(object sender, EventArgs e)
        {
            _fileUtilities.ChooseRandmWord(_fileUtilities.temp); // choose word
            MessageBox.Show(_fileUtilities.word);
            GenerateUnderscores();
            if (difficulty == GameplayMechanics.difficultySetting.Easy)
            {
                // nothing
            }
            else if (difficulty == GameplayMechanics.difficultySetting.Medium)
            {
                for (_gameplayMechanics.currentNumber = 0; _gameplayMechanics.currentNumber < 3; _gameplayMechanics.currentNumber++)
                    DrawHangman(_gameplayMechanics.currentNumber);

            }
            else if (difficulty == GameplayMechanics.difficultySetting.Hard)
            {
                for (_gameplayMechanics.currentNumber = 0; _gameplayMechanics.currentNumber < 4; _gameplayMechanics.currentNumber++)
                    DrawHangman(_gameplayMechanics.currentNumber);
            }
            else if (difficulty == GameplayMechanics.difficultySetting.VeryHard)
            {
                for (_gameplayMechanics.currentNumber = 0; _gameplayMechanics.currentNumber < 5; _gameplayMechanics.currentNumber++)
                    DrawHangman(_gameplayMechanics.currentNumber);
            }

            _gameplayMechanics.livesLeft = (13 -_gameplayMechanics.currentNumber);
            livesRemaining.Text = "Lives Remaining: " + _gameplayMechanics.livesLeft;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            wordSelectionText.Clear();
            letterSelectionText.Clear();
            difficulty = GameplayMechanics.difficultySetting.ChooseDifficulty;
            difficultySetting.SelectedItem = difficulty;
            _gameplayMechanics.guessedLetters.Clear();
            _gameplayMechanics.guessedWords.Clear();
            livesRemaining.Text = @"Lives Remaining: ";
            for (int i = 0; i < _labels.Count; i++)
                _labels[i].Text = "";
        }

        private void wordSubmit_Click(object sender, EventArgs e)
        {
            if (!_validility.ContainsNumber(wordSelectionText) && !_validility.IsEmpty(wordSelectionText))
            {
                if (_gameplayMechanics.CheckWord(wordSelectionText.Text, _fileUtilities.word))
                {
                    MessageBox.Show("Correct!");
                    Reset();
                }
                else
                {
                    DrawHangman(_gameplayMechanics.currentNumber++);
                }
            }

        }

        void GenerateUnderscores()
        {
            
            char[] chars = _fileUtilities.word.ToCharArray();
            int between = 250 / chars.Length; 
            for (int i = 0; i < chars.Length; i++)
            {
                _labels.Add(new Label()); 
                _labels[i].Location = new Point((i * between) + 130, 150); 
                _labels[i].Text = "___"; 
                _labels[i].Parent = mainCanvas; 
                _labels[i].BringToFront(); 
                _labels[i].CreateControl(); 
            }
        }
    }
}
