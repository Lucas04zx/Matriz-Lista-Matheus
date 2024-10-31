using System;
using System.IO;

namespace Biblioteca_Matriz
{
    class Matriz
    {
        public static void leia(int[ , ] mat)
        {
            int Linhas = mat.GetLength( 0 );
            int Coluna = mat.GetLength(1);

            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Coluna; j++)
                {
                    Console.Write($"Escreva o valor de : [ {i} , {j} ] : ");
                    mat[i, j]= int.Parse(Console.ReadLine()); 
                    
                }   
            }//Fim dos for

        }//Fim leia

        public static void mostra(int[,] mat)
        {
            int Linha = mat.GetLength( 0 );
            int Coluna = mat.GetLength(1);
            for(int i = 0;i < Linha; i++)
            {
                for(int j = 0;j < Coluna; j++)
                {
                    Console.Write($"|{mat[i,j],3}| ");
                }//fim for j
                Console.WriteLine();
            }//fim for I
        }//Fim mostre
        public static void gera(int[,] mat)
        {
            int Linha = mat.GetLength(0);
            int Coluna = mat.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < Linha; i++)
            
                
                for (int j = 0; j < Coluna; j++)
                
                    mat[i, j] = random.Next(1, 50);
                
                Console.WriteLine();
            //fim for I
        }//Fim mostre

    }//Fim gera
    }//Classe matriz
//Fim biblioteca
