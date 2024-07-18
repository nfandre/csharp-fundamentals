//LSP = Princípio Da Substituição de Liskov
// Paralelogramo definição de formas geográficas
namespace CsharpSolid.SOLID.LSP.Solucao
{
    public abstract class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; private set; }
        public double Largura { get; private set ; }
        public double Area { get { return Altura * Largura; } } 
    }
}