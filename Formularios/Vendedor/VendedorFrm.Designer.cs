namespace AppForm.Formularios.Vendedor
{
  partial class Vendedor_Frm
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
      this.Cancelar_Btn = new System.Windows.Forms.Button();
      this.SalvarVendedor_Btn = new System.Windows.Forms.Button();
      this.NomeVendedor_TxtBox = new System.Windows.Forms.TextBox();
      this.NomeVendedor_Label = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Cancelar_Btn
      // 
      this.Cancelar_Btn.Location = new System.Drawing.Point(382, 75);
      this.Cancelar_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Cancelar_Btn.Name = "Cancelar_Btn";
      this.Cancelar_Btn.Size = new System.Drawing.Size(86, 31);
      this.Cancelar_Btn.TabIndex = 0;
      this.Cancelar_Btn.Text = "Cancelar";
      this.Cancelar_Btn.UseVisualStyleBackColor = true;
      // 
      // SalvarVendedor_Btn
      // 
      this.SalvarVendedor_Btn.Location = new System.Drawing.Point(474, 75);
      this.SalvarVendedor_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.SalvarVendedor_Btn.Name = "SalvarVendedor_Btn";
      this.SalvarVendedor_Btn.Size = new System.Drawing.Size(86, 31);
      this.SalvarVendedor_Btn.TabIndex = 1;
      this.SalvarVendedor_Btn.Text = "Salvar";
      this.SalvarVendedor_Btn.UseVisualStyleBackColor = true;
      this.SalvarVendedor_Btn.Click += new System.EventHandler(this.SalvarVendedor_Btn_Click);
      // 
      // NomeVendedor_TxtBox
      // 
      this.NomeVendedor_TxtBox.Location = new System.Drawing.Point(14, 36);
      this.NomeVendedor_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.NomeVendedor_TxtBox.Name = "NomeVendedor_TxtBox";
      this.NomeVendedor_TxtBox.Size = new System.Drawing.Size(546, 27);
      this.NomeVendedor_TxtBox.TabIndex = 2;
      // 
      // NomeVendedor_Label
      // 
      this.NomeVendedor_Label.AutoSize = true;
      this.NomeVendedor_Label.Location = new System.Drawing.Point(14, 12);
      this.NomeVendedor_Label.Name = "NomeVendedor_Label";
      this.NomeVendedor_Label.Size = new System.Drawing.Size(121, 20);
      this.NomeVendedor_Label.TabIndex = 3;
      this.NomeVendedor_Label.Text = "Nome Vendedor:";
      // 
      // Vendedor_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(574, 127);
      this.Controls.Add(this.NomeVendedor_Label);
      this.Controls.Add(this.NomeVendedor_TxtBox);
      this.Controls.Add(this.Cancelar_Btn);
      this.Controls.Add(this.SalvarVendedor_Btn);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "Vendedor_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Vendedores";
      this.Load += new System.EventHandler(this.Vendedor_Frm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button Cancelar_Btn;
        private Button SalvarVendedor_Btn;
        private TextBox NomeVendedor_TxtBox;
        private Label NomeVendedor_Label;
    }
}