using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265midterm
{
    public class GameOverseer
    {
        private Man man;
        private GuessTracker guessTracker;
        private Random generator;
        private Word winningWord;
        private string tempCharacter;
        private bool gameNotOver;
        string[] inputWordList = { "apple", "banana", "cherry", "durian", "elderberry", "fig" };
        Word[] wordList = new Word[6];

        public GameOverseer()
        {
            man = new Man();
            guessTracker = new GuessTracker();
            generator = new Random();
            winningWord = new Word();
            tempCharacter = string.Empty;
            gameNotOver = true;
        }
        

        #region SETTERS
        public void SetWinningWord(Word[] wordList)
        {
            winningWord.SetWord(wordList[generator.Next(wordList.Length)]);
        }

        public void SetGameNotOver(bool gameNotOver)
        {
            this.gameNotOver = gameNotOver;
        }
        #endregion

        #region GETTERS
        public string GetWinningWord()
        {
            return winningWord.GetWord();
        }

        public bool GetGameNotOver()
        {
            return gameNotOver;
        }
        #endregion

        #region METHODS
        public void DisplayWinningWord()
        {
            System.Console.WriteLine(winningWord.GetWord());
        }

        public void EvaluateGuess()
        {
            for (int i = 0; i < winningWord.GetWord().Length; i++)
            {
                tempCharacter = winningWord.GetWord().Substring(i, 1);
                if (guessTracker.GetLetterGuess().Equals(tempCharacter))
                {
                    guessTracker.SetCorrectGuess(true);
                    guessTracker.IterateCorrectGuessTotal();
                }

            }
        }

        public void DisplaySlashes()
        {
            for (int i = 0; i < winningWord.GetWord().Length; i++)
            {
                System.Console.Write("_ ");
            }
            System.Console.WriteLine("\n\n");
        }

        public void RunGame()
        {
            //Populate wordList array with intended values
            for (int i = 0; i < wordList.Length; i++)
            {
                wordList[i] = new Word();
                wordList[i].SetWord(inputWordList[i]);
            }

            //for (int i = 0; i < wordList.Length; i++)
           //{
                //wordList[i].Display();
            //}

            SetWinningWord(wordList);
            DisplayWinningWord();
            DisplaySlashes(); 

            do
            {
                guessTracker.SetLetterGuess(KeyboardUtility.GetValidString("Guess a letter: "));
                guessTracker.SetLetterGuess(guessTracker.GetLetterGuess().ToLower());
                guessTracker.SetLetterGuess(guessTracker.GetLetterGuess().Substring(0, 1));

                //determine if the letter is correct or not
                guessTracker.SetCorrectGuess(false);

                EvaluateGuess();

                if (guessTracker.GetCorrectGuess())
                {
                    guessTracker.SetCorrectGuesses();
                    guessTracker.IterateCorrectGuessCount();
                }
                else
                {
                    guessTracker.SetWrongGuesses();
                    guessTracker.IterateWrongGuessCount();
                }

                //display any body parts if wrong guesses exist
                System.Console.WriteLine("\n\n");
                    man.DisplayMan(guessTracker.GetWrongGuessCount());
                System.Console.WriteLine("\n\n");


                // display intermingled dashes and word letters if correct guesses exist
                for (int i = 0; i < winningWord.GetWord().Length; i++)
                {
                    guessTracker.SetCorrectGuess(false);
                    for (int j = 0; j < guessTracker.GetCorrectGuessCount(); j++)
                    {
                        tempCharacter = winningWord.GetWord().Substring(i, 1);
                        if (tempCharacter.Equals(guessTracker.GetCorrectGuesses(j)))
                        {
                            guessTracker.SetCorrectGuess(true);
                        }
                    }

                    if (guessTracker.GetCorrectGuess())
                    {
                        //display the inividual letter
                        System.Console.Write(tempCharacter + " ");
                    }
                    else
                    {
                        //display a dash
                        System.Console.Write("_ ");
                    }
                }

                System.Console.WriteLine("\n\n");

                //display the WRONG GUESSES array
                guessTracker.DisplayWrongGuesses();


                System.Console.WriteLine("\n\n");

                if (guessTracker.GetWrongGuessCount() == 7 || guessTracker.GetCorrectGuessTotal() == winningWord.GetWord().Length)
                {
                    gameNotOver = false;
                }
            } while (gameNotOver);

            if (guessTracker.GetWrongGuessCount() == 7)
            {
                System.Console.WriteLine("You lost !!!\n");
            }
            else
            {
                System.Console.WriteLine("Congratulations - you won !!!\n");
            }
            
        }
        #endregion
    }
}
