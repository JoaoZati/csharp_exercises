using System;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.WriteLine("Hello, Debugging from scratch!");
        int x = 5;
        int y = 10;
        int result = x + y;
        Console.WriteLine($"The result is: {result}");

        int idade;
        double salario;
        string nome;
        char sexo;

        Console.WriteLine($"Digite a idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o Salario: ");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o Nome: ");
        nome = Console.ReadLine();

        Console.WriteLine($"Digite o Sexo: ");
        sexo = char.Parse(Console.ReadLine());

        Console.WriteLine(
            "A funcionaria " +nome +
            ", sexo " + sexo +
            ", ganha " + salario.ToString("F2", CI) +
            " e tem " + idade + " anos"
        ); 

    }
}