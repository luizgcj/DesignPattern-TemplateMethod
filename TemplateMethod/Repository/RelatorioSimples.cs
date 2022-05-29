using System;
using System.Collections.Generic;
using TemplateMethod.Entity;
using TemplateMethod.Helper;

namespace TemplateMethod.Repository
{
    public class RelatorioSimples : TemplateRelatorioConta
    {
        protected override string Cabecalho(Banco banco)
        {
            return $"Nome Banco: {banco.NomeBanco}";
        }

        protected override void Detalhe(List<ContaCorrente> contaCorrente)
        {
            foreach (var item in contaCorrente)
                Console.WriteLine($"Titular: {item.NomeTitular} - Saldo: {item.Saldo}");
        }

        protected override string Rodape(Banco banco)
        {
            return $"Telefone {banco.Telefone}";
        }
    }
}
