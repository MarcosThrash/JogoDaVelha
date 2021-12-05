using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.JogoDaVelha.Core.BaseTest
{
    public abstract class TesteVerificacoesSeGanhouBase
    {
        protected readonly VerificacoesSeGanhou verificacoesSeGanhou;
        protected readonly List<Jogada> jogadasHorizontais;
        protected readonly List<Jogada> jogadasVerticais;
        protected readonly List<Jogada> jogadasDiagonais;

        protected TesteVerificacoesSeGanhouBase()
        {
            verificacoesSeGanhou = new VerificacoesSeGanhou();
            jogadasHorizontais = new List<Jogada>();
            jogadasVerticais = new List<Jogada>();
            jogadasDiagonais = new List<Jogada>();
            AlimentarListasParaVerificacoesHorizontais();
            AlimentarListasParaVerificacoesVerticais();
            AlimentarListasParaVerificacoesDiagonais();
        }

        private void AlimentarListasParaVerificacoesVerticais()
        {
            AdicionarJogada(new JogadaPosicao1(1, Jogador.Maquina), jogadasVerticais);
            AdicionarJogada(new JogadaPosicao4(3, Jogador.Maquina), jogadasVerticais);
            AdicionarJogada(new JogadaPosicao2(2, Jogador.Humano), jogadasVerticais);
            AdicionarJogada(new JogadaPosicao5(4, Jogador.Humano), jogadasVerticais);
            AdicionarJogada(new JogadaPosicao3(6, Jogador.Humano), jogadasVerticais);
            AdicionarJogada(new JogadaPosicao6(7, Jogador.Humano), jogadasVerticais);
        }

        private void AlimentarListasParaVerificacoesHorizontais()
        {
            AdicionarJogada(new JogadaPosicao1(1, Jogador.Humano), jogadasHorizontais);
            AdicionarJogada(new JogadaPosicao2(3, Jogador.Humano), jogadasHorizontais);
            AdicionarJogada(new JogadaPosicao5(2, Jogador.Humano), jogadasHorizontais);
            AdicionarJogada(new JogadaPosicao4(4, Jogador.Humano), jogadasHorizontais);
            AdicionarJogada(new JogadaPosicao7(7, Jogador.Maquina), jogadasHorizontais);
            AdicionarJogada(new JogadaPosicao8(5, Jogador.Maquina), jogadasHorizontais);            
        }

        private void AlimentarListasParaVerificacoesDiagonais()
        {
            AdicionarJogada(new JogadaPosicao1(1, Jogador.Humano), jogadasDiagonais);
            AdicionarJogada(new JogadaPosicao5(3, Jogador.Humano), jogadasDiagonais);
            AdicionarJogada(new JogadaPosicao7(5, Jogador.Humano), jogadasDiagonais);
        }

        private void AdicionarJogada(Jogada jogada, List<Jogada> lista)
        {
            lista.Add(jogada);
        }
    }
}
