namespace AppForm.Formularios.Vendedor
{
  public partial class ListaVendedores_Frm : Form
  {
    public ListaVendedores_Frm()
    {
      InitializeComponent();
    }

    private void ListaVendedores_Frm_Load(object sender, EventArgs e)
    {
      
    }

    private void NovoVendedor_Btn_Click(object sender, EventArgs e)
    {
      Vendedor_Frm vendedor_frm = new();
      vendedor_frm.ShowDialog();
    }
  }
}
