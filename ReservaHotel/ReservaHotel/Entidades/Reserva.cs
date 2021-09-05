using System;
using ReservaHotel.Entidades.Excecoes;

namespace ReservaHotel.Entidades
{
    class Reserva
    {
        public int NumQuarto { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtSaida { get; set; }

        public Reserva()
        {
        }

        public Reserva(int numQuarto, DateTime dtEntrada, DateTime dtSaida)
        {
            if (dtSaida <= dtEntrada)
            {
                throw new DomaninException("A data de saida deve ser posterior a data de entrada.");
            }

            NumQuarto = numQuarto;
            DtEntrada = dtEntrada;
            DtSaida = dtSaida;
        }

        public void AtualizarDatas(DateTime dtEntrada, DateTime dtSaida)
        {
            DateTime agora = DateTime.Now;

            if (dtEntrada < agora || dtSaida < agora)
            {
                throw new DomaninException("As datas de reserva precisam ser futuras.");
            }
            if (dtSaida <= dtEntrada)
            {
                throw new DomaninException("A data de saida deve ser posterior a data de entrada.");
            }

            DtEntrada = dtEntrada;
            DtSaida = dtSaida;
        }

        public int Duracao()
        {
            return DtSaida.Subtract(DtEntrada).Days;
        }

        public override string ToString()
        {
            return "Quarto " + NumQuarto 
                + ", data de entrada " + DtEntrada.ToString("dd/MM/yyyy") 
                + ", data de saida " + DtSaida.ToString("dd/MM/yyyy") 
                + ", duração " + Duracao() + " noites";
        }
    }
}
