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
      this.OkBuscar_Btn = new System.Windows.Forms.Button();
      this.Buscar_TxtBox = new System.Windows.Forms.TextBox();
      this.Deletar_Btn = new System.Windows.Forms.Button();
      this.LoadRequesicao_StatusStrip = new System.Windows.Forms.StatusStrip();
      this.TSSLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.TSPBar = new System.Windows.Forms.ToolStripProgressBar();
      this.NovoCliente_Btn = new System.Windows.Forms.Button();
      this.Decoracao_Panel = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientes_DataGridView)).BeginInit();
      this.LoadRequesicao_StatusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // TodosClientes_DataGridView
      // 
      this.TodosClientes_DataGridView.AllowUserToAddRows = false;
      this.TodosClientes_DataGridView.AllowUserToDeleteRows = false;
      this.TodosClientes_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.TodosClientes_DataGridView.Location = new System.Drawing.Point(13, 58);
      this.TodosClientes_DataGridView.Name = "TodosClientes_DataGridView";
      this.TodosClientes_DataGridView.ReadOnly = true;
      this.TodosClientes_DataGridView.RowHeadersWidth = 51;
      this.TodosClientes_DataGridView.RowTemplate.Height = 25;
      this.TodosClientes_DataGridView.Size = new System.Drawing.Size(776, 364);
      this.TodosClientes_DataGridView.TabIndex = 0;
      this.TodosClientes_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodosClientes_CellContentClick);
      this.TodosClientes_DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodosClientesDataGridView_CellDoubleClick);
      // 
      // OkBuscar_Btn
      // 
      this.OkBuscar_Btn.Location = new System.Drawing.Point(626, 25);
      this.OkBuscar_Btn.Name = "OkBuscar_Btn";
      this.OkBuscar_Btn.Size = new System.Drawing.Size(75, 23);
      this.OkBuscar_Btn.TabIndex = 1;
      this.OkBuscar_Btn.Text = "Buscar";
      this.OkBuscar_Btn.UseVisualStyleBackColor = true;
      // 
      // Buscar_TxtBox
      // 
      this.Buscar_TxtBox.Location = new System.Drawing.Point(13, 25);
      this.Buscar_TxtBox.Name = "Buscar_TxtBox";
      this.Buscar_TxtBox.Size = new System.Drawing.Size(607, 23);
      this.Buscar_TxtBox.TabIndex = 2;
      // 
      // Deletar_Btn
      // 
      this.Deletar_Btn.Location = new System.Drawing.Point(707, 432);
      this.Deletar_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Deletar_Btn.Name = "Deletar_Btn";
      this.Deletar_Btn.Size = new System.Drawing.Size(82, 22);
      this.Deletar_Btn.TabIndex = 3;
      this.Deletar_Btn.Text = "Excluir";
      this.Deletar_Btn.UseVisualStyleBackColor = true;
      // 
      // LoadRequesicao_StatusStrip
      // 
      this.LoadRequesicao_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLabel,
            this.TSPBar});
      this.LoadRequesicao_StatusStrip.Location = new System.Drawing.Point(0, 462);
      this.LoadRequesicao_StatusStrip.Name = "LoadRequesicao_StatusStrip";
      this.LoadRequesicao_StatusStrip.Size = new System.Drawing.Size(800, 22);
      this.LoadRequesicao_StatusStrip.TabIndex = 4;
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
      // NovoCliente_Btn
      // 
      this.NovoCliente_Btn.Location = new System.Drawing.Point(707, 25);
      this.NovoCliente_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.NovoCliente_Btn.Name = "NovoCliente_Btn";
      this.NovoCliente_Btn.Size = new System.Drawing.Size(82, 23);
      this.NovoCliente_Btn.TabIndex = 5;
      this.NovoCliente_Btn.Text = "Novo";
      this.NovoCliente_Btn.UseVisualStyleBackColor = true;
      this.NovoCliente_Btn.Click += new System.EventHandler(this.NovoCliente_Btn_Click);
      // 
      // Decoracao_Panel
      // 
      this.Decoracao_Panel.BackColor = System.Drawing.Color.LightSkyBlue;
      this.Decoracao_Panel.Dock = System.Windows.Forms.DockStyle.Top;
      this.Decoracao_Panel.Location = new System.Drawing.Point(0, 0);
      this.Decoracao_Panel.Name = "Decoracao_Panel";
      this.Decoracao_Panel.Size = new System.Drawing.Size(800, 13);
      this.Decoracao_Panel.TabIndex = 29;
      // 
      // ListaClientes_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 484);
      this.Controls.Add(this.Decoracao_Panel);
      this.Controls.Add(this.NovoCliente_Btn);
      this.Controls.Add(this.LoadRequesicao_StatusStrip);
      this.Controls.Add(this.Deletar_Btn);
      this.Controls.Add(this.Buscar_TxtBox);
      this.Controls.Add(this.OkBuscar_Btn);
      this.Controls.Add(this.TodosClientes_DataGridView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
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
    private Panel Decoracao_Panel;
  }
}