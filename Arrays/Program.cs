using System;
using System.Threading;

namespace Array
{
    class TicTacToe
    {
        static public void Main()
        {
            var table = new Matrix();
            table.ClearTable();
            Console.WriteLine("Here is a little game for you");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Tic Tac Toe!\n\n\n");
            table.DisplayTable();
            Console.WriteLine("\n\n\nX makes the first move!");
            Console.WriteLine("Press enter to contimue...");
            string dump=Console.ReadLine();
            Console.Clear();
            bool flag=false;
            while (flag == false)
            {
                table.DisplayTable();
                table.AnnounceTurn();
                turn:
                Console.WriteLine("Pick a row");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick a column");
                int col = int.Parse(Console.ReadLine());
                try
                {
                    table.ChangeTable(row, col);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please only select a blank cell. Try again");
                    goto turn;
                }
                Console.Clear();
                flag=table.SetFlag(flag);
                if(flag==true)
                    table.AnnounceWinner();
                else
                    table.ChangePlayer();
            }
        }
    }
    class Matrix
    {
        private char[,] table = new char[3, 3];
        private char player;
        public Matrix()
        {
            player = 'X';
        }
        public void AnnounceTurn()
        {
            Console.WriteLine("It's your turn, {0}!", player);
        }
        public void ClearTable()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = ' ';
                }
            }
        }
        public void DisplayTable()
        {
            Console.WriteLine("       1 | 2 | 3\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                        Console.Write("{0}     _{1}_|", i+1,table[i, j]);
                    else if (j==1)
                        Console.Write("_{0}_|", table[i, j]);
                    else
                        Console.Write("_{0}_", table[i, j]);
                }
                Console.Write("\n");
            }
        }
        public void ChangeTable(int row,int col)
        {
            if (table[row - 1, col - 1] == ' ')
            {
                table[row - 1, col - 1] = player;
            }
            else
            {
                throw new Exception();
            }
        }
        public void ChangePlayer()
        {
            player = player == 'X' ? 'O' : 'X';
        }
        public bool SetFlag(bool flag)
        {
            for (int i = 0; i < 3; i++)
            {
                if (table[i,0]==player && table[i,1]==player && table[i, 2] == player)
                {
                    flag = true;
                }
                else if(table[0, i] == player && table[1, i] == player && table[2, i] == player)
                {
                    flag = true;
                }
                else if (table[0, 0] == player && table[1, 1] == player && table[2, 2] == player)
                {
                    flag = true;
                }
                else if (table[0, 2] == player && table[1, 1] == player && table[2, 0] == player)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public void AnnounceWinner()
        {
            DisplayTable();
            Console.WriteLine("\n\n{0} wins!",player);
        }
    }
}