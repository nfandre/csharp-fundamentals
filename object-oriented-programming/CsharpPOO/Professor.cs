using System;
using System.Collections.Generic;

namespace CsharpPOO
{
	public class Professor : Pessoa
	{
		public Professor()
		{
		}
        public double _valorHora;
        public double ValorHora
        {
            get => _valorHora;
            set => _valorHora = value;
        }

        private int _tipo;
        public int Tipo
        {
            get => _tipo;
            set => _tipo = value;
        }

        private int _bonus;
        public int Bonus
        {
            get => _bonus;
            set => _bonus = value;
        }


        /// Associação pode ou não ser proprietário do outro ( Professor existe independente de alunos)
        public List<Aluno> professores = new List<Aluno>();

        // Agregação => um professor tem um departamento/ um departamento tem vários professores ( Professor existe independente de alunos)
        private Departamento departamento = new Departamento();
        public Departamento Departamento
        {
            get => departamento;
            set => departamento = value;
        }

        // Composição (é uma agregação com dependência de objetos ex: carro depende te pneus ) 
        // ex: Para existir departamento precisa existir escola para existir escola precisa exisitr departamentos
        // é conceitual, precisa ser tratado via código, por exemplo em relacionamentos de banco de dados
        private Escola escola = new Escola();
        public Escola Escola
        {
            get => escola;
            set => escola = value;
        }


        //Polimorfismo = assumir diferentes formas
        public override string ResponderPresenca()
        {
            return "Bateu o ponto hoje";
        }

        // Sobrecarga de metoodo//
        public double CalcularSalario(int horas)
        {
            return ValorHora * horas;
        }

        // Sobrecarga de metoodo//
        public double CalcularSalario(int horas, double bonificacao)
        {
            return (ValorHora * horas) * ((bonificacao / 100) + 1);
        }


        public double CalcularSalarioFinal(int horas)
        {
            if (Tipo == 1)
            {
                return CalcularSalario(horas);
            } else
            {
                return CalcularSalario(horas, Bonus);
            }

        }
    }
}

