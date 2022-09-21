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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TodosClientesDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TodosClientesDataGridView
            // 
            this.TodosClientesDataGridView.AllowUserToAddRows = false;
            this.TodosClientesDataGridView.AllowUserToDeleteRows = false;
            this.TodosClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodosClientesDataGridView.Location = new System.Drawing.Point(13, 58);
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
            this.btnBuscar.Location = new System.Drawing.Point(626, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(13, 25);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(607, 23);
            this.buscarTextBox.TabIndex = 2;
            this.buscarTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(707, 432);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 22);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Excluir";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "statusText";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 13);
            this.panel1.TabIndex = 29;
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.buscarTextBox);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TodosClientesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listar Clientes - NomeSistema";
            this.Load += new System.EventHandler(this.ListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TodosClientesDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private DataGridView TodosClientesDataGridView;
        private Button btnBuscar;
        private TextBox buscarTextBox;
        private Button btnDel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button button1;
        private Panel panel1;
    }
}