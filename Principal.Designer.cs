namespace AppForm
{
  partial class Principal
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.listarToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(742, 28);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // cadastroToolStripMenuItem
      // 
      this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem});
      this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
      this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
      this.cadastroToolStripMenuItem.Text = "&Cadastro";
      // 
      // clienteToolStripMenuItem
      // 
      this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
      this.clienteToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
      this.clienteToolStripMenuItem.Text = "Cliente";
      this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
      // 
      // produtoToolStripMenuItem
      // 
      this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
      this.produtoToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
      this.produtoToolStripMenuItem.Text = "Produto";
      // 
      // listarToolStripMenuItem
      // 
      this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1});
      this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
      this.listarToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
      this.listarToolStripMenuItem.Text = "Listar";
      // 
      // clienteToolStripMenuItem1
      // 
      this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
      this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
      this.clienteToolStripMenuItem1.Text = "Cliente";
      this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(742, 488);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bem Vindo!";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem1;
    }
}