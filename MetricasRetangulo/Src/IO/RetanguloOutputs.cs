using System;
using System.Globalization;

namespace MetricasRetangulo.Src.IO;

static class RetanguloOutputs
{
    public static string ExibirArea(Retangulo retangulo)
    {
        return $"Área = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)} ua";
    }

    public static string ExibirPerimetro(Retangulo retangulo)
    {
        return $"Perímetro = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)} uc";
    }

    public static string ExibirDiagonal(Retangulo retangulo)
    {
        return $"Diagonal = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)} uc";
    }
}