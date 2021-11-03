using System.IO;

namespace ExercicoResolvidoLinqSQLMediaProdutos.Entidades
{
    class Arquivo
    {
        private string Caminho;
        public string[] Texto { get; private set; }

        public Arquivo(string caminho)
        {
            Caminho = caminho;

            if (File.Exists(Caminho))
            { 
                Texto = System.IO.File.ReadAllLines(@""+Caminho);
            }
        }
    }
}
