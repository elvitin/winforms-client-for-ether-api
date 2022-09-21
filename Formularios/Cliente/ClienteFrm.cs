using AppForm.Entidades.Cliente;
using Newtonsoft.Json;
using System.Text;

namespace AppForm
{
  public partial class Cliente_Frm : Form
  {
    bool TpClienteEstado = true;

    public Cliente_Frm()
    {
      InitializeComponent();
    }

    public Cliente_Frm(string identificador, string nome, string email, string telefone, string okBtnMsg)
    {
      InitializeComponent();
      Ok_Btn.Text = okBtnMsg;
      Cpf_TxtBox.Text = identificador;
      Nome_TxtBox.Text = nome;
      Email_TxtBox.Text = email;
      Telefone_TxtBox.Text = telefone;
    }

    private void CadCliente_Load(object sender, EventArgs e)
    {
      PesFis_RadioBtn.Checked = true;
    }

    private Cliente ObtemClienteFormulario()
    {
      Cliente cliente = new()
      {
        Id = 0,
        Nome = Nome_TxtBox.Text,
        Email = Email_TxtBox.Text,
        Fone = Telefone_TxtBox.Text
      };

      if (PesFis_RadioBtn.Checked)
      {
        cliente.TipoPessoa = 'F';
        cliente.Fisica = new()
        {
          Cpf = Int64.Parse(Cpf_TxtBox.Text),
          Rg = Int64.Parse(Rg_TxtBox.Text),
          Sexo = SexoM_RadioBtn.Checked ? 'M' : 'F',
          ClienteId = 0
        };
      }
      else
      {
        cliente.TipoPessoa = 'J';
        cliente.Juridica = new()
        {
          Cnpj = Int64.Parse(Cnpj_mTxtBox.Text),
          InscEstadual = Int64.Parse(InscEst_TxtBox.Text),
          InscMunicipal = Int64.Parse(InscMuni_TxtBox.Text),
          ClienteId = 0
        };
      }
      return cliente;
    }

    private async void SalvarCliente()
    {
      Cliente cliente = ObtemClienteFormulario();

      using var client = new HttpClient();
      if (!Ok_Btn.Text.Equals("Atualizar"))
      {
        //string createURI = "http://localhost/criarCliente";
        var clienteSerializado = JsonConvert.SerializeObject(cliente, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, });
        MessageBox.Show(clienteSerializado);
        //var conteudo = new StringContent(clienteSerializado, Encoding.UTF8, "application/json");
        //MessageBox.Show(conteudo);
        //var result = await client.PostAsync(createURI, conteudo);
      }
      else
      {
        
      }
    }

    private static void TrocaContextoPessoa(Panel atual, Panel novo)
    {
      atual.Visible = atual.Enabled = false;
      novo.Visible = novo.Enabled = true;
    }

    private void PesFisRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      if (TpClienteEstado)
      {
        TrocaContextoPessoa(PesJur_Panel, PesFis_Panel);
        TpClienteEstado = false;
      }
    }

    private void PesJurRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      if (!TpClienteEstado)
      {
        TrocaContextoPessoa(PesFis_Panel, PesJur_Panel);
        TpClienteEstado = true;
      }
    }

 


    private void Ok_Btn_Click(object sender, EventArgs e)
    {
      SalvarCliente();
    }
  }
}
