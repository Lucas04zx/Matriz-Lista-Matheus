using System;

internal class Exercicio_10
{
    public static int[] Soma(int[,] matriz)
    {
        int lin = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int[] soma = new int[lin];
        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                soma[i] += matriz[i, j];
            }
        }
        return soma;
    }
    public static void geratropas(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);

        Random random = new Random();

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                mat[i, j] = random.Next(0, 100);
            }
        }
    }
    public static void mostra(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        int cont = 1;

        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"Regiao {cont}: ");
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($" {mat[i, j]} |");
            } 
            cont++;
            Console.WriteLine();
        }
    }
    public static void mostrasoma(int[] soma)
    {

        int cont = 1;

        for (int i = 0; i < soma.Length; i++)

        { Console.WriteLine($"Região {cont}: {soma[i]} tropas"); cont++; }
    }

    static void Main()
    {
        Console.WriteLine("Digite de regiões");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite de cidade");
        int c = int.Parse(Console.ReadLine());


        int[,] matriz = new int[r, c];
        geratropas(matriz);

        Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
        mostra(matriz);

        Console.WriteLine("Força Total das Regiões:");
        int[] somaTropas = Soma(matriz);
        mostrasoma(somaTropas);

    }
}