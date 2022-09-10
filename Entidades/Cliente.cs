using System.Text.Json.Serialization;

namespace AppForm.Entidades
{
  internal class Cliente
  {
    public string Id { get; set; }

    public string Nome { get; set; }

    public string Email { get; set; }

    public string Fone { get; set; }

    public string TipoPessoa { get; set; }

    public PessoaJuridica Juridica { get; set; }

    public PessoaFisica Fisica { get; set; }
  }
}
