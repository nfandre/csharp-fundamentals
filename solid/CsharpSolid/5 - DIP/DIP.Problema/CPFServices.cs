//DIP = Princ�pio da Invers�o de Depend�ncia
namespace CsharpSolid.SOLID.DIP.Problema
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}