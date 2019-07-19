using System;

namespace tickTackToe
{
    class seaChess
    {
        static void Main()
        {
            string placeAA = "";
            string placeAB = "";
            string placeAC = "";
            string placeBA = "";
            string placeBB = "";
            string placeBC = "";
            string placeCA = "";
            string placeCB = "";
            string placeCC = "";

            #region WinConditions
            /*int winUser = 0;
            if (placeAA == placeAB && placeAB == placeAC)
            {
                Console.WriteLine("Player 1 won the game!");
            }
            else if (placeAA == placeBA && placeBA == placeCA)
            {
                Console.WriteLine("Player 2 won the game!");
            }
            else
            {
                Console.WriteLine("The game is a draw... again.");
            }*/
            #endregion

            for (int totalInputs = 0; totalInputs < 9; totalInputs++)
            {
                string userA = Console.ReadLine();
                string userB = Console.ReadLine();
                Console.WriteLine();
                #region userA X input
                if (userA == "AA" || userA == "aa")
                {
                    placeAA = "X";
                }
                if (userA == "AB" || userA == "ab")
                {
                    placeAB = "X";
                }
                if (userA == "AC" || userA == "ac")
                {
                    placeAC = "X";
                }
                if (userA == "BA" || userA == "ba")
                {
                    placeBA = "X";
                }
                if (userA == "BB" || userA == "bb")
                {
                    placeBB = "X";
                }
                if (userA == "BC" || userA == "bc")
                {
                    placeBC = "X";
                }
                if (userA == "CA" || userA == "ca")
                {
                    placeCA = "X";
                }
                if (userA == "CB" || userA == "cb")
                {
                    placeCB = "X";
                }
                if (userA == "CC" || userA == "cc")
                {
                    placeCC = "X";
                }
                #endregion
                #region userB O input
                if (userB == "AA" || userB == "aa")
                {
                    placeAA = "О";
                }
                if (userB == "AB" || userB == "ab")
                {
                    placeAB = "О";
                }
                if (userB == "AC" || userB == "ac")
                {
                    placeAC = "О";
                }
                if (userB == "BA" || userB == "ba")
                {
                    placeBA = "О";
                }
                if (userB == "BB" || userB == "bb")
                {
                    placeBB = "О";
                }
                if (userB == "BC" || userB == "bc")
                {
                    placeBC = "О";
                }
                if (userB == "CA" || userB == "ca")
                {
                    placeCA = "О";
                }
                if (userB == "CB" || userB == "cb")
                {
                    placeCB = "О";
                }
                if (userB == "CC" || userB == "cc")
                {
                    placeCC = "О";
                }
                #endregion
                #region Matrix with symbols
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", placeAA, placeAB, placeAC);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", placeBA, placeBB, placeBC);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", placeCA, placeCB, placeCC);
                Console.WriteLine("     |     |      ");
                #endregion
            }
        }
    }
}
