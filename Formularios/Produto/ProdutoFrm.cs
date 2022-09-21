using AppForm.Entidades.Produto;

namespace AppForm.Formularios.Produto
{
  public partial class Produto_Frm : Form
  {
    public Produto_Frm()
    {
      InitializeComponent();
    }

    public Produto_Frm(string Nome, float estoqueInicial, int unidadeCod, int preco)
    {
      InitializeComponent();
      Nome_TxtBox.Text = Nome;
      Estoque_Txt_Box.Text = estoqueInicial.ToString();

      //@Todo Lista de categorias

    }

    private void Produto_Frm_Load(object sender, EventArgs e)
    {

    }

    private void CadastrarUnidade_Btn_Click(object sender, EventArgs e)
    {
      Unidade_Frm unidade_frm = new();
      unidade_frm.ShowDialog();
    }

    private void CadastrarCategoria_Btn_Click(object sender, EventArgs e)
    {
      Categoria_Frm categoria_frm = new();
      categoria_frm.ShowDialog();
    }

    private void SalvarProduto_Btn_Click(object sender, EventArgs e)
    {

    }

    private void CancelarProduto_Btn_Click(object sender, EventArgs e)
    {

    }
  }
}
