using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            tick_tack_toe();
        }
        static void tick_tack_toe()
        {
            bool run = true;
            bool turn = true;
            bool forever = true;
            int rotation = 0;
            string[] letter = {"1","2","3","4","5","6","7","8","9"};
            while (run == true)
            {
            
                Console.WriteLine(@$"
  {letter[0]}  │  {letter[1]}  │  {letter[2]} 
─────┼─────┼─────
  {letter[3]}  │  {letter[4]}  │  {letter[5]} 
─────┼─────┼─────
  {letter[6]}  │  {letter[7]}  │  {letter[8]}
");
                run = win(letter,rotation);
                Console.WriteLine(rotation);
                if (rotation == 9)
                {
                    Console.WriteLine("Tie!");
                    break;
                }
                if (run == false)
                {
                    Console.WriteLine("Winner!");
                    break;
                }
                if (turn == true)
                {   
                    Console.WriteLine("X's turn. Pick a number between 1-9: ");
                    while (forever == true)
                    {
                        string user = Console.ReadLine();
                        int user2 = int.Parse(user);
                        user2 = user2 - 1;
                        if (user != letter[user2])
                        {
                            Console.WriteLine("Try again");
                        }
                        else
                        {
                            letter[user2] = "X";
                            turn = false;
                            rotation = rotation + 1;
                            break;
                        }
                    }

                }
                else if (turn == false)
                {
                    Console.WriteLine("O's turn. Pick a number between 1-9: ");
                    while (forever == true)
                    {
                        string user = Console.ReadLine();
                        int user2 = int.Parse(user);
                        user2 = user2 - 1;
                        if (user != letter[user2])
                        {
                            Console.WriteLine("Try again");
                        }
                        else
                        {
                            letter[user2] = "O"; 
                            turn = true;
                            rotation = rotation + 1;
                            break;
                        }
                    }

                }
                
            }
        }
        static bool win(string[] letter, int rotation)
        {
            bool run = true;
            //Horizontal win condition
            if ((letter[0] == "X" && letter[1] == "X" && letter[2] == "X") || (letter[0] == "O" && letter[1] == "O" && letter[2] == "O"))
            {
                run = false;
            }
            if ((letter[3] == "X" && letter[4] == "X" && letter[5] == "X") || (letter[3] == "O" && letter[4] == "O" && letter[5] == "O"))
            {
                run = false;
            }
            if ((letter[6] == "X" && letter[7] == "X" && letter[8] == "X") || (letter[6] == "O" && letter[7] == "O" && letter[8] == "O"))
            {
                run = false;
            }
            // Vertical win ondition
            if ((letter[0] == "X" && letter[3] == "X" && letter[6] == "X") || (letter[0] == "O" && letter[3] == "O" && letter[6] == "O"))
            {
                run = false;
            }
            if ((letter[1] == "X" && letter[4] == "X" && letter[7] == "X") || (letter[1] == "O" && letter[4] == "O" && letter[7] == "O"))
            {
                run = false;
            }
            if ((letter[2] == "X" && letter[5] == "X" && letter[8] == "X") || (letter[2] == "O" && letter[5] == "O" && letter[8] == "O"))
            {
                run = false;
            }
            //diagnal win condition
            if ((letter[0] == "X" && letter[4] == "X" && letter[8] == "X") || (letter[0] == "O" && letter[4] == "O" && letter[8] == "O"))
            {
                run = false;
            }
            if ((letter[6] == "X" && letter[4] == "X" && letter[2] == "X") || (letter[6] == "O" && letter[4] == "O" && letter[2] == "O"))
            {
                run = false;
            }
            return run;
        }
    }
}
