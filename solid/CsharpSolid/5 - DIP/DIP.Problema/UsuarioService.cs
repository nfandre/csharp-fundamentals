//DIP = Princípio da Inversão de Dependência
namespace CsharpSolid.SOLID.DIP.Problema
{
    public class UsuarioService
    {
        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";
            // Depende da implementação e não da abstração
            var repo = new UsuarioRepository();
            repo.AdicionarUsuario(usuario);

            // dependencia do email service
            EmailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}