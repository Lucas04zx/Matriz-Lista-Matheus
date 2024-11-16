using System;
using Biblioteca_Matriz;
using System.IO;


class Exercicio_1_2
{
    public static int MaiorMatriz(int[,] matriz)
    {
        int maior = matriz[0, 0];

        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }
        return maior;
    }
    public static int MenorMatriz(int[,] matriz)
    {
        int menor = matriz[0, 0];

        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }
        return menor;
    }
    static void Main()
    {

        Console.WriteLine("Digite a quantidade de linhas e colunas: ");

        int linha = int.Parse(Console.ReadLine());
        int coluna = int.Parse(Console.ReadLine());

        int[,] matrix = new int[linha, coluna]; // criando a matriz

        Matrizes.gera(matrix);
        Console.WriteLine("Matriz Gerada: ");
        Matrizes.mostra(matrix);

        int maiorValor = MaiorMatriz(matrix);
        int menorValor = MenorMatriz(matrix);

        Console.WriteLine($"\n O maior número da matriz é: {maiorValor}");
        Console.WriteLine($"\n O menor número da matriz é: {menorValor}");
        Console.ReadKey();
    }
}