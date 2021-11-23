using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador1:iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Fênomeno")
        {
            _Nome = nome;
        }
        //chuta
        public string Chuta(){
            return $"{_Nome} está chutando\n";
        }
        //corre
        public string Corre(){
            return $"{_Nome} está correndo\n";
        }
        //passa
        public string Passa(){
            return $"{_Nome} está passando\n";
        }
    }
}