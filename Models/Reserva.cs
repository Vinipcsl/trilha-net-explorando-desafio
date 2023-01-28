namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        private const int V = 5;
        private const double V1 = 0.1;

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            if (hospedes.Count <= 3)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException("A capacidade foi excedida!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
          
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            // Cálculo: DiasReservados X Suite.ValorDiaria
           
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10)
            {

        decimal desconto = 10 ;
               valor =  DiasReservados * Suite.ValorDiaria - ((desconto / 100) * Suite.ValorDiaria * DiasReservados);
            }

            return valor;
        }


    }
}