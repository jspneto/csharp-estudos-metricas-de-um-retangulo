using System;
using System.Globalization;

namespace MetricasRetangulo;

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = CriarRetangulo();

        Console.WriteLine();
        Console.WriteLine(retangulo.ExibirArea());
        Console.WriteLine(retangulo.ExibirPerimetro());
        Console.WriteLine(retangulo.ExibirDiagonal());
    }

    static Retangulo CriarRetangulo()
    {
        Retangulo retangulo = new Retangulo();
                
        Console.Write("Digite o nome do retângulo: ");
        retangulo.Nome = Console.ReadLine()!;
        Console.Write("Digite a largura do retângulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Digite a altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        return retangulo;
    }
}
