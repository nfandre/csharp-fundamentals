using System;

//DIP = Princípio da Inversão de Dependência
namespace CsharpSolid.SOLID.DIP.Problema
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool IsValid()
        {
            //Depende da implementação de email e cpf service
            return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
        }
    }
}