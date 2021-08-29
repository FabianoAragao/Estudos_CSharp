using System;
using System.Collections.Generic;
using System.Globalization;
using FigurasGeometricas.Entidades;
using FigurasGeometricas.Entidades.Enuns;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> formasGeometricas = new List<Forma>();

            Console.Write("Numero de formas: ");
            int numFormas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numFormas; i++)
            {
                Console.WriteLine($"Dados da forma #{i}:");

                Console.Write("Retangulo ou círculo(r/c)? ");
                char tipoForma = char.Parse(Console.ReadLine());

                Console.Write("Cor(Preto/Azul/Vermelho): ");
                Cor corForma = Enum.Parse<Cor>(Console.ReadLine());

                if((tipoForma == 'r')||(tipoForma == 'R'))
                {
                    Console.Write("Largura: ");
                    double larguraRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Altura: ");
                    double alturaRetangulo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    formasGeometricas.Add(new Retangulo(corForma, larguraRetangulo, alturaRetangulo));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    formasGeometricas.Add(new Circulo(corForma, raioCirculo));
                }
            }

            Console.WriteLine("AREAS DAS FIGURAS: ");

            foreach (Forma formaAt in formasGeometricas)
            {
                Console.WriteLine(formaAt.ToString());
            }
        }
    }
}
