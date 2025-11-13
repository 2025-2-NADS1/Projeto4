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
    public partial class TELA_MENU : Form
    {
        public TELA_MENU()
        {
            InitializeComponent();
        }

        private void buttonIniciarJogo_Click(object sender, EventArgs e)
        {
            TELA_DIFICULDADE telaDificuldade = new TELA_DIFICULDADE(); // Cria a nova tela de dificuldade
            telaDificuldade.Show(); // Exibe a tela de dificuldade
            this.Hide(); // Esconde a tela do menu
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            TELA_RANKING telaRanking = new TELA_RANKING(); // Cria a nova tela de ranking
            telaRanking.Show(); // Exibe a tela de ranking
            this.Hide(); // Esconde a tela do menu
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            TELA_PERFIL telaPerfil = new TELA_PERFIL(); // Cria a nova tela de perfil
            telaPerfil.Show(); // Exibe a tela de perfil
            this.Hide(); // Esconde a tela do menu
        }

        private void buttonResgatarCupons_Click(object sender, EventArgs e)
        {
            TELA_RESGATAR_CUPONS telaResgatarCupons = new TELA_RESGATAR_CUPONS(); // Cria a nova tela de resgatar cupons
            telaResgatarCupons.Show(); // Exibe a tela de resgatar cupons
            this.Hide(); // Esconde a tela do menu
        }

    }
}
