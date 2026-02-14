using System;
using System.Globalization;
using MetricasRetangulo.Src.IO;

namespace MetricasRetangulo.Src;

static class RetanguloExemplos
{
    public static void ExemploGeral()
    {
        Retangulo retangulo = RetanguloInputs.CriarRetangulo();

        Console.WriteLine();
        Console.WriteLine(RetanguloOutputs.ExibirArea(retangulo));
        Console.WriteLine(RetanguloOutputs.ExibirPerimetro(retangulo));
        Console.WriteLine(RetanguloOutputs.ExibirDiagonal(retangulo));
    }
}