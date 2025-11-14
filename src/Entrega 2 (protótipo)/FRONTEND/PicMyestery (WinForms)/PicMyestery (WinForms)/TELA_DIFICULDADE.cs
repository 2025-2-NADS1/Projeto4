using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicMyestery__WinForms_
{
    public partial class TELA_DIFICULDADE : Form
    {
        public TELA_DIFICULDADE()
        {
            InitializeComponent();
        }

        // Clique no botão "Fácil"
        private void buttonFacil_Click(object sender, EventArgs e)
        {
            TELA_JOGO jogo = new TELA_JOGO("Fácil");  // Passando a dificuldade para o jogo
            jogo.Show();
            this.Hide();  // Fecha a TELA_DIFICULDADE
        }

        // Clique no botão "Médio"
        private void buttonMedio_Click(object sender, EventArgs e)
        {
            TELA_JOGO jogo = new TELA_JOGO("Médio");  // Passando a dificuldade para o jogo
            jogo.Show();
            this.Hide();  // Fecha a TELA_DIFICULDADE
        }

        // Clique no botão "Difícil"
        private void buttonDificil_Click(object sender, EventArgs e)
        {
            TELA_JOGO jogo = new TELA_JOGO("Difícil");  // Passando a dificuldade para o jogo
            jogo.Show();
            this.Hide();  // Fecha a TELA_DIFICULDADE
        }
    }
}
