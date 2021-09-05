using System;
using System.Globalization;
using ContaBancariaLimiteDeSaque.Entidades.Excecoes;

namespace ContaBancariaLimiteDeSaque.Entidades
{
    class ContaBancaria
    {
        public  int NumConta { get; set; }
        public string Titular { get; set; }
        public double SaldoConta { get; set; }
        public double LimiteDeSaque { get; set; }

        public ContaBancaria(int numConta, string titular, double saldoConta, double limiteDeSaque)
        {
            NumConta = numConta;
            Titular = titular;
            SaldoConta = saldoConta;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Deposito(double vlrDep)
        {
            SaldoConta += vlrDep;
        }

        public void Saque(double vlrSaque)
        {
            if (vlrSaque > LimiteDeSaque)
            {
                throw new DomaninException($"O valor do saque não pode ser maior que o valor do limite para saques" +
                                            $"({LimiteDeSaque.ToString("f2", CultureInfo.InvariantCulture)})");
            }
            if (vlrSaque > SaldoConta)
            {
                throw new DomaninException($"O valor do saque não pode ser maior que o valor na conta" +
                                             $"({SaldoConta.ToString("f2", CultureInfo.InvariantCulture)})");
            }

            SaldoConta -= vlrSaque;
        }

        public override string ToString()
        {
            return $"Conta: {NumConta} - " +
                    $"Titular: {Titular} - " +
                    $"Total em conta: {SaldoConta.ToString("f2", CultureInfo.InvariantCulture)} - " +
                    $"Limite de saque: {LimiteDeSaque.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
