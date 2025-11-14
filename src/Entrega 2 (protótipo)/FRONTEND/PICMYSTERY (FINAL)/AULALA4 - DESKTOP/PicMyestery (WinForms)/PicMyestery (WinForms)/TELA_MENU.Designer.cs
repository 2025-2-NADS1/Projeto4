namespace PicMyestery__WinForms_
{
    partial class TELA_MENU
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
            pictureBox1 = new PictureBox();
            buttonIniciarJogo = new Button();
            buttonRanking = new Button();
            buttonPerfil = new Button();
            buttonResgatarCupons = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_2;
            pictureBox1.Location = new Point(108, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 195);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonIniciarJogo
            // 
            buttonIniciarJogo.Location = new Point(130, 236);
            buttonIniciarJogo.Name = "buttonIniciarJogo";
            buttonIniciarJogo.Size = new Size(135, 33);
            buttonIniciarJogo.TabIndex = 1;
            buttonIniciarJogo.Text = "Iniciar Jogo";
            buttonIniciarJogo.UseVisualStyleBackColor = true;
            buttonIniciarJogo.Click += buttonIniciarJogo_Click;
            // 
            // buttonRanking
            // 
            buttonRanking.Location = new Point(130, 275);
            buttonRanking.Name = "buttonRanking";
            buttonRanking.Size = new Size(135, 33);
            buttonRanking.TabIndex = 2;
            buttonRanking.Text = "Ranking";
            buttonRanking.UseVisualStyleBackColor = true;
            buttonRanking.Click += buttonRanking_Click;
            // 
            // buttonPerfil
            // 
            buttonPerfil.Location = new Point(130, 314);
            buttonPerfil.Name = "buttonPerfil";
            buttonPerfil.Size = new Size(135, 33);
            buttonPerfil.TabIndex = 3;
            buttonPerfil.Text = "Perfil";
            buttonPerfil.UseVisualStyleBackColor = true;
            buttonPerfil.Click += buttonPerfil_Click;
            // 
            // buttonResgatarCupons
            // 
            buttonResgatarCupons.Location = new Point(130, 353);
            buttonResgatarCupons.Name = "buttonResgatarCupons";
            buttonResgatarCupons.Size = new Size(135, 33);
            buttonResgatarCupons.TabIndex = 4;
            buttonResgatarCupons.Text = "Resgatar Cupons";
            buttonResgatarCupons.UseVisualStyleBackColor = true;
            buttonResgatarCupons.Click += buttonResgatarCupons_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 425);
            label1.Name = "label1";
            label1.Size = new Size(333, 20);
            label1.TabIndex = 5;
            label1.Text = "Está preparador para testar seus conhecimentos?";
            // 
            // TELA_MENU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(label1);
            Controls.Add(buttonResgatarCupons);
            Controls.Add(buttonPerfil);
            Controls.Add(buttonRanking);
            Controls.Add(buttonIniciarJogo);
            Controls.Add(pictureBox1);
            Name = "TELA_MENU";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonIniciarJogo;
        private Button buttonRanking;
        private Button buttonPerfil;
        private Button buttonResgatarCupons;
        private Label label1;
        private Button button1;
    }
}