using System;
using System.Collections.Generic;

namespace CsharpPOO
{
	public class Aluno : Pessoa
	{
		public Aluno()
		{
			// classe pai
			var nameFromHerance = base.Nome;
		}
        private string matricula { get; set; }

        public string Matricula
		{
			get => matricula;
			set => matricula = value;
		}

		/// Associação
		public List<Professor> professores = new List<Professor>();


		public void estaPresente(bool presente)
		{
			if (presente)
			{
				Console.WriteLine("Aluno presente");
			} else
			{
                Console.WriteLine("Aluno não está presente");
            }
		}

        //Polimorfismo = assumir diferentes formas
        public override string ResponderPresenca()
        {
            return "Bateu o ponto hoje";
        }
    }
}

