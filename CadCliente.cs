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
  public partial class CadCliente : Form
  {
    public CadCliente()
    {
      InitializeComponent();
    }

        private void CadCliente_Load(object sender, EventArgs e)
        {

        }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      checkBox2.Checked = !checkBox1.Checked;
      UpdateText();
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      checkBox1.Checked = !checkBox2.Checked;
      UpdateText();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
    public void UpdateText()
    {
      if (checkBox1.Checked)
      {
        DocLabel.Text = "CNPJ";
      }
      else
      {
        DocLabel.Text = "CPF";
      }
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
  }
}
