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
                        Console.Write("Digite o Nome jogador 1: ");
                        string name1 = Console.ReadLine();
                        Player player1 = new Player(name1);

                        Console.Write("Digite o Nome jogador 2: ");
                        string name2 = Console.ReadLine();
                        Player player2 = new Player(name2);

                        Board board = new Board(player1, player2);

                        Sistema.Start(board);
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