namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    public List<Pessoa> CadastrarPessoas()
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        bool cadastrar = false;

        Console.WriteLine("");
        Console.Write("Informe o nome do hóspede: ");
        string nome = Console.ReadLine();

        pessoas.Add(new Pessoa(nome));
        Console.Clear();

        do
        {
            Console.Clear();
            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine($"Hóspede {i + 1}: {pessoas[i].Nome}");
            }

            Console.WriteLine("");
            Console.WriteLine("Deseja cadastrar mais um hóspede? ");
            Console.WriteLine("[1] - Sim ");
            Console.WriteLine("[2] - Nao ");
            Console.WriteLine("");
            Console.Write("Digite sua opção: ");
            string cadastrarHospede = Console.ReadLine();

            if (cadastrarHospede == "sim" ||
                cadastrarHospede == "Sim" ||
                cadastrarHospede == "S" ||
                cadastrarHospede == "s" ||
                cadastrarHospede == "1")
            {
                cadastrar = true;
                Console.Write("Informe o nome do hóspede: ");
                nome = Console.ReadLine();
                pessoas.Add(new Pessoa(nome));
            }
            else if (cadastrarHospede == "nao" ||
                     cadastrarHospede == "Nao" ||
                     cadastrarHospede == "N" ||
                     cadastrarHospede == "n" ||
                     cadastrarHospede == "2")
            {
                cadastrar = false;
            }
            else
            {
                Console.WriteLine("Opção Inválida");
                Console.WriteLine("Opções válidas [1][Sim] ou [2][Nao]");
                Thread.Sleep(3000);
                cadastrar = true;
            }

        } while (cadastrar);

        Console.WriteLine("");
        return pessoas;
    }
}