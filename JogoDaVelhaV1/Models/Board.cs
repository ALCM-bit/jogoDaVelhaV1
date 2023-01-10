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
        }

        public static bool PlacePiece(char positionChosed, char vez)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                if (positions[i] == positionChosed)
                {
                    positions[i] = vez;
                    return true;
                }
                else
                {
                    Console.WriteLine("Posição escolhida já foi ocupada ou é inválida");
                    return false;
                }              
            }
            Console.WriteLine("Posição Inválida");
            return false;
        }

    }
}
