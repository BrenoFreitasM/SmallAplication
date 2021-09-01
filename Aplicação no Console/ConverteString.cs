using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Aplicação_no_Console
{
    class ConverteString
    {
        private string nome;
        private string mnome;
        public String entrada()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome ou frase: \n");
            nome = Console.ReadLine();
            mnome = nome.ToUpper();
            return mnome;
        }
    }
}
