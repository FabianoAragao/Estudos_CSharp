using System.Globalization;
using FigurasGeometricas.Entidades.Enuns;

namespace FigurasGeometricas.Entidades
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo()
        {
        }

        public Retangulo(Cor corFigura,double largura, double altura) : base(corFigura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return Area().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
