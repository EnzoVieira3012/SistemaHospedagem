namespace SistemaHospedagem
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite? Suite { get; set; } // Agora Suite pode ser nulo
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
            {
                throw new Exception("A suíte ainda não foi cadastrada.");
            }

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
            {
                throw new Exception("A suíte ainda não foi cadastrada.");
            }

            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
            {
                valorTotal -= valorTotal * 0.1m; // Desconto de 10%
            }

            return valorTotal;
        }
    }
}