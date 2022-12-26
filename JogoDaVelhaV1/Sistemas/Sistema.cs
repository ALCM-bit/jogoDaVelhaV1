using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace JogoDaVelhaV1.Sistemas
{
    public class Sistema
    {
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Lembre-se que, para zerar o placar é necessário reiniciar a aplicação");
            Console.WriteLine("--------------------------");
            Console.WriteLine("0 - Para finalizar o programa;");
            Console.WriteLine("1 - Iniciar nova partida;");
            Console.WriteLine("2 - Ver Placar.");
            Console.Write("Digite a opção desejada: ");
        }

        public static void IniciarSistema()
        {
            
            int option = 0;
            do
            {
                JogoDaVelha jogo = new JogoDaVelha();
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    case 1: 
                        Console.WriteLine("Iniciando jogo...");
                        jogo.Iniciar();
                        Console.WriteLine("Aperte ENTER para finalizar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Mostrando Placar");
                        jogo.MostrarPlacar();
                        Console.WriteLine("Aperte ENTER para finalizar");
                        Console.ReadLine();
                        break;
                }

            } while (option != 0);

        }
    }
}
