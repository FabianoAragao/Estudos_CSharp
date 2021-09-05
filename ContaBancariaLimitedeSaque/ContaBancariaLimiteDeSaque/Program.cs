using System;
using System.Globalization;
using ContaBancariaLimiteDeSaque.Entidades;
using ContaBancariaLimiteDeSaque.Entidades.Excecoes;

namespace ContaBancariaLimiteDeSaque
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta");
                Console.Write("Numero: ");
                int numConta = int.Parse(Console.ReadLine());

                Console.Write("Titular: ");
                string titular = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Limite de saque: ");
                double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ContaBancaria conta = new ContaBancaria(numConta, titular, saldo, limite);

                Console.WriteLine(conta);

                Console.Write("Entre com o valor do saque: ");
                double vlrSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta.Saque(vlrSaque);
                Console.WriteLine(conta);

            }
            catch (DomaninException e)
            {
                Console.WriteLine("Não foi possível realizar o saque: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}
