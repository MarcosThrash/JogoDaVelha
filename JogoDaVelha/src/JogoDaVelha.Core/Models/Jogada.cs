﻿using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Models
{
    public abstract class Jogada
    {
        public int Id { get; set; }
        public int Posicao { get; set; }
        public Jogador Jogador { get; set; }
        public string Rotulo { get; set; }

        protected Jogada(int id, Jogador jogador, string rotulo)
        {
            Id = id;
            Jogador = jogador;
            Rotulo = rotulo.ToUpper();
        }

        public abstract bool Ganhou();
        public abstract Jogada OndeJogar(); 
    }
}