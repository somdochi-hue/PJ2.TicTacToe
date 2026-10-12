using System;
using System.Linq;


namespace TicTacToe02
{
    internal class PlayBoard
    {
        private string[] comma = Enumerable.Repeat(" .", 9).ToArray();
        public void ShowBox()
        {

            for (int i = 0; i < comma.Length; i++)
            {
                Console.Write(comma[i]);

                if (i % 3 != 2)
                {
                    Console.Write(" |");
                }

                if (i % 3 == 2)
                {
                    Console.WriteLine();
                    
                    if (i < comma.Length - 1)
                    {
                        Console.WriteLine("-----------");
                    }
                }
            }
            Console.WriteLine();
        }
        //public bool 
    }
}
