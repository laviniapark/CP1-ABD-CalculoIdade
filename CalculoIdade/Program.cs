namespace CalculoIdade;

struct Pessoa
{
    public string? Nome;
    public DateTime? DtNascimento;
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o seu nome completo: ");
        string? nome = Console.ReadLine();
        Console.Write("Digite sua data de nascimento: ");
        DateTime nascimento = Convert.ToDateTime(Console.ReadLine());

        Pessoa p = new Pessoa
        {
            Nome = nome,
            DtNascimento = nascimento
        };
        
        // CALCULO IDADE
        DateTime hoje = DateTime.Today;
        int idade = hoje.Year - nascimento.Year;
        if (nascimento > hoje.AddYears(-idade))
            idade--;
        
        Console.WriteLine($"Nome : {nome}");
        Console.WriteLine($"Idade : {idade}");

        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade | Você pode tirar a carteira de habilitação :D");
        }
        else
        {
            Console.WriteLine("Menor de idade | Você não pode tirar a carteira de habilitação D:");
        }
    }
}