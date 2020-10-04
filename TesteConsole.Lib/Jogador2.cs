using TesteConsole.Interface;

namespace TesteConsole.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Bruno is kicking \n";
        }

        public string Correr()
        {
            return "Bruno is running \n";
        }

        public string Passar()
        {
            return "Bruno is passing \n";
        }
    }
}