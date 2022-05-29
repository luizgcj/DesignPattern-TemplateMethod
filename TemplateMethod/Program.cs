using System;
using System.Collections.Generic;
using TemplateMethod.Entity;
using TemplateMethod.Helper;
using TemplateMethod.Repository;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateRelatorioConta relatorio = new RelatorioSimples();
            //TemplateRelatorioConta relatorio = new RelatorioComplexo();
            Banco banco = new Banco("Banco do Brasil", "Rua Goias", "3732218088", "bancodobrasil@bancodobrasil.com.br");
            ContaCorrente c1 = new ContaCorrente("Luiz Costa", 3490, "010102880", 100000);
            ContaCorrente c2 = new ContaCorrente("Thais Tré Viana", 3490, "010102881", 200000);
            ContaCorrente c3 = new ContaCorrente("Samuel Viana Costa", 3490, "010102882", 300000);
            List<ContaCorrente> listaContas = new List<ContaCorrente>();
            listaContas.Add(c1);
            listaContas.Add(c2);
            listaContas.Add(c3);
            relatorio.GerarRelatorio(banco, listaContas);
        }
    }
}
