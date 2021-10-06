using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    enum Scene
    {
        MAINMENU,
        PLAYTICTAK,
        REPLAYMENU
    }
    class Game
    {
        private static bool _gameOver;
        private Board _gameBoard;
        private static Scene _currentScene;

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
                Console.WriteLine(desc);
                if (!int.TryParse(Console.ReadLine(), out outputInt))
                {
                    Console.WriteLine("Invalid Coordinate");
                    outputInt = -1;
                }
            }

            return outputInt;
        }

        private static void DisplayCurrentScene()
        {
            switch (_currentScene)
            {
                case Scene.MAINMENU:
                    break;
                case Scene.PLAYTICTAK:
                    break;
                case Scene.REPLAYMENU:
                    break;
            }
        }

        private static void EndGame()
        {
            _gameOver = true;
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("TIC-TAC-TOE: The Game");
            int playgame = 
        }
    }
}
