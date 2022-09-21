namespace AppForm.Formularios.Produto
{
  partial class Unidade_Frm
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
      this.CancelarUnidade_Btn = new System.Windows.Forms.Button();
      this.SalvarUnidade_Btn = new System.Windows.Forms.Button();
      this.Unidade_Label = new System.Windows.Forms.Label();
      this.Unidade_TxtBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // CancelarUnidade_Btn
      // 
      this.CancelarUnidade_Btn.Location = new System.Drawing.Point(229, 56);
      this.CancelarUnidade_Btn.Name = "CancelarUnidade_Btn";
      this.CancelarUnidade_Btn.Size = new System.Drawing.Size(75, 23);
      this.CancelarUnidade_Btn.TabIndex = 0;
      this.CancelarUnidade_Btn.Text = "Cancelar";
      this.CancelarUnidade_Btn.UseVisualStyleBackColor = true;
      // 
      // SalvarUnidade_Btn
      // 
      this.SalvarUnidade_Btn.Location = new System.Drawing.Point(310, 56);
      this.SalvarUnidade_Btn.Name = "SalvarUnidade_Btn";
      this.SalvarUnidade_Btn.Size = new System.Drawing.Size(75, 23);
      this.SalvarUnidade_Btn.TabIndex = 1;
      this.SalvarUnidade_Btn.Text = "Salvar";
      this.SalvarUnidade_Btn.UseVisualStyleBackColor = true;
      // 
      // Unidade_Label
      // 
      this.Unidade_Label.AutoSize = true;
      this.Unidade_Label.Location = new System.Drawing.Point(12, 9);
      this.Unidade_Label.Name = "Unidade_Label";
      this.Unidade_Label.Size = new System.Drawing.Size(54, 15);
      this.Unidade_Label.TabIndex = 2;
      this.Unidade_Label.Text = "Unidade:";
      // 
      // Unidade_TxtBox
      // 
      this.Unidade_TxtBox.Location = new System.Drawing.Point(12, 27);
      this.Unidade_TxtBox.Name = "Unidade_TxtBox";
      this.Unidade_TxtBox.Size = new System.Drawing.Size(373, 23);
      this.Unidade_TxtBox.TabIndex = 3;
      // 
      // Unidade_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 90);
      this.Controls.Add(this.Unidade_Label);
      this.Controls.Add(this.Unidade_TxtBox);
      this.Controls.Add(this.SalvarUnidade_Btn);
      this.Controls.Add(this.CancelarUnidade_Btn);
      this.MaximizeBox = false;
      this.Name = "Unidade_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "UnidadeFrm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button CancelarUnidade_Btn;
        private Button SalvarUnidade_Btn;
        private Label Unidade_Label;
        private TextBox Unidade_TxtBox;
    }
}