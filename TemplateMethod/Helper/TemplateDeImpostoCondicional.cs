using TemplateMethod.Entity;

namespace TemplateMethod.Helper
{
    public abstract class TemplateDeImpostoCondicional
    {
        public double Calcular(Orcamento orcamento)
        {
            if (UsarTaxacaoMaxima(orcamento))
                return TaxacaoMaxima(orcamento);
            else
                return TaxacaoMinima(orcamento);
        }

        protected abstract bool UsarTaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMinima(Orcamento orcamento);
    }
}
