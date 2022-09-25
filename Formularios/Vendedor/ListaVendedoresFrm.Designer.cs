namespace AppForm.Formularios.Vendedor
{
  partial class ListaVendedores_Frm
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
      this.ListaVendedoresDataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ExcluirVendedor_Btn = new System.Windows.Forms.Button();
      this.NovoVendedor_Btn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.ListaVendedoresDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // ListaVendedoresDataGridView
      // 
      this.ListaVendedoresDataGridView.AllowUserToAddRows = false;
      this.ListaVendedoresDataGridView.AllowUserToOrderColumns = true;
      this.ListaVendedoresDataGridView.ColumnHeadersHeight = 29;
      this.ListaVendedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome});
      this.ListaVendedoresDataGridView.Location = new System.Drawing.Point(12, 13);
      this.ListaVendedoresDataGridView.Margin = new System.Windows.Forms.Padding(0);
      this.ListaVendedoresDataGridView.Name = "ListaVendedoresDataGridView";
      this.ListaVendedoresDataGridView.RowHeadersWidth = 51;
      this.ListaVendedoresDataGridView.Size = new System.Drawing.Size(887, 291);
      this.ListaVendedoresDataGridView.TabIndex = 2;
      this.ListaVendedoresDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaVendedoresDataGridView_CellDoubleClick);
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
      // ExcluirVendedor_Btn
      // 
      this.ExcluirVendedor_Btn.Location = new System.Drawing.Point(680, 312);
      this.ExcluirVendedor_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ExcluirVendedor_Btn.Name = "ExcluirVendedor_Btn";
      this.ExcluirVendedor_Btn.Size = new System.Drawing.Size(99, 31);
      this.ExcluirVendedor_Btn.TabIndex = 3;
      this.ExcluirVendedor_Btn.Text = "Excluir";
      this.ExcluirVendedor_Btn.UseVisualStyleBackColor = true;
      this.ExcluirVendedor_Btn.Click += new System.EventHandler(this.ExcluirVendedor_Btn_Click);
      // 
      // NovoVendedor_Btn
      // 
      this.NovoVendedor_Btn.Location = new System.Drawing.Point(785, 312);
      this.NovoVendedor_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.NovoVendedor_Btn.Name = "NovoVendedor_Btn";
      this.NovoVendedor_Btn.Size = new System.Drawing.Size(117, 31);
      this.NovoVendedor_Btn.TabIndex = 4;
      this.NovoVendedor_Btn.Text = "Novo vendedor";
      this.NovoVendedor_Btn.UseVisualStyleBackColor = true;
      this.NovoVendedor_Btn.Click += new System.EventHandler(this.NovoVendedor_Btn_Click);
      // 
      // ListaVendedores_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(914, 354);
      this.Controls.Add(this.NovoVendedor_Btn);
      this.Controls.Add(this.ListaVendedoresDataGridView);
      this.Controls.Add(this.ExcluirVendedor_Btn);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "ListaVendedores_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Lista de Vendedores";
      this.Load += new System.EventHandler(this.ListaVendedores_Frm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ListaVendedoresDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private DataGridView ListaVendedoresDataGridView;
    private Button ExcluirVendedor_Btn;
    private Button NovoVendedor_Btn;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNome;
    }
}