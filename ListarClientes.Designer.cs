namespace AppForm
{
  partial class ListarClientes
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
      this.TodosClientesDataGridView = new System.Windows.Forms.DataGridView();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.buscarTextBox = new System.Windows.Forms.TextBox();
      this.btnDel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientesDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // TodosClientesDataGridView
      // 
      this.TodosClientesDataGridView.AllowUserToAddRows = false;
      this.TodosClientesDataGridView.AllowUserToDeleteRows = false;
      this.TodosClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.TodosClientesDataGridView.Location = new System.Drawing.Point(12, 45);
      this.TodosClientesDataGridView.Name = "TodosClientesDataGridView";
      this.TodosClientesDataGridView.ReadOnly = true;
      this.TodosClientesDataGridView.RowHeadersWidth = 51;
      this.TodosClientesDataGridView.RowTemplate.Height = 25;
      this.TodosClientesDataGridView.Size = new System.Drawing.Size(776, 364);
      this.TodosClientesDataGridView.TabIndex = 0;
      this.TodosClientesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodosClientes_CellContentClick);
      this.TodosClientesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodosClientesDataGridView_CellDoubleClick);
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(713, 12);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 23);
      this.btnBuscar.TabIndex = 1;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
      // 
      // buscarTextBox
      // 
      this.buscarTextBox.Location = new System.Drawing.Point(12, 12);
      this.buscarTextBox.Name = "buscarTextBox";
      this.buscarTextBox.Size = new System.Drawing.Size(695, 23);
      this.buscarTextBox.TabIndex = 2;
      this.buscarTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // btnDel
      // 
      this.btnDel.Location = new System.Drawing.Point(706, 419);
      this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new System.Drawing.Size(82, 22);
      this.btnDel.TabIndex = 3;
      this.btnDel.Text = "Excluir";
      this.btnDel.UseVisualStyleBackColor = true;
      this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
      // 
      // ListarClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnDel);
      this.Controls.Add(this.buscarTextBox);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.TodosClientesDataGridView);
      this.Name = "ListarClientes";
      this.Text = "ListarClientes";
      this.Load += new System.EventHandler(this.ListarClientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientesDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private DataGridView TodosClientesDataGridView;
        private Button btnBuscar;
        private TextBox buscarTextBox;
        private Button btnDel;
    }
}