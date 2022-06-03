using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Test_POO_00
{
    internal class testeFuncionarios
    {
        public static void Main(string[] args)
        {
            funcionarios funcionario1 = new funcionarios();
            funcionario1.nome = "Rodrigo Bueno";
            funcionario1.salario = 5000;

            funcionarios funcionario2 = new funcionarios();
            funcionario2.nome = "Thiago Rodriguês";
            funcionario2.salario = 6000;

            System.Console.WriteLine("Dados do primeiro funcionario");
            System.Console.WriteLine($"Nome: {funcionario1.nome}");
            System.Console.WriteLine($"Salário: {funcionario1.salario}");

            System.Console.WriteLine("Dados do segungo funcionario");
            System.Console.WriteLine($"Nome: {funcionario2.nome}");
            System.Console.WriteLine($"Salário: {funcionario2.salario}");

        }
    }
}
