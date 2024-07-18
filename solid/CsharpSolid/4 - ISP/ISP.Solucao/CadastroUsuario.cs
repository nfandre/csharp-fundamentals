using CsharpSolid.SOLID.ISP.Solucao.Interfaces;

//ISP = Princípio da Segregação de Interface
namespace CsharpSolid.SOLID.ISP.Solucao
{
    public class CadastroUsuario : ICadastroUsuario
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void Salvar()
        {
            // Insert na tabela Usuário
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o usuário
        }
    }
}