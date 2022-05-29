namespace TemplateMethod.Entity
{
    public class ContaCorrente
    {
        public string NomeTitular { get; set; }
        public int Agencia { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (string nomeTitular, int agencia, string numeroConta, double saldo)
        {
            this.NomeTitular = nomeTitular;
            this.Agencia = agencia;
            this.NumeroConta = numeroConta;
            this.Saldo = saldo;
        }
    }
}
