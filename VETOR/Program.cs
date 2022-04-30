using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETOR
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
           // Criação dos vetores.
            double[] Vetor1 = new double[3];
            double[] Vetor2 = new double[3];
            double A, B, C, D, E, F;

            Console.ForegroundColor = ConsoleColor.White;

            //Atribuição dos valores ao vetor 1. (Deve ter um jeito mais bonito mas funciona)
            
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Digite os valores para o valor de X do primeiro vetor: ");
           
            Vetor1[0] = Convert.ToInt16(Console.ReadLine());
            A = Vetor1[0];

            Console.WriteLine("Digite os valores para o valor de Y do primeiro vetor: ");
           
            Vetor1[1] = Convert.ToInt16(Console.ReadLine());
            B = Vetor1[1];
                 
            Console.WriteLine("Digite os valores para o valor de Z do primeiro vetor: ");
            
            Vetor1[2] = Convert.ToInt16(Console.ReadLine());
            C = Vetor1[2];

            //Atribuição dos valores ao vetor 2.

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Digite os valores para o valor de X do segundo vetor: ");
            Vetor2[0] = Convert.ToInt16(Console.ReadLine());
            D = Vetor2[0];

            Console.WriteLine("Digite os valores para o valor de Y do segundo vetor: ");
            Vetor2[1] = Convert.ToInt16(Console.ReadLine());
            E = Vetor2[1];  

            Console.WriteLine("Digite os valores para o valor de Z do segundo vetor: ");
            Vetor2[2] = Convert.ToInt16(Console.ReadLine());
            F = Vetor2[2];

            //Menu

            Console.BackgroundColor = ConsoleColor.DarkGray;

            int resp;
            Console.WriteLine("=====MENU=====\n");
            Console.WriteLine("Digite um número para escolher uma opção:\n" +
                              "1- Produto escalar:\n" +
                              "2- Produto Vetorial:\n" +
                              "3- Digitar outro vetor:\n");
            resp = Convert.ToInt16(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    double escalar;
                    
                    //Cálculo do escalar.
                    
                    escalar = A * D + B * E + C * F;

                    //Saída
                    Console.WriteLine("O produto escalar entre os vetores: \n");

                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine($"A = ({A}, {B}, {C}) \n");

                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine($"B = ({D}, {E}, {F}) \n");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine($"É igual a: {escalar}");
                    break;

                case 2:
                    double[] vetorial = new double[3];
                    double X, Y, Z;
                    
                    //Cálculo do vetorial

                    vetorial[0] = B * F - C * E;
                    X = vetorial[0];
                    
                    vetorial[1] = -1 * (A * F - C * D);
                    Y = vetorial[1];
                    
                    vetorial[2] = A * E - B * D;
                    Z = vetorial[2];

                    Console.WriteLine("O produto vetorial entre os vetores: \n");
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine($"A = ({A}, {B}, {C}) \n");

                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine($"B = ({D}, {E}, {F}) \n");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine($"É igual a: V =({X}, {Y}, {Z})");
                    
                    break;

                    
                    

                default:
                    break;
            }
            Console.ReadKey();
        }   


    }
}
