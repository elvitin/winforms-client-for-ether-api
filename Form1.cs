namespace AppForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }


    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CadCliente cliente = new CadCliente();
      cliente.ShowDialog();
    }

    private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }
  }
}