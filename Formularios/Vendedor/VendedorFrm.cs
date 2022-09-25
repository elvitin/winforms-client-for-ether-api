using Newtonsoft.Json;
using ProjetoEngenhariaIII.Control;
using ProjetoEngenhariaIII.Models.Cliente;

namespace AppForm.Formularios.Vendedor
{
  public partial class Vendedor_Frm : Form
  {
    int UltimoID = 0;
    public Vendedor_Frm()
    {
      InitializeComponent();
    }

    public Vendedor_Frm(DataGridViewRow row)
    {
      InitializeComponent();
      SalvarVendedor_Btn.Text = "Atualizar";
      SerializarVendedor(row);
    }

    private void SerializarVendedor(DataGridViewRow row)
    {
      UltimoID = int.Parse(row.Cells[0].Value.ToString());
      NomeVendedor_TxtBox.Text = (string)row.Cells[1].Value;
    }

    private void SalvarVendedor_Btn_Click(object sender, EventArgs e)
    {
      SalvarVendedor();
    }

    private void SalvarVendedor()
    {
      ProjetoEngenhariaIII.Models.Vendedor.Vendedor vendedor = new()
      {
        Id = UltimoID,
        Nome = NomeVendedor_TxtBox.Text
      };
      
      string vendedorJson = JsonConvert.SerializeObject(vendedor, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
      //MessageBox.Show(vendedorJson);
      VendedorControl vendedorControl = new();
      if (!vendedorControl.Salvar(vendedorJson))
      {
        MessageBox.Show("Erro ao salvar vendedor!");
      }
      this.Close();
    }

    private void Vendedor_Frm_Load(object sender, EventArgs e)
    {

    }
  }
}
