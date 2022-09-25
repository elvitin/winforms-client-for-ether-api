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
      this.Principal_MenuStrip = new System.Windows.Forms.MenuStrip();
      this.Cadastro_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Cliente_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Produto_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Vendedor_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Venda_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Versao_Label = new System.Windows.Forms.Label();
      this.Principal_MenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // Principal_MenuStrip
      // 
      this.Principal_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.Principal_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastro_ToolStripMenuItem});
      this.Principal_MenuStrip.Location = new System.Drawing.Point(0, 0);
      this.Principal_MenuStrip.Name = "Principal_MenuStrip";
      this.Principal_MenuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
      this.Principal_MenuStrip.Size = new System.Drawing.Size(742, 30);
      this.Principal_MenuStrip.TabIndex = 6;
      this.Principal_MenuStrip.Text = "menuStrip1";
      // 
      // Cadastro_ToolStripMenuItem
      // 
      this.Cadastro_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cliente_ToolStripMenuItem,
            this.Produto_ToolStripMenuItem,
            this.Vendedor_ToolStripMenuItem,
            this.Venda_ToolStripMenuItem});
      this.Cadastro_ToolStripMenuItem.Name = "Cadastro_ToolStripMenuItem";
      this.Cadastro_ToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
      this.Cadastro_ToolStripMenuItem.Text = "Início";
      // 
      // Cliente_ToolStripMenuItem
      // 
      this.Cliente_ToolStripMenuItem.Name = "Cliente_ToolStripMenuItem";
      this.Cliente_ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
      this.Cliente_ToolStripMenuItem.Text = "Cliente";
      this.Cliente_ToolStripMenuItem.Click += new System.EventHandler(this.Cliente_ToolStripMenuItem_Click);
      // 
      // Produto_ToolStripMenuItem
      // 
      this.Produto_ToolStripMenuItem.Name = "Produto_ToolStripMenuItem";
      this.Produto_ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
      this.Produto_ToolStripMenuItem.Text = "Produto";
      this.Produto_ToolStripMenuItem.Click += new System.EventHandler(this.Produto_ToolStripMenuItem_Click);
      // 
      // Vendedor_ToolStripMenuItem
      // 
      this.Vendedor_ToolStripMenuItem.Name = "Vendedor_ToolStripMenuItem";
      this.Vendedor_ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
      this.Vendedor_ToolStripMenuItem.Text = "Vendedor";
      this.Vendedor_ToolStripMenuItem.Click += new System.EventHandler(this.Vendedor_ToolStripMenuItem_Click);
      // 
      // Venda_ToolStripMenuItem
      // 
      this.Venda_ToolStripMenuItem.Name = "Venda_ToolStripMenuItem";
      this.Venda_ToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
      this.Venda_ToolStripMenuItem.Text = "Venda";
      this.Venda_ToolStripMenuItem.Click += new System.EventHandler(this.Venda_ToolStripMenuItem_Click);
      // 
      // Versao_Label
      // 
      this.Versao_Label.AutoSize = true;
      this.Versao_Label.Location = new System.Drawing.Point(14, 456);
      this.Versao_Label.Name = "Versao_Label";
      this.Versao_Label.Size = new System.Drawing.Size(46, 20);
      this.Versao_Label.TabIndex = 7;
      this.Versao_Label.Text = "v1.0.0";
      // 
      // Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(742, 488);
      this.Controls.Add(this.Versao_Label);
      this.Controls.Add(this.Principal_MenuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.Principal_MenuStrip;
      this.MaximizeBox = false;
      this.Name = "Principal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bem Vindo!";
      this.Principal_MenuStrip.ResumeLayout(false);
      this.Principal_MenuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private MenuStrip Principal_MenuStrip;
        private ToolStripMenuItem Cadastro_ToolStripMenuItem;
        private ToolStripMenuItem Cliente_ToolStripMenuItem;
        private ToolStripMenuItem Produto_ToolStripMenuItem;
        private Label Versao_Label;
        private ToolStripMenuItem Vendedor_ToolStripMenuItem;
        private ToolStripMenuItem Venda_ToolStripMenuItem;
  }
}