namespace AppForm.Formularios.Venda
{
  partial class Venda_Frm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ExcluirVenda_Btn = new System.Windows.Forms.Button();
      this.NovaVenda_Btn = new System.Windows.Forms.Button();
      this.SalvarVenda_Btn = new System.Windows.Forms.Button();
      this.ListarVendas_Btn = new System.Windows.Forms.Button();
      this.DataVenda_TxtBox = new System.Windows.Forms.TextBox();
      this.DataVenda_Label = new System.Windows.Forms.Label();
      this.IdCliente_TxtBox = new System.Windows.Forms.TextBox();
      this.IdCliente_Label = new System.Windows.Forms.Label();
      this.SelecionarCliente_Btn = new System.Windows.Forms.Button();
      this.NomeCliente_TxtBox = new System.Windows.Forms.TextBox();
      this.NomeCliente_Label = new System.Windows.Forms.Label();
      this.NomeVendedor_TxtBox = new System.Windows.Forms.TextBox();
      this.NomeVendedor_Label = new System.Windows.Forms.Label();
      this.IdVendedor_TxtBox = new System.Windows.Forms.TextBox();
      this.IdVendedor_Label = new System.Windows.Forms.Label();
      this.ProdutoPdv_DataGridView = new System.Windows.Forms.DataGridView();
      this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ValorTotal_TxtBox = new System.Windows.Forms.TextBox();
      this.ValorTotal_Label = new System.Windows.Forms.Label();
      this.Desconto_TxtBox = new System.Windows.Forms.TextBox();
      this.Desconto_Label = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ProdutoPdv_DataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // ExcluirVenda_Btn
      // 
      this.ExcluirVenda_Btn.Location = new System.Drawing.Point(196, 12);
      this.ExcluirVenda_Btn.Name = "ExcluirVenda_Btn";
      this.ExcluirVenda_Btn.Size = new System.Drawing.Size(86, 23);
      this.ExcluirVenda_Btn.TabIndex = 2;
      this.ExcluirVenda_Btn.Text = "Excluir Venda";
      this.ExcluirVenda_Btn.UseVisualStyleBackColor = true;
      // 
      // NovaVenda_Btn
      // 
      this.NovaVenda_Btn.Location = new System.Drawing.Point(12, 12);
      this.NovaVenda_Btn.Name = "NovaVenda_Btn";
      this.NovaVenda_Btn.Size = new System.Drawing.Size(86, 23);
      this.NovaVenda_Btn.TabIndex = 3;
      this.NovaVenda_Btn.Text = "Nova Venda";
      this.NovaVenda_Btn.UseVisualStyleBackColor = true;
      // 
      // SalvarVenda_Btn
      // 
      this.SalvarVenda_Btn.Location = new System.Drawing.Point(104, 12);
      this.SalvarVenda_Btn.Name = "SalvarVenda_Btn";
      this.SalvarVenda_Btn.Size = new System.Drawing.Size(86, 23);
      this.SalvarVenda_Btn.TabIndex = 4;
      this.SalvarVenda_Btn.Text = "Salvar Venda";
      this.SalvarVenda_Btn.UseVisualStyleBackColor = true;
      // 
      // ListarVendas_Btn
      // 
      this.ListarVendas_Btn.Location = new System.Drawing.Point(288, 12);
      this.ListarVendas_Btn.Name = "ListarVendas_Btn";
      this.ListarVendas_Btn.Size = new System.Drawing.Size(98, 23);
      this.ListarVendas_Btn.TabIndex = 5;
      this.ListarVendas_Btn.Text = "Listar Vendas";
      this.ListarVendas_Btn.UseVisualStyleBackColor = true;
      // 
      // DataVenda_TxtBox
      // 
      this.DataVenda_TxtBox.Enabled = false;
      this.DataVenda_TxtBox.Location = new System.Drawing.Point(12, 69);
      this.DataVenda_TxtBox.Name = "DataVenda_TxtBox";
      this.DataVenda_TxtBox.Size = new System.Drawing.Size(100, 23);
      this.DataVenda_TxtBox.TabIndex = 7;
      // 
      // DataVenda_Label
      // 
      this.DataVenda_Label.AutoSize = true;
      this.DataVenda_Label.Location = new System.Drawing.Point(12, 51);
      this.DataVenda_Label.Name = "DataVenda_Label";
      this.DataVenda_Label.Size = new System.Drawing.Size(79, 15);
      this.DataVenda_Label.TabIndex = 6;
      this.DataVenda_Label.Text = "DATA VENDA:";
      // 
      // IdCliente_TxtBox
      // 
      this.IdCliente_TxtBox.Enabled = false;
      this.IdCliente_TxtBox.Location = new System.Drawing.Point(12, 120);
      this.IdCliente_TxtBox.Name = "IdCliente_TxtBox";
      this.IdCliente_TxtBox.Size = new System.Drawing.Size(100, 23);
      this.IdCliente_TxtBox.TabIndex = 9;
      // 
      // IdCliente_Label
      // 
      this.IdCliente_Label.AutoSize = true;
      this.IdCliente_Label.Location = new System.Drawing.Point(12, 102);
      this.IdCliente_Label.Name = "IdCliente_Label";
      this.IdCliente_Label.Size = new System.Drawing.Size(68, 15);
      this.IdCliente_Label.TabIndex = 8;
      this.IdCliente_Label.Text = "ID CLIENTE:";
      // 
      // SelecionarCliente_Btn
      // 
      this.SelecionarCliente_Btn.Location = new System.Drawing.Point(579, 118);
      this.SelecionarCliente_Btn.Name = "SelecionarCliente_Btn";
      this.SelecionarCliente_Btn.Size = new System.Drawing.Size(135, 23);
      this.SelecionarCliente_Btn.TabIndex = 10;
      this.SelecionarCliente_Btn.Text = "Selecionar Cliente";
      this.SelecionarCliente_Btn.UseVisualStyleBackColor = true;
      this.SelecionarCliente_Btn.Click += new System.EventHandler(this.SelecionarCliente_Btn_Click);
      // 
      // NomeCliente_TxtBox
      // 
      this.NomeCliente_TxtBox.Enabled = false;
      this.NomeCliente_TxtBox.Location = new System.Drawing.Point(118, 120);
      this.NomeCliente_TxtBox.Name = "NomeCliente_TxtBox";
      this.NomeCliente_TxtBox.Size = new System.Drawing.Size(456, 23);
      this.NomeCliente_TxtBox.TabIndex = 12;
      // 
      // NomeCliente_Label
      // 
      this.NomeCliente_Label.AutoSize = true;
      this.NomeCliente_Label.Location = new System.Drawing.Point(118, 102);
      this.NomeCliente_Label.Name = "NomeCliente_Label";
      this.NomeCliente_Label.Size = new System.Drawing.Size(92, 15);
      this.NomeCliente_Label.TabIndex = 11;
      this.NomeCliente_Label.Text = "NOME CLIENTE:";
      // 
      // NomeVendedor_TxtBox
      // 
      this.NomeVendedor_TxtBox.Enabled = false;
      this.NomeVendedor_TxtBox.Location = new System.Drawing.Point(118, 171);
      this.NomeVendedor_TxtBox.Name = "NomeVendedor_TxtBox";
      this.NomeVendedor_TxtBox.Size = new System.Drawing.Size(596, 23);
      this.NomeVendedor_TxtBox.TabIndex = 16;
      this.NomeVendedor_TxtBox.Text = "VICTOR TAVEIRA RODRIGUES";
      // 
      // NomeVendedor_Label
      // 
      this.NomeVendedor_Label.AutoSize = true;
      this.NomeVendedor_Label.Location = new System.Drawing.Point(118, 153);
      this.NomeVendedor_Label.Name = "NomeVendedor_Label";
      this.NomeVendedor_Label.Size = new System.Drawing.Size(108, 15);
      this.NomeVendedor_Label.TabIndex = 15;
      this.NomeVendedor_Label.Text = "NOME VENDEDOR:";
      // 
      // IdVendedor_TxtBox
      // 
      this.IdVendedor_TxtBox.Enabled = false;
      this.IdVendedor_TxtBox.Location = new System.Drawing.Point(12, 171);
      this.IdVendedor_TxtBox.Name = "IdVendedor_TxtBox";
      this.IdVendedor_TxtBox.Size = new System.Drawing.Size(100, 23);
      this.IdVendedor_TxtBox.TabIndex = 14;
      this.IdVendedor_TxtBox.Text = "000";
      // 
      // IdVendedor_Label
      // 
      this.IdVendedor_Label.AutoSize = true;
      this.IdVendedor_Label.Location = new System.Drawing.Point(12, 153);
      this.IdVendedor_Label.Name = "IdVendedor_Label";
      this.IdVendedor_Label.Size = new System.Drawing.Size(84, 15);
      this.IdVendedor_Label.TabIndex = 13;
      this.IdVendedor_Label.Text = "ID VENDEDOR:";
      // 
      // ProdutoPdv_DataGridView
      // 
      this.ProdutoPdv_DataGridView.AllowUserToOrderColumns = true;
      this.ProdutoPdv_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.ProdutoPdv_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ProdutoPdv_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.NomeProduto,
            this.Qtde,
            this.Preco});
      this.ProdutoPdv_DataGridView.Location = new System.Drawing.Point(10, 207);
      this.ProdutoPdv_DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ProdutoPdv_DataGridView.Name = "ProdutoPdv_DataGridView";
      this.ProdutoPdv_DataGridView.RowHeadersWidth = 51;
      this.ProdutoPdv_DataGridView.RowTemplate.Height = 29;
      this.ProdutoPdv_DataGridView.Size = new System.Drawing.Size(511, 222);
      this.ProdutoPdv_DataGridView.TabIndex = 17;
      // 
      // IdProduto
      // 
      this.IdProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.IdProduto.Frozen = true;
      this.IdProduto.HeaderText = "ID PRODUTO";
      this.IdProduto.MinimumWidth = 6;
      this.IdProduto.Name = "IdProduto";
      this.IdProduto.Width = 91;
      // 
      // NomeProduto
      // 
      this.NomeProduto.Frozen = true;
      this.NomeProduto.HeaderText = "NOME PRODUTO";
      this.NomeProduto.MinimumWidth = 6;
      this.NomeProduto.Name = "NomeProduto";
      this.NomeProduto.ReadOnly = true;
      this.NomeProduto.Width = 113;
      // 
      // Qtde
      // 
      this.Qtde.Frozen = true;
      this.Qtde.HeaderText = "QTDE";
      this.Qtde.MinimumWidth = 6;
      this.Qtde.Name = "Qtde";
      this.Qtde.ReadOnly = true;
      this.Qtde.Width = 60;
      // 
      // Preco
      // 
      this.Preco.Frozen = true;
      this.Preco.HeaderText = "PRECO";
      this.Preco.MinimumWidth = 6;
      this.Preco.Name = "Preco";
      this.Preco.ReadOnly = true;
      this.Preco.Width = 69;
      // 
      // ValorTotal_TxtBox
      // 
      this.ValorTotal_TxtBox.Enabled = false;
      this.ValorTotal_TxtBox.Location = new System.Drawing.Point(542, 343);
      this.ValorTotal_TxtBox.Name = "ValorTotal_TxtBox";
      this.ValorTotal_TxtBox.Size = new System.Drawing.Size(173, 23);
      this.ValorTotal_TxtBox.TabIndex = 19;
      // 
      // ValorTotal_Label
      // 
      this.ValorTotal_Label.AutoSize = true;
      this.ValorTotal_Label.Location = new System.Drawing.Point(646, 325);
      this.ValorTotal_Label.Name = "ValorTotal_Label";
      this.ValorTotal_Label.Size = new System.Drawing.Size(61, 15);
      this.ValorTotal_Label.TabIndex = 18;
      this.ValorTotal_Label.Text = "Valor Total";
      this.ValorTotal_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // Desconto_TxtBox
      // 
      this.Desconto_TxtBox.Location = new System.Drawing.Point(542, 294);
      this.Desconto_TxtBox.Name = "Desconto_TxtBox";
      this.Desconto_TxtBox.Size = new System.Drawing.Size(173, 23);
      this.Desconto_TxtBox.TabIndex = 21;
      // 
      // Desconto_Label
      // 
      this.Desconto_Label.AutoSize = true;
      this.Desconto_Label.Location = new System.Drawing.Point(651, 276);
      this.Desconto_Label.Name = "Desconto_Label";
      this.Desconto_Label.Size = new System.Drawing.Size(57, 15);
      this.Desconto_Label.TabIndex = 20;
      this.Desconto_Label.Text = "Desconto";
      this.Desconto_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // Venda_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(726, 438);
      this.Controls.Add(this.Desconto_TxtBox);
      this.Controls.Add(this.Desconto_Label);
      this.Controls.Add(this.ValorTotal_TxtBox);
      this.Controls.Add(this.ValorTotal_Label);
      this.Controls.Add(this.ProdutoPdv_DataGridView);
      this.Controls.Add(this.NomeVendedor_TxtBox);
      this.Controls.Add(this.NomeVendedor_Label);
      this.Controls.Add(this.IdVendedor_TxtBox);
      this.Controls.Add(this.IdVendedor_Label);
      this.Controls.Add(this.NomeCliente_TxtBox);
      this.Controls.Add(this.NomeCliente_Label);
      this.Controls.Add(this.SelecionarCliente_Btn);
      this.Controls.Add(this.IdCliente_TxtBox);
      this.Controls.Add(this.IdCliente_Label);
      this.Controls.Add(this.DataVenda_TxtBox);
      this.Controls.Add(this.DataVenda_Label);
      this.Controls.Add(this.ListarVendas_Btn);
      this.Controls.Add(this.SalvarVenda_Btn);
      this.Controls.Add(this.NovaVenda_Btn);
      this.Controls.Add(this.ExcluirVenda_Btn);
      this.MaximizeBox = false;
      this.Name = "Venda_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Venda de Produtos";
      ((System.ComponentModel.ISupportInitialize)(this.ProdutoPdv_DataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private Button ExcluirVenda_Btn;
        private Button NovaVenda_Btn;
        private Button SalvarVenda_Btn;
        private Button ListarVendas_Btn;
        private TextBox DataVenda_TxtBox;
        private Label DataVenda_Label;
        private TextBox IdCliente_TxtBox;
        private Label IdCliente_Label;
        private Button SelecionarCliente_Btn;
        private TextBox NomeCliente_TxtBox;
        private Label NomeCliente_Label;
        private TextBox NomeVendedor_TxtBox;
        private Label NomeVendedor_Label;
        private TextBox IdVendedor_TxtBox;
        private Label IdVendedor_Label;
        private DataGridView ProdutoPdv_DataGridView;
        private TextBox ValorTotal_TxtBox;
        private Label ValorTotal_Label;
        private TextBox Desconto_TxtBox;
        private Label Desconto_Label;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn Qtde;
        private DataGridViewTextBoxColumn Preco;
    }
}