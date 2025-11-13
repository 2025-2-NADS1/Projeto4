namespace PicMyestery__WinForms_
{
    partial class TELA_CADASTRO
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
            textBoxUser = new TextBox();
            textBoxEmail = new TextBox();
            textBoxDataNasc = new TextBox();
            textBoxSenha = new TextBox();
            buttonConfirmar = new Button();
            labelUser = new Label();
            labelEmail = new Label();
            labelDataNasc = new Label();
            labelSenha = new Label();
            pictureBox1 = new PictureBox();
            buttonVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(109, 235);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(187, 27);
            textBoxUser.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(109, 271);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(187, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxDataNasc
            // 
            textBoxDataNasc.Location = new Point(109, 309);
            textBoxDataNasc.Name = "textBoxDataNasc";
            textBoxDataNasc.Size = new Size(187, 27);
            textBoxDataNasc.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(109, 347);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(187, 27);
            textBoxSenha.TabIndex = 3;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(151, 397);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(95, 30);
            buttonConfirmar.TabIndex = 4;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(53, 238);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(50, 20);
            labelUser.TabIndex = 5;
            labelUser.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(57, 271);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // labelDataNasc
            // 
            labelDataNasc.AutoSize = true;
            labelDataNasc.Location = new Point(26, 312);
            labelDataNasc.Name = "labelDataNasc";
            labelDataNasc.Size = new Size(77, 20);
            labelDataNasc.TabIndex = 7;
            labelDataNasc.Text = "Data Nasc";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(53, 350);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 8;
            labelSenha.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_2;
            pictureBox1.Location = new Point(109, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 195);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonVoltar
            // 
            buttonVoltar.Location = new Point(8, 12);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(94, 29);
            buttonVoltar.TabIndex = 10;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // TELA_CADASTRO
            // 
            ClientSize = new Size(393, 448);
            Controls.Add(buttonVoltar);
            Controls.Add(pictureBox1);
            Controls.Add(labelSenha);
            Controls.Add(labelDataNasc);
            Controls.Add(labelEmail);
            Controls.Add(labelUser);
            Controls.Add(buttonConfirmar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxDataNasc);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUser);
            Name = "TELA_CADASTRO";
            Text = "Tela de Cadastro";
            Load += TELA_CADASTRO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDataNasc;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.Label labelSenha;
        private PictureBox pictureBox1;
        private Button buttonVoltar;
    }
}
