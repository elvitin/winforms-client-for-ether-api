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
      this.Cancelar_Btn.Location = new System.Drawing.Point(334, 56);
      this.Cancelar_Btn.Name = "Cancelar_Btn";
      this.Cancelar_Btn.Size = new System.Drawing.Size(75, 23);
      this.Cancelar_Btn.TabIndex = 0;
      this.Cancelar_Btn.Text = "Cancelar";
      this.Cancelar_Btn.UseVisualStyleBackColor = true;
      // 
      // SalvarVendedor_Btn
      // 
      this.SalvarVendedor_Btn.Location = new System.Drawing.Point(415, 56);
      this.SalvarVendedor_Btn.Name = "SalvarVendedor_Btn";
      this.SalvarVendedor_Btn.Size = new System.Drawing.Size(75, 23);
      this.SalvarVendedor_Btn.TabIndex = 1;
      this.SalvarVendedor_Btn.Text = "Salvar";
      this.SalvarVendedor_Btn.UseVisualStyleBackColor = true;
      // 
      // NomeVendedor_TxtBox
      // 
      this.NomeVendedor_TxtBox.Location = new System.Drawing.Point(12, 27);
      this.NomeVendedor_TxtBox.Name = "NomeVendedor_TxtBox";
      this.NomeVendedor_TxtBox.Size = new System.Drawing.Size(478, 23);
      this.NomeVendedor_TxtBox.TabIndex = 2;
      // 
      // NomeVendedor_Label
      // 
      this.NomeVendedor_Label.AutoSize = true;
      this.NomeVendedor_Label.Location = new System.Drawing.Point(12, 9);
      this.NomeVendedor_Label.Name = "NomeVendedor_Label";
      this.NomeVendedor_Label.Size = new System.Drawing.Size(96, 15);
      this.NomeVendedor_Label.TabIndex = 3;
      this.NomeVendedor_Label.Text = "Nome Vendedor:";
      // 
      // Vendedor_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(502, 95);
      this.Controls.Add(this.NomeVendedor_Label);
      this.Controls.Add(this.NomeVendedor_TxtBox);
      this.Controls.Add(this.Cancelar_Btn);
      this.Controls.Add(this.SalvarVendedor_Btn);
      this.MaximizeBox = false;
      this.Name = "Vendedor_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Vendedores";
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