using AppForm.Entidades;

namespace AppForm
{
  public partial class Principal : Form
  {
    public Principal()
    {
      InitializeComponent();
    }

    private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CadCliente cliente = new CadCliente();
      cliente.ShowDialog();
    }

    private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ListarClientes l = new ListarClientes();
      l.ShowDialog();
    }
  }
}