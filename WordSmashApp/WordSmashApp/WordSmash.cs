using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gnuciDictionary;

namespace WordSmashApp
{
    public partial class WordSmash : Form
    {
        // Form-level variables
        
        List<char> revealedLetters = new();
        List<Button> alphabetButtons = new();
        string targetWord = "";
        int score = 0;
        int remainingTries = 6;
        Random rnd = new();

        public WordSmash()
        {
            InitializeComponent();
            InitializeGameSetup();
   
        }

        private void InitializeGameSetup()
        {
            // Load alphabet buttons
            alphabetButtons.AddRange(new List<Button>
            {
                btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ,
                btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT,
                btnU, btnV, btnW, btnX, btnY, btnZ
            });

            // Attach event handlers
            btnStart.Click += BtnStart_Click;
            btnHint.Click += BtnHint_Click;
            foreach (var btn in alphabetButtons)
            {
                btn.Click += AlphabetButton_Click;
            }

            // Initial UI state
            DisableAlphabetButtons();
            btnHint.Enabled = false;
        }

        // Event handlers
        private void BtnStart_Click(object sender, EventArgs e) => StartGame();
        private void BtnHint_Click(object sender, EventArgs e) => UseHint();
        private void AlphabetButton_Click(object sender, EventArgs e) => ProcessLetterClick((Button)sender);

        // Start a new game
        private void StartGame()
        {
            List<Word> lstWord = new();
            if (!lstWord.Any())
            {
                var allWords = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
                lstWord = allWords.Where(w => w.Value.All(char.IsLetter)).ToList();
                // RS This is nessecary because some words in the dictionary list include numbers.
            }

            // Select a random word
            targetWord = lstWord[rnd.Next(lstWord.Count)].Value.ToUpper();

            // Reset game state
            revealedLetters.Clear();
            score = 0;
            remainingTries = 6;

            // Update UI
            InitializeGameUI("", "Game Started", targetWord.Select(l => "_").ToList());
            EnableAlphabetButtons();
            btnStart.Enabled = false;
            btnHint.Enabled = true;
        }

        // Handle letter button click
        private void ProcessLetterClick(Button btn)
        {
            char guessedLetter = btn.Text[0];
            btn.Enabled = false;
            btn.Text = "";
            if (revealedLetters.Contains(guessedLetter))
            {
                return;
            }
            else if (targetWord.Contains(guessedLetter))
            {
                revealedLetters.Add(guessedLetter);
                score += 10;
                lblFeedback.Text = "Great Choice!";
            }
            else
            {
                if (score >= 5)
                {
                    score -= 5;
                }
                else
                {
                    score = 0;
                }

                remainingTries--;
                lblFeedback.Text = "Try Again!";
            }

            RefreshGameUI();
            CheckGameEndConditions();
        }

        // Use a hint
        private void UseHint()
        {
            char nextLetter = targetWord.First(c => !revealedLetters.Contains(c));

            revealedLetters.Add(nextLetter);
            remainingTries--;
            lblFeedback.Text = "Hint used!";
            RefreshGameUI();
            CheckGameEndConditions();
        }

    

        private string GetRevealedWord()
        {
            var displayWord = new StringBuilder();

            for (int i = 0; i < targetWord.Length; i++)
            {
                displayWord.Append(revealedLetters.Contains(targetWord[i]) ? targetWord[i] : '_');

                if (i < targetWord.Length - 1)
                {
                    displayWord.Append(' ');
                }
            }

            return displayWord.ToString(); // Convert the StringBuilder to a string and return it.
        }


        private void CheckGameEndConditions()
        {
            // Check if the word is fully guessed
            if (targetWord.All(c => revealedLetters.Contains(c)))
            {
                score += 100; // Add 100 points for uncovering the word
                RefreshGameUI(); // Ensure the updated score is reflected in the UI
                EndGame("You uncovered the hidden word!!!!!!");
            }
            else if (remainingTries == 0)
            {
                EndGame($"The word was: {targetWord}. So Close! Press Start to try again!");
            }
        }

        private void EndGame(string feedback)
        {
            lblFeedback.Text = feedback;
            lblStatus.Text = "Game Over";
            DisableAlphabetButtons();
            btnStart.Enabled = true;
            btnHint.Enabled = false;
        }

        // UI Updates and helpers
        private void InitializeGameUI(string feedback, string status, IEnumerable<string> displayWord)
        {
            lblFeedback.Text = feedback;
            lblStatus.Text = status;
            lblDisplayWord.Text = string.Join(" ", displayWord);
            RefreshGameUI();
        }
        private void RefreshGameUI()
        {
            txtScore.Text = score.ToString();
            txtRemainingTries.Text = remainingTries.ToString();
            lblDisplayWord.Text = GetRevealedWord();
        }

        private void EnableAlphabetButtons() => alphabetButtons.ForEach(btn => btn.Enabled = true);
        private void DisableAlphabetButtons() => alphabetButtons.ForEach(btn => btn.Enabled = false);
    }
}
