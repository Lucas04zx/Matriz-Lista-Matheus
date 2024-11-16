using System;

class  Desafio_11
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho da matriz (N): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        PreencheMatriz(matriz);

        Console.WriteLine("Matriz Gerada:");
        ExibeMatriz(matriz);

        int somaPrincipal = SomaDiagonalPrincipal(matriz);
        int somaSecundaria = SomaDiagonalSecundaria(matriz);

        Console.WriteLine($"\nSoma da diagonal principal: {somaPrincipal}");
        Console.WriteLine($"Soma da diagonal secundária: {somaSecundaria}");

        if (somaPrincipal > somaSecundaria)
        {
            Console.WriteLine("\nA diagonal principal tem mais moedas de ouro.");
        }
        else if (somaPrincipal < somaSecundaria)
        {
            Console.WriteLine("\nA diagonal secundária tem mais moedas de ouro.");
        }
        else
        {
            Console.WriteLine("\nAs duas diagonais têm a mesma quantidade de moedas de ouro.");
        }
    }

    static void PreencheMatriz(int[,] mat)
    {
        Random random = new Random();
        int n = mat.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = random.Next(1, 101);
            }
        }
    }

    static void ExibeMatriz(int[,] mat)
    {
        int n = mat.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{mat[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    static int SomaDiagonalPrincipal(int[,] mat)
    {
        int soma = 0;
        int n = mat.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            soma += mat[i, i];
        }
        return soma;
    }

    static int SomaDiagonalSecundaria(int[,] mat)
    {
        int soma = 0;
        int n = mat.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            soma += mat[i, n - 1 - i];
        }
        return soma;
    }
}
