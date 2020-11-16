using GameTop;
using GameTop.Interface;
using GameTop.Lib;
using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador3(), new Jogador2("Ronaldo"));
            jogo.IniciarJogo();
            Console.ReadLine();
        }
    }
}
