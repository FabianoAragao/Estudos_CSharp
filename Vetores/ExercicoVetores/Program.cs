using System;

namespace ExercicoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Quantidade de pessoas:");

            int qtde = int.Parse(Console.ReadLine());

            Pensionato[] quartos = new Pensionato[10];

            for (int i = 0; i < qtde; i++)
            {
                int numeroQuarto = 0;
                string nome, email;

                Console.WriteLine("Digite o nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o email:");
                email = Console.ReadLine();

                Console.WriteLine("Digite o numero do quarto:");
                numeroQuarto = int.Parse(Console.ReadLine());

                quartos[numeroQuarto] = new Pensionato();

                quartos[numeroQuarto].Nome = nome;
                quartos[numeroQuarto].Email = email;
            }

            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}:{quartos[i].Nome}, {quartos[i].Email}");
                }
            }
        }
    }
}
