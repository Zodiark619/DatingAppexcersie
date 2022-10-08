using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdotnet5
{
    static class susu1
    {
        public static void Hihi3()
        {
        char[,] meong = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            susu.SetField();

    }



    public static bool Hihi2()
        {
            char[] koko = { 'X', 'O' };

            foreach(char c in koko)
            {
                if(susu.meong[0, 0]==c&& susu.meong[0, 1]==c&& susu.meong[0, 2]==c ||
                    susu.meong[1, 0] == c && susu.meong[1, 1] == c && susu.meong[1, 2] == c ||
                    susu.meong[2, 0] == c && susu.meong[2, 1] == c && susu.meong[2, 2] == c ||
                    susu.meong[0, 0] == c && susu.meong[1, 0] == c && susu.meong[2, 0] == c ||
                    susu.meong[0, 1] == c && susu.meong[1, 1] == c && susu.meong[2, 1] == c ||
                    susu.meong[0, 2] == c && susu.meong[1, 2] == c && susu.meong[2, 2] == c ||
                    susu.meong[0, 0] == c && susu.meong[1,1] == c && susu.meong[2,2] == c ||
                    susu.meong[0, 2] == c && susu.meong[1,1] == c && susu.meong[2, 0] == c )
                {
                    if (c == 'X')
                    {
                        susu.SetField();

                        Console.WriteLine($"Player 2 has won!!");
                        return true;
                    }
                    else if (c == 'O')
                    {
                        susu.SetField();

                        Console.WriteLine($"Player 1 has won!!");
                        return true;
                    }
                }
            }
            return false;
            

        }


        public static int Hihi1(int player)
        {
         
            while (true)
            {
                //int input = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Player {player}, pick which number: ");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int sisi))
                {
                    if (sisi < 1 || sisi > 10)
                    {
                        Console.WriteLine("numbers within 1-9 only");

                        continue;
                    }
                    return sisi;
                   

                }
                else
                {
                    Console.WriteLine("wrong input,only integer");
                }
            }
            
        }

        public static bool Hihi(int player,int input)
        {
            char meong=' ';
            if (player == 1) meong = 'X';
            else if (player == 2) meong = 'O';

            switch (input)
            {
                case 1:
                    if (susu.meong[0, 0]!='X'&& susu.meong[0, 0]!='O')
                    {
                        susu.meong[0, 0] = meong;
                        return true;

                    }
                   

                        return false;
                   
                    
                case 2:
                    if (susu.meong[0, 1] != 'X' && susu.meong[0, 1] != 'O')
                    {
                        susu.meong[0, 1] = meong;
                        return true;

                    }
                   

                        return false;
                    
                case 3:
                    if (susu.meong[0, 2] != 'X' && susu.meong[0, 2] != 'O')
                    {
                        susu.meong[0, 2] = meong;
                        return true;

                    }
                   

                        return false;
                   
                case 4:
                    if (susu.meong[1, 0] != 'X' && susu.meong[1, 0] != 'O')
                    {
                        susu.meong[1, 0] = meong;
                        return true;

                    }
                    

                        return false;
                   
                case 5:
                    if (susu.meong[1, 1] != 'X' && susu.meong[1,1] != 'O')
                    {
                        susu.meong[1,1] = meong;
                        return true;

                    }
                   

                        return false;
                  
                case 6:
                    if (susu.meong[1, 2] != 'X' && susu.meong[1,2] != 'O')
                    {
                        susu.meong[1,2] = meong;
                        return true;

                    }
                    

                        return false;
                  
                case 7:
                    if (susu.meong[2, 0] != 'X' && susu.meong[2, 0] != 'O')
                    {
                        susu.meong[2, 0] = meong;
                        return true;

                    }
                   

                        return false;
                   
                case 8:
                    if (susu.meong[2,1] != 'X' && susu.meong[2,1] != 'O')
                    {
                        susu.meong[2,1] = meong;
                        return true;

                    }
                    

                        return false;
                   
                case 9:
                    if (susu.meong[2,2] != 'X' && susu.meong[2,2] != 'O')
                    {
                        susu.meong[2,2] = meong;
                        return true;

                    }
                   

                        return false;
                    
                
            }
            return false;
        }
        

    }

    internal static class susu
    {
        public static char[,] meong = { { '1','2','3' }, { '4','5','6' } ,{ '7','8','9' } };
        public static void SetField()
        {
            Console.WriteLine();
            Console.WriteLine("|~~~~~|~~~~~|~~~~~|");
            Console.WriteLine("|     |     |     |");

            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", meong[0, 0], meong[0, 1], meong[0,2]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|     |     |     |");

            Console.WriteLine("|~~~~~|~~~~~|~~~~~|");
            Console.WriteLine("|     |     |     |");

            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", meong[1, 0], meong[1, 1], meong[1, 2]);
            Console.WriteLine("|     |     |     |");

            Console.WriteLine("|     |     |     |");

            Console.WriteLine("|~~~~~|~~~~~|~~~~~|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", meong[2, 0], meong[2, 1], meong[2, 2]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|     |     |     |");


            Console.WriteLine("|~~~~~|~~~~~|~~~~~|");

        }
    }
}
