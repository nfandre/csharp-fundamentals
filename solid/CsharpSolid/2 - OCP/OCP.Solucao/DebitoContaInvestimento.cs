﻿//OCP = Princípio Aberto/Fechado
namespace CsharpSolid.SOLID.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita Conta Investimento
            // Isentar Taxas
            return FormatarTransacao();
        }
    }
}