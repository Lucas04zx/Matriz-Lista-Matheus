using System;

class Exercicio7
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de linhas (N): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas (M): ");
        int m = int.Parse(Console.ReadLine());

        double[,] matriz1 = new double[n, m];
        double[,] matriz2 = new double[n, m];

        GeraMatriz(matriz1);
        GeraMatriz(matriz2);

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("a) Somar as duas matrizes");
            Console.WriteLine("b) Subtrair a primeira matriz da segunda");
            Console.WriteLine("c) Adicionar uma constante às duas matrizes");
            Console.WriteLine("d) Imprimir as matrizes");
            Console.WriteLine("e) Sair");
            Console.Write("Escolha uma opção: ");
            char opcao = Console.ReadLine()[0];

            switch (opcao)
            {
                case 'a':
                    double[,] soma = SomaMatrizes(matriz1, matriz2);
                    Console.WriteLine("Resultado da soma das matrizes:");
                    ImprimeMatriz(soma);
                    break;
                case 'b':
                    double[,] subtracao = SubtraiMatrizes(matriz1, matriz2);
                    Console.WriteLine("Resultado da subtração da primeira matriz pela segunda:");
                    ImprimeMatriz(subtracao);
                    break;
                case 'c':
                    Console.Write("Digite a constante a ser adicionada: ");
                    double constante = double.Parse(Console.ReadLine());
                    AdicionaConstante(matriz1, constante);
                    AdicionaConstante(matriz2, constante);
                    Console.WriteLine("Constante adicionada às matrizes.");
                    break;
                case 'd':
                    Console.WriteLine("Matriz 1:");
                    ImprimeMatriz(matriz1);
                    Console.WriteLine("Matriz 2:");
                    ImprimeMatriz(matriz2);
                    break;
                case 'e':
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void GeraMatriz(double[,] mat)
    {
        Random random = new Random();
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                mat[i, j] = random.NextDouble() * 100;
            }
        }
    }

    static double[,] SomaMatrizes(double[,] mat1, double[,] mat2)
    {
        int linhas = mat1.GetLength(0);
        int colunas = mat1.GetLength(1);
        double[,] resultado = new double[linhas, colunas];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = mat1[i, j] + mat2[i, j];
            }
        }
        return resultado;
    }

    static double[,] SubtraiMatrizes(double[,] mat1, double[,] mat2)
    {
        int linhas = mat1.GetLength(0);
        int colunas = mat1.GetLength(1);
        double[,] resultado = new double[linhas, colunas];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = mat1[i, j] - mat2[i, j];
            }
        }
        return resultado;
    }

    static void AdicionaConstante(double[,] mat, double constante)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                mat[i, j] += constante;
            }
        }
    }

    static void ImprimeMatriz(double[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{mat[i, j]:F2} ");
            }
            Console.WriteLine();
        }
    }
}
