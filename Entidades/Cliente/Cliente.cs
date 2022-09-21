using System.Text.Json.Serialization;

namespace AppForm.Entidades.Cliente
{
    internal class Cliente
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Fone { get; set; }

        public char TipoPessoa { get; set; }

        public PessoaJuridica Juridica { get; set; }

        public PessoaFisica Fisica { get; set; }
    }
}
