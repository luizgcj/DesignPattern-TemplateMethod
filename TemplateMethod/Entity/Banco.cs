namespace TemplateMethod.Entity
{
    public class Banco
    {
        public string NomeBanco { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Banco(string nomeBanco, string endereco, string telefone, string email)
        {
            this.NomeBanco = nomeBanco;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
        }

    }
}
