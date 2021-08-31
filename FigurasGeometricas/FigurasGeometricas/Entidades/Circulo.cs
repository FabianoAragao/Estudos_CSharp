using System;
using System.Globalization;
using FigurasGeometricas.Entidades.Enuns;

namespace FigurasGeometricas.Entidades
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(Cor corFigura, double raio) : base(corFigura)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.Pow(Raio,2) * Math.PI;
        }

        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}