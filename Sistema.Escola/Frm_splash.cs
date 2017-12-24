using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Escola
{
    public partial class Frm_splash : Form
    {
        public Frm_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100) // se progressBar1 for menor que 100
            {
                progressBar1.Value = progressBar1.Value + 2; // adicionar progressBar1 mais progressBar1 + 2
            }
            else //se não chamar tela de login 
            {
                timer1.Enabled = false; // desabilitar o timer
                Frm_login frm = new Frm_login(); // chama a tela de login
                frm.Show();
                this.Visible = false; // torna invisivel a janela de splash
            }
        }
    }
}
