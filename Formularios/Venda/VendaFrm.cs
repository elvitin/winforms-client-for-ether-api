using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForm.Formularios.Venda
{
  public partial class Venda_Frm : Form
  {
    public Venda_Frm()
    {
      InitializeComponent();
    }

    private void SelecionarCliente_Btn_Click(object sender, EventArgs e)
    {
      ListaClientes_Frm lista_clientes_frm = new();
      lista_clientes_frm.ShowDialog();
    }
  }
}
