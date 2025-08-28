using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPaes
{
    public partial class MenuPrincipal : Form
    {
        // Variaveis globais
        Model.Usuario usario = new Model.Usuario();

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usario = usuario;
            lblOla.Text = $"Ola {usuario.NomeCompleto}!!! Escolha uma opção abaixo:"; 
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }
    }
}
