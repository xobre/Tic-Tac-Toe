using System;

namespace TicTacToe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int choice;   
        static bool flag = false;
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2");
                }
                else
                {
                    Console.WriteLine("Player 1");
                }

                Console.WriteLine("\n");

                Board();

                CheckWin();
                if (flag == true)
                {
                    Console.Clear();
                    Board();
                    Console.WriteLine("Player {0} has won", (player % 2) + 1);
                    Console.ReadLine();
                }

                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
            }
            while (player < 11);
        
            static void Board()
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     |     |      ");
            }
            static void CheckWin()
            {
                if (player == 10 && flag == false)
                {
                    Console.Clear();
                    Board();
                    Console.WriteLine("Draw");
                    Console.ReadLine();
                }
                if (arr[1] == arr[2] && arr[2] == arr[3]) flag = true;
                if (arr[4] == arr[5] && arr[5] == arr[6]) flag = true;
                if (arr[7] == arr[8] && arr[8] == arr[9]) flag = true;
                if (arr[1] == arr[4] && arr[4] == arr[7]) flag = true;
                if (arr[2] == arr[5] && arr[5] == arr[8]) flag = true;
                if (arr[3] == arr[6] && arr[6] == arr[9]) flag = true;
                if (arr[1] == arr[5] && arr[5] == arr[9]) flag = true;
                if (arr[3] == arr[5] && arr[5] == arr[7]) flag = true;
            }    
        }
    }
}

