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
      this.Deletar_Btn = new System.Windows.Forms.Button();
      this.NovoCliente_Btn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientes_DataGridView)).BeginInit();
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
      this.TodosClientes_DataGridView.Location = new System.Drawing.Point(15, 13);
      this.TodosClientes_DataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.TodosClientes_DataGridView.Name = "TodosClientes_DataGridView";
      this.TodosClientes_DataGridView.ReadOnly = true;
      this.TodosClientes_DataGridView.RowHeadersWidth = 51;
      this.TodosClientes_DataGridView.RowTemplate.Height = 25;
      this.TodosClientes_DataGridView.Size = new System.Drawing.Size(1221, 491);
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
      // Deletar_Btn
      // 
      this.Deletar_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Deletar_Btn.Location = new System.Drawing.Point(1042, 514);
      this.Deletar_Btn.Name = "Deletar_Btn";
      this.Deletar_Btn.Size = new System.Drawing.Size(94, 29);
      this.Deletar_Btn.TabIndex = 3;
      this.Deletar_Btn.Text = "Excluir";
      this.Deletar_Btn.UseVisualStyleBackColor = true;
      this.Deletar_Btn.Click += new System.EventHandler(this.Deletar_Btn_Click);
      // 
      // NovoCliente_Btn
      // 
      this.NovoCliente_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.NovoCliente_Btn.Location = new System.Drawing.Point(1142, 512);
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
      this.ClientSize = new System.Drawing.Size(1248, 553);
      this.Controls.Add(this.NovoCliente_Btn);
      this.Controls.Add(this.Deletar_Btn);
      this.Controls.Add(this.TodosClientes_DataGridView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "ListaClientes_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Listar Clientes - NomeSistema";
      this.Load += new System.EventHandler(this.ListarClientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientes_DataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView TodosClientes_DataGridView;
    private Button Deletar_Btn;
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