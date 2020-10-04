using TesteConsole.Interface;

namespace TesteConsole.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1 (string nome = "Carlos")
        {
            _Nome = nome;
        }
        //chutar
        public string Chutar()
        {
            return $"{_Nome} está chutando \n";
        }
        //correr
        public string Correr()
        {
            return $"{_Nome} está correndo \n";
        }
        //passar
        public string Passar()
        {
            return $"{_Nome} está passando \n";
        }
    }
}