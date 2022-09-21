using Newtonsoft.Json;

namespace AppForm
{
  public partial class ListaClientes_Frm : Form
  {

    public bool pesquisando = true;
    public ListaClientes_Frm()
    {
      InitializeComponent();
    }

    //PROCURA FETCH
    public void UpdateLoading()
    {
      if (pesquisando)
      {
        TSPBar.Visible = true;
        TSSLabel.Text = "Pesquisando...";
        TodosClientes_DataGridView.Cursor = Cursors.WaitCursor;
      }
      else
      {
        TSPBar.Visible = false;
        TSSLabel.Text = "";
        TodosClientes_DataGridView.Cursor = Cursors.WaitCursor;
      }
    }



    private void TodosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void ListarClientes_Load(object sender, EventArgs e)
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
        TodosClientes_DataGridView.DataSource = JsonConvert.DeserializeObject(jsonString);
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

    private void TodosClientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      Cliente_Frm form = new(
        TodosClientes_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
        TodosClientes_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
        TodosClientes_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(),
        TodosClientes_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(),
        "Atualizar"
      );
      form.Show();
    }

    private void NovoCliente_Btn_Click(object sender, EventArgs e)
    {
      Cliente_Frm cli = new();
      cli.ShowDialog();
    }
  }
}
