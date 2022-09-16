using DesafioFundamentos.Models;

namespace DesafioFundamentos.Models
{   
    public class Estacionamento
    {   
        // declaração das variáves
        private decimal precoInicial = 0;
        private decimal precoHora = 0;

        // Criação de uma Lista
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;

        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Introduza a placa do veículo a estacionar: ");
            string placaAdd = Console.ReadLine();
            veiculos.Add(placaAdd);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Introduza a placa do veículo a remover: ");
            string placaRemover = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que esteve etacionado: ");

                //Declaração de Variável inteira e decimal
                int horas = 0;
                horas = int.Parse(Console.ReadLine()); // Conversão. Com Convert To.int32 deu erro
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoHora * horas;

                veiculos.Remove(placaRemover);
                Console.WriteLine($"O veículo {placaRemover} foi removido sendo o preço final: R${valorTotal}");

            }
            else
            {
                Console.WriteLine("Esse veículo não está registrado. Verifique se inseriu a placa corretamente!");
            }
        }
        public void listarVeiculos()
        {
            // Verificação dos veículos existentes no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos atualmente estacionados são: ");
                foreach(string el in veiculos)
                {
                    Console.WriteLine(el);
                }
            }
            else
            {
                Console.WriteLine("Não existem veículos estacionados!");
            }
        }
    }   
        
}
 
