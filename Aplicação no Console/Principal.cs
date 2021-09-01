using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Aplicação_no_Console
{
    class Principal
    {
        static void Linha()
        {
            Console.Write("=======================================");
        }
        static void Main(string[]args)
        {
            bool inicio = false;
            while (inicio != true)
            {
                Console.Clear();
                int op;
                ConverteString muda = new ConverteString();
                Ordena ordenar = new Ordena();
                Linha();
                Console.SetCursorPosition(15, 1);
                Console.Write("Menu de Opções\n");
                Linha();
                Console.SetCursorPosition(10, 4);
                Console.Write("1-Conversão de String");
                Console.SetCursorPosition(10, 6);
                Console.Write("2-Ordenar números");
                Console.SetCursorPosition(10, 8);
                Console.Write("3-Finalizar\n\n");
                Linha();

                Console.SetCursorPosition(15, 11);
                Console.Write("Opção[ ]");
                Console.SetCursorPosition(21, 11);
                try
                {
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
              Console.WriteLine("\nA frase convertida ->" + muda.entrada());
                    }
                    if (op == 2)
                    {
                        ordenar.organizar();
                    }
                    if (op == 3)
                    {
                        Console.Clear();
                        inicio = true;
                        Console.WriteLine("\n\n*********** Opção Inválida  ! ! ! *************");
                    }
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.Clear();
                    Linha();
                    Console.WriteLine("\nDigite um dos valores das opções! \n\nTente novamete , ok !");
                    Linha();
                    Console.ReadLine();
                }
            }
        }
    }
}
