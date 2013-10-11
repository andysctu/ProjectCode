using System;
using System.Text;
class TicTacToe
{
    private int a, b, c, d, e, f, g, h, i;
    public string[] XandOs = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
    private bool isWon = false;
    public string sumString;

    public TicTacToe()
    {
        a = 1; b = 2; c = 3; d = 4; e = 5; f = 6; g = 7; h = 8; i = 9;

        Console.WriteLine();
        Console.WriteLine("  {0}  {1}  {2}  {3}  {4}", a, "|", b, "|", c);
        Console.WriteLine("---------------");
        Console.WriteLine("  {0}  {1}  {2}  {3}  {4}", d, "|", e, "|", f);
        Console.WriteLine("---------------");
        Console.WriteLine("  {0}  {1}  {2}  {3}  {4}", g, "|", h, "|", i);
        Console.WriteLine();
    }

    public void Player1Move(int i)
    {
        string y;
        while (i < 1 || i > 9)
        {
            Console.WriteLine("Please enter a valid move");
            i = Convert.ToInt32(Console.ReadLine());
        }

        while (XandOs[i - 1] == "X" || XandOs[i - 1] == "O")
        {
            do
            {
                Console.WriteLine("That spot is already taken! Please enter a valid move");
                y = Console.ReadLine();
            } while (y == "");

            i = Convert.ToInt32(y);
            while (i < 1 || i > 9)
            {
                Console.WriteLine("Please enter a valid move");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }

        switch (i)
        {
            case 1: a = (int)Math.Pow(10, i); XandOs[0] = "X"; break;
            case 2: b = (int)Math.Pow(10, i); XandOs[1] = "X"; break;
            case 3: c = (int)Math.Pow(10, i); XandOs[2] = "X"; break;
            case 4: d = (int)Math.Pow(10, i); XandOs[3] = "X"; break;
            case 5: e = (int)Math.Pow(10, i); XandOs[4] = "X"; break;
            case 6: f = (int)Math.Pow(10, i); XandOs[5] = "X"; break;
            case 7: g = (int)Math.Pow(10, i); XandOs[6] = "X"; break;
            case 8: h = (int)Math.Pow(10, i); XandOs[7] = "X"; break;
            case 9: i = (int)Math.Pow(10, i); XandOs[8] = "X"; break;
        }

        for (int m = 0; m < 9; m += 3)
        {
            for (int n = 0; n < 3; n++)
            {
                if (XandOs[m + n] == "X")
                {
                    sumString = sumString + XandOs[m + n];
                }

            }
            if (sumString == "XXX")
            {
                isWon = true;
            }
            else
            {
                sumString = "";
            }

        }
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 9; n += 3)
            {
                if (XandOs[m + n] == "X")
                {
                    sumString = sumString + XandOs[m + n];
                }
            }
            if (sumString == "XXX")
            {
                isWon = true;
            }
            else
            {
                sumString = "";
            }

        }
        for (int m = 0; m < 9; m += 4)
        {
            if (XandOs[m] == "X")
            {
                sumString = sumString + XandOs[m];
            }

        }
        if (sumString == "XXX")
        {
            isWon = true;
        }
        else
        {
            sumString = "";
        }
        for (int m = 2; m < 7; m += 2)
        {
            if (XandOs[m] == "X")
            {
                sumString = sumString + XandOs[m];
            }

        }
        if (sumString == "XXX")
        {
            isWon = true;
        }
        else
        {
            sumString = "";
        }

    }

    public void Player2Move(int i)
    {
        string y;
        while (i < 1 || i > 9)
        {
            Console.WriteLine("Please enter a valid move");
            i = Convert.ToInt32(Console.ReadLine());
        }

        while (XandOs[i - 1] == "X" || XandOs[i - 1] == "O")
        {
            do
            {
                Console.WriteLine("That spot is already taken! Please enter a valid move");
                y = Console.ReadLine();
            } while (y == "");

            i = Convert.ToInt32(y);

            while (i < 1 || i > 9)
            {
                Console.WriteLine("Please enter a valid move");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }

        switch (i)
        {
            case 1: a = (int)Math.Pow(10, i); XandOs[0] = "O"; break;
            case 2: b = (int)Math.Pow(10, i); XandOs[1] = "O"; break;
            case 3: c = (int)Math.Pow(10, i); XandOs[2] = "O"; break;
            case 4: d = (int)Math.Pow(10, i); XandOs[3] = "O"; break;
            case 5: e = (int)Math.Pow(10, i); XandOs[4] = "O"; break;
            case 6: f = (int)Math.Pow(10, i); XandOs[5] = "O"; break;
            case 7: g = (int)Math.Pow(10, i); XandOs[6] = "O"; break;
            case 8: h = (int)Math.Pow(10, i); XandOs[7] = "O"; break;
            case 9: i = (int)Math.Pow(10, i); XandOs[8] = "O"; break;
        }
        for (int m = 0; m < 9; m += 3)
        {
            for (int n = 0; n < 3; n++)
            {
                if (XandOs[m + n] == "O")
                {
                    sumString = sumString + XandOs[m + n];
                }

            }
            if (sumString == "OOO")
            {
                isWon = true;
            }
            else
            {
                sumString = "";
            }

        }
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 9; n += 3)
            {
                if (XandOs[m + n] == "O")
                {
                    sumString = sumString + XandOs[m + n];
                }
            }
            if (sumString == "OOO")
            {
                isWon = true;
            }
            else
            {
                sumString = "";
            }

        }
        for (int m = 0; m < 9; m += 4)
        {
            if (XandOs[m] == "O")
            {
                sumString = sumString + XandOs[m];
            }

        }
        if (sumString == "OOO")
        {
            isWon = true;
        }
        else
        {
            sumString = "";
        }
        for (int m = 2; m < 7; m += 2)
        {
            if (XandOs[m] == "O")
            {
                sumString = sumString + XandOs[m];
            }

        }
        if (sumString == "OOO")
        {
            isWon = true;
        }
        else
        {
            sumString = "";
        }

    }

    public void EasyComputerMove()
    {
        Random random = new Random();
        int i = random.Next(0, 9);
        while (XandOs[i] == "X" || XandOs[i] == "O")
        {
            i = random.Next(0, 9);
        }
        switch (i)
        {
            case 1: a = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 2: b = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 3: c = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 4: d = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 5: e = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 6: f = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 7: g = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 8: h = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
            case 9: i = (int)Math.Pow(10, i); XandOs[i] = "O"; break;
        }
        for (int m = 0; m < 9; m += 3)
        {
            for (int n = 0; n < 3; n++)
            {
                if (XandOs[m + n] == "O")
                {
                    sumString = sumString + XandOs[m + n];
                }

            }
            if (sumString == "OOO")
            {
                isWon = true;
            }
            else
            {
                sumString = "";
            }

        }
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 9; n += 3)
            {
                if (XandOs[m + n] == "O")
                {
                    sumString = sumString + XandOs[m + n];
                }
            }
            if (sumString == "OOO")
            {
                isWon = true;
            }
            else
            {
                sumString = "";
            }

        }
        for (int m = 0; m < 9; m += 4)
        {
            if (XandOs[m] == "O")
            {
                sumString = sumString + XandOs[m];
            }

        }
        if (sumString == "OOO")
        {
            isWon = true;
        }
        else
        {
            sumString = "";
        }
        for (int m = 2; m < 7; m += 2)
        {
            if (XandOs[m] == "O")
            {
                sumString = sumString + XandOs[m];
            }

        }
        if (sumString == "OOO")
        {
            isWon = true;
        }
        else
        {
            sumString = "";
        }
    }


    public void DisplayBoard()
    {
        Console.WriteLine();
        Console.WriteLine("  {0} {1}  {2}  {3}  {4}", XandOs[0], "|", XandOs[1], "|", XandOs[2]);
        Console.WriteLine("---------------");
        Console.WriteLine("  {0} {1}  {2}  {3}  {4}", XandOs[3], "|", XandOs[4], "|", XandOs[5]);
        Console.WriteLine("---------------");
        Console.WriteLine("  {0} {1}  {2}  {3}  {4}", XandOs[6], "|", XandOs[7], "|", XandOs[8]);
        Console.WriteLine();
    }


    public static void DisplayTitle()
    {
        Console.WriteLine(string.Format("{0,13}", "Welcome To"));
        Console.WriteLine();
        Console.WriteLine("  {0}  {1}  {2}  {3}  {4}", "T", "|", "I", "|", "C");
        Console.WriteLine("---------------");
        Console.WriteLine("  {0}  {1}  {2}  {3}  {4}", "T", "|", "A", "|", "C");
        Console.WriteLine("---------------");
        Console.WriteLine("  {0}  {1}  {2}  {3}  {4}", "T", "|", "O", "|", "E");
        Console.WriteLine();
        Console.WriteLine("Press Enter to Continue");
        Console.ReadKey();
        Console.WriteLine();



    }
    static string ConvertStringArrayToString(string[] array)
    {
        //
        // Concatenate all the elements into a StringBuilder.
        //
        StringBuilder builder = new StringBuilder();
        foreach (string value in array)
        {
            builder.Append(value);
            builder.Append('.');
        }
        return builder.ToString();
    }
    static string ConvertStringArrayToStringJoin(string[] array)
    {
        //
        // Use string Join to concatenate the string elements.
        //
        string result = string.Join("", array);
        return result;
    }




    public static void Main()
    {

        DisplayTitle();
        int numPlayers;
        string numPlayer;
        //string tieDeterminant = "OOOOXXXXX";
        //string[] sorted;
        do
        {
            Console.Write("1 Player or 2 Players? : ");
            numPlayer = (Console.ReadLine());
        } while (!((numPlayer == "1") || (numPlayer == "2")));

        numPlayers = Convert.ToInt32(numPlayer);

        if (numPlayers == 1)
        {
            TicTacToe game1 = new TicTacToe();
            int x;
            string y;
            do
            {
                
                do
                {
                Console.Write("Your move: ");
                y = (Console.ReadLine());
                } while ( y == "");

                x = Convert.ToInt32(y);
                game1.Player1Move(x);
                game1.DisplayBoard();

                //sorted = (game1.XandOs).Sort;
                //if (tieDeterminant == ConvertStringArrayToStringJoin(sorted))
                //{
                //    Console.WriteLine("It's a Tie!");
                //    break;
                //}
                if (game1.isWon == true)
                {
                    Console.WriteLine("You Win!");
                    break;
                }



                Console.WriteLine("Computer's Move\n\nPress Enter");
                Console.ReadKey();
                game1.EasyComputerMove();
                game1.DisplayBoard();
                

                if (game1.isWon == true)
                {
                    Console.WriteLine("You Lose!");
                    break;
                }
            } while (game1.isWon == false);
            Console.ReadKey();
        }


        else if (numPlayers == 2)
        {
            TicTacToe game2 = new TicTacToe();
            int x;
            string y;
            do
            {
                
                do
                {
                    Console.Write("Player 1's turn: ");
                    y = Console.ReadLine();
                } while (y == "");

                x = Convert.ToInt32(y);
                game2.Player1Move(x);
                game2.DisplayBoard();

                
                if (game2.isWon == true)
                {
                    Console.WriteLine("Player 1 Wins!");
                    break;
                }


                do
                {
                    Console.Write("Player 2's turn: ");
                    y = Console.ReadLine();
                } while (y == "");

                x = Convert.ToInt32(y);
                game2.Player2Move(x);
                game2.DisplayBoard();

                

                if (game2.isWon == true)
                {
                    Console.WriteLine("Player 2 Wins!");
                    break;
                }
            } while (game2.isWon == false);



            Console.ReadKey();
        }

    }
}


