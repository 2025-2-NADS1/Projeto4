namespace PicMyestery__WinForms_
{
    partial class TELA_DIFICULDADE
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
            buttonFacil = new Button();
            buttonMedio = new Button();
            buttonDificil = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_2;
            pictureBox1.Location = new Point(106, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 195);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonFacil
            // 
            buttonFacil.Location = new Point(140, 247);
            buttonFacil.Name = "buttonFacil";
            buttonFacil.Size = new Size(110, 36);
            buttonFacil.TabIndex = 2;
            buttonFacil.Text = "Fácil";
            buttonFacil.UseVisualStyleBackColor = true;
            buttonFacil.Click += buttonFacil_Click;
            // 
            // buttonMedio
            // 
            buttonMedio.Location = new Point(140, 289);
            buttonMedio.Name = "buttonMedio";
            buttonMedio.Size = new Size(110, 36);
            buttonMedio.TabIndex = 3;
            buttonMedio.Text = "Médio";
            buttonMedio.UseVisualStyleBackColor = true;
            buttonMedio.Click += buttonMedio_Click;
            // 
            // buttonDificil
            // 
            buttonDificil.Location = new Point(140, 331);
            buttonDificil.Name = "buttonDificil";
            buttonDificil.Size = new Size(110, 36);
            buttonDificil.TabIndex = 4;
            buttonDificil.Text = "Dificil";
            buttonDificil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 421);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 5;
            label1.Text = "Escolha a Dificuldade do jogo";
            // 
            // TELA_DIFICULDADE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 450);
            Controls.Add(label1);
            Controls.Add(buttonDificil);
            Controls.Add(buttonMedio);
            Controls.Add(buttonFacil);
            Controls.Add(pictureBox1);
            Name = "TELA_DIFICULDADE";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonFacil;
        private Button buttonMedio;
        private Button buttonDificil;
        private Label label1;
    }
}