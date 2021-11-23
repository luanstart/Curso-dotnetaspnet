using GameTop.Interface;

namespace GameTop.lib
{
    public class jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Romario está chutando\n";
        }

        public string Corre()
        {
            return "Romario está correnndo\n";
        }

        public string Passa()
        {
            return "Romario está passando\n";
        }
    }
}