using System;
using Biblioteca_Matriz;

class Program
{
   static void Main()
    {
        int linhas, colunas;

        Console.WriteLine("== Matrizes ==");

        Console.WriteLine("Digites os dados da matriz, indique nesta ordem: ");

        Console.Write("Linhas: ");
        linhas = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Colunas: ");
        colunas = int.Parse(Console.ReadLine());

        int[ , ] mat = new int[linhas, colunas];

        Console.WriteLine("Agora insira os dados da matriz");
        Matriz.gera(mat);

        Console.WriteLine("A Matriz é:");
        Matriz.mostra(mat);

        Console.ReadKey();
    }
}
