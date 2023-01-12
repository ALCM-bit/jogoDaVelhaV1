using JogoDaVelhaV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Sistemas
{
    public class StartGame
    {
        public static void Start(Board board)
        {
            while (board.checkForVictory() != 1)
            {
                board.ShowBoard();
                char place = char.Parse(Console.ReadLine());
                board.PlacePiece(place);
            }
        }
    }
}
