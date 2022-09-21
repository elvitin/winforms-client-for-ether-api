using AppForm.Formularios.Produto;
using AppForm.Formularios.Venda;
using AppForm.Formularios.Vendedor;

namespace AppForm
{
  public partial class Principal : Form
  {
    public Principal()
    {
      InitializeComponent();
    }



    private void Cliente_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //Cliente_Frm cliente = new();
      //cliente.Show();

      ListaClientes_Frm lista_lientes_frm = new();
      lista_lientes_frm.ShowDialog();
    }

    private void Produto_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ListaProdutosFrm listaProd = new ListaProdutosFrm();
      listaProd.ShowDialog();
    }

    private void Vendedor_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ListaVendedores_Frm lista_vendedores_frm = new();
      lista_vendedores_frm.ShowDialog();
    }

    private void Venda_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Venda_Frm venda_frm = new();
      venda_frm.ShowDialog();
    }

    private void Vendedor_PicBox_Click(object sender, EventArgs e)
    {
      ListaVendedores_Frm lista_vendedores_frm = new();
      lista_vendedores_frm.ShowDialog();
    }
  }
}