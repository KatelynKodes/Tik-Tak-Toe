using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {                                          /*0, 1, 2*/
            int[,] Array2D = new int[3, 3] { /*0*/ { 1, 2, 3 }, 
                                             /*1*/ { 4, 5, 6 }, 
                                             /*2*/ { 7, 8, 9 } };

                                           /*0, 1, 2*/
            int[,] Array2DExample2 = {/*0*/{ 1, 2, 3 }, 
                                      /*1*/{ 4, 5, 6 }, 
                                      /*2*/{ 7, 8, 9 }, 
                                      /*3*/{10, 11, 12 } };

            Add2DArray(Array2DExample2);

            //Adding 2D array excercise
            void Add2DArray(int[,] ArrayToAdd)
            {
                int FirstDimLength = ArrayToAdd.GetLength(0);
                int SecDimLength = ArrayToAdd.GetLength(1);
                int Result = 0;
                for (int i = 0; i < FirstDimLength; i++)
                {
                    for (int j = 0; j < SecDimLength; j++)
                    {
                        Result += ArrayToAdd[i, j];
                        if ((j + 1) >= SecDimLength)
                        {
                            Console.WriteLine(Result);
                            Result = 0;
                        }
                    }
                }
            }

            //Writing out Array Excercise
            void WriteArrayExample1()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine(Array2D[i, j]);
                    }
                }
            }
        }
    }
}
