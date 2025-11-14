namespace PicMyestery__WinForms_
{
    partial class TELA_JOGO
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
            label1 = new Label();
            txtResposta = new TextBox();
            btnFinalizar = new Button();
            txtPergunta = new TextBox();
            btnPerguntar = new Button();
            btnVerificar = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonVoltar = new Button();
            labelTimer = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 77);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Pergunta";
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(112, 321);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(149, 27);
            txtResposta.TabIndex = 1;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(150, 391);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtPergunta
            // 
            txtPergunta.Location = new Point(115, 104);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.ReadOnly = true;
            txtPergunta.Size = new Size(246, 106);
            txtPergunta.TabIndex = 4;
            // 
            // btnPerguntar
            // 
            btnPerguntar.Location = new Point(113, 216);
            btnPerguntar.Name = "btnPerguntar";
            btnPerguntar.Size = new Size(131, 29);
            btnPerguntar.TabIndex = 5;
            btnPerguntar.Text = "Me Pergunte!";
            btnPerguntar.UseVisualStyleBackColor = true;
            btnPerguntar.Click += btnPerguntar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(267, 320);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 298);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 7;
            label2.Text = "Digite sua Resposta:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_3;
            pictureBox1.Location = new Point(11, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 106);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // buttonVoltar
            // 
            buttonVoltar.Location = new Point(11, 12);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(94, 29);
            buttonVoltar.TabIndex = 9;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(332, 12);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(0, 20);
            labelTimer.TabIndex = 10;
            // 
            // TELA_JOGO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(labelTimer);
            Controls.Add(buttonVoltar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnVerificar);
            Controls.Add(btnPerguntar);
            Controls.Add(txtPergunta);
            Controls.Add(btnFinalizar);
            Controls.Add(txtResposta);
            Controls.Add(label1);
            Name = "TELA_JOGO";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResposta;
        private Button btnFinalizar;
        private TextBox txtPergunta;
        private Button btnPerguntar;
        private Button btnVerificar;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonVoltar;
        private Label labelTimer;
    }
}
