using AppForm.Entidades;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace AppForm
{
  public partial class CadCliente : Form
  {
    //true = Cliente Fisico
    bool TpClienteEstado = true;

    public CadCliente()
    {
      InitializeComponent();
    }

    public CadCliente(string identificador, string nome, string email, string telefone, string okBtnMsg)
    {
      InitializeComponent();
      okBtn.Text = okBtnMsg;
      Cpf_TxtBox.Text = identificador;
      nomeInput.Text = nome;
      emailInput.Text = email;
      telefoneInput.Text = telefone;
    }

    private void CadCliente_Load(object sender, EventArgs e)
    {
      PesFisRadioBtn.Checked = true;
    }

    

    private void label1_Click(object sender, EventArgs e)
    {

    }
   

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void DocLabel_Click(object sender, EventArgs e)
    {

    }

    private void okBtn_Click(object sender, EventArgs e)
    {
      salvarCliente();
    }


    private async void salvarCliente()
    {
      Cliente cliente = new();

      cliente.Id = Cpf_TxtBox.Text;
      cliente.Nome = nomeInput.Text;
      cliente.Email = emailInput.Text;
      cliente.Fone = telefoneInput.Text;
      
      
      using(var client =  new HttpClient())
      {
        if(okBtn.Text.Equals("Atualizar"))
        {
          string updateURI = "api/salvarCliente";
          HttpResponseMessage response = await client.PutAsJsonAsync(updateURI + "/" + cliente.Id, cliente);
          if(response.IsSuccessStatusCode)
          {
            MessageBox.Show("Produto atualizado");

          } else
          {
            MessageBox.Show("Falha ao atualizar: " + response.StatusCode);
          }
        } else
        {
          string createURI = "http://localhost/criarCliente";
          var clienteSerializado = JsonConvert.SerializeObject(cliente);
          var conteudo = new StringContent(clienteSerializado, Encoding.UTF8, "application/json");
          var result = await client.PostAsync(createURI, conteudo);
        }
      }
    }

    private void label1_Click_2(object sender, EventArgs e)
    {

    }

    private void PesFisRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      if(TpClienteEstado)
      {
        PesJur_Panel.Visible = false;
        PesJur_Panel.Enabled = false;

        PesFis_Panel.Visible = true;
        PesFis_Panel.Enabled = true;

        TpClienteEstado = false;
      }
    }

    private void PesJurRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      if (!TpClienteEstado)
      {
        PesFis_Panel.Enabled = false;
        PesFis_Panel.Visible = false;

        PesJur_Panel.Visible = true;
        PesJur_Panel.Enabled = true;

        TpClienteEstado = true;
      }
    }

    private void trocaTipoCliente()
    {
      
    }

    private void Sexo_GroupBox_Enter(object sender, EventArgs e)
    {

    }

    private void Inscri_Muni_Label_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_3(object sender, EventArgs e)
    {

    }

    private void PesFis_Panel_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
