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
      this.Buscar_TxtBox = new System.Windows.Forms.TextBox();
      this.OkBuscar_Btn = new System.Windows.Forms.Button();
      this.TodosProdutos_DataGridView = new System.Windows.Forms.DataGridView();
      this.Decoracao_Panel = new System.Windows.Forms.Panel();
      this.NovoCliente_Btn = new System.Windows.Forms.Button();
      this.LoadRequesicao_StatusStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TodosProdutos_DataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // LoadRequesicao_StatusStrip
      // 
      this.LoadRequesicao_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLabel,
            this.TSPBar});
      this.LoadRequesicao_StatusStrip.Location = new System.Drawing.Point(0, 462);
      this.LoadRequesicao_StatusStrip.Name = "LoadRequesicao_StatusStrip";
      this.LoadRequesicao_StatusStrip.Size = new System.Drawing.Size(800, 22);
      this.LoadRequesicao_StatusStrip.TabIndex = 34;
      this.LoadRequesicao_StatusStrip.Text = "Request Load";
      // 
      // TSSLabel
      // 
      this.TSSLabel.Name = "TSSLabel";
      this.TSSLabel.Size = new System.Drawing.Size(59, 17);
      this.TSSLabel.Text = "statusText";
      // 
      // TSPBar
      // 
      this.TSPBar.Name = "TSPBar";
      this.TSPBar.Size = new System.Drawing.Size(100, 16);
      this.TSPBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      // 
      // Deletar_Btn
      // 
      this.Deletar_Btn.Location = new System.Drawing.Point(707, 432);
      this.Deletar_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Deletar_Btn.Name = "Deletar_Btn";
      this.Deletar_Btn.Size = new System.Drawing.Size(82, 22);
      this.Deletar_Btn.TabIndex = 33;
      this.Deletar_Btn.Text = "Excluir";
      this.Deletar_Btn.UseVisualStyleBackColor = true;
      // 
      // Buscar_TxtBox
      // 
      this.Buscar_TxtBox.Location = new System.Drawing.Point(13, 25);
      this.Buscar_TxtBox.Name = "Buscar_TxtBox";
      this.Buscar_TxtBox.Size = new System.Drawing.Size(607, 23);
      this.Buscar_TxtBox.TabIndex = 32;
      // 
      // OkBuscar_Btn
      // 
      this.OkBuscar_Btn.Location = new System.Drawing.Point(626, 25);
      this.OkBuscar_Btn.Name = "OkBuscar_Btn";
      this.OkBuscar_Btn.Size = new System.Drawing.Size(75, 23);
      this.OkBuscar_Btn.TabIndex = 31;
      this.OkBuscar_Btn.Text = "Buscar";
      this.OkBuscar_Btn.UseVisualStyleBackColor = true;
      this.OkBuscar_Btn.Click += new System.EventHandler(this.OkBuscar_Btn_Click);
      // 
      // TodosProdutos_DataGridView
      // 
      this.TodosProdutos_DataGridView.AllowUserToAddRows = false;
      this.TodosProdutos_DataGridView.AllowUserToDeleteRows = false;
      this.TodosProdutos_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.TodosProdutos_DataGridView.Location = new System.Drawing.Point(13, 58);
      this.TodosProdutos_DataGridView.Name = "TodosProdutos_DataGridView";
      this.TodosProdutos_DataGridView.ReadOnly = true;
      this.TodosProdutos_DataGridView.RowHeadersWidth = 51;
      this.TodosProdutos_DataGridView.RowTemplate.Height = 25;
      this.TodosProdutos_DataGridView.Size = new System.Drawing.Size(776, 364);
      this.TodosProdutos_DataGridView.TabIndex = 30;
      // 
      // Decoracao_Panel
      // 
      this.Decoracao_Panel.BackColor = System.Drawing.Color.LightSkyBlue;
      this.Decoracao_Panel.Dock = System.Windows.Forms.DockStyle.Top;
      this.Decoracao_Panel.Location = new System.Drawing.Point(0, 0);
      this.Decoracao_Panel.Name = "Decoracao_Panel";
      this.Decoracao_Panel.Size = new System.Drawing.Size(800, 13);
      this.Decoracao_Panel.TabIndex = 36;
      // 
      // NovoCliente_Btn
      // 
      this.NovoCliente_Btn.Location = new System.Drawing.Point(707, 25);
      this.NovoCliente_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.NovoCliente_Btn.Name = "NovoCliente_Btn";
      this.NovoCliente_Btn.Size = new System.Drawing.Size(82, 23);
      this.NovoCliente_Btn.TabIndex = 35;
      this.NovoCliente_Btn.Text = "Novo";
      this.NovoCliente_Btn.UseVisualStyleBackColor = true;
      this.NovoCliente_Btn.Click += new System.EventHandler(this.NovoCliente_Btn_Click);
      // 
      // ListaProdutosFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 484);
      this.Controls.Add(this.LoadRequesicao_StatusStrip);
      this.Controls.Add(this.Deletar_Btn);
      this.Controls.Add(this.Buscar_TxtBox);
      this.Controls.Add(this.OkBuscar_Btn);
      this.Controls.Add(this.TodosProdutos_DataGridView);
      this.Controls.Add(this.Decoracao_Panel);
      this.Controls.Add(this.NovoCliente_Btn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private TextBox Buscar_TxtBox;
        private Button OkBuscar_Btn;
        private DataGridView TodosProdutos_DataGridView;
        private Panel Decoracao_Panel;
        private Button NovoCliente_Btn;
    }
}