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
    public partial class TELA_RESGATAR_CUPONS : Form
    {
        public TELA_RESGATAR_CUPONS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            // Fecha a TELA_RESGATAR_CUPONS
            this.Close();

            // Cria uma instância da TELA_MENU e exibe
            TELA_MENU telaMenu = new TELA_MENU();
            telaMenu.Show();
        }

    }
}
