namespace AppForm
{
  partial class Cliente_Frm
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
      this.Ok_Btn = new System.Windows.Forms.Button();
      this.Nome_TxtBox = new System.Windows.Forms.TextBox();
      this.Nome_Label = new System.Windows.Forms.Label();
      this.Email_Label = new System.Windows.Forms.Label();
      this.Email_TxtBox = new System.Windows.Forms.TextBox();
      this.Cancelar_Btn = new System.Windows.Forms.Button();
      this.PesFis_RadioBtn = new System.Windows.Forms.RadioButton();
      this.PesJur_RadioBtn = new System.Windows.Forms.RadioButton();
      this.Rg_TxtBox = new System.Windows.Forms.TextBox();
      this.SexoM_RadioBtn = new System.Windows.Forms.RadioButton();
      this.SexoF_RadioBtn = new System.Windows.Forms.RadioButton();
      this.Sexo_GroupBox = new System.Windows.Forms.GroupBox();
      this.Cpf_TxtBox = new System.Windows.Forms.TextBox();
      this.Cpf_Label = new System.Windows.Forms.Label();
      this.Telefone_TxtBox = new System.Windows.Forms.TextBox();
      this.Telefone_Label = new System.Windows.Forms.Label();
      this.PesFis_Panel = new System.Windows.Forms.Panel();
      this.Rg_Label = new System.Windows.Forms.Label();
      this.PesJur_Panel = new System.Windows.Forms.Panel();
      this.Cnpj_mTxtBox = new System.Windows.Forms.MaskedTextBox();
      this.Cnpj_Label = new System.Windows.Forms.Label();
      this.InscEst_Label = new System.Windows.Forms.Label();
      this.InscEst_TxtBox = new System.Windows.Forms.TextBox();
      this.InscMuni_Label = new System.Windows.Forms.Label();
      this.InscMuni_TxtBox = new System.Windows.Forms.TextBox();
      this.Header = new System.Windows.Forms.Panel();
      this.Sexo_GroupBox.SuspendLayout();
      this.PesFis_Panel.SuspendLayout();
      this.PesJur_Panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // Ok_Btn
      // 
      this.Ok_Btn.Location = new System.Drawing.Point(502, 352);
      this.Ok_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Ok_Btn.Name = "Ok_Btn";
      this.Ok_Btn.Size = new System.Drawing.Size(82, 22);
      this.Ok_Btn.TabIndex = 6;
      this.Ok_Btn.Text = "Cadastrar";
      this.Ok_Btn.UseVisualStyleBackColor = true;
      this.Ok_Btn.Click += new System.EventHandler(this.Ok_Btn_Click);
      // 
      // Nome_TxtBox
      // 
      this.Nome_TxtBox.Location = new System.Drawing.Point(112, 222);
      this.Nome_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Nome_TxtBox.Name = "Nome_TxtBox";
      this.Nome_TxtBox.PlaceholderText = "Seu Nome";
      this.Nome_TxtBox.Size = new System.Drawing.Size(472, 23);
      this.Nome_TxtBox.TabIndex = 11;
      // 
      // Nome_Label
      // 
      this.Nome_Label.AutoSize = true;
      this.Nome_Label.Location = new System.Drawing.Point(112, 205);
      this.Nome_Label.Name = "Nome_Label";
      this.Nome_Label.Size = new System.Drawing.Size(43, 15);
      this.Nome_Label.TabIndex = 12;
      this.Nome_Label.Text = "Nome:";
      // 
      // Email_Label
      // 
      this.Email_Label.AutoSize = true;
      this.Email_Label.Location = new System.Drawing.Point(112, 252);
      this.Email_Label.Name = "Email_Label";
      this.Email_Label.Size = new System.Drawing.Size(44, 15);
      this.Email_Label.TabIndex = 14;
      this.Email_Label.Text = "E-mail:";
      // 
      // Email_TxtBox
      // 
      this.Email_TxtBox.Location = new System.Drawing.Point(112, 269);
      this.Email_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Email_TxtBox.Name = "Email_TxtBox";
      this.Email_TxtBox.PlaceholderText = "dominio@email.com";
      this.Email_TxtBox.Size = new System.Drawing.Size(472, 23);
      this.Email_TxtBox.TabIndex = 13;
      // 
      // Cancelar_Btn
      // 
      this.Cancelar_Btn.Location = new System.Drawing.Point(404, 352);
      this.Cancelar_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Cancelar_Btn.Name = "Cancelar_Btn";
      this.Cancelar_Btn.Size = new System.Drawing.Size(82, 22);
      this.Cancelar_Btn.TabIndex = 17;
      this.Cancelar_Btn.Text = "Cancelar";
      this.Cancelar_Btn.UseVisualStyleBackColor = true;
      // 
      // PesFis_RadioBtn
      // 
      this.PesFis_RadioBtn.AutoSize = true;
      this.PesFis_RadioBtn.Location = new System.Drawing.Point(112, 32);
      this.PesFis_RadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.PesFis_RadioBtn.Name = "PesFis_RadioBtn";
      this.PesFis_RadioBtn.Size = new System.Drawing.Size(93, 19);
      this.PesFis_RadioBtn.TabIndex = 18;
      this.PesFis_RadioBtn.TabStop = true;
      this.PesFis_RadioBtn.Text = "Pessoa Fisíca";
      this.PesFis_RadioBtn.UseVisualStyleBackColor = true;
      this.PesFis_RadioBtn.CheckedChanged += new System.EventHandler(this.PesFisRadioBtn_CheckedChanged);
      // 
      // PesJur_RadioBtn
      // 
      this.PesJur_RadioBtn.AutoSize = true;
      this.PesJur_RadioBtn.Location = new System.Drawing.Point(220, 32);
      this.PesJur_RadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.PesJur_RadioBtn.Name = "PesJur_RadioBtn";
      this.PesJur_RadioBtn.Size = new System.Drawing.Size(104, 19);
      this.PesJur_RadioBtn.TabIndex = 19;
      this.PesJur_RadioBtn.TabStop = true;
      this.PesJur_RadioBtn.Text = "Pessoa Jurídica";
      this.PesJur_RadioBtn.UseVisualStyleBackColor = true;
      this.PesJur_RadioBtn.CheckedChanged += new System.EventHandler(this.PesJurRadioBtn_CheckedChanged);
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
      // SexoM_RadioBtn
      // 
      this.SexoM_RadioBtn.AutoSize = true;
      this.SexoM_RadioBtn.Location = new System.Drawing.Point(89, 14);
      this.SexoM_RadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.SexoM_RadioBtn.Name = "SexoM_RadioBtn";
      this.SexoM_RadioBtn.Size = new System.Drawing.Size(80, 19);
      this.SexoM_RadioBtn.TabIndex = 23;
      this.SexoM_RadioBtn.TabStop = true;
      this.SexoM_RadioBtn.Text = "Masculino";
      this.SexoM_RadioBtn.UseVisualStyleBackColor = true;
      // 
      // SexoF_RadioBtn
      // 
      this.SexoF_RadioBtn.AutoSize = true;
      this.SexoF_RadioBtn.Location = new System.Drawing.Point(292, 14);
      this.SexoF_RadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.SexoF_RadioBtn.Name = "SexoF_RadioBtn";
      this.SexoF_RadioBtn.Size = new System.Drawing.Size(75, 19);
      this.SexoF_RadioBtn.TabIndex = 24;
      this.SexoF_RadioBtn.TabStop = true;
      this.SexoF_RadioBtn.Text = "Feminino";
      this.SexoF_RadioBtn.UseVisualStyleBackColor = true;
      // 
      // Sexo_GroupBox
      // 
      this.Sexo_GroupBox.Controls.Add(this.SexoM_RadioBtn);
      this.Sexo_GroupBox.Controls.Add(this.SexoF_RadioBtn);
      this.Sexo_GroupBox.Location = new System.Drawing.Point(0, 98);
      this.Sexo_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Sexo_GroupBox.Name = "Sexo_GroupBox";
      this.Sexo_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Sexo_GroupBox.Size = new System.Drawing.Size(472, 37);
      this.Sexo_GroupBox.TabIndex = 25;
      this.Sexo_GroupBox.TabStop = false;
      this.Sexo_GroupBox.Text = "Sexo:";
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
      // Cpf_Label
      // 
      this.Cpf_Label.AutoSize = true;
      this.Cpf_Label.Location = new System.Drawing.Point(0, 4);
      this.Cpf_Label.Name = "Cpf_Label";
      this.Cpf_Label.Size = new System.Drawing.Size(31, 15);
      this.Cpf_Label.TabIndex = 10;
      this.Cpf_Label.Text = "CPF:";
      // 
      // Telefone_TxtBox
      // 
      this.Telefone_TxtBox.Location = new System.Drawing.Point(112, 316);
      this.Telefone_TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Telefone_TxtBox.Name = "Telefone_TxtBox";
      this.Telefone_TxtBox.PlaceholderText = "(XX) X XXXX XXXX";
      this.Telefone_TxtBox.Size = new System.Drawing.Size(472, 23);
      this.Telefone_TxtBox.TabIndex = 15;
      // 
      // Telefone_Label
      // 
      this.Telefone_Label.AutoSize = true;
      this.Telefone_Label.Location = new System.Drawing.Point(112, 299);
      this.Telefone_Label.Name = "Telefone_Label";
      this.Telefone_Label.Size = new System.Drawing.Size(54, 15);
      this.Telefone_Label.TabIndex = 16;
      this.Telefone_Label.Text = "Telefone:";
      // 
      // PesFis_Panel
      // 
      this.PesFis_Panel.Controls.Add(this.Cpf_Label);
      this.PesFis_Panel.Controls.Add(this.Cpf_TxtBox);
      this.PesFis_Panel.Controls.Add(this.Rg_Label);
      this.PesFis_Panel.Controls.Add(this.Rg_TxtBox);
      this.PesFis_Panel.Controls.Add(this.Sexo_GroupBox);
      this.PesFis_Panel.Location = new System.Drawing.Point(112, 56);
      this.PesFis_Panel.Name = "PesFis_Panel";
      this.PesFis_Panel.Size = new System.Drawing.Size(472, 142);
      this.PesFis_Panel.TabIndex = 26;
      this.PesFis_Panel.Tag = "";
      // 
      // Rg_Label
      // 
      this.Rg_Label.AutoSize = true;
      this.Rg_Label.Location = new System.Drawing.Point(0, 46);
      this.Rg_Label.Name = "Rg_Label";
      this.Rg_Label.Size = new System.Drawing.Size(25, 15);
      this.Rg_Label.TabIndex = 27;
      this.Rg_Label.Text = "RG:";
      // 
      // PesJur_Panel
      // 
      this.PesJur_Panel.Controls.Add(this.Cnpj_mTxtBox);
      this.PesJur_Panel.Controls.Add(this.Cnpj_Label);
      this.PesJur_Panel.Controls.Add(this.InscEst_Label);
      this.PesJur_Panel.Controls.Add(this.InscEst_TxtBox);
      this.PesJur_Panel.Controls.Add(this.InscMuni_Label);
      this.PesJur_Panel.Controls.Add(this.InscMuni_TxtBox);
      this.PesJur_Panel.Location = new System.Drawing.Point(112, 56);
      this.PesJur_Panel.Name = "PesJur_Panel";
      this.PesJur_Panel.Size = new System.Drawing.Size(472, 142);
      this.PesJur_Panel.TabIndex = 27;
      this.PesJur_Panel.Tag = "";
      // 
      // Cnpj_mTxtBox
      // 
      this.Cnpj_mTxtBox.BeepOnError = true;
      this.Cnpj_mTxtBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
      this.Cnpj_mTxtBox.Location = new System.Drawing.Point(0, 22);
      this.Cnpj_mTxtBox.Mask = "00.000.000/0000-00";
      this.Cnpj_mTxtBox.Name = "Cnpj_mTxtBox";
      this.Cnpj_mTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Cnpj_mTxtBox.Size = new System.Drawing.Size(472, 23);
      this.Cnpj_mTxtBox.TabIndex = 29;
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
      // InscEst_Label
      // 
      this.InscEst_Label.AutoSize = true;
      this.InscEst_Label.Location = new System.Drawing.Point(0, 46);
      this.InscEst_Label.Name = "InscEst_Label";
      this.InscEst_Label.Size = new System.Drawing.Size(101, 15);
      this.InscEst_Label.TabIndex = 27;
      this.InscEst_Label.Text = "Inscrição Estadual";
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
      // Header
      // 
      this.Header.BackColor = System.Drawing.Color.Peru;
      this.Header.Dock = System.Windows.Forms.DockStyle.Top;
      this.Header.Location = new System.Drawing.Point(0, 0);
      this.Header.Name = "Header";
      this.Header.Size = new System.Drawing.Size(705, 13);
      this.Header.TabIndex = 28;
      // 
      // Cliente_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(705, 397);
      this.Controls.Add(this.Header);
      this.Controls.Add(this.PesFis_RadioBtn);
      this.Controls.Add(this.PesJur_RadioBtn);
      this.Controls.Add(this.PesJur_Panel);
      this.Controls.Add(this.Nome_Label);
      this.Controls.Add(this.Nome_TxtBox);
      this.Controls.Add(this.Email_Label);
      this.Controls.Add(this.Email_TxtBox);
      this.Controls.Add(this.Telefone_Label);
      this.Controls.Add(this.Telefone_TxtBox);
      this.Controls.Add(this.Cancelar_Btn);
      this.Controls.Add(this.Ok_Btn);
      this.Controls.Add(this.PesFis_Panel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximizeBox = false;
      this.Name = "Cliente_Frm";
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
        private Button Ok_Btn;
        private TextBox Nome_TxtBox;
        private Label Nome_Label;
        private Label Email_Label;
        private TextBox Email_TxtBox;
        private Button Cancelar_Btn;
        private RadioButton PesFis_RadioBtn;
        private RadioButton PesJur_RadioBtn;
        private TextBox Rg_TxtBox;
        private RadioButton SexoM_RadioBtn;
        private RadioButton SexoF_RadioBtn;
    private GroupBox Sexo_GroupBox;
        private TextBox Cpf_TxtBox;
        private Label Cpf_Label;
        private TextBox Telefone_TxtBox;
        private Label Telefone_Label;
        private Panel PesFis_Panel;
        private Label Rg_Label;
    private Panel PesJur_Panel;
    private Label InscMuni_Label;
    private TextBox InscMuni_TxtBox;
    private Label InscEst_Label;
    private TextBox InscEst_TxtBox;
    private Label Cnpj_Label;
        private Panel Header;
    private MaskedTextBox Cnpj_mTxtBox;
  }
}