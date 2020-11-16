using GameTop.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop
{
    public class Jogador1 : iJogador
    {
        public Jogador1()
        {

        }

        public string Corre()
        {
            return $"Maradona correu";
        }

        public string Chuta()
        {
            return $"Maradona chutou";
        }

        public string Passe()
        {
            return $"Maradona passou";
        }

    }
}
