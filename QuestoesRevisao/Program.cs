using System;

namespace QuestoesRevisao
{
  class Program
  {
    static void Main(string[] args)
    {
      a();
    }

    public static void a()
    {
      Console.Write("Inteiro: ");
      int inteiro = int.Parse(Console.ReadLine());
      Console.WriteLine($"Inteiro: {inteiro}");

      Console.Write("Flufuante: ");
      float flufuante = float.Parse(Console.ReadLine());
      Console.WriteLine($"Flufuante: {flufuante}");

      Console.Write("DuploFlutuante: ");
      double DuploFlutuante = double.Parse(Console.ReadLine());
      Console.WriteLine($"DuploFlutuante: {DuploFlutuante}");

      Console.Write("Caracter: ");
      char caracter = Console.ReadLine()[0];
      Console.WriteLine($"Caracter: {caracter}");

      Console.Write("Palavra: ");
      string palavra = Console.ReadLine();
      Console.WriteLine($"Palavra: {palavra}");

      Console.Write("Booleano: ");
      bool boleano = bool.Parse(Console.ReadLine());
      Console.WriteLine($"Boleano: {boleano.ToString()}");
    }
  }
}
