using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForm.Entidades
{
  internal class PessoaFisica
  {
    public int Cpf { get; set; }

    public int Rg { get; set; }

    public string Sexo { get; set; }

    public int ClienteId { get; set; }

    public PessoaFisica()
    {
      
    }
  }
}
