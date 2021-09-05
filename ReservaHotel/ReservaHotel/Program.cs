using System;
using ReservaHotel.Entidades;
using ReservaHotel.Entidades.Excecoes;

namespace ReservaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Numero do quarto: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Data de entrada(dd/MM/yyyy): ");
                DateTime dtEnt = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de saida(dd/MM/yyyy): ");
                DateTime dtSai = DateTime.Parse(Console.ReadLine());

                Reserva novaReserva = new Reserva(numero, dtEnt, dtSai);
                Console.WriteLine("Reserva: " + novaReserva);
                Console.WriteLine();

                Console.WriteLine("Entre com uma data para atualizar a reserva: ");
                Console.Write("Data de entrada(dd/MM/yyyy): ");
                dtEnt = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de saida(dd/MM/yyyy): ");
                dtSai = DateTime.Parse(Console.ReadLine());

                novaReserva.AtualizarDatas(dtEnt, dtSai);
                Console.WriteLine("Reserrva: " + novaReserva);
            }
            catch (DomaninException e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Inesperado: " + e.Message);
            }
        }
    }
}
