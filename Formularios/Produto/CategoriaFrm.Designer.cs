namespace AppForm
{
  partial class Categoria_Frm
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
      this.Categoria_Label = new System.Windows.Forms.Label();
      this.NomeCat_TxtBox = new System.Windows.Forms.TextBox();
      this.SalvarCategoria_Btn = new System.Windows.Forms.Button();
      this.CancelarCategoria_Btn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Categoria_Label
      // 
      this.Categoria_Label.AutoSize = true;
      this.Categoria_Label.Location = new System.Drawing.Point(12, 9);
      this.Categoria_Label.Name = "Categoria_Label";
      this.Categoria_Label.Size = new System.Drawing.Size(97, 15);
      this.Categoria_Label.TabIndex = 0;
      this.Categoria_Label.Text = "Nome Categoria:";
      // 
      // NomeCat_TxtBox
      // 
      this.NomeCat_TxtBox.Location = new System.Drawing.Point(12, 27);
      this.NomeCat_TxtBox.Name = "NomeCat_TxtBox";
      this.NomeCat_TxtBox.Size = new System.Drawing.Size(398, 23);
      this.NomeCat_TxtBox.TabIndex = 1;
      // 
      // SalvarCategoria_Btn
      // 
      this.SalvarCategoria_Btn.Location = new System.Drawing.Point(335, 56);
      this.SalvarCategoria_Btn.Name = "SalvarCategoria_Btn";
      this.SalvarCategoria_Btn.Size = new System.Drawing.Size(75, 23);
      this.SalvarCategoria_Btn.TabIndex = 2;
      this.SalvarCategoria_Btn.Text = "Salvar";
      this.SalvarCategoria_Btn.UseVisualStyleBackColor = true;
      this.SalvarCategoria_Btn.Click += new System.EventHandler(this.SalvarCategoria_Btn_Click);
      // 
      // CancelarCategoria_Btn
      // 
      this.CancelarCategoria_Btn.Location = new System.Drawing.Point(254, 56);
      this.CancelarCategoria_Btn.Name = "CancelarCategoria_Btn";
      this.CancelarCategoria_Btn.Size = new System.Drawing.Size(75, 23);
      this.CancelarCategoria_Btn.TabIndex = 3;
      this.CancelarCategoria_Btn.Text = "Cancelar";
      this.CancelarCategoria_Btn.UseVisualStyleBackColor = true;
      // 
      // Categoria_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 84);
      this.Controls.Add(this.Categoria_Label);
      this.Controls.Add(this.NomeCat_TxtBox);
      this.Controls.Add(this.CancelarCategoria_Btn);
      this.Controls.Add(this.SalvarCategoria_Btn);
      this.MaximizeBox = false;
      this.Name = "Categoria_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Cadastro de Categoria";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

    private Label Categoria_Label;
    private TextBox NomeCat_TxtBox;
    private Button SalvarCategoria_Btn;
        private Button CancelarCategoria_Btn;
    }
}