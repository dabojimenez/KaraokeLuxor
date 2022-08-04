using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaraokeDesktop
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            pnlPadre.Controls.Clear();
            Catalogo controlCatalogo = new Catalogo();
            controlCatalogo.Dock = DockStyle.Fill;
            pnlPadre.Controls.Add(controlCatalogo);
        }
    }
}
