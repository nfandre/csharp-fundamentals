using System;

namespace CsharpPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Matricula = "abc22333";
            aluno.Idade = 22;
            Console.WriteLine($"Aluno: {aluno.ResponderPresenca()}");


            Professor jose = new Professor();
            jose.Idade = 40;
            jose.ValorHora = 10;
            jose.Bonus = 0;
            jose.Tipo = 1;

            Console.WriteLine($"Professor1: {jose.ResponderPresenca()}");
            Console.WriteLine("Professor1 Valor hora: {0:c}", jose.CalcularSalarioFinal(120));

            Professor maria = new Professor();
            maria.Idade = 40;
            maria.ValorHora = 10;
            maria.Tipo = 2;
            maria.Bonus = 15;


            Console.WriteLine("Professor2 Valor hora: {0:c}", maria.CalcularSalarioFinal(120));

        }
    }


}
