using System.Collections.Generic;

namespace CsharpPOO
{
	public class Departamento
	{
		public Departamento()
		{
		}

		private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        // Agregação => um professor tem um departamento/ um departamento tem vários professores
        public List<Professor> professores = new List<Professor>();

    }
}

