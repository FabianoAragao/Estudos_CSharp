using System;
using System.Collections.Generic;
using DictionaryContagemDeVotos.Entidades;

namespace DictionaryContagemDeVotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo: ");
            Arquivo arquivo = new Arquivo(@Console.ReadLine());
            
            Dictionary<string, int> votacao = new Dictionary<string, int>();

            foreach (string s in arquivo.Texto)
            {
                string[] valores = s.Split(";");

                if (votacao.ContainsKey(valores[0]))
                {
                    votacao[valores[0]] += int.Parse(valores[1]);
                }
                else
                {
                    votacao[valores[0]] = int.Parse(valores[1]);
                }
            }

            foreach (var item in votacao)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
