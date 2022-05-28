using System;
using System.Collections.Generic;
namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Minesweeper!");
            Console.WriteLine("Hope you have fun!");

            int coordinates = 10; // Creating a 10x10 grid

            char[,] minesweeperBoard = new char[coordinates, coordinates];

            //  var mineChecker = new CalculateMines();
            // CalculateMines.MinesaroundBoard(x, y) = minesweeperBoard;



            for (int x = 0; x < coordinates; x++)
            
                for (int y = 0; y < coordinates; y++)
                    minesweeperBoard[x, y] = '-';
            
            Board.BoardDisplay(coordinates, minesweeperBoard);

            // mines = '*'
            // how many mines around cell is indicated by '?'
            // -1 is if user has lost
            //  1 is if they have won

            int userInput = 0; // Setting starting to 0. 

            while (userInput == 0) //the whole grid is starting at 0, hence why we have a value of == 0
            {
                Board.SetUpBombs(minesweeperBoard, coordinates);

                Console.Write("Please enter your X coordinate: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter your Y coordinate: ");
                int y = Convert.ToInt32(Console.ReadLine());

                
                if (minesweeperBoard[x, y] == '*')
                {


                    userInput = -1;
                    
                }

                else 
                {
                    minesweeperBoard[x, y] = MinesaroundBoard(minesweeperBoard, x, y);

                    MinesaroundBoard(minesweeperBoard, x, y);
                }

                Board.BoardDisplay(coordinates, minesweeperBoard);

            }

            //// public static void Starting()
            //{
            //    Console.WriteLine("Get ready for Minesweeper!");
            //    Console.Write("Please enter the X coordinate");
            //    String UserInput = Console.ReadLine();

            //}

       

            if (userInput == 1)
                Console.WriteLine("Woohoo! You win!");

            else if (userInput == -1)
            
                Console.WriteLine("BOOM!!");
                Console.WriteLine("");
                Console.WriteLine("You hit a mine.");
                Console.WriteLine(" Better luck next time =( ");
            

        }


        static char MinesaroundBoard(char[,] minesweeperBoard, int x, int y)
        {
            int mineCount = 0;
            if (minesweeperBoard[x - 1, y - 1] == '*')
            {
                mineCount++;
            }
            if (minesweeperBoard[x, y - 1] == '*')
            {
                mineCount++;
            }
            if (minesweeperBoard[x + 1, y - 1] == '*')
            {
                mineCount++;
            }



            if (minesweeperBoard[x - 1, y] == '*')
            {
                mineCount++;
            }
            if (minesweeperBoard[x + 1, y] == '*')
            {
                mineCount++;
            }
            if (minesweeperBoard[x - 1, y + 1] == '*')
            {
                mineCount++;

            if (minesweeperBoard[x, y + 1] == '*')
            {
                    mineCount++;
            }

            if (minesweeperBoard[x + 1, y + 1] == '*')
            {
                    mineCount++;
            }

                //   return mineCount.ToString().ToCharArray()[0];


            }

           return mineCount.ToString().ToCharArray()[0];
        
        }

         

    }
}
