namespace PicMyestery__WinForms_
{
    partial class TELA_RANKING
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonVoltar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 227);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 2;
            label1.Text = "RANKING MUNDIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 261);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 3;
            label2.Text = "1º";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 292);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 4;
            label3.Text = "2º";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 326);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 5;
            label4.Text = "3º";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 359);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 6;
            label5.Text = "4º";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 392);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 7;
            label6.Text = "5º";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Location = new Point(6, 12);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(80, 29);
            buttonVoltar.TabIndex = 9;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 356);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(121, 323);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(121, 389);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 27);
            textBox5.TabIndex = 14;
            // 
            // TELA_RANKING
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonVoltar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TELA_RANKING";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonVoltar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}