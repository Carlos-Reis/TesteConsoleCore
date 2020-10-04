using TesteConsole.Interface;

namespace TesteConsole.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chutar()
        {
            return "Teste chute \n";
        }

        public string Correr()
        {
            return "Teste corrida \n";
        }

        public string Passar()
        {
            return "Teste passe \n";
        }
    }
}