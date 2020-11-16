using GameTop.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public Jogador2(string nome = "Ronaldo")
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }

        public string Corre()
        {
            return $"{this.Nome} correu";
        }

        public string Chuta()
        {
            return $"{this.Nome} chutou";
        }

        public string Passe()
        {
            return $"{this.Nome} passou";
        }
    }
}
