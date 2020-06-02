using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SindarinQuiz_V._1._0
{
    public partial class GameScreen : Form
    {
        static string[] SindarinWords = { "adan", "edain", "aran", "erain", "aras", "erais", "cabed", "cuio vae!", "edhel", "edhil", "elleth", "ellith", "Ennorath", "hir", "Imladris", "ion", "ma", "mae", "mae govannen", "methed", "naug", "noeg", "nirnaeth", "peredhel", "rath", "raith", "sell", "sill", "uin" };
        static string[] EnglishWords = { "human", "humans", "king", "kings", "deer", "deers", "leap", "fairwell!", "elf", "elves", "elf-maiden", "elf-maidens", "Middle Earth", "lord", "Rivendell", "son", "yes/good","well", "Well Meet", "end", "dwarf", "dwarfs", "bitter tears", "half-elf", "way/path", "ways/paths", "daughter", "daughters", "no" };
        static int StringLength = SindarinWords.Length;
        int CorrectNum;
        int TotalRounds;
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

            ScoreTracker.Text = "0/0";
            int buttonNumber = NextRound();
        }
        private int NextRound()
        {
            var rand = new Random();
            int WordToGuess = rand.Next(StringLength);
            int CorectButton = rand.Next(1, 5);
            WordToTranslate.Text = SindarinWords[WordToGuess];
            if (CorectButton == 1) Option1.Text = EnglishWords[WordToGuess];
            else Option1.Text = EnglishWords[rand.Next(StringLength)];

            if (CorectButton == 2) Option2.Text = EnglishWords[WordToGuess];
            else Option2.Text = EnglishWords[rand.Next(StringLength)];

            if (CorectButton == 3) Option3.Text = EnglishWords[WordToGuess];
            else Option3.Text = EnglishWords[rand.Next(StringLength)];

            if (CorectButton == 4) Option4.Text = EnglishWords[WordToGuess];
            else Option4.Text = EnglishWords[rand.Next(StringLength)];

            return CorectButton;
        }
        private string UpdateScore(bool correct)
        {
            TotalRounds = TotalRounds +1;
            if(correct)
            {
                CorrectNum = CorrectNum + 1;
            }
            return CorrectNum.ToString() + "/" + TotalRounds.ToString();

        }

        private void Option1_Click(object sender, EventArgs e)
        {
            bool CorrectGuess;
            int WordGuessed = Array.IndexOf(EnglishWords, Option1.Text);
            int WordToGuess = Array.IndexOf(SindarinWords, WordToTranslate.Text); // goes to -1
            if ( WordGuessed == WordToGuess)
            {
                CorrectGuess = true;
            }
            else
            {
                CorrectGuess = false;
            }
            ScoreTracker.Text = UpdateScore(CorrectGuess);
            NextRound();
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            bool CorrectGuess;
            if (Array.IndexOf(EnglishWords, Option2.Text) == Array.IndexOf(SindarinWords, WordToTranslate.Text))
            {
                CorrectGuess = true;
            }
            else
            {
                CorrectGuess = false;
            }
            ScoreTracker.Text = UpdateScore(CorrectGuess);
            NextRound();
        }

        private void Option3_Click(object sender, EventArgs e)
        {
            bool CorrectGuess;
            if (Array.IndexOf(EnglishWords, Option3.Text) == Array.IndexOf(SindarinWords, WordToTranslate.Text))
            {
                CorrectGuess = true;
            }
            else
            {
                CorrectGuess = false;
            }
            ScoreTracker.Text = UpdateScore(CorrectGuess);
            NextRound();
        }

        private void Option4_Click(object sender, EventArgs e)
        {
            bool CorrectGuess;
            if (Array.IndexOf(EnglishWords, Option4.Text) == Array.IndexOf(SindarinWords, WordToTranslate.Text))
            {
                CorrectGuess = true;
            }
            else
            {
                CorrectGuess = false;
            }
            ScoreTracker.Text = UpdateScore(CorrectGuess);
            NextRound();
        }
    }
}
