namespace AppForm
{
  partial class ListaClientes_Frm
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
      this.TodosClientes_DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnCpjCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnRgInscriEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnSexoInscriMuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.OkBuscar_Btn = new System.Windows.Forms.Button();
      this.Buscar_TxtBox = new System.Windows.Forms.TextBox();
      this.Deletar_Btn = new System.Windows.Forms.Button();
      this.LoadRequesicao_StatusStrip = new System.Windows.Forms.StatusStrip();
      this.TSSLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.TSPBar = new System.Windows.Forms.ToolStripProgressBar();
      this.NovoCliente_Btn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientes_DataGridView)).BeginInit();
      this.LoadRequesicao_StatusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // TodosClientes_DataGridView
      // 
      this.TodosClientes_DataGridView.AllowUserToAddRows = false;
      this.TodosClientes_DataGridView.AllowUserToDeleteRows = false;
      this.TodosClientes_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TodosClientes_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.TodosClientes_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnEmail,
            this.ColumnFone,
            this.ColumnTipoPessoa,
            this.ColumnCpjCnpj,
            this.ColumnRgInscriEst,
            this.ColumnSexoInscriMuni});
      this.TodosClientes_DataGridView.Location = new System.Drawing.Point(15, 77);
      this.TodosClientes_DataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.TodosClientes_DataGridView.Name = "TodosClientes_DataGridView";
      this.TodosClientes_DataGridView.ReadOnly = true;
      this.TodosClientes_DataGridView.RowHeadersWidth = 51;
      this.TodosClientes_DataGridView.RowTemplate.Height = 25;
      this.TodosClientes_DataGridView.Size = new System.Drawing.Size(1221, 506);
      this.TodosClientes_DataGridView.TabIndex = 0;
      this.TodosClientes_DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodosClientesDataGridView_CellDoubleClick);
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
      // ColumnEmail
      // 
      this.ColumnEmail.HeaderText = "Email";
      this.ColumnEmail.MinimumWidth = 6;
      this.ColumnEmail.Name = "ColumnEmail";
      this.ColumnEmail.ReadOnly = true;
      this.ColumnEmail.Width = 125;
      // 
      // ColumnFone
      // 
      this.ColumnFone.HeaderText = "Fone";
      this.ColumnFone.MinimumWidth = 6;
      this.ColumnFone.Name = "ColumnFone";
      this.ColumnFone.ReadOnly = true;
      this.ColumnFone.Width = 125;
      // 
      // ColumnTipoPessoa
      // 
      this.ColumnTipoPessoa.HeaderText = "Tipo de Pessoa";
      this.ColumnTipoPessoa.MinimumWidth = 6;
      this.ColumnTipoPessoa.Name = "ColumnTipoPessoa";
      this.ColumnTipoPessoa.ReadOnly = true;
      this.ColumnTipoPessoa.Width = 125;
      // 
      // ColumnCpjCnpj
      // 
      this.ColumnCpjCnpj.HeaderText = "CPF/CNPJ";
      this.ColumnCpjCnpj.MinimumWidth = 6;
      this.ColumnCpjCnpj.Name = "ColumnCpjCnpj";
      this.ColumnCpjCnpj.ReadOnly = true;
      this.ColumnCpjCnpj.Width = 125;
      // 
      // ColumnRgInscriEst
      // 
      this.ColumnRgInscriEst.HeaderText = "RG / Inscrição Estadual";
      this.ColumnRgInscriEst.MinimumWidth = 6;
      this.ColumnRgInscriEst.Name = "ColumnRgInscriEst";
      this.ColumnRgInscriEst.ReadOnly = true;
      this.ColumnRgInscriEst.Width = 125;
      // 
      // ColumnSexoInscriMuni
      // 
      this.ColumnSexoInscriMuni.HeaderText = "Sexo / Inscrição Municipal";
      this.ColumnSexoInscriMuni.MinimumWidth = 6;
      this.ColumnSexoInscriMuni.Name = "ColumnSexoInscriMuni";
      this.ColumnSexoInscriMuni.ReadOnly = true;
      this.ColumnSexoInscriMuni.Width = 125;
      // 
      // OkBuscar_Btn
      // 
      this.OkBuscar_Btn.Location = new System.Drawing.Point(715, 33);
      this.OkBuscar_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.OkBuscar_Btn.Name = "OkBuscar_Btn";
      this.OkBuscar_Btn.Size = new System.Drawing.Size(86, 31);
      this.OkBuscar_Btn.TabIndex = 1;
      this.OkBuscar_Btn.Text = "Buscar";
      this.OkBuscar_Btn.UseVisualStyleBackColor = true;
      // 
      // Buscar_TxtBox
      // 
      this.Buscar_TxtBox.Location = new System.Drawing.Point(15, 33);
      this.Buscar_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Buscar_TxtBox.Name = "Buscar_TxtBox";
      this.Buscar_TxtBox.Size = new System.Drawing.Size(693, 27);
      this.Buscar_TxtBox.TabIndex = 2;
      // 
      // Deletar_Btn
      // 
      this.Deletar_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Deletar_Btn.Location = new System.Drawing.Point(1142, 597);
      this.Deletar_Btn.Name = "Deletar_Btn";
      this.Deletar_Btn.Size = new System.Drawing.Size(94, 29);
      this.Deletar_Btn.TabIndex = 3;
      this.Deletar_Btn.Text = "Excluir";
      this.Deletar_Btn.UseVisualStyleBackColor = true;
      this.Deletar_Btn.Click += new System.EventHandler(this.Deletar_Btn_Click);
      // 
      // LoadRequesicao_StatusStrip
      // 
      this.LoadRequesicao_StatusStrip.Enabled = false;
      this.LoadRequesicao_StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.LoadRequesicao_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLabel,
            this.TSPBar});
      this.LoadRequesicao_StatusStrip.Location = new System.Drawing.Point(0, 639);
      this.LoadRequesicao_StatusStrip.Name = "LoadRequesicao_StatusStrip";
      this.LoadRequesicao_StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.LoadRequesicao_StatusStrip.Size = new System.Drawing.Size(1248, 27);
      this.LoadRequesicao_StatusStrip.TabIndex = 4;
      this.LoadRequesicao_StatusStrip.Text = "Request Load";
      // 
      // TSSLabel
      // 
      this.TSSLabel.Enabled = false;
      this.TSSLabel.Name = "TSSLabel";
      this.TSSLabel.Size = new System.Drawing.Size(74, 21);
      this.TSSLabel.Text = "statusText";
      // 
      // TSPBar
      // 
      this.TSPBar.Enabled = false;
      this.TSPBar.Name = "TSPBar";
      this.TSPBar.Size = new System.Drawing.Size(114, 19);
      this.TSPBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      // 
      // NovoCliente_Btn
      // 
      this.NovoCliente_Btn.Location = new System.Drawing.Point(808, 33);
      this.NovoCliente_Btn.Name = "NovoCliente_Btn";
      this.NovoCliente_Btn.Size = new System.Drawing.Size(94, 31);
      this.NovoCliente_Btn.TabIndex = 5;
      this.NovoCliente_Btn.Text = "Novo";
      this.NovoCliente_Btn.UseVisualStyleBackColor = true;
      this.NovoCliente_Btn.Click += new System.EventHandler(this.NovoCliente_Btn_Click);
      // 
      // ListaClientes_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1248, 666);
      this.Controls.Add(this.NovoCliente_Btn);
      this.Controls.Add(this.LoadRequesicao_StatusStrip);
      this.Controls.Add(this.Deletar_Btn);
      this.Controls.Add(this.Buscar_TxtBox);
      this.Controls.Add(this.OkBuscar_Btn);
      this.Controls.Add(this.TodosClientes_DataGridView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "ListaClientes_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Listar Clientes - NomeSistema";
      this.Load += new System.EventHandler(this.ListarClientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientes_DataGridView)).EndInit();
      this.LoadRequesicao_StatusStrip.ResumeLayout(false);
      this.LoadRequesicao_StatusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DataGridView TodosClientes_DataGridView;
    private Button OkBuscar_Btn;
    private TextBox Buscar_TxtBox;
    private Button Deletar_Btn;
    private StatusStrip LoadRequesicao_StatusStrip;
    private ToolStripStatusLabel TSSLabel;
    private ToolStripProgressBar TSPBar;
    private Button NovoCliente_Btn;
    private DataGridViewTextBoxColumn ColumnID;
    private DataGridViewTextBoxColumn ColumnNome;
    private DataGridViewTextBoxColumn ColumnEmail;
    private DataGridViewTextBoxColumn ColumnFone;
    private DataGridViewTextBoxColumn ColumnTipoPessoa;
    private DataGridViewTextBoxColumn ColumnCpjCnpj;
    private DataGridViewTextBoxColumn ColumnRgInscriEst;
    private DataGridViewTextBoxColumn ColumnSexoInscriMuni;
  }
}