using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json;
using ProjetoEngenhariaIII.Control;

namespace AppForm.Formularios.Vendedor
{
  public partial class ListaVendedores_Frm : Form
  {
    public ListaVendedores_Frm()
    {
      InitializeComponent();
    }

    private void NovoVendedor_Btn_Click(object sender, EventArgs e)
    {
      Vendedor_Frm vendedor_frm = new();
      vendedor_frm.ShowDialog();
      ObterListaVendedores();
    }

    private void ListaVendedores_Frm_Load(object sender, EventArgs e)
    {
      ObterListaVendedores();
    }

    private void LimpaLista()
    {
      ListaVendedoresDataGridView.Rows.Clear();
    }

    private void ObterListaVendedores()
    {
      VendedorControl vendedorControl = new();
      string json = vendedorControl.ObterTodos();
      LimpaLista();
      List<ProjetoEngenhariaIII.Models.Vendedor.Vendedor> vendedores = JsonConvert.DeserializeObject<List<ProjetoEngenhariaIII.Models.Vendedor.Vendedor>>(json);

      foreach (var vendedor in vendedores)
      {
        var tupla = new object[] { vendedor.Id, vendedor.Nome };
        ListaVendedoresDataGridView.Rows.Add(tupla);
      }
    }

    private void ListaVendedoresDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0) return;
      DataGridViewRow row = ListaVendedoresDataGridView.Rows[e.RowIndex];
      Vendedor_Frm vendForm = new(row);
      vendForm.ShowDialog();
      ObterListaVendedores();
    }

    private void ExcluirVendedor_Btn_Click(object sender, EventArgs e)
    {
      VendedorControl vendedorControl = new();
      DataGridViewSelectedRowCollection linhas = ListaVendedoresDataGridView.SelectedRows;
      if (linhas.Count == 0) return;
      if (linhas.Count > 1)
      {
        MessageBox.Show("Selecione apenas uma linha!");
        return;
      }
      int id = int.Parse(linhas[0].Cells[0].Value.ToString());
      MessageBox.Show(id.ToString());
      if (!vendedorControl.Excluir(id))
        MessageBox.Show("Falha ao deletar!");
      ObterListaVendedores();
    }
  }
}
