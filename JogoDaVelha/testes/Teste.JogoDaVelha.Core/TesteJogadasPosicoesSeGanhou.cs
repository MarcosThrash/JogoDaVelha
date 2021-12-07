using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Teste.JogoDaVelha.Core
{
    public class TesteJogadasPosicoesSeGanhou
    {

        protected readonly List<Jogada> jogadas;

        public TesteJogadasPosicoesSeGanhou()
        {
            jogadas = new List<Jogada>();
            jogadas.Add(new JogadaPosicao5(3, Jogador.Maquina, jogadas));
            jogadas.Add(new JogadaPosicao9(5, Jogador.Humano, jogadas));

            jogadas.Add(new JogadaPosicao2(3, Jogador.Maquina, jogadas));
            jogadas.Add(new JogadaPosicao3(5, Jogador.Humano, jogadas));
            jogadas.Add(new JogadaPosicao4(3, Jogador.Maquina, jogadas));
            jogadas.Add(new JogadaPosicao6(5, Jogador.Humano, jogadas));
            jogadas.Add(new JogadaPosicao7(3, Jogador.Maquina, jogadas));
            jogadas.Add(new JogadaPosicao8(5, Jogador.Maquina, jogadas));
        }

        [Fact]
        [Trait("TestePosicoes","SeGanhou")]
        public void TesteSeganhouDeveRetornarVerdadeiro()
        {
            //arrange
            var jogadaP1 = new JogadaPosicao1(1, Jogador.Maquina, jogadas);

            //act
            var resultadoP1 = jogadaP1.SituacaoPosJogada();

            //assert
            Assert.Equal(SituacaoJogo.MaquinaGanhou, resultadoP1.SituacaoJogo);
            Assert.Equal(LinhaDeVerificacao.Vertical_1, resultadoP1.LinhaVitoria);
        }
    }
}
