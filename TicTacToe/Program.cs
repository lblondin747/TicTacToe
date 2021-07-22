using System;

namespace TicTacToe
{
    class Program
    {
        public static class Globals
        {
            
            public static char[] array = { '0', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
            public static int gameSelect;
            public static int[,] winCombos = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 }, { 1, 5, 9 }, { 3, 5, 7 } };
            
        }

        public static void PrintBoard()
        {

            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {Globals.array[1]} | {Globals.array[2]} | {Globals.array[3]} ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("-----------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {Globals.array[4]} | {Globals.array[5]} | {Globals.array[6]} ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("-----------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {Globals.array[7]} | {Globals.array[8]} | {Globals.array[9]} ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine();

        }
        public static void PrintBlankBoard()
        {

            Console.WriteLine("   |   |   ");
            Console.WriteLine($" 1 | 2 | 3 ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("-----------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" 4 | 5 | 6 ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("-----------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" 7 | 8 | 9 ");
            Console.WriteLine("   |   |   ");
            Console.WriteLine();

        }

        public static void Player1Move()
        {
            bool hasMoved = false;
            Console.WriteLine("Enter a number 1-9:");
            while (hasMoved == false)
            {
                bool success = int.TryParse(Console.ReadLine(), out int move);
                if (success)
                {
                    if (Globals.array[move] == ' ')
                    {
                        Globals.array[move] = 'X';
                        hasMoved = true;
                    }
                    else
                    { Console.WriteLine("That spot is taken, try again"); }
                }
                else
                    Console.WriteLine("Try again");
            }
     
        }
        public static void Player2Move()
        {
            bool hasMoved = false;
            Console.WriteLine("Enter a number 1-9:");
            while (hasMoved == false)
            {
                bool success = int.TryParse(Console.ReadLine(), out int move);
                if (success)
                {
                    if (Globals.array[move] == ' ')
                    {
                        Globals.array[move] = 'O';
                        hasMoved = true;
                    }
                    else
                    { Console.WriteLine("That spot is taken, try again"); }
                }
                else
                    Console.WriteLine("Try again");
            }

        }
        public static void ComputerMove()
        {
            bool logicMove = false;
            bool help = true;
            int c;
            for (c = 0; c < 8 && help == true; c++)
            {
                int oCount = 0;
                
                for (int i = 0; i < 3; i++)
                {
                    if (Globals.array[Globals.winCombos[c, i]] == 'O')
                    {
                        oCount++;
                    }
                    

                }
                if (oCount == 2)
                {
                    for (int d = 0; d < 3; d++)
                    {
                        if (Globals.array[Globals.winCombos[c, d]] == ' ')
                        {
                            Globals.array[Globals.winCombos[c, d]] = 'O';
                            help = false;
                            logicMove = true;
                        }


                    }

                }
            }
            if (logicMove == false)
            {
                for (c = 0; c < 8 && help == true; c++)
                {

                    int xCount = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        if (Globals.array[Globals.winCombos[c, i]] == 'X')
                        {
                            xCount++;
                        }


                    }
                    if (xCount == 2)
                    {
                        for (int d = 0; d < 3; d++)
                        {
                            if (Globals.array[Globals.winCombos[c, d]] == ' ')
                            {
                                Globals.array[Globals.winCombos[c, d]] = 'O';
                                help = false;
                                logicMove = true;
                            }


                        }

                    }
                }
            }
            if (logicMove == false)
            { 
            var r = new Random();
            var move = r.Next(1, 9);
            while (Globals.array[move] != ' ')
            {
                move = r.Next(1, 9);
            }
            Globals.array[move] = 'O';
            }
        }

        public static bool CheckWin()
        {
            
            if (Globals.array[1] == Globals.array[2] && Globals.array[2] == Globals.array[3])
            {
                if (Globals.array[1] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    {Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[1] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else if (Globals.array[4] == Globals.array[5] && Globals.array[5] == Globals.array[6])
            {
                if (Globals.array[4] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    { Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[4] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else if (Globals.array[7] == Globals.array[8] && Globals.array[8] == Globals.array[9])
            {
                if (Globals.array[7] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    { Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[7] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else if (Globals.array[1] == Globals.array[4] && Globals.array[4] == Globals.array[7])
            {
                if (Globals.array[1] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    { Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[1] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else if (Globals.array[2] == Globals.array[5] && Globals.array[5] == Globals.array[8])
            {
                if (Globals.array[2] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    { Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[2] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else if (Globals.array[3] == Globals.array[6] && Globals.array[6] == Globals.array[9])
            {
                if (Globals.array[3] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    { Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[3] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else if (Globals.array[1] == Globals.array[5] && Globals.array[5] == Globals.array[9])
            {
                if (Globals.array[1] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    { Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[1] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else if (Globals.array[3] == Globals.array[5] && Globals.array[5] == Globals.array[7])
            {
                if (Globals.array[3] == 'X')
                {
                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You win!"); }
                    else
                    { Console.WriteLine("Player 1 Wins!"); }
                    return true;
                }
                else if (Globals.array[3] == 'O')
                {

                    if (Globals.gameSelect == 1)
                    { Console.WriteLine("You lose!"); }
                    else
                    { Console.WriteLine("Player 2 Wins!"); }
                    return true;
                }
                else
                    return false;
            }
            else
            { return false; }

            
        }

        static void Main(string[] args)
        {
            bool kill = false;

            Console.WriteLine("Welcome to Tic Tac Toe!");
            while (kill == false)
            {
                bool win = false;
                int moveCount = 1;
                for (int i = 1; i <= 9; i++)
                    Globals.array[i] = ' ';

                Console.WriteLine("Enter 1 for single player, and 2 for two player");
                bool success = int.TryParse(Console.ReadLine(), out Globals.gameSelect);
                if (Globals.gameSelect == 1)
                {

                    
                    PrintBlankBoard();
                    while (win == false && moveCount < 10)
                    {

                        Player1Move();
                        PrintBoard();
                        win = CheckWin();
                        
                        moveCount++;
                        if (moveCount < 10 && win == false)
                        {
                            ComputerMove();
                            PrintBoard();
                            win = CheckWin();
                            moveCount++;
                            
                        }
                    }
                    if (win == false)
                    {
                        Console.WriteLine("Tie!");
                    }




                }
                else if(Globals.gameSelect == 2)
                {
                    PrintBlankBoard();
                    while (win == false && moveCount < 10)
                    {
                        Console.WriteLine("Player 1");
                        Player1Move();
                        PrintBoard();
                        win = CheckWin();

                        moveCount++;
                        if (moveCount < 10 && win == false)
                        {
                            Console.WriteLine("Player 2");
                            Player2Move();
                            PrintBoard();
                            win = CheckWin();
                            moveCount++;

                        }
                    }
                    if (win == false)
                    {
                        Console.WriteLine("Tie!");
                    }



                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (win == true || moveCount >= 10)
                {
                    Console.WriteLine("Play again? Enter y for yes or any other key for no");

                    if (Console.ReadLine() != "y")
                    {
                        kill = true;
                    }
                }
            }
        

        }
    }
}
