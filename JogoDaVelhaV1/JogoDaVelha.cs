using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1
{
    public class JogoDaVelha
    {
        private bool fimDeJogo;
        private char[] posicoes;
        private char vez;
        private int quantidadePreenchida;

        public JogoDaVelha()
        {
            fimDeJogo = false;
            posicoes = new[] {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            vez = 'X';
            quantidadePreenchida = 0;
        }
        private void MudarVez()
        {
            vez = vez == 'X' ? 'O' : 'X';
        }

        private void VerificarFimDeJogo()
        {
            if (quantidadePreenchida < 5)
            {
                return;

            }
            if (ExisteVitoriaDiagonal() || ExisteVitoriaVertical() || ExisteVitoriaHorizontal())
            {
                fimDeJogo = true;
                Console.WriteLine($"Fim de jogo!!! Vitória de {vez}");
                return;
            }
            if (quantidadePreenchida is 9)
            {
                fimDeJogo = true;
                Console.WriteLine("Fim de jogo!!! Empate");
            }
        }

        private bool ExisteVitoriaHorizontal()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[1] && posicoes[0] == posicoes[2];
            bool vitoriaLinha2 = posicoes[3] == posicoes[4] && posicoes[3] == posicoes[5];
            bool vitoriaLinha3 = posicoes[6] == posicoes[7] && posicoes[6] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;

        }
        private bool ExisteVitoriaVertical()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[3] && posicoes[0] == posicoes[6];
            bool vitoriaLinha2 = posicoes[1] == posicoes[4] && posicoes[1] == posicoes[7];
            bool vitoriaLinha3 = posicoes[2] == posicoes[5] && posicoes[2] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;

        }
        private bool ExisteVitoriaDiagonal()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[4] && posicoes[0] == posicoes[8];
            bool vitoriaLinha2 = posicoes[2] == posicoes[4] && posicoes[2] == posicoes[6];
            

            return vitoriaLinha1 || vitoriaLinha2;

        }
        private void LerEscolhaDoUsuario()
        {
            Console.WriteLine($"Agora é a vez de {vez}, digite uma posicao de 1 a 9: ");
            bool conversao = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

            while (!conversao || !ValidarEscolhaUsuario(posicaoEscolhida))
            {
                Console.WriteLine("O campo escolhido é inválido, " +
                    "por favor digite um número entre 1 e 9 que esteja disponível na tabela");
                conversao = int.TryParse(Console.ReadLine(), out posicaoEscolhida);
            }

            PreencheEscolha(posicaoEscolhida);

        }

        private void PreencheEscolha(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida -1;
            posicoes[indice] = vez;
            quantidadePreenchida++;
            
        }

        private bool ValidarEscolhaUsuario(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;

            return posicoes[indice] != 'O' && posicoes[indice] != 'X';
        }

        private void RenderizarTabela()
        {
            Console.Clear();
            Console.WriteLine(ObterTabela());
        }

        private string ObterTabela()
        {
            return $"  {posicoes[0]}  |  {posicoes[1]}  |  {posicoes[2]}  \n" +
                   $"  {posicoes[3]}  |  {posicoes[4]}  |  {posicoes[5]}  \n" +
                   $"  {posicoes[6]}  |  {posicoes[7]}  |  {posicoes[8]}  \n\n";
        }

        public void Iniciar()
        {
            while (!fimDeJogo)
            {
                RenderizarTabela();
                LerEscolhaDoUsuario();
                RenderizarTabela();
                VerificarFimDeJogo();
                MudarVez();
            }
        }

       
    }
}
