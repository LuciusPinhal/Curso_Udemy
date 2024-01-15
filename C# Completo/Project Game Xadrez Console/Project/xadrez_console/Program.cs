using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez pos = new('c', 8);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 9));

                //Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}