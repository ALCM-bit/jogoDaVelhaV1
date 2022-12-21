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

        public JogoDaVelha()
        {
            fimDeJogo = false;
            posicoes = new[] {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            vez = 'X';
        }
        private void MudarVez()
        {
            vez = vez == 'X' ? 'O' : 'X';
        }

        private void VerificarFimDeJogo()
        {
            throw new NotImplementedException();
        }

        private void LerEscolhaDoUsuario()
        {
            throw new NotImplementedException();
        }

        private void RenderizarTabela()
        {
            throw new NotImplementedException();
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
