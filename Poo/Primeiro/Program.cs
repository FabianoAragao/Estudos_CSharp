using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria();
         
            while (true)
            {
                conta1.CadastrarConta();
                conta1.Deposito();
                conta1.Saque();

                Console.WriteLine($"Conta {conta1.CodConta} - Titular {conta1.NomeTitular} - Saldo {conta1.SaldoConta}");
                Console.WriteLine();
            }



        }
    }
}
