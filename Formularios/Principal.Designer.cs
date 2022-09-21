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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
      this.Principal_MenuStrip = new System.Windows.Forms.MenuStrip();
      this.Cadastro_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Cliente_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Produto_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Vendedor_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Venda_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Versao_Label = new System.Windows.Forms.Label();
      this.Vendedor_PicBox = new System.Windows.Forms.PictureBox();
      this.Vendedor_Label = new System.Windows.Forms.Label();
      this.Principal_MenuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Vendedor_PicBox)).BeginInit();
      this.SuspendLayout();
      // 
      // Principal_MenuStrip
      // 
      this.Principal_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.Principal_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastro_ToolStripMenuItem});
      this.Principal_MenuStrip.Location = new System.Drawing.Point(0, 0);
      this.Principal_MenuStrip.Name = "Principal_MenuStrip";
      this.Principal_MenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.Principal_MenuStrip.Size = new System.Drawing.Size(649, 24);
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
      this.Cadastro_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.Cadastro_ToolStripMenuItem.Text = "Início";
      // 
      // Cliente_ToolStripMenuItem
      // 
      this.Cliente_ToolStripMenuItem.Name = "Cliente_ToolStripMenuItem";
      this.Cliente_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.Cliente_ToolStripMenuItem.Text = "Cliente";
      this.Cliente_ToolStripMenuItem.Click += new System.EventHandler(this.Cliente_ToolStripMenuItem_Click);
      // 
      // Produto_ToolStripMenuItem
      // 
      this.Produto_ToolStripMenuItem.Name = "Produto_ToolStripMenuItem";
      this.Produto_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.Produto_ToolStripMenuItem.Text = "Produto";
      this.Produto_ToolStripMenuItem.Click += new System.EventHandler(this.Produto_ToolStripMenuItem_Click);
      // 
      // Vendedor_ToolStripMenuItem
      // 
      this.Vendedor_ToolStripMenuItem.Name = "Vendedor_ToolStripMenuItem";
      this.Vendedor_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.Vendedor_ToolStripMenuItem.Text = "Vendedor";
      this.Vendedor_ToolStripMenuItem.Click += new System.EventHandler(this.Vendedor_ToolStripMenuItem_Click);
      // 
      // Venda_ToolStripMenuItem
      // 
      this.Venda_ToolStripMenuItem.Name = "Venda_ToolStripMenuItem";
      this.Venda_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.Venda_ToolStripMenuItem.Text = "Venda";
      this.Venda_ToolStripMenuItem.Click += new System.EventHandler(this.Venda_ToolStripMenuItem_Click);
      // 
      // Versao_Label
      // 
      this.Versao_Label.AutoSize = true;
      this.Versao_Label.Location = new System.Drawing.Point(12, 342);
      this.Versao_Label.Name = "Versao_Label";
      this.Versao_Label.Size = new System.Drawing.Size(37, 15);
      this.Versao_Label.TabIndex = 7;
      this.Versao_Label.Text = "v1.0.0";
      // 
      // Vendedor_PicBox
      // 
      this.Vendedor_PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Vendedor_PicBox.Image")));
      this.Vendedor_PicBox.Location = new System.Drawing.Point(39, 27);
      this.Vendedor_PicBox.Name = "Vendedor_PicBox";
      this.Vendedor_PicBox.Size = new System.Drawing.Size(128, 138);
      this.Vendedor_PicBox.TabIndex = 8;
      this.Vendedor_PicBox.TabStop = false;
      this.Vendedor_PicBox.Click += new System.EventHandler(this.Vendedor_PicBox_Click);
      // 
      // Vendedor_Label
      // 
      this.Vendedor_Label.AutoSize = true;
      this.Vendedor_Label.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.Vendedor_Label.Location = new System.Drawing.Point(173, 88);
      this.Vendedor_Label.Name = "Vendedor_Label";
      this.Vendedor_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Vendedor_Label.Size = new System.Drawing.Size(122, 25);
      this.Vendedor_Label.TabIndex = 9;
      this.Vendedor_Label.Text = "Vendedores";
      // 
      // Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(649, 366);
      this.Controls.Add(this.Vendedor_Label);
      this.Controls.Add(this.Vendedor_PicBox);
      this.Controls.Add(this.Versao_Label);
      this.Controls.Add(this.Principal_MenuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.Principal_MenuStrip;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximizeBox = false;
      this.Name = "Principal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bem Vindo!";
      this.Principal_MenuStrip.ResumeLayout(false);
      this.Principal_MenuStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Vendedor_PicBox)).EndInit();
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
        private PictureBox Vendedor_PicBox;
    private Label Vendedor_Label;
  }
}