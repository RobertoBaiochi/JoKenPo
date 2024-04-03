using System;
using System.Drawing;

namespace JoKenPo
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        public Image imgPc {  get; private set; }

        public Image imgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {

            int pc = JogadaPc();

            imgJogador = imagens[jogador];
            imgPc = imagens[pc];

           if (jogador == pc)
            {
                return Resultado.Empatar;
            }
           else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                return Resultado.Ganhar;
            }
           else 
            {
                return Resultado.Perder;
            }

        }

        private int JogadaPc()
        {
            int random = DateTime.Now.Millisecond;
            
            if (random < 333)
            {
                return 0;
            }
            else if (random <= 666)
            {
                return 1;
            }
            else
            {
                return 2;
            }

            return 0;
        }
    }
}
