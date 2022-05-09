using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terapiaDoPizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação dos vetores.
            double[] Vetor1 = new double[3];
            double[] Vetor2 = new double[3];
            double A, B, C, D, E, F, raiz;
            bool simnao;

            simnao = true;
            raiz = 0.5;


            while (simnao == true)
            {
                Console.Clear();

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

                //escalar
                double escalar;

                //Cálculo do escalar.
                escalar = A * D + B * E + C * F;

                //vetorial
                double[] vetorial = new double[3];
                double X, Y, Z;

                //Cálculo do vetorial
                vetorial[0] = B * F - C * E;
                X = vetorial[0];

                vetorial[1] = -1 * (A * F - C * D);
                Y = vetorial[1];

                vetorial[2] = A * E - B * D;
                Z = vetorial[2];

                //modulo dos vetores
                double moduloA, moduloB;

                //Calculo do modulo dos vetores
                moduloA = Math.Pow((Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2)), (raiz));
                moduloB = Math.Pow((Math.Pow(D, 2) + Math.Pow(E, 2) + Math.Pow(F, 2)), (raiz));

                //Modulo do produto vetorial
                double moduloVetorial;

                //Calculo do modulo do produto vetorial
                moduloVetorial = Math.Pow((Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)), (raiz));

                //Menu
                bool menu = true;
                while (menu == true)
                {
                    
                    Console.BackgroundColor = ConsoleColor.DarkGray;

                    int resp;
                    Console.WriteLine("=====MENU=====\n");
                    Console.WriteLine("Digite um número para escolher uma opção:\n" +
                                      "1- Produto escalar:\n" +
                                      "2- Produto Vetorial:\n" +
                                      "3- Angulo entre os vetores: \n" +
                                      "4- Cosseno do angulo entre os vetores:\n" +
                                      "5- Seno do angulo entre os vetores:\n" +
                                      "6- Área o triângulo:\n" +
                                      "7- Área do paralelogramo:\n" +
                                      "8- Digitar outro vetor:\n" +
                                      "9- Sair");

                    resp = Convert.ToInt16(Console.ReadLine());

                    switch (resp)
                    {
                        case 1:
                            //Produto escalar

                            //Saída
                            Console.WriteLine("O produto escalar entre os vetores: \n");

                            Console.BackgroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine($"A = ({A}, {B}, {C}) \n");

                            Console.BackgroundColor = ConsoleColor.DarkBlue;

                            Console.WriteLine($"B = ({D}, {E}, {F}) \n");

                            Console.BackgroundColor = ConsoleColor.DarkGreen;

                            Console.WriteLine($"\nÉ igual a: {escalar}\n" +
                                "\n!!!!!IMPRESSIONANTE!!!!!\n");
                            break;

                        case 2:
                            //Produto vetorial

                            //Saida
                            Console.WriteLine("O produto vetorial entre os vetores: \n");
                            Console.BackgroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine($"A = ({A}, {B}, {C}) \n");

                            Console.BackgroundColor = ConsoleColor.DarkBlue;

                            Console.WriteLine($"B = ({D}, {E}, {F}) \n");

                            Console.BackgroundColor = ConsoleColor.DarkGreen;

                            Console.WriteLine($"\nÉ igual a: V =({X}, {Y}, {Z})\n" +
                                "\n!!!!!IMPRESSIONANTE!!!!!\n");

                            break;

                        case 3:
                            //Angulo entre vetores
                            double angulo, arcSeno;

                            //Calculo do angulo
                            arcSeno = Math.Asin(( moduloVetorial / (moduloA * moduloB)));
                            angulo = arcSeno * (180/Math.PI);
             
                            //Saida
                            Console.WriteLine($"\nO angulo entre os vetores é: {angulo}º" +
                                "\n!!!!!IMPRESSIONANTE!!!!!\n");

                            break;

                        case 4:
                            //cosseno do angulo
                            double cossenoAn;

                            //Calculo do cosseno
                            cossenoAn = escalar / (moduloA * moduloB);

                            //Saida
                            Console.WriteLine($"\nO cosseno do angulo é igual a: {cossenoAn}\n" +
                                "\n!!!!!IMPRESSIONANTE!!!!!\n");

                            break;

                        case 5:
                            //Seno do angulo
                            double senoA;

                            //Cálculo do vetoriaL
                            senoA = moduloVetorial / (moduloA * moduloB);

                            //Saida
                            Console.WriteLine($"\nO seno do angulo é igual a: {senoA}\n" +
                                "\n!!!!!IMPRESSIONANTE!!!!!\n");

                            break;

                        case 6:
                            //Area do triangulo
                            double areaTriangulo;

                            //Calculo da area
                            areaTriangulo = moduloVetorial / 2;

                            //Saida
                            Console.WriteLine($"\nA area do triangulo é igual a: {areaTriangulo}\n" +
                                "\n!!!!!IMPRESSIONANTE!!!!!\n");

                            break;

                        case 7:
                            //area do paralelogramo
                            double areaParalelogramo;

                            //Calculo do paralologramo
                            areaParalelogramo = moduloVetorial;

                            //Saida
                            Console.WriteLine($"\nA area do paralelogramo é igual a: {areaParalelogramo}\n" +
                                "\n!!!!!IMPRESSIONANTE!!!!!\n");

                            break;

                        case 8:
                            //Digitar novamente os vetores
                            menu = false;

                            break;

                        case 9:
                            //Fechar o programa 
                            menu = false;
                            simnao = false;
                            break;


                        default:
                            //Fechar o programa
                            menu = false;
                            simnao = false;
                            break;
                    }
                }
            }
        }
    } 
}
