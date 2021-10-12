
namespace TaxaServico.Servicos
{
    class ImpostosDoBrasil: ITaxaImposto
    {
        public double CalculoImposto(double valorTotal)
        {
            if (valorTotal <= 100)
            {
                return valorTotal * 0.2;
            }
            else
            {
                return valorTotal * 0.15;

            }
        }
    }
}
