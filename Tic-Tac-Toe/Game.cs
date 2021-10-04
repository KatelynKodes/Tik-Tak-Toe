using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Game
    {
        private bool _gameOver;
        private Board _gameBoard;

        public void Run()
        {
            Start();
            while (!_gameOver)
            {
                Draw();
                Update();
            }
            End();
        }

        /// <summary>
        /// called at the start of the game.
        /// </summary>
        private void Start()
        {
            _gameBoard = new Board();
            _gameBoard.Start();
        }

        /// <summary>
        /// Draws the board onto the screen to reflect any changes made
        /// </summary>
        private void Draw()
        {
            Console.Clear();
            _gameBoard.Draw();
        }

        /// <summary>
        /// Called every time the game loops
        /// </summary>
        private void Update()
        {
            _gameBoard.Update();
        }

        //Called at the end of the game
        private void End()
        {
            _gameBoard.End();
        }

        public static int GetInput(string desc)
        {
            int outputInt = -1;
            while (outputInt == -1)
            {
                Console.WriteLine();
                if (int.TryParse(Console.ReadLine(), out outputInt))
                {
                    //check if Coordinate is too big
                }
                else
                {
                    Console.WriteLine("Invalid Coordinate");
                    outputInt = -1;
                }
            }

            return outputInt;
        }
    }
}
