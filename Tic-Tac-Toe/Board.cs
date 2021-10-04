using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        private char _player1Token;
        private char _player2Token;
        private char _currentToken;
        private char[,] _board;


        /// <summary>
        /// Initializes game board and player tokens
        /// </summary>
        public void Start()
        {
            _player1Token = 'X';
            _player2Token = 'O';
            _currentToken = _player1Token;
            _board = new char[3, 3] { {'-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        }

        /// <summary>
        /// Gets input from the player and sets the player token at the desired spot in the array
        /// Checks if there is a winner
        /// Changes the current tokens in play
        /// </summary>
        public void Update()
        {
            
        }

        /// <summary>
        /// Draws the board and lets the players know who's turn it is.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine(_board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2] + "\n" +
                              _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2] + "\n" +
                              _board[2,1] + "|" + _board[2, 1] + "|" + _board[2, 2]);
        }

        /// <summary>
        /// Called when Game ends
        /// </summary>
        public void End()
        {
            
        }

        /// <summary>
        /// Assigns the spot at the given indices in the board array to the given token.
        /// </summary>
        /// <param name="token"> The token to set the array indice to</param>
        /// <param name="posX"> The x position of the token</param>
        /// <param name="posY"> The y position of the token</param>
        /// <returns>Returns false if the indices are out of range </returns>
        public bool SetToken(char token, int posX, int posY)
        {
            return false;
        }

        /// <summary>
        /// Checks to see if the token appears three times consecutively. Vertically, horizontally, or diagonally
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool checkWinner(char token)
        {
            return false;
        }

        /// <summary>
        /// Clears the board
        /// </summary>
        public void ClearBoard()
        {
            
        }
    }
}
