using TemplateMethod.Entity;
using TemplateMethod.Helper;

namespace TemplateMethod.Impostos
{
    public class IKCP : TemplateDeImpostoCondicional
    {
        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override bool UsarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }
    }
}
