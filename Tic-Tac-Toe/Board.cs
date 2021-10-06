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
        private bool _BothCoordinatesChosen;
        private bool _SecondCoordinateChosen;

        private int _cor1;
        private int _cor2;
        private string _currentPlayer;



        /// <summary>
        /// Initializes game board and player tokens
        /// </summary>
        public void Start()
        {
            _player1Token = 'X';
            _player2Token = 'O';
            _currentToken = _player1Token;
            _board = new char[3, 3] { {'-', '-', '-' }, 
                                      { '-', '-', '-' }, 
                                      { '-', '-', '-' } };
        }

        /// <summary>
        /// Gets input from the player and sets the player token at the desired spot in the array
        /// Checks if there is a winner
        /// Changes the current tokens in play
        /// </summary>
        public void Update()
        {
            if (CheckDraw(_player1Token, _player2Token))
            {
                Console.WriteLine("Game Board is full, DRAW.");
                Console.ReadKey(true);
            }
            else if (checkWinner(_player1Token))
            {
                Console.WriteLine("PLAYER 1 WON!");
                Console.ReadKey(true);
            }
            else if (checkWinner(_player2Token))
            {
                Console.WriteLine("PLAYER 2 WON!");
                Console.ReadKey(true);
            }

            while (!_BothCoordinatesChosen)
            {
                Console.WriteLine("PLAYER " + _currentToken + "," + " It's your turn");
                _cor1 = Game.GetInput("Input your first Coordinate");
                if (_cor1 < _board.GetLongLength(0))
                {
                    while (!_SecondCoordinateChosen)
                    {
                        _cor2 = Game.GetInput("Input your second coordinate");
                        if (_cor2 < _board.GetLongLength(1))
                        {
                            _SecondCoordinateChosen = true;
                            _BothCoordinatesChosen = true;
                        }
                        else
                        {
                            Console.WriteLine("INVALID COORDINATE");
                            Console.ReadKey(true);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("INVALID COORDINATE");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
            _board[_cor1, _cor2] = _currentToken;
            if (_currentToken == _player1Token)
            {
                _currentToken = _player2Token;
            }
            else if (_currentToken == _player2Token)
            {
                _currentToken = _player1Token;
            }
            _SecondCoordinateChosen = false;
            _BothCoordinatesChosen = false;
        }

        /// <summary>
        /// Draws the board and lets the players know who's turn it is.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("0 " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2] + "\n" +
                              "1 " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2] + "\n" +
                              "2 " + _board[2,1] + "|" + _board[2, 1] + "|" + _board[2, 2]);
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
            int count = 0;
            //Vertical Check
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(0); i++)
                {
                    
                }
            }

            //Horizontal Check
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    if (_board[i, j] == token)
                    {
                        count++;
                        if (count == _board.GetLength(0) && count == _board.GetLength(1))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
            }

            //Diagonal Check
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = _board.GetLength(1); j > 0; j--)
                { 
                }
            }
            //Return TokenWon
            return false;
        }

        /// <summary>
        /// Checks to see if any spaces on the board are not equal to any of the tokens
        /// returns true if all spaces are equal to a token
        /// returns false if a space is not equal to a token
        /// </summary>
        /// <param name="token1"></param>
        /// <param name="token2"></param>
        /// <returns></returns>
        private bool CheckDraw(char token1, char token2)
        {
            for (int i = 0; i < _board.GetLongLength(0); i++)
            {
                for (int j = 0; i < _board.GetLongLength(1); j++)
                {
                    if (_board[i, j] != token1 || _board[i, j] != token2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// Clears the board
        /// </summary>
        public void ClearBoard()
        {
            _board = new char[,]{ { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        }
    }
}
