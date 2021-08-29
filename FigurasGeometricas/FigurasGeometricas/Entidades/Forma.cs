using FigurasGeometricas.Entidades.Enuns;

namespace FigurasGeometricas.Entidades
{
    abstract class Forma
    {
        public Cor CorFigura { get; set; }

        protected Forma(Cor corFigura)
        {
            CorFigura = corFigura;
        }

        public abstract double Area();
    }
}
