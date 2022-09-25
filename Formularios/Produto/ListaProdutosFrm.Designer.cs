namespace AppForm.Formularios.Produto
{
  partial class ListaProdutosFrm
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
      this.LoadRequesicao_StatusStrip = new System.Windows.Forms.StatusStrip();
      this.TSSLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.TSPBar = new System.Windows.Forms.ToolStripProgressBar();
      this.Deletar_Btn = new System.Windows.Forms.Button();
      this.TodosProdutos_DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnUnidadeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NovoCliente_Btn = new System.Windows.Forms.Button();
      this.LoadRequesicao_StatusStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TodosProdutos_DataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // LoadRequesicao_StatusStrip
      // 
      this.LoadRequesicao_StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.LoadRequesicao_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLabel,
            this.TSPBar});
      this.LoadRequesicao_StatusStrip.Location = new System.Drawing.Point(0, 618);
      this.LoadRequesicao_StatusStrip.Name = "LoadRequesicao_StatusStrip";
      this.LoadRequesicao_StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.LoadRequesicao_StatusStrip.Size = new System.Drawing.Size(914, 27);
      this.LoadRequesicao_StatusStrip.TabIndex = 34;
      this.LoadRequesicao_StatusStrip.Text = "Request Load";
      // 
      // TSSLabel
      // 
      this.TSSLabel.Name = "TSSLabel";
      this.TSSLabel.Size = new System.Drawing.Size(74, 21);
      this.TSSLabel.Text = "statusText";
      // 
      // TSPBar
      // 
      this.TSPBar.Name = "TSPBar";
      this.TSPBar.Size = new System.Drawing.Size(114, 19);
      this.TSPBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      // 
      // Deletar_Btn
      // 
      this.Deletar_Btn.Location = new System.Drawing.Point(708, 578);
      this.Deletar_Btn.Name = "Deletar_Btn";
      this.Deletar_Btn.Size = new System.Drawing.Size(94, 31);
      this.Deletar_Btn.TabIndex = 33;
      this.Deletar_Btn.Text = "Excluir";
      this.Deletar_Btn.UseVisualStyleBackColor = true;
      this.Deletar_Btn.Click += new System.EventHandler(this.Deletar_Btn_Click);
      // 
      // TodosProdutos_DataGridView
      // 
      this.TodosProdutos_DataGridView.AllowUserToAddRows = false;
      this.TodosProdutos_DataGridView.AllowUserToDeleteRows = false;
      this.TodosProdutos_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.TodosProdutos_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnPreco,
            this.ColumnEstoque,
            this.ColumnUnidade,
            this.ColumnUnidadeID});
      this.TodosProdutos_DataGridView.Location = new System.Drawing.Point(15, 13);
      this.TodosProdutos_DataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.TodosProdutos_DataGridView.Name = "TodosProdutos_DataGridView";
      this.TodosProdutos_DataGridView.ReadOnly = true;
      this.TodosProdutos_DataGridView.RowHeadersWidth = 51;
      this.TodosProdutos_DataGridView.RowTemplate.Height = 25;
      this.TodosProdutos_DataGridView.Size = new System.Drawing.Size(887, 549);
      this.TodosProdutos_DataGridView.TabIndex = 30;
      this.TodosProdutos_DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodosProdutosDataGridView_CellDoubleClick);
      // 
      // ColumnID
      // 
      this.ColumnID.HeaderText = "ID";
      this.ColumnID.MinimumWidth = 6;
      this.ColumnID.Name = "ColumnID";
      this.ColumnID.ReadOnly = true;
      this.ColumnID.Width = 125;
      // 
      // ColumnNome
      // 
      this.ColumnNome.HeaderText = "Nome";
      this.ColumnNome.MinimumWidth = 6;
      this.ColumnNome.Name = "ColumnNome";
      this.ColumnNome.ReadOnly = true;
      this.ColumnNome.Width = 125;
      // 
      // ColumnPreco
      // 
      this.ColumnPreco.HeaderText = "Preco";
      this.ColumnPreco.MinimumWidth = 6;
      this.ColumnPreco.Name = "ColumnPreco";
      this.ColumnPreco.ReadOnly = true;
      this.ColumnPreco.Width = 125;
      // 
      // ColumnEstoque
      // 
      this.ColumnEstoque.HeaderText = "Estoque";
      this.ColumnEstoque.MinimumWidth = 6;
      this.ColumnEstoque.Name = "ColumnEstoque";
      this.ColumnEstoque.ReadOnly = true;
      this.ColumnEstoque.Width = 125;
      // 
      // ColumnUnidade
      // 
      this.ColumnUnidade.HeaderText = "Unidade";
      this.ColumnUnidade.MinimumWidth = 6;
      this.ColumnUnidade.Name = "ColumnUnidade";
      this.ColumnUnidade.ReadOnly = true;
      this.ColumnUnidade.Width = 125;
      // 
      // ColumnUnidadeID
      // 
      this.ColumnUnidadeID.HeaderText = "Unidade ID";
      this.ColumnUnidadeID.MinimumWidth = 6;
      this.ColumnUnidadeID.Name = "ColumnUnidadeID";
      this.ColumnUnidadeID.ReadOnly = true;
      this.ColumnUnidadeID.Width = 125;
      // 
      // NovoCliente_Btn
      // 
      this.NovoCliente_Btn.Location = new System.Drawing.Point(808, 578);
      this.NovoCliente_Btn.Name = "NovoCliente_Btn";
      this.NovoCliente_Btn.Size = new System.Drawing.Size(94, 31);
      this.NovoCliente_Btn.TabIndex = 35;
      this.NovoCliente_Btn.Text = "Novo";
      this.NovoCliente_Btn.UseVisualStyleBackColor = true;
      this.NovoCliente_Btn.Click += new System.EventHandler(this.NovoCliente_Btn_Click);
      // 
      // ListaProdutosFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(914, 645);
      this.Controls.Add(this.LoadRequesicao_StatusStrip);
      this.Controls.Add(this.Deletar_Btn);
      this.Controls.Add(this.TodosProdutos_DataGridView);
      this.Controls.Add(this.NovoCliente_Btn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "ListaProdutosFrm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Listar Produtos - NomeSistema";
      this.Activated += new System.EventHandler(this.ListaProdutosFrm_Activated);
      this.Load += new System.EventHandler(this.ListaProdutosFrm_Load);
      this.LoadRequesicao_StatusStrip.ResumeLayout(false);
      this.LoadRequesicao_StatusStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TodosProdutos_DataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private StatusStrip LoadRequesicao_StatusStrip;
    private ToolStripStatusLabel TSSLabel;
    private ToolStripProgressBar TSPBar;
    private Button Deletar_Btn;
    private DataGridView TodosProdutos_DataGridView;
    private Button NovoCliente_Btn;
    private DataGridViewTextBoxColumn ColumnID;
    private DataGridViewTextBoxColumn ColumnNome;
    private DataGridViewTextBoxColumn ColumnPreco;
    private DataGridViewTextBoxColumn ColumnEstoque;
    private DataGridViewTextBoxColumn ColumnUnidade;
    private DataGridViewTextBoxColumn ColumnUnidadeID;
  }
}