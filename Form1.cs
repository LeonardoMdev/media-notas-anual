using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo02
{
    public partial class FrmFormulario : Form
    {
        public FrmFormulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            int nota01;
            int nota02;
            int nota03;
            int nota04;
            int mediaNotas;

            nota01 = int.Parse(txtNota1.Text);
            nota02 = int.Parse(txtNota2.Text);
            nota03 = int.Parse(txtNota3.Text);
            nota04 = int.Parse(txtNota4.Text);

            mediaNotas = (nota01 + nota02 + nota03 + nota04)/ 4;

            txtResultado.Text = Convert.ToString(mediaNotas);
        }
    }
}
