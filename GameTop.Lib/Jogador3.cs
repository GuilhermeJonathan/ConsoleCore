using GameTop.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "teste chuta";
        }

        public string Corre()
        {
            return "teste corre";
        }

        public string Passe()
        {
            return "teste passe";
        }
    }
}
