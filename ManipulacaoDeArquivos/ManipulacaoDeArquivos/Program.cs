using System;
using System.IO;
using System.Globalization;

namespace ManipulacaoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string caminhoOrigem = @"D:\documentos\projetoDesenvolvimento\C#\Ws-Vs2019\ManipulacaoDeArquivos\";
                string caminhoDestino = @"D:\documentos\projetoDesenvolvimento\C#\Ws-Vs2019\ManipulacaoDeArquivos\out\";
                string nomeArquivo = "Arquivo.csv";

                //cria a pasta out
                Directory.CreateDirectory(caminhoDestino);

                //le os dados do arquivo de origem
                string[] linhas = File.ReadAllLines(caminhoOrigem + nomeArquivo);

                using (StreamWriter sw = File.AppendText(caminhoDestino + nomeArquivo))
                {
                    //processa os dados e grava no arquivo de destino
                    foreach (string linha in linhas)
                    {
                        string[] colunas = linha.Split(';');
                        double valorTotal = double.Parse(colunas[1],CultureInfo.InvariantCulture) * 
                                                double.Parse(colunas[2],CultureInfo.InvariantCulture);

                        sw.WriteLine($"{colunas[0]};{valorTotal.ToString("F2",CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
