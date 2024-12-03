using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnuciDictionary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DefinitionGame
{
    public partial class Defineciando : Form
    {
        List<Word> lstWord = new();
        private Word currentWord;
        int score = 0;
        int numberOfTries = -1;
        int correctIndex = -1;
        int selectedIndex = -1;
        Random rnd = new();

        public Defineciando()
        {
            InitializeComponent();
            lstWord = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
            ShowUpdatedScoreAndTries();

            btnEnter.Click += btnEnter_Click;
            btnPickWord.Click += btnPickWord_Click;
            btnGiveUp.Click += btnGiveUp_Click;

        }


        private void btnPickWord_Click(object sender, EventArgs e)
        {
            ClearPreviousSelection();
            btnPickWord.Enabled = false;
            ApplyFilters();
            GenerateDefinitions(currentWord);
            btnEnter.Enabled = true;
            btnGiveUp.Enabled = true;

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            ShowAnswers();
            UpdateScore();
            ShowUpdatedScoreAndTries();
            btnPickWord.Enabled = true;
            btnGiveUp.Enabled = false;
        }
        private void btnGiveUp_Click(object sender, EventArgs e)

        {

            lblFeedback.Text = $"The correct definition was: {currentWord.Definition}";
            ShowAnswers();
            ShowUpdatedScoreAndTries();
            btnPickWord.Enabled = true;
            btnEnter.Enabled = false;
            btnGiveUp.Enabled = false;
        }

        private void ShowUpdatedScoreAndTries()
        {
            txtScore.Text = score.ToString();
            txtWordsTried.Text = numberOfTries.ToString();
        }

        private void ClearPreviousSelection()
        {

            rbDefinition1.Checked = false;
            rbDefinition2.Checked = false;
            rbDefinition3.Checked = false;
            lblFeedback.Text = ""; // Clear feedback
            lblWord.Text = "";
        }
        private void ApplyFilters()
        {
            //Apply Filters
            int.TryParse(txtNumberOfLetters.Text, out int numLetters);
            string specificLetters = txtSpecificLetters.Text;

            var filteredWords = lstWord.Where
            (w =>
                (numLetters == 0 || w.Value.Length == numLetters) &&
                (specificLetters == "" || specificLetters.All(l => w.Value.Contains(l)))
            ).ToList();

            if (filteredWords.Count < 3)
            {
                MessageBox.Show("Not enough words match your filter. Please adjust your filter and try again.");
                btnPickWord.Enabled = true;
                return;
            }
            currentWord = filteredWords[rnd.Next(filteredWords.Count)];
            lblWord.Text = currentWord.Value; // Display the word

        }


        private void GenerateDefinitions(Word word)
        {
            var correctDefinition = word.Definition;
            var incorrectDefinitions = lstWord
                .Where(w => w.Value != word.Value) // Exclude current word
                .OrderBy(x => rnd.Next())
                .Take(2) // Pick two random words
                .Select(w => w.Definition)
                .ToList();
            var allDefinitions = new List<string>();
            allDefinitions.Add(correctDefinition);
            foreach (var def in incorrectDefinitions)
            {
                allDefinitions.Add(def);
            }
            allDefinitions = allDefinitions.OrderBy(x => rnd.Next()).ToList();

            // Bind definitions to UI
            lblDef1.Text = allDefinitions[0];
            lblDef2.Text = allDefinitions[1];
            lblDef3.Text = allDefinitions[2];

            correctIndex = allDefinitions.IndexOf(correctDefinition);

            lblAnswer1.Visible = false;
            lblAnswer2.Visible = false;
            lblAnswer3.Visible = false;


        }

        private void ShowAnswers()
        {



            if (rbDefinition1.Checked) selectedIndex = 0;
            else if (rbDefinition2.Checked) selectedIndex = 1;
            else if (rbDefinition3.Checked) selectedIndex = 2;

            lblAnswer1.Visible = true;
            lblAnswer2.Visible = true;
            lblAnswer3.Visible = true;

            // Mark the correct definition with green and incorrect with red
            lblAnswer1.Text = (correctIndex == 0) ? "Correct!" : "Incorrect!";
            lblAnswer1.BackColor = (correctIndex == 0) ? Color.Green : Color.Red;

            lblAnswer2.Text = (correctIndex == 1) ? "Correct!" : "Incorrect!";
            lblAnswer2.BackColor = (correctIndex == 1) ? Color.Green : Color.Red;

            lblAnswer3.Text = (correctIndex == 2) ? "Correct!" : "Incorrect!";
            lblAnswer3.BackColor = (correctIndex == 2) ? Color.Green : Color.Red;

            numberOfTries++;
        }

        private void UpdateScore()
        {
            if (selectedIndex == correctIndex)
            {
                score++;
                lblFeedback.Text = "Good, Your choice is correct!";
            }
            else
            {
                score--;
                lblFeedback.Text = "Try again!";
            }


        }


    }
}
