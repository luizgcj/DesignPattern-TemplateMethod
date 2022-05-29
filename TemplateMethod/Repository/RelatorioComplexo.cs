using System;
using System.Collections.Generic;
using TemplateMethod.Entity;
using TemplateMethod.Helper;

namespace TemplateMethod.Repository
{
    public class RelatorioComplexo : TemplateRelatorioConta
    {
        protected override string Cabecalho(Banco banco)
        {
            return $"Nome Banco: {banco.NomeBanco} - Endereço: {banco.Endereco} - Telefone: {banco.Telefone}";
        }

        protected override void Detalhe(List<ContaCorrente> contaCorrente)
        {
            foreach (var item in contaCorrente)
                Console.WriteLine($"Titular: {item.NomeTitular} - Agência: {item.Agencia} - Numero Conta: {item.NumeroConta} - Saldo: {item.Saldo}");
        }

        protected override string Rodape(Banco banco)
        {
            return $"Email: {banco.Email} - Data Atual: {DateTime.Today.ToString("d")}";
        }
    }
}
