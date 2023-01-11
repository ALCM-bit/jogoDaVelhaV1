using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Models
{
    public class Board
    {
        public static char piece = 'X';
        public static int times = 0;
        private static char[] positions = 
            { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Board()
        {

        }

        public static void ShowBoard()
        {
            Console.Clear();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"|{positions[j]}|");
            }
            Console.WriteLine();
            for (int j = 3; j < 6; j++)
            {
                Console.Write($"|{positions[j]}|");
            }
            Console.WriteLine();
            for (int j = 6; j < 9; j++)
            {
                Console.Write($"|{positions[j]}|");
            }
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadKey();
        }

        public static bool PlacePiece(char positionChosed)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                if (positions[i] == positionChosed)
                {
                    if (times%2 == 0)
                    {
                        piece = 'X';
                    }
                    else
                    {
                        piece = 'O';
                    }
                    positions[i] = piece;
                    times++;
                    return true;
                } 
            }
            Console.WriteLine("Posição Inválida");
            Console.ReadKey();
            return false;
        }

    }
}
