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
      this.BuscaVendedor_Btn = new System.Windows.Forms.Button();
      this.BuscaVendedor_TxtBox = new System.Windows.Forms.TextBox();
      this.ListaVendedoresDataGridView = new System.Windows.Forms.DataGridView();
      this.ExcluirVendedor_Btn = new System.Windows.Forms.Button();
      this.NovoVendedor_Btn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.ListaVendedoresDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // BuscaVendedor_Btn
      // 
      this.BuscaVendedor_Btn.Location = new System.Drawing.Point(691, 15);
      this.BuscaVendedor_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.BuscaVendedor_Btn.Name = "BuscaVendedor_Btn";
      this.BuscaVendedor_Btn.Size = new System.Drawing.Size(86, 31);
      this.BuscaVendedor_Btn.TabIndex = 0;
      this.BuscaVendedor_Btn.Text = "Buscar";
      this.BuscaVendedor_Btn.UseVisualStyleBackColor = true;
      // 
      // BuscaVendedor_TxtBox
      // 
      this.BuscaVendedor_TxtBox.Location = new System.Drawing.Point(14, 16);
      this.BuscaVendedor_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.BuscaVendedor_TxtBox.Name = "BuscaVendedor_TxtBox";
      this.BuscaVendedor_TxtBox.Size = new System.Drawing.Size(670, 27);
      this.BuscaVendedor_TxtBox.TabIndex = 1;
      // 
      // ListaVendedoresDataGridView
      // 
      this.ListaVendedoresDataGridView.AllowUserToOrderColumns = true;
      this.ListaVendedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ListaVendedoresDataGridView.Location = new System.Drawing.Point(14, 55);
      this.ListaVendedoresDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ListaVendedoresDataGridView.Name = "ListaVendedoresDataGridView";
      this.ListaVendedoresDataGridView.RowHeadersWidth = 51;
      this.ListaVendedoresDataGridView.Size = new System.Drawing.Size(887, 291);
      this.ListaVendedoresDataGridView.TabIndex = 2;
      // 
      // ExcluirVendedor_Btn
      // 
      this.ExcluirVendedor_Btn.Location = new System.Drawing.Point(815, 353);
      this.ExcluirVendedor_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ExcluirVendedor_Btn.Name = "ExcluirVendedor_Btn";
      this.ExcluirVendedor_Btn.Size = new System.Drawing.Size(86, 31);
      this.ExcluirVendedor_Btn.TabIndex = 3;
      this.ExcluirVendedor_Btn.Text = "Excluir";
      this.ExcluirVendedor_Btn.UseVisualStyleBackColor = true;
      this.ExcluirVendedor_Btn.Click += new System.EventHandler(this.ExcluirVendedor_Btn_Click);
      // 
      // NovoVendedor_Btn
      // 
      this.NovoVendedor_Btn.Location = new System.Drawing.Point(784, 15);
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
      this.ClientSize = new System.Drawing.Size(914, 485);
      this.Controls.Add(this.BuscaVendedor_TxtBox);
      this.Controls.Add(this.BuscaVendedor_Btn);
      this.Controls.Add(this.NovoVendedor_Btn);
      this.Controls.Add(this.ListaVendedoresDataGridView);
      this.Controls.Add(this.ExcluirVendedor_Btn);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "ListaVendedores_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Lista de Vendedores";
      ((System.ComponentModel.ISupportInitialize)(this.ListaVendedoresDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button BuscaVendedor_Btn;
        private TextBox BuscaVendedor_TxtBox;
        private DataGridView ListaVendedoresDataGridView;
        private Button ExcluirVendedor_Btn;
        private Button NovoVendedor_Btn;
    }
}