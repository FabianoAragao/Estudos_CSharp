using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListas
{
    class Funcionario
    {
        public int idFuncionario { get; set; }
        public string nomeFuncionario { get; set; }
        public double salarioFuncionario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            this.idFuncionario      = id;
            this.nomeFuncionario    = nome;
            this.salarioFuncionario = salario;
        }

    public void AumentaSalario(double pPorcAumento)
    {
        if (pPorcAumento != 0)
        {
            salarioFuncionario += (salarioFuncionario * (pPorcAumento / 100));
        }
    }

    public override string ToString()
    {
            return idFuncionario + " - " + nomeFuncionario + " - " + salarioFuncionario;
        }

}
}
