using Newtonsoft.Json;
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
      Produto_Frm prodFrm = new Produto_Frm();
      prodFrm.ShowDialog();

    }

    private void ListaProdutosFrm_Load(object sender, EventArgs e)
    {
      ObterTodos();
    }


    private async void ObterTodos()
    {
      pesquisando = true;
      UpdateLoading();
      //string endPoint = "https://gorest.co.in/public/v2/users";

      //string endPoint = "https://api.publicapis.org/entries";

      string endPoint = "https://gorest.co.in/public/v2/comments";
      var cliente = new HttpClient();
      var resposta = await cliente.GetAsync(endPoint);

      if (resposta.IsSuccessStatusCode)
      {
        string jsonString = await resposta.Content.ReadAsStringAsync();
        //MessageBox.Show(jsonString);
        //TodosClientesDataGridView.DataSource = JsonConvert.DeserializeObject<Cliente[]>(jsonString).ToList();
        TodosProdutos_DataGridView.DataSource = JsonConvert.DeserializeObject(jsonString);
        pesquisando = false;
        UpdateLoading();

      }
      else
      {
        _ = MessageBox.Show("Um erro ocorreu!");
        pesquisando = false;
        UpdateLoading();
      }
    }

    //PROCURA FETCH
    public void UpdateLoading()
    {
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

    private void OkBuscar_Btn_Click(object sender, EventArgs e)
    {

    }

    private void ListaProdutosFrm_Activated(object sender, EventArgs e)
    {
      //TODO PESQUISA AQUI 
      ObterTodos();
    }
  }
}
