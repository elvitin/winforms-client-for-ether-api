using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForm.Entidades.Cliente
{
    internal class PessoaJuridica
    {
        public long Cnpj { get; set; }
        public long InscEstadual { get; set; }
        public long InscMunicipal { get; set; }
        public long ClienteId { get; set; }

        public PessoaJuridica()
        { }
    }
}
