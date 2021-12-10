using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Exceptions;
using JogoDaVelha.Core.Interfaces;
using JogoDaVelha.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Teste.JogoDaVelha.Core
{
    public class TesteJogoClassePrincipal
    {
        public Jogo Jogo { get; set; }

        public TesteJogoClassePrincipal()
        {
            Jogo = new Jogo();
        }

        [Fact]
        [Trait("Teste Prinicpal Jogo","Situaçao Continua")]
        public void DeveRetornarJogoContinua()
        {            
            //Act
            var jogadaResult = Jogo.AdicionarJogada(1, 3, Jogador.Humano);

            //Assert
            Assert.Equal(SituacaoJogo.Continua, jogadaResult.SituacaoJogo);
            Assert.Equal(LinhaDeVerificacao.SemLinha, jogadaResult.LinhaVitoria);
            Assert.Equal(Jogador.Humano, jogadaResult.JogadaAtual.Jogador);
            Assert.Equal(3, jogadaResult.JogadaAtual.Posicao);
            Assert.Equal(1, jogadaResult.JogadaAtual.IdSequencia);
        }

        [Fact]
        [Trait("Teste Prinicpal Jogo", "Exception JogadaRepetida")]
        public void DeveRetornarJogadaRepetidaException()
        {
            //Arrange & Act & Assert

            Jogo.AdicionarJogada(2, 4, Jogador.Maquina);
            var ex = Assert.Throws<JogadaRepetidaException>(() => Jogo.AdicionarJogada(7, 4, Jogador.Humano));
            Assert.Equal("Não é permitido jogar duas vezes na mesma posicão.", ex.Message);
            
        }
    }
}
