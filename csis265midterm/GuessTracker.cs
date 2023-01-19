using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265midterm
{
    public class GuessTracker
    {
        private string[] correctGuesses;
        private string[] wrongGuesses;
        private int correctGuessCount;
        private int correctGuessTotal;
        private int wrongGuessCount;
        private string letterGuess = string.Empty;
        private bool correctGuess;

        public GuessTracker()
        {
            correctGuesses = new String[26];
            wrongGuesses = new String[26];
            correctGuessCount = 0;
            correctGuessTotal = 0;
            wrongGuessCount = 0;
            letterGuess = string.Empty;
            correctGuess = false;
        }

        #region SETTERS
        public void SetCorrectGuessCount(int correctGuessCount)
        {
            this.correctGuessCount = correctGuessCount;
        }

        public void SetCorrectGuessTotal(int correctGuessTotal)
        {
            this.correctGuessTotal = correctGuessTotal;
        }

        public void SetWrongGuessCount(int wrongGuessCount)
        {
            this.wrongGuessCount = wrongGuessCount;
        }

        public void SetLetterGuess(string letterGuess)
        {
            this.letterGuess = letterGuess;
        }

        public void SetCorrectGuess(bool correctGuess)
        {
            this.correctGuess = correctGuess;
        }

        public void SetCorrectGuesses()
        {
            correctGuesses[correctGuessCount] = letterGuess;
        }

        public void SetWrongGuesses()
        {
            wrongGuesses[wrongGuessCount] = letterGuess;
        }
        #endregion

        #region GETTERS
        public int GetCorrectGuessCount()
        {
            return correctGuessCount;
        }

        public int GetCorrectGuessTotal()
        {
            return correctGuessTotal;
        }

        public int GetWrongGuessCount()
        {
            return wrongGuessCount;
        }

        public string GetLetterGuess()
        {
            return letterGuess;
        }

        public bool GetCorrectGuess()
        {
            return correctGuess;
        }

        public string GetCorrectGuesses(int i)
        {
            return correctGuesses[i];
        }
        #endregion

        #region METHODS
        public void IterateCorrectGuessCount()
        {
            correctGuessCount++;
        }

        public void IterateCorrectGuessTotal()
        {
            correctGuessTotal++;
        }

        public void IterateWrongGuessCount()
        {
            wrongGuessCount++;
        }



        public void DisplayWrongGuesses()
        {
            System.Console.Write("Wrong guesses: ");
            for (int i = 0; i < wrongGuessCount; i++)
            {
                System.Console.Write(wrongGuesses[i] + " ");
            }
        }
        #endregion
    }
}
