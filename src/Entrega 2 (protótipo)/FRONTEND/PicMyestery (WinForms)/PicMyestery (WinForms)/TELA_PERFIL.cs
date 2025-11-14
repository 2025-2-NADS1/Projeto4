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
    public partial class TELA_PERFIL : Form
    {
        public TELA_PERFIL()
        {
            InitializeComponent();
        }

        private void buttonResgatarCupons_Click(object sender, EventArgs e)
        {
            // Fecha a TELA_PERFIL
            this.Close();

            // Cria uma instância da TELA_RESGATAR_CUPONS e exibe
            TELA_RESGATAR_CUPONS telaResgatarCupons = new TELA_RESGATAR_CUPONS();
            telaResgatarCupons.Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            // Fecha a TELA_PERFIL
            this.Close();

            // Cria uma instância da TELA_MENU e exibe
            TELA_MENU telaMenu = new TELA_MENU();
            telaMenu.Show();
        }

    }
}
