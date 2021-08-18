using System;


namespace ContratosTrabalho.Entidades
{
    class Departamento
    {
        public string Nome{ get; set; }

        public Departamento()
        {

        }
        public Departamento(string depNome)
        {
            this.Nome = depNome;
        }
    }
}
