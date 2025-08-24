using System;

class Program
{
    static void Main()
    {
        Usuario user = new Usuario();

        Console.Write("Digite seu nome: ");
        user.Nome = Console.ReadLine();

        // Idade com validação
        int idade;
        while (true)
        {
            Console.Write("Digite sua idade: ");
            if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0 && idade <= 120)
            {
                user.Idade = idade;
                break;
            }
            Console.WriteLine("Idade inválida, tenta de novo.");
        }

        // Salário com validação
        decimal salario;
        while (true)
        {
            Console.Write("Digite seu salário: ");
            if (decimal.TryParse(Console.ReadLine(), out salario) && salario >= 0)
            {
                user.Salario = salario;
                break;
            }
            Console.WriteLine("Salário inválido, tenta de novo.");
        }

        Console.WriteLine($"\nNome: {user.Nome}, Idade: {user.Idade}, Salário: {user.Salario:C}");

        if (user.Idade < 18)
            Console.WriteLine("Vai estudar, moleque!");

        if (user.Salario < 1500)
            Console.WriteLine("Tá foda, precisa ganhar mais.");
        else
            Console.WriteLine("Dá pra sobreviver, mas não vacila.");
    }
}

public class Usuario
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public decimal Salario { get; set; }
}
