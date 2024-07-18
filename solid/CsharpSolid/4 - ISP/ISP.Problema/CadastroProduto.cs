using System;

//ISP = Princ�pio da Segrega��o de Interface
namespace CsharpSolid.SOLID.ISP.Problema
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void Salvar()
        {
            // Insert tabela Produto
        }

        public void EnviarEmail()
        {
            // Produto n�o tem e-mail
            // Qual dever� ser a implementa��o?
        }
    }
}