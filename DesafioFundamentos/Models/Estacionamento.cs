namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicioneUmNovoVeiculo()
        {
            Console.WriteLine("Digite a placa do novo veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido:");

            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento:");

                int quantidadeDeHoras = 0;
                decimal valorTotal = 0; 

                quantidadeDeHoras = Convert.ToInt32(Console.ReadLine());
                valorTotal = Convert.ToDecimal(precoInicial + precoPorHora * quantidadeDeHoras);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total a ser cobrado é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (string item in veiculos)
                {
                    Console.WriteLine(veiculos);
                }
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
