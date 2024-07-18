using System.Collections.Generic;

namespace CsharpPOO
{
	public class Escola
	{
		public Escola()
		{
		}

        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        // Composição (é uma agregação com dependência de objetos ex: carro depende te pneus ) 
        // ex: Para existir departamento precisa existir escola para existir escola precisa exisitr departamentos
        public List<Departamento> departamento = new List<Departamento>();

    }
}

