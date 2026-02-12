using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Pessoa
    {
        public string Nome;

        public int Idade = 0;

        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Idade {Idade}");
        }
    }

}