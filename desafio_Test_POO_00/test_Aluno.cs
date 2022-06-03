using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Test_POO_00
{
    internal class test_Aluno
    {
        public static void Main(string[] args)
        {
            aluno aluno1 = new aluno();
            aluno1.nome = "Ana de Paula";
            aluno1.dataNascimento = "27/10/1992";
            aluno1.rg = 23559966;

            aluno aluno2 = new aluno();
            aluno2.nome = "Ana Carolina";
            aluno2.dataNascimento = "25/10/1991";
            aluno2.rg = 22558899;

            System.Console.WriteLine("Dados do primeiro aluno");
            System.Console.WriteLine($"Nome: {aluno1.nome}");
            System.Console.WriteLine($"Data de nascimento: {aluno1.dataNascimento}");
            System.Console.WriteLine($"RG: {aluno1.rg}");

            System.Console.WriteLine("Dados do segundo aluno");
            System.Console.WriteLine($"Nome: {aluno2.nome}");
            System.Console.WriteLine($"Data de nascimento: {aluno2.dataNascimento}");
            System.Console.WriteLine($"RG: {aluno2.rg}");


        }
    }
}
