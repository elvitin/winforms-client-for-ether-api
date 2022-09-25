using Newtonsoft.Json;
using EtherAPI.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForm.Formularios.Produto
{
  public partial class ListaProdutosFrm : Form
  {
    public bool pesquisando = true;
    public ListaProdutosFrm()
    {
      InitializeComponent();
    }

    private void NovoCliente_Btn_Click(object sender, EventArgs e)
    {
      Produto_Frm prodFrm = new();
      prodFrm.ShowDialog();

    }

    private void LimpaLista(DataGridView dgv)
    {
      dgv.Rows.Clear();
    }

    private void ListaProdutosFrm_Load(object sender, EventArgs e)
    {
      ObterListaProdutos();
    }


    private void ObterListaProdutos()
    {
      UpdateLoading(true);

      ProdutoControl produtoControl = new();
      string json = produtoControl.ObterTodos();
      LimpaLista(TodosProdutos_DataGridView);
      List<EtherAPI.Models.Produto.Produto> produtos = JsonConvert.DeserializeObject<List<EtherAPI.Models.Produto.Produto>>(json);

      foreach (var produto in produtos)
      {
        var tupla = new object[] { produto.Id, produto.Nome, produto.Preco, produto.Estoque, produto.Unidade.Nome, produto.Unidade.Id };
        TodosProdutos_DataGridView.Rows.Add(tupla);
      }
      UpdateLoading(false);
    }

    //PROCURA FETCH
    public void UpdateLoading(bool status)
    {
      pesquisando = status;
      if (pesquisando)
      {
        TSPBar.Visible = true;
        TSSLabel.Text = "Pesquisando...";
        TodosProdutos_DataGridView.Cursor = Cursors.WaitCursor;
      }
      else
      {
        TSPBar.Visible = false;
        TSSLabel.Text = "";
        TodosProdutos_DataGridView.Cursor = Cursors.Default;
      }
    }

    private void ListaProdutosFrm_Activated(object sender, EventArgs e)
    {
      //TODO PESQUISA AQUI 
      ObterListaProdutos();
    }

    private void TodosProdutosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      MessageBox.Show("ColumnIndex: " + e.ColumnIndex.ToString() + "\nRowIndex" + e.RowIndex.ToString());
    }

    private void Deletar_Btn_Click(object sender, EventArgs e)
    {
      ProdutoControl produtoControl = new();
      FormsControl.Excluir(produtoControl, TodosProdutos_DataGridView, ObterListaProdutos);
    }
  }
}
