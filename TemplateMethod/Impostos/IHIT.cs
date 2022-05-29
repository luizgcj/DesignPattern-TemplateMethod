using System.Collections.Generic;
using TemplateMethod.Entity;
using TemplateMethod.Helper;

namespace TemplateMethod.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100.00;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        protected override bool UsarTaxacaoMaxima(Orcamento orcamento)
        {
            if (Existem2ItensComMesmoNome(orcamento))
                return true;
            else
                return false;
        }

        private bool Existem2ItensComMesmoNome(Orcamento orcamento)
        {
            List<string> listaItem = new List<string>();
            foreach(var item in orcamento.Itens)
            {
                if (listaItem.Contains(item.Nome))
                    return true;
                listaItem.Add(item.Nome);

            }
            return false;
        }
    }
}
