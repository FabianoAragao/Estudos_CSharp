
namespace Contribuintes.Entidades
{
    class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual,double gastosComSaude) :base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalcuoImposto()
        {
            if (GastosComSaude < 20000)
            {
                return (RendaAnual * 0.15) - (GastosComSaude * 0.5);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastosComSaude * 0.5);
            }
        }
    }
}
