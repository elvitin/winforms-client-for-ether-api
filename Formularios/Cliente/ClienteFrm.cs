using EtherAPI.Models.Cliente;
using Newtonsoft.Json;
using EtherAPI.Control;

namespace AppForm
{
  public partial class Cliente_Frm : Form
  {
    bool TpClienteEstado = true;
    bool UpdateState = false;
    int ultimoID = 0;

    public Cliente_Frm()
    {
      InitializeComponent();
    }

    public Cliente_Frm(DataGridViewRow row)
    {
      UpdateState = true;
      InitializeComponent();
      PesFis_RadioBtn.Enabled = false;
      PesJur_RadioBtn.Enabled = false;
      Ok_Btn.Text = "Atualizar";
      SerializaCliente(row);
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

    private void SerializaCliente(DataGridViewRow row)
    {
      ultimoID = int.Parse(row.Cells[0].Value.ToString());
      Nome_TxtBox.Text = (string)row.Cells[1].Value;
      Email_TxtBox.Text = (string)row.Cells[2].Value;
      Telefone_TxtBox.Text = (string)row.Cells[3].Value;
          
      if (row.Cells[4].Value.ToString().Equals("F"))
      {
        TrocaContextoPessoa(PesJur_Panel, PesFis_Panel);

        Cpf_TxtBox.Text = (string)row.Cells[5].Value;
        Rg_TxtBox.Text = (string)row.Cells[6].Value;
        bool sexo = ((string)row.Cells[7].Value).ToString().Equals("M");
        SexoM_RadioBtn.Checked = sexo;
        SexoF_RadioBtn.Checked = !sexo;
      } 
      else
      {
        TrocaContextoPessoa(PesFis_Panel, PesJur_Panel);
        Cnpj_mTxtBox.Text = (string)row.Cells[5].Value;
        InscEst_TxtBox.Text = (string)row.Cells[6].Value;
        InscMuni_TxtBox.Text = (string)row.Cells[7].Value;
      }
    }

    private Cliente ObtemClienteFormulario()
    {
      Cliente cliente = new()
      {
        Id = ultimoID,
        Nome = Nome_TxtBox.Text,
        Email = Email_TxtBox.Text,
        Fone = Telefone_TxtBox.Text
      };

      if (PesFis_RadioBtn.Checked)
      {
        cliente.TipoPessoa = "F";
        cliente.Fisica = new()
        {
          Cpf = Cpf_TxtBox.Text,
          Rg = Rg_TxtBox.Text,
          Sexo = SexoM_RadioBtn.Checked ? "M" : "F",
          ClienteId = ultimoID
        };
      }
      else
      {
        cliente.TipoPessoa = "J";
        cliente.Juridica = new()
        {
          Cnpj = Cnpj_mTxtBox.Text,
          InscEstadual = InscEst_TxtBox.Text,
          InscMunicipal = InscMuni_TxtBox.Text,
          ClienteId = ultimoID
        };
      }
      return cliente;
    }

    private void SalvarCliente()
    {
      Cliente cliente = ObtemClienteFormulario();
      string clienteSerializado = JsonConvert.SerializeObject(cliente, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
      //MessageBox.Show(clienteSerializado);
      ClienteControl clienteControl = new();

      if(!clienteControl.Salvar(clienteSerializado))
      {
        MessageBox.Show("Erro ao salvar cliente!");
      }
      this.Close();
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

    private void Cancelar_Btn_Click(object sender, EventArgs e)
    {
  
    }
  }
}
