using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Test_POO_00
{
    internal class test_turma
    {
        public static void Main(string[] args)
        {
            turma turma1 = new turma();
            turma1.periodo = "Manhã";
            turma1.serie = 8;
            turma1.sigla = "M8";
            turma1.tipoEnsino = "Meio Periodo";

            turma turma2 = new turma();
            turma2.periodo = "Manhã";
            turma2.serie = 9;
            turma2.sigla = "M9";
            turma2.tipoEnsino = "Meio Periodo";

            System.Console.WriteLine($"Dados da primeira turma");
            System.Console.WriteLine($"Periodo: {turma1.periodo}");
            System.Console.WriteLine($"Série: {turma1.serie}");
            System.Console.WriteLine($"Sigla: {turma1.sigla}");
            System.Console.WriteLine($"Tipo de ensino: {turma1.tipoEnsino}");

            System.Console.WriteLine($"Dados da segunda turma");
            System.Console.WriteLine($"Periodo: {turma2.periodo}");
            System.Console.WriteLine($"Série: {turma2.serie}");
            System.Console.WriteLine($"Sigla: {turma2.sigla}");
            System.Console.WriteLine($"Tipo de ensino: {turma2.tipoEnsino}");


        }
    }
}
