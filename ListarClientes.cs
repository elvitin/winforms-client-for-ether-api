using AppForm.Entidades;
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

namespace AppForm
{
  public partial class ListarClientes : Form
  {

        public bool pesquisando = true;
    public ListarClientes()
    {
      InitializeComponent();
    }

        //PROCURA FETCH
        public void UpdateLoading()
        {
            if (pesquisando)
            {
                toolStripProgressBar1.Visible = true;
                toolStripStatusLabel1.Text = "Pesquisando...";
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "";
            }
        }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void TodosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void ListarClientes_Load(object sender, EventArgs e)
    {
      ObterTodos();
    }
    private void textBox1_TextChanged(object sender, EventArgs e)
    {

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
        TodosClientesDataGridView.DataSource = JsonConvert.DeserializeObject(jsonString);
                pesquisando = false;
                UpdateLoading();
        
      } else {
        MessageBox.Show("Deu errado men!");
                pesquisando = false;
                UpdateLoading();
      }
    }

    private void btnDel_Click(object sender, EventArgs e)
    {

    }

    private void TodosClientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      
      CadCliente form = new(
        TodosClientesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
        TodosClientesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
        TodosClientesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(),
        TodosClientesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(),
        "Atualizar"
      );
      
      form.Show();
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadCliente cli = new CadCliente();
            cli.ShowDialog();
        }
    }
}
