using Newtonsoft.Json;
using ProjetoEngenhariaIII.Control;
using ProjetoEngenhariaIII.Models.Cliente;

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
    /*
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
        TodosClientes_DataGridView.Cursor = Cursors.Default;
      }
    }
    */

    private void ListarClientes_Load(object sender, EventArgs e)
    {
      ObterTodos();
    }

    private void DeserializarClientes(string json)
    {
      List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
      //R
      foreach (var cliente in clientes)
      {
        object[] tupla = new object[8];
        int index = 0;
        tupla[index++] = cliente.Id;
        tupla[index++] = cliente.Nome;
        tupla[index++] = cliente.Email;
        tupla[index++] = cliente.Fone;
        tupla[index++] = cliente.TipoPessoa;

        if (cliente.TipoPessoa.Equals("F"))
        {
          tupla[index++] = cliente.Fisica.Cpf;
          tupla[index++] = cliente.Fisica.Rg;
          tupla[index++] = cliente.Fisica.Sexo;
        }
        else
        {
          tupla[index++] = cliente.Juridica.Cnpj;
          tupla[index++] = cliente.Juridica.InscEstadual;
          tupla[index++] = cliente.Juridica.InscMunicipal;
        }
        TodosClientes_DataGridView.Rows.Add(tupla);
      }
    }

    private void LimpaLista()
    {
      TodosClientes_DataGridView.Rows.Clear();
    }

    private void ObterTodos()
    {
      ClienteControl clienteControl = new();
      string json = clienteControl.ObterTodos();
      LimpaLista();
      DeserializarClientes(json);
    }

    private void TodosClientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0) return;
      DataGridViewRow row = TodosClientes_DataGridView.Rows[e.RowIndex];
      Cliente_Frm form = new(row);
      form.ShowDialog();
      ObterTodos();
    }

    private void NovoCliente_Btn_Click(object sender, EventArgs e)
    {
      Cliente_Frm cli = new();
      cli.ShowDialog();
      ObterTodos();
    }

    private void Deletar_Btn_Click(object sender, EventArgs e)
    {
      ClienteControl clienteControl = new();
      DataGridViewSelectedRowCollection rows = TodosClientes_DataGridView.SelectedRows;
      if (rows.Count == 0) return;
      if (rows.Count > 1)
      {
        MessageBox.Show("Selecione apenas uma linha!");
        return;
      }
      
      int id = int.Parse(rows[0].Cells[0].Value.ToString());
      if (!clienteControl.Excluir(id))
        MessageBox.Show("Falha ao deletar!");
      ObterTodos();
    }
  }
}
