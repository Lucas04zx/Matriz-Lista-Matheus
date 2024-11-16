using System;
using Biblioteca_Matriz;

internal class Exercicio_6
{
    public static int[,] SomaMatriz(int[,] matriz1, int[,] matriz2)
    {
        int lin = matriz1.GetLength(0);
        int cols = matriz1.GetLength(1);
        int[,] soma = new int[lin, cols];

        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                soma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }
        return soma;
    }

    static void Main()
    {
        Console.WriteLine("Digite o numeros de linhas e colunas da primeira matriz");
        int linhas = int.Parse(Console.ReadLine());
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz1 = new int[linhas, colunas];

        Console.WriteLine("Digite o numeros de linhas e colunas da segunda matriz");
        int linhas2 = int.Parse(Console.ReadLine());
        int colunas2 = int.Parse(Console.ReadLine());

        int[,] matriz2 = new int[linhas, colunas]; ;

        if (linhas == linhas2 && colunas == colunas2)
        {
            Console.WriteLine("---Matriz 1---");
            Matriz.gera(matriz1);
            Matriz.mostra(matriz1);
            Console.WriteLine();
            Console.WriteLine("---Matriz 2---");
            Matriz.gera(matriz2);
            Matriz.mostra(matriz2);
            Console.WriteLine();

            Console.WriteLine("A soma das duas Matrizes resulta em: ");
            Console.WriteLine();

            int[,] resultado = SomaMatriz(matriz1, matriz2);
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                for (int j = 0; j < resultado.GetLength(1); j++)
                {
                    Console.Write($"{resultado[i, j],3} |");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Não é possível somar matrizes de ordem diferente!!");
        }
        Console.ReadKey();
    }
}