namespace PicMyestery__WinForms_
{
    partial class TELA_LOGIN
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
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            buttonCadastro = new Button();
            labelLogin = new Label();
            labelSenha = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(108, 251);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(187, 27);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(108, 308);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(187, 27);
            textBoxSenha.TabIndex = 1;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(155, 346);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(90, 30);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // buttonCadastro
            // 
            buttonCadastro.Location = new Point(183, 416);
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.Size = new Size(103, 30);
            buttonCadastro.TabIndex = 3;
            buttonCadastro.Text = "Cadastrar";
            buttonCadastro.UseVisualStyleBackColor = true;
            buttonCadastro.Click += buttonCadastro_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(105, 228);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 4;
            labelLogin.Text = "Login";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(105, 285);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 5;
            labelSenha.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_2;
            pictureBox1.Location = new Point(109, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 195);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 421);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 7;
            label1.Text = "Ainda não tem cadastro?";
            label1.Click += label1_Click;
            // 
            // TELA_LOGIN
            // 
            ClientSize = new Size(394, 449);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelSenha);
            Controls.Add(labelLogin);
            Controls.Add(buttonCadastro);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Name = "TELA_LOGIN";
            Text = "Tela de Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
