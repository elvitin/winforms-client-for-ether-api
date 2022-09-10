using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForm.Entidades
{
  internal class PessoaJuridica
  {
    public int Cpnj { get; set; }
    public int InscEstadual { get; set; }
    public int InscMunicipal { get; set; }
    public int ClienteId { get; set; }

    public PessoaJuridica(int cpnj, int inscEstadual, int inscMunicipal, int clienteId)
    {
      Cpnj = cpnj;
      InscEstadual = inscEstadual;
      InscMunicipal = inscMunicipal;
      ClienteId = clienteId;
    }
  }
}
