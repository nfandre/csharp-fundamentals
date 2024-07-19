using System;
namespace CsharpPOO
{
	public class Pessoa: IDisposable, IEquatable<Pessoa>
	{
		public Pessoa()
		{

		}
		private string nome;
        private int idade;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        public delegate void Emprestar();

        public virtual string ResponderPresenca()
        {
            return "Estou aqui";
        }

        public void Dispose()
        {
            Console.WriteLine("Destruindo classe memória");
        }

        public bool Equals(Pessoa other)
        {
            return nome == other.nome;
        }
    }
}

