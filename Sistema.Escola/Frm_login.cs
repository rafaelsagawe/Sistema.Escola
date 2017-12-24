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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "rafael") && (textBox2.Text == "123")) // autenticação basica será subutituido pelo banco de dados (testa para ve se textBox1 e textBox2 tem os valores definidos)
            {
                Frm_principal frm = new Frm_principal();
                frm.Show();
                this.Visible = false;
            }
        }
    }
}
