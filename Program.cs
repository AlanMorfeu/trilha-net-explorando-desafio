using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa hospede = new Pessoa();

Console.WriteLine("------------------------");
Console.WriteLine("===== Hotel DioWex =====");
Console.WriteLine("------------------------");

hospedes = hospede.CadastrarPessoas();

// Cria a suíte
Suite suiteTipo = new Suite();
var(suite, dias) = suiteTipo.EscolherSuite();

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: dias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");