using System;
using GameTop.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new JogoFODA(
               new Jogador1(),
               new jogador2());
           
           jogo.iniciarJOGO();
        }
    }
}
