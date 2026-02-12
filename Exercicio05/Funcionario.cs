using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio05.Exercicio05;

public class Funcionario : Pessoa
    {
        public double Salario = 0.0;
        public void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salário: {Salario}");
        }
    }
