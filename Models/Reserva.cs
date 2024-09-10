namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        
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
            //Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            int totalhospedes = 0;
             foreach(Pessoa quantiahospedes in hospedes)
             {
                totalhospedes++;
             }
          
            try{
            if (totalhospedes <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                Console.WriteLine("O número de hóspedes é maior do que a capacidade suportada");
            }
            }catch(Exception E)
            {
                Console.WriteLine($"Ocorreu o seguinte erro: {E.Message}");
            }
        }
        
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria
            //Incrementado
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            //Implementado
            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * Suite.ValorDiaria)-((DiasReservados * Suite.ValorDiaria)*10)/100;
            }

            return valor;
        }
    }
}