using System;
using System.Globalization;

namespace MetricasRetangulo;

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        
        Console.WriteLine("Entre com a largura e a altura do retângulo:");
        retangulo.Largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        retangulo.Altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine(retangulo.ToString());
    }
}
