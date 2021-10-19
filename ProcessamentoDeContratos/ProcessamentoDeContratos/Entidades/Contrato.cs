using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProcessamentoDeContratos.Entidades
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorContrato { get; set; }

        public List<Parcela> Parcela = new List<Parcela>();
        public Contrato(int numeroContrato, DateTime dataContrato, double valorContrato)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorContrato = valorContrato;
            Parcela = null;
        }

        public void AddParcela(Parcela novaParc)
        {
            Parcela.Add(novaParc);
        }

        public void RemoveParcela(Parcela remParc)
        {
            Parcela.Remove(remParc);
        }

        public override string ToString()
        {
            string retorno = "";

            foreach (Parcela parcela in Parcela)
            {
                retorno += parcela.DataDoContrato + " - " + 
                            parcela.ValorDoContrato.ToString("F2",CultureInfo.InvariantCulture) + "\n";
            }
            return retorno;
        }
    }
}
