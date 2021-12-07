using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Models;
using Teste.JogoDaVelha.Core.BaseTest;
using Xunit;

namespace Teste.JogoDaVelha.Core
{
    public class TesteVerificacoesSeGanhou: TesteVerificacoesSeGanhouBase
    {        
        [Fact]
        [Trait("Verificacões:","Horizontais")]
        public void DeveRetornarVerdadeiroNasHorizontais()
        {
            //arrange
            var jogadaAtualNaHorizontal1 = new JogadaPosicao3(5, Jogador.Humano, jogadasVerticais);
            var jogadaAtualNaHorizontal2 = new JogadaPosicao6(6, Jogador.Humano, jogadasVerticais);
            var jogadaAtualNaHorizontal3 = new JogadaPosicao9(9, Jogador.Maquina, jogadasVerticais);

            //act
            var resultadoH1 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasHorizontais, jogadaAtualNaHorizontal1, LinhaDeVerificacao.Horizontal_1);
            var resultadoH2 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasHorizontais, jogadaAtualNaHorizontal2, LinhaDeVerificacao.Horizontal_2);
            var resultadoH3 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasHorizontais, jogadaAtualNaHorizontal3, LinhaDeVerificacao.Horizontal_3);

            //assert
            Assert.True(resultadoH1);
            Assert.True(resultadoH2);
            Assert.True(resultadoH3);
        }

        [Fact]
        [Trait("Verificacões:", "Horizontais")]
        public void DeveRetornarFalsoNasHorizontais()
        {
            //arrange
            var jogadaAtualNaHorizontal1 = new JogadaPosicao3(5, Jogador.Maquina, jogadasVerticais);
            var jogadaAtualNaHorizontal2 = new JogadaPosicao6(6, Jogador.Maquina, jogadasVerticais);
            var jogadaAtualNaHorizontal3 = new JogadaPosicao9(9, Jogador.Humano, jogadasVerticais);

            //act
            var resultadoH1 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasHorizontais, jogadaAtualNaHorizontal1, LinhaDeVerificacao.Horizontal_1);
            var resultadoH2 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasHorizontais, jogadaAtualNaHorizontal2, LinhaDeVerificacao.Horizontal_2);
            var resultadoH3 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasHorizontais, jogadaAtualNaHorizontal3, LinhaDeVerificacao.Horizontal_3);

            //assert
            Assert.False(resultadoH1);
            Assert.False(resultadoH2);
            Assert.False(resultadoH3);
        }

        [Fact]
        [Trait("Verificacões:", "Verticais")]
        public void DeveRetornarVerdadeiroNasVerticais()
        {
            //arrange
            var jogadaAtualNaVertical1 = new JogadaPosicao7(8, Jogador.Maquina, jogadasVerticais);
            var jogadaAtualNaVertical2 = new JogadaPosicao8(7, Jogador.Humano, jogadasVerticais);
            var jogadaAtualNaVertical3 = new JogadaPosicao9(9, Jogador.Humano, jogadasVerticais);

            //act
            var resultadoH1 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasVerticais, jogadaAtualNaVertical1, LinhaDeVerificacao.Vertical_1);
            var resultadoH2 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasVerticais, jogadaAtualNaVertical2, LinhaDeVerificacao.Vertical_2);
            var resultadoH3 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasVerticais, jogadaAtualNaVertical3, LinhaDeVerificacao.Vertical_3);

            //assert
            Assert.True(resultadoH1);
            Assert.True(resultadoH2);
            Assert.True(resultadoH3);
        }

        [Fact]
        [Trait("Verificacões:", "Verticais")]
        public void DeveRetornarFalsoNasVerticais()
        {
            //arrange
            var jogadaAtualNaVertical1 = new JogadaPosicao7(8, Jogador.Humano, jogadasVerticais);
            var jogadaAtualNaVertical2 = new JogadaPosicao8(7, Jogador.Maquina, jogadasVerticais);
            var jogadaAtualNaVertical3 = new JogadaPosicao9(9, Jogador.Maquina, jogadasVerticais);

            //act
            var resultadoH1 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasVerticais, jogadaAtualNaVertical1, LinhaDeVerificacao.Vertical_1);
            var resultadoH2 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasVerticais, jogadaAtualNaVertical2, LinhaDeVerificacao.Vertical_2);
            var resultadoH3 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasVerticais, jogadaAtualNaVertical3, LinhaDeVerificacao.Vertical_3);

            //assert
            Assert.False(resultadoH1);
            Assert.False(resultadoH2);
            Assert.False(resultadoH3);
        }

        [Fact]
        [Trait("Verificacões:", "Diagonais")]
        public void DeveRetornarVerdadeiroNasDiagonais()
        {
            //arrange
            var jogadaAtual1 = new JogadaPosicao9(8, Jogador.Humano, jogadasVerticais);
            var jogadaAtual2 = new JogadaPosicao3(7, Jogador.Humano, jogadasVerticais);

            //act
            var resultadoH1 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasDiagonais, jogadaAtual1, LinhaDeVerificacao.Diagonal_1);
            var resultadoH2 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasDiagonais, jogadaAtual2, LinhaDeVerificacao.Diagonal_2);

            //assert
            Assert.True(resultadoH1);
            Assert.True(resultadoH2);
        }

        [Fact]
        [Trait("Verificacões:", "Diagonais")]
        public void DeveRetornarFalsoNasDiagonais()
        {
            //arrange
            var jogadaAtual1 = new JogadaPosicao9(8, Jogador.Maquina, jogadasVerticais);
            var jogadaAtual2 = new JogadaPosicao3(7, Jogador.Maquina, jogadasVerticais);

            //act
            var resultadoH1 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasDiagonais, jogadaAtual1, LinhaDeVerificacao.Diagonal_1);
            var resultadoH2 = verificacoesSeGanhou.VerificaSeGanhouPorLinha(jogadasDiagonais, jogadaAtual2, LinhaDeVerificacao.Diagonal_2);

            //assert
            Assert.False(resultadoH1);
            Assert.False(resultadoH2);
        }
    }
}
