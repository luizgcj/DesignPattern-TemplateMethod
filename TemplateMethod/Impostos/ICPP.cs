using TemplateMethod.Entity;
using TemplateMethod.Helper;

namespace TemplateMethod.Impostos
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool UsarTaxacaoMaxima(Orcamento orcamento)
        {
            return (orcamento.Valor > 500 && PossuiItemMaiorQue100(orcamento));
        }

        private bool PossuiItemMaiorQue100(Orcamento orcamento)
        {
            foreach(var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}
