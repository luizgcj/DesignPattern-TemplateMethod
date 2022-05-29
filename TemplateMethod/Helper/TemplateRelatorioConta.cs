using System;
using System.Collections.Generic;
using TemplateMethod.Entity;

namespace TemplateMethod.Helper
{
    public abstract class TemplateRelatorioConta
    {    
        protected abstract string Cabecalho(Banco banco);
        protected abstract void Detalhe(List<ContaCorrente> contaCorrente);
        protected abstract string Rodape(Banco banco);

        public void GerarRelatorio(Banco banco, List<ContaCorrente> contaCorrente)
        {
            Console.WriteLine(Cabecalho(banco));
            Detalhe(contaCorrente);            
            Console.WriteLine(Rodape(banco));         

        }
    }
}
