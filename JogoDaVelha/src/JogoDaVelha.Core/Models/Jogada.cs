using JogoDaVelha.Core.Enums;

namespace JogoDaVelha.Core.Models
{
    public abstract class Jogada
    {
        public int Id { get; set; }
        public int Posicao { get; set; }
        public Jogador Jogador { get; set; }
        public string Rotulo { get; set; }

        protected Jogada(int id, Jogador jogador)
        {
            Id = id;
            Jogador = jogador;
            Rotulo = jogador==Jogador.Humano ? "X" : "Y";            
        }

        public abstract bool Ganhou();
        public abstract Jogada ProximaJogadaDaMaquina(); 
    }
}
