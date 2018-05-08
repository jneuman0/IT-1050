namespace IT_1050_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] board = new string[8][];

            for (int i = 0; i < 8; i++)


           {

                System.Console.WriteLine("+---+---+---+---+---+---+---+---+");

                board[i] = new string[8];

                for (int j = 0; j < 8; j++)

                {



                    board[i][j] = "  ";

                    if (i <= 1 || i >= 6)

                    {

                        board[i][j] = "X ";

                    }

                    System.Console.Write("| " + board[i][j]);

                }

                System.Console.WriteLine("|");

            }

            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");



            System.Console.WriteLine(" ");



            int a = 0;

            int b = 0;

            int c = 0;

            int d = 0;



            while (a <= 7 && a >= 0 && b <= 7 && b >= 0 && c <= 7 && c >= 0 && d <= 7 && d >= 0)

            {

                System.Console.WriteLine(" ");

                System.Console.WriteLine("Type an X Coordinate Between 0 and 7:");

                a = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Type a Y Coordinate Between 0 and 7:");

                b = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Type an X Coordinate Between 0 and 7:");

                c = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Type a Y Coordinate Between 0 and 7:");

                d = int.Parse(System.Console.ReadLine());

                System.Console.Clear();



                if (a <= 7 && a >= 0 && b <= 7 && b >= 0 && c <= 7 && c >= 0 && d <= 7 && d >= 0)

                {

                    for (int i = 0; i < 8; i++)



                    {

                        System.Console.WriteLine("+---+---+---+---+---+---+---+---+");

                        board[i] = new string[8];



                        for (int j = 0; j < 8; j++)

                        {

                            board[i][j] = "  ";

                            if (i <= 1 || i >= 6)

                            {

                                board[i][j] = "X ";

                            }

                            board[a][b] = "  ";

                            board[c][d] = "X ";

                            System.Console.Write("| " + board[i][j]);

                        }

                        System.Console.WriteLine("|");

                    }

                    System.Console.WriteLine("+---+---+---+---+---+---+---+---+");

                }

            }

            System.Console.WriteLine("Invalid.");
                        
            System.Console.ReadKey();
























        }
    }
}
