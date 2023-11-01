using System.Linq.Expressions;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public (Suite suite, int dias) EscolherSuite()
        {
            Console.WriteLine("Deseja reservar a suite por quantos dias?");
            Console.Write("Dias para reserva: ");

            int diasReserva = 0;
            bool valorDiasEhValido = false;

            // Converte o valor digitado e verifica se o valor é válido
            do
            {
                valorDiasEhValido = int.TryParse(Console.ReadLine(), out diasReserva);

                if (!valorDiasEhValido)
                {
                    Console.Write("Valor de dias informado é inválido.\nDigite a quantidade de dias novamente usando apenas números: ");
                };

            } while (!valorDiasEhValido);

            Console.Clear();
            Console.WriteLine("Escolha sua suite:");
            Console.WriteLine("[ 1 ] Master  : capacidade para 2 pessoas, diaria R$ 50,00");
            Console.WriteLine("[ 2 ] Premium : capacidade para 3 pessoas, diaria R$ 80,00");
            Console.WriteLine("[ 3 ] Deluxe  : capacidade para 5 pessoas, diaria R$ 100,00");
            Console.Write("Digite o nome ou número da sua suite: ");

            string tipoSuite = Console.ReadLine();

            switch (tipoSuite)
            {
                case "1":
                case "Master":
                    TipoSuite = "Master";
                    Capacidade = 2;
                    ValorDiaria = 50.00M;
                    break;
                case "2":
                case "Premiun":
                    TipoSuite = "Premium";
                    Capacidade = 3;
                    ValorDiaria = 80.00M;
                    break;
                case "3":
                case "Deluxe":
                    TipoSuite = "Deluxe";
                    Capacidade = 5;
                    ValorDiaria = 100.00M;
                    break;
                default:
                    Console.WriteLine("Opção Inválida. Tente novamente");
                    Thread.Sleep(2000);
                    Console.Clear();
                    EscolherSuite();
                    break;
            }
            
            Console.WriteLine("");
            
            return (new Suite(TipoSuite, Capacidade, ValorDiaria), diasReserva);
        }
    }
}