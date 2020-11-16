using GameTop.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop
{
    public class JogoFoda
    {
        public readonly iJogador _jogadorA;
        public readonly iJogador _jogadorB;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            this._jogadorA = jogadorA;
            this._jogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Corre());
            Console.WriteLine(_jogadorA.Chuta());
            Console.WriteLine(_jogadorA.Passe());
            Console.WriteLine("/n");

            Console.WriteLine(_jogadorB.Corre());
            Console.WriteLine(_jogadorB.Chuta());
            Console.WriteLine(_jogadorB.Passe());
        }
    }
}
