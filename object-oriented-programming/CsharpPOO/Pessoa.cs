using System;
namespace CsharpPOO
{
	public class Pessoa
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


        public string ResponderPresenca()
        {
            return "Estou aqui";
        }

    }
}

