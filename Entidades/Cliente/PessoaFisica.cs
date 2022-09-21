using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForm.Entidades.Cliente
{
    internal class PessoaFisica
    {
        public long Cpf { get; set; }

        public long Rg { get; set; }

        public char Sexo { get; set; }

        public int ClienteId { get; set; }

        public PessoaFisica()
        {

        }
    }
}
