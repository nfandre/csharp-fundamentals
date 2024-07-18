using System;
using CsharpSolid.SOLID.DIP.Solucao.Interfaces;

//DIP = Princípio da Inversão de Dependência
namespace CsharpSolid.SOLID.DIP.Solucao
{
    public class Usuario
    {
        private readonly ICPFServices _cpfServices;
        private readonly IEmailServices _emailServices;

        // Depende da abstração, utilza outros princípios SRP e ISP
        public Usuario(
            ICPFServices cpfServices, 
            IEmailServices emailServices)
        {
            _cpfServices = cpfServices;
            _emailServices = emailServices;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool IsValid()
        {
            return _emailServices.IsValid(Email) && _cpfServices.IsValid(CPF);
        }
    }
}