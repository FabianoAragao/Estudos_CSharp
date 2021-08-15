using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    class ContaBancaria
    {
        public int CodConta { get; private set; }
        public string NomeTitular { get; set; }
        public float SaldoConta { get; private set; }



        private void InformeAConta()
        {
            Console.WriteLine("Digite o código da conta");

            string conta = "0";

            //vai repetir ate o puto digitar um inteiro  valido
            while (int.Parse(conta) == 0)
            {
                conta = Console.ReadLine();

                if (int.Parse(conta) == 0)
                {
                    Console.WriteLine("Conta invalida tente novamente");
                }
            }

            CodConta = int.Parse(conta);
        }

        public void CadastrarConta()
        {
            InformeAConta();

            //nome do titular
            Console.WriteLine("Digite o nome do titular.");
            NomeTitular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial?.");
            char depositoInicial = char.Parse(Console.ReadLine());

            if ((depositoInicial == 's') || (depositoInicial == 'S'))
            {
                //Saldo inicial
                Console.WriteLine("Digite o valor do deposito inicial.");
                SaldoConta = float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Conta {CodConta} - Titular {NomeTitular} - Saldo {SaldoConta}");
            Console.WriteLine();
        }

        public void Deposito()
        {
            float valorDeposito;
            Console.WriteLine("Digite o valor do deposito.");
            valorDeposito = float.Parse(Console.ReadLine());
            SaldoConta += valorDeposito;

            Console.WriteLine($"O valor do deposito foi {valorDeposito}, o saldo da conta é {SaldoConta}.");
            Console.WriteLine();
        }
        public void Saque()
        {
            float valorDoSaque;
            Console.WriteLine("Digite o valor do saque.");
            valorDoSaque = float.Parse(Console.ReadLine());

            //o banco cobra uma taxa de 5 reais pra sacar
            SaldoConta -= (5 + valorDoSaque);

            Console.WriteLine($"O valor do saque foi {valorDoSaque}, o saldo da conta é {SaldoConta}.");
            Console.WriteLine();
        }


    }
}
