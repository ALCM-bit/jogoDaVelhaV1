using JogoDaVelhaV1.Models;
using JogoDaVelhaV1.Sistemas;
using JogoDaVelhaV1.Views;
using System;

namespace JogoDaVelhaV1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int option = 10;
            Menus.ShowWelcome();

            while (option != 0)
            {
                Menus.ShowOptions();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Board.ShowBoard();
                        Board.PlacePiece('1');
                        Board.ShowBoard();
                        Board.PlacePiece('1');
                        Board.ShowBoard();

                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}