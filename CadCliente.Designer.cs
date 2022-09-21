namespace AppForm
{
  partial class CadCliente
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
            this.okBtn = new System.Windows.Forms.Button();
            this.nomeInput = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.PesFisRadioBtn = new System.Windows.Forms.RadioButton();
            this.PesJurRadioBtn = new System.Windows.Forms.RadioButton();
            this.Rg_TxtBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Sexo_GroupBox = new System.Windows.Forms.GroupBox();
            this.Cpf_TxtBox = new System.Windows.Forms.TextBox();
            this.Cpf_Cnpj_Label = new System.Windows.Forms.Label();
            this.telefoneInput = new System.Windows.Forms.TextBox();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.PesFis_Panel = new System.Windows.Forms.Panel();
            this.Rg_Label = new System.Windows.Forms.Label();
            this.PesJur_Panel = new System.Windows.Forms.Panel();
            this.InscMuni_Label = new System.Windows.Forms.Label();
            this.InscMuni_TxtBox = new System.Windows.Forms.TextBox();
            this.InscEst_Label = new System.Windows.Forms.Label();
            this.Cnpj_TxtBox = new System.Windows.Forms.TextBox();
            this.InscEst_TxtBox = new System.Windows.Forms.TextBox();
            this.Cnpj_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sexo_GroupBox.SuspendLayout();
            this.PesFis_Panel.SuspendLayout();
            this.PesJur_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(502, 352);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(82, 22);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "Cadastrar";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // nomeInput
            // 
            this.nomeInput.Location = new System.Drawing.Point(112, 222);
            this.nomeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeInput.Name = "nomeInput";
            this.nomeInput.PlaceholderText = "Seu Nome";
            this.nomeInput.Size = new System.Drawing.Size(472, 23);
            this.nomeInput.TabIndex = 11;
            this.nomeInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(112, 205);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 15);
            this.nomeLabel.TabIndex = 12;
            this.nomeLabel.Text = "Nome:";
            this.nomeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(112, 252);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 15);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "E-mail:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(112, 269);
            this.emailInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailInput.Name = "emailInput";
            this.emailInput.PlaceholderText = "dominio@email.com";
            this.emailInput.Size = new System.Drawing.Size(472, 23);
            this.emailInput.TabIndex = 13;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(404, 352);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(82, 22);
            this.cancelarBtn.TabIndex = 17;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // PesFisRadioBtn
            // 
            this.PesFisRadioBtn.AutoSize = true;
            this.PesFisRadioBtn.Location = new System.Drawing.Point(112, 32);
            this.PesFisRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PesFisRadioBtn.Name = "PesFisRadioBtn";
            this.PesFisRadioBtn.Size = new System.Drawing.Size(93, 19);
            this.PesFisRadioBtn.TabIndex = 18;
            this.PesFisRadioBtn.TabStop = true;
            this.PesFisRadioBtn.Text = "Pessoa Fisíca";
            this.PesFisRadioBtn.UseVisualStyleBackColor = true;
            this.PesFisRadioBtn.CheckedChanged += new System.EventHandler(this.PesFisRadioBtn_CheckedChanged);
            // 
            // PesJurRadioBtn
            // 
            this.PesJurRadioBtn.AutoSize = true;
            this.PesJurRadioBtn.Location = new System.Drawing.Point(220, 32);
            this.PesJurRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PesJurRadioBtn.Name = "PesJurRadioBtn";
            this.PesJurRadioBtn.Size = new System.Drawing.Size(104, 19);
            this.PesJurRadioBtn.TabIndex = 19;
            this.PesJurRadioBtn.TabStop = true;
            this.PesJurRadioBtn.Text = "Pessoa Jurídica";
            this.PesJurRadioBtn.UseVisualStyleBackColor = true;
            this.PesJurRadioBtn.CheckedChanged += new System.EventHandler(this.PesJurRadioBtn_CheckedChanged);
            // 
            // Rg_TxtBox
            // 
            this.Rg_TxtBox.Location = new System.Drawing.Point(0, 63);
            this.Rg_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rg_TxtBox.Name = "Rg_TxtBox";
            this.Rg_TxtBox.PlaceholderText = "000.000.00";
            this.Rg_TxtBox.Size = new System.Drawing.Size(472, 23);
            this.Rg_TxtBox.TabIndex = 20;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(89, 14);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 19);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(292, 14);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 19);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Sexo_GroupBox
            // 
            this.Sexo_GroupBox.Controls.Add(this.radioButton2);
            this.Sexo_GroupBox.Controls.Add(this.radioButton1);
            this.Sexo_GroupBox.Location = new System.Drawing.Point(0, 98);
            this.Sexo_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sexo_GroupBox.Name = "Sexo_GroupBox";
            this.Sexo_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sexo_GroupBox.Size = new System.Drawing.Size(472, 37);
            this.Sexo_GroupBox.TabIndex = 25;
            this.Sexo_GroupBox.TabStop = false;
            this.Sexo_GroupBox.Text = "Sexo:";
            this.Sexo_GroupBox.Enter += new System.EventHandler(this.Sexo_GroupBox_Enter);
            // 
            // Cpf_TxtBox
            // 
            this.Cpf_TxtBox.Location = new System.Drawing.Point(0, 21);
            this.Cpf_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cpf_TxtBox.Name = "Cpf_TxtBox";
            this.Cpf_TxtBox.PlaceholderText = "000.000.00";
            this.Cpf_TxtBox.Size = new System.Drawing.Size(472, 23);
            this.Cpf_TxtBox.TabIndex = 9;
            // 
            // Cpf_Cnpj_Label
            // 
            this.Cpf_Cnpj_Label.AutoSize = true;
            this.Cpf_Cnpj_Label.Location = new System.Drawing.Point(0, 4);
            this.Cpf_Cnpj_Label.Name = "Cpf_Cnpj_Label";
            this.Cpf_Cnpj_Label.Size = new System.Drawing.Size(31, 15);
            this.Cpf_Cnpj_Label.TabIndex = 10;
            this.Cpf_Cnpj_Label.Text = "CPF:";
            this.Cpf_Cnpj_Label.Click += new System.EventHandler(this.DocLabel_Click);
            // 
            // telefoneInput
            // 
            this.telefoneInput.Location = new System.Drawing.Point(112, 316);
            this.telefoneInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefoneInput.Name = "telefoneInput";
            this.telefoneInput.PlaceholderText = "(XX) X XXXX XXXX";
            this.telefoneInput.Size = new System.Drawing.Size(472, 23);
            this.telefoneInput.TabIndex = 15;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(112, 299);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(54, 15);
            this.telefoneLabel.TabIndex = 16;
            this.telefoneLabel.Text = "Telefone:";
            this.telefoneLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PesFis_Panel
            // 
            this.PesFis_Panel.Controls.Add(this.Sexo_GroupBox);
            this.PesFis_Panel.Controls.Add(this.Rg_Label);
            this.PesFis_Panel.Controls.Add(this.Cpf_TxtBox);
            this.PesFis_Panel.Controls.Add(this.Rg_TxtBox);
            this.PesFis_Panel.Controls.Add(this.Cpf_Cnpj_Label);
            this.PesFis_Panel.Location = new System.Drawing.Point(112, 56);
            this.PesFis_Panel.Name = "PesFis_Panel";
            this.PesFis_Panel.Size = new System.Drawing.Size(472, 142);
            this.PesFis_Panel.TabIndex = 26;
            this.PesFis_Panel.Tag = "";
            this.PesFis_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.PesFis_Panel_Paint);
            // 
            // Rg_Label
            // 
            this.Rg_Label.AutoSize = true;
            this.Rg_Label.Location = new System.Drawing.Point(0, 46);
            this.Rg_Label.Name = "Rg_Label";
            this.Rg_Label.Size = new System.Drawing.Size(25, 15);
            this.Rg_Label.TabIndex = 27;
            this.Rg_Label.Text = "RG:";
            this.Rg_Label.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // PesJur_Panel
            // 
            this.PesJur_Panel.Controls.Add(this.InscMuni_Label);
            this.PesJur_Panel.Controls.Add(this.InscMuni_TxtBox);
            this.PesJur_Panel.Controls.Add(this.InscEst_Label);
            this.PesJur_Panel.Controls.Add(this.Cnpj_TxtBox);
            this.PesJur_Panel.Controls.Add(this.InscEst_TxtBox);
            this.PesJur_Panel.Controls.Add(this.Cnpj_Label);
            this.PesJur_Panel.Location = new System.Drawing.Point(112, 56);
            this.PesJur_Panel.Name = "PesJur_Panel";
            this.PesJur_Panel.Size = new System.Drawing.Size(472, 142);
            this.PesJur_Panel.TabIndex = 27;
            this.PesJur_Panel.Tag = "";
            // 
            // InscMuni_Label
            // 
            this.InscMuni_Label.AutoSize = true;
            this.InscMuni_Label.Location = new System.Drawing.Point(0, 88);
            this.InscMuni_Label.Name = "InscMuni_Label";
            this.InscMuni_Label.Size = new System.Drawing.Size(110, 15);
            this.InscMuni_Label.TabIndex = 29;
            this.InscMuni_Label.Text = "Inscrição Municipal";
            // 
            // InscMuni_TxtBox
            // 
            this.InscMuni_TxtBox.Location = new System.Drawing.Point(0, 105);
            this.InscMuni_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InscMuni_TxtBox.Name = "InscMuni_TxtBox";
            this.InscMuni_TxtBox.PlaceholderText = "000.000.00";
            this.InscMuni_TxtBox.Size = new System.Drawing.Size(472, 23);
            this.InscMuni_TxtBox.TabIndex = 28;
            // 
            // InscEst_Label
            // 
            this.InscEst_Label.AutoSize = true;
            this.InscEst_Label.Location = new System.Drawing.Point(0, 46);
            this.InscEst_Label.Name = "InscEst_Label";
            this.InscEst_Label.Size = new System.Drawing.Size(101, 15);
            this.InscEst_Label.TabIndex = 27;
            this.InscEst_Label.Text = "Inscrição Estadual";
            // 
            // Cnpj_TxtBox
            // 
            this.Cnpj_TxtBox.Location = new System.Drawing.Point(0, 21);
            this.Cnpj_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cnpj_TxtBox.Name = "Cnpj_TxtBox";
            this.Cnpj_TxtBox.PlaceholderText = "000.000.00";
            this.Cnpj_TxtBox.Size = new System.Drawing.Size(472, 23);
            this.Cnpj_TxtBox.TabIndex = 9;
            // 
            // InscEst_TxtBox
            // 
            this.InscEst_TxtBox.Location = new System.Drawing.Point(0, 63);
            this.InscEst_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InscEst_TxtBox.Name = "InscEst_TxtBox";
            this.InscEst_TxtBox.PlaceholderText = "000.000.00";
            this.InscEst_TxtBox.Size = new System.Drawing.Size(472, 23);
            this.InscEst_TxtBox.TabIndex = 20;
            // 
            // Cnpj_Label
            // 
            this.Cnpj_Label.AutoSize = true;
            this.Cnpj_Label.Location = new System.Drawing.Point(0, 4);
            this.Cnpj_Label.Name = "Cnpj_Label";
            this.Cnpj_Label.Size = new System.Drawing.Size(37, 15);
            this.Cnpj_Label.TabIndex = 10;
            this.Cnpj_Label.Text = "CNPJ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 13);
            this.panel1.TabIndex = 28;
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PesJurRadioBtn);
            this.Controls.Add(this.PesFisRadioBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.telefoneInput);
            this.Controls.Add(this.PesJur_Panel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeInput);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.PesFis_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadCliente_Load);
            this.Sexo_GroupBox.ResumeLayout(false);
            this.Sexo_GroupBox.PerformLayout();
            this.PesFis_Panel.ResumeLayout(false);
            this.PesFis_Panel.PerformLayout();
            this.PesJur_Panel.ResumeLayout(false);
            this.PesJur_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private Button okBtn;
        private TextBox nomeInput;
        private Label nomeLabel;
        private Label emailLabel;
        private TextBox emailInput;
        private Button cancelarBtn;
        private RadioButton PesFisRadioBtn;
        private RadioButton PesJurRadioBtn;
        private TextBox Rg_TxtBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    private GroupBox Sexo_GroupBox;
        private TextBox Cpf_TxtBox;
        private Label Cpf_Cnpj_Label;
        private TextBox telefoneInput;
        private Label telefoneLabel;
        private Panel PesFis_Panel;
        private Label Rg_Label;
    private Panel PesJur_Panel;
    private Label InscMuni_Label;
    private TextBox InscMuni_TxtBox;
    private Label InscEst_Label;
    private TextBox Cnpj_TxtBox;
    private TextBox InscEst_TxtBox;
    private Label Cnpj_Label;
        private Panel panel1;
    }
}