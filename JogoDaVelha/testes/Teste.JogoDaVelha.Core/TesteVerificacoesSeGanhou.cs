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
    public class TesteVerificacoesSeGanhou
    {

        private readonly List<Jogada> jogadasRetornaVerdadeiro;
        private readonly List<Jogada> jogadasRetornaFalso;

        public TesteVerificacoesSeGanhou()
        {
            jogadasRetornaVerdadeiro = new List<Jogada>();
            jogadasRetornaFalso = new List<Jogada>();
            var jogada1 = new JogadaPosicao1(1, Jogador.Humano,"x");
            var jogada2 = new JogadaPosicao2(3, Jogador.Humano, "x");
            jogadasRetornaVerdadeiro.Add(jogada1);
            jogadasRetornaVerdadeiro.Add(jogada2);
            jogadasRetornaFalso.Add(jogada1);
        }

        [Fact]
        [Trait("Verificacões:","Horizontal1 - Verdadeiro")]
        public void DeveRetornarVerdadeiroVerificaSeGanhouNasHorizontais()
        {
            //arrange
            var verificacaoHorizontais = new VerificacoesSeGanhou();
            var jogadaAtual = new JogadaPosicao3(5, Jogador.Humano, "x");

            //act
            var resultado = verificacaoHorizontais.VerificaSeGanhouHorizontal1(jogadasRetornaVerdadeiro, jogadaAtual);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        [Trait("Verificacões:", "Horizontal1 - Falso")]
        public void DeveRetornarFalsoVerificaSeGanhouNasHorizontais()
        {
            //arrange
            var verificacaoHorizontais = new VerificacoesSeGanhou();
            var jogadaAtual = new JogadaPosicao3(5, Jogador.Humano, "x");

            //act
            var resultado = verificacaoHorizontais.VerificaSeGanhouHorizontal1(jogadasRetornaFalso, jogadaAtual);

            //assert
            Assert.False(resultado);
        }
    }
}
