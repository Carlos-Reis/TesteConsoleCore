using System;
using TesteConsole.Lib;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoTeste(
                new Jogador1(), 
                new Jogador3()
            );

            jogo.IniciarJogo();
        }
    }

    
    
}
