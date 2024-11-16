
using Biblioteca_Matriz;
using System;
internal class Exercicio_4_5
{
    public static void DiagonalPrincipal(int[,] matriz)
    {
        int lin = matriz.GetLength(0);

        for (int i = 0; i < lin; i++)
        {
            Console.Write($"{matriz[i, i]} |"); 
        }
    }


    public static void DiagonalSecundaria(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int j = colunas - 1;
        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"{matriz[i, j]} |");
            j--;
        }
    }
    public static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Digite a quantidade de linhas e colunas:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        if (linhas == cols)
        {
            int[,] matriz = new int[linhas, cols];
            Matriz.gera(matriz);

            Console.WriteLine("Matriz Gerada");
            Matriz.mostra(matriz);

            Console.WriteLine("Diagonal Principal:");
            DiagonalPrincipal(matriz);

            Console.WriteLine();

            Console.WriteLine("Diagonal Secundária:");
            DiagonalSecundaria(matriz);
        }
        else
        {
            Console.WriteLine("Não é possível apresentar dados para esta Matriz");
        }
        Console.ReadKey();
    }
}