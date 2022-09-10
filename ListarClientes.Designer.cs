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
      this.TodosClientes = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientes)).BeginInit();
      this.SuspendLayout();
      // 
      // TodosClientes
      // 
      this.TodosClientes.AllowUserToAddRows = false;
      this.TodosClientes.AllowUserToDeleteRows = false;
      this.TodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.TodosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
      this.TodosClientes.Location = new System.Drawing.Point(12, 45);
      this.TodosClientes.Name = "TodosClientes";
      this.TodosClientes.ReadOnly = true;
      this.TodosClientes.RowTemplate.Height = 25;
      this.TodosClientes.Size = new System.Drawing.Size(776, 321);
      this.TodosClientes.TabIndex = 0;
      this.TodosClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodosClientes_CellContentClick);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(713, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Buscar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(695, 23);
      this.textBox1.TabIndex = 2;
      // 
      // Nome
      // 
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      this.Nome.ReadOnly = true;
      // 
      // ListarClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.TodosClientes);
      this.Name = "ListarClientes";
      this.Text = "ListarClientes";
      ((System.ComponentModel.ISupportInitialize)(this.TodosClientes)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private DataGridView TodosClientes;
        private Button button1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Nome;
    }
}