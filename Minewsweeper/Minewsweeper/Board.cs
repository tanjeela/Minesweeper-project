using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    // Creating a class for the Minesweeper Grid. 
    // The grid will include a 2D Array (or List?) for the coordinates
    // Need variables 
    public class Board
    {
        //Method to display Grid
        public static void BoardDisplay(int coordinates, char[,] mineSweepergrid)
        {


            for (int x = 0; x < coordinates; x++)
            {
                for (int y = 0; y < coordinates; y++)

                    Console.Write(mineSweepergrid[x, y]);

                    Console.WriteLine();
            }
            Console.WriteLine();  // Without this, doesn't display grid

        }
            //Console.WriteLine();

            //for (int x = 0; x < minesweeperGrid.GetLength(0); x++)
            //{
            //    for (int y = 0; y < minesweeperGrid.GetLength(1); y++)
            //    {

            //        Console.Write(minesweeperGrid[x, y] + " ");

            //    }
            //    Console.WriteLine();

            //}
        
        //Need to do a double for statement to initialise the array for each row and column

        //public void GridCoordinates() {
        //    for (int x = 0; x < coordinates1; x++)
        //    {
        //        for (int y = 0; y < coordinates2; y++)
        //        {
        //            minesweeperGrid[x, y] = new Cell(x, y);
        //        }


        //    }

        //        for (int i = 0; i < minesweeperGrid.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < minesweeperGrid.GetLength(1); j++)

        //                Console.Write(minesweeperGrid[i, j] + " ");
        //        }
        //        Console.WriteLine();

        //}




        public static char[,] SetUpBombs(char[,] mineSweeperBoard, int coordinates) // Not static you have to have an instance to run it on, static won't know about the data from class
        {


            Random BombGenerator = new Random();

            //int bomb1 = BombGenerator.Next(0, coordinates);
            //int bomb2 = BombGenerator.Next(0, coordinates);

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    

                    //int bomb1 = BombGenerator.Next(coordinates, 0);
                    int bomb1 = BombGenerator.Next(0, coordinates);
                    int bomb2 = BombGenerator.Next(0, coordinates);
                    int bomb = mineSweeperBoard[bomb1, bomb2];
                    mineSweeperBoard[bomb1, bomb2] = bomb.ToString("*").ToCharArray()[0];
                }
            }
            return mineSweeperBoard;
        }
        
        //    public static void gridCreation()
        //    {
        //        int coordinates = 10;

        //        //  char[,] minesweeperBoard = new char(coordinates, coordinates); // creating the object// char not recognsing int, maybe need to convert?
        //        char[,] minesweeperBoard = new char[coordinates, coordinates]; // NOte to self: It is an ARRAY of coordinates, why are you passing them as arguments previously? Change to []

        //        for (int i = 0; i < coordinates; i++)
        //            for (int j = 0; j < coordinates; j++)
        //                minesweeperBoard[i, j] = '-';

        //    }

        //}





    }

}


