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
        Model.Usuario usuario = new Model.Usuario();

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblOla.Text = $"Ola {usuario.NomeCompleto}!!! Escolha uma opção abaixo:"; 
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            FormComandas formcomandas = new FormComandas(usuario);
            formcomandas.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(usuario);
            formUsuario.ShowDialog(); // Mostrar o form
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(usuario);
            formProdutos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FormCaixa formCaixa = new FormCaixa(usuario);
            formCaixa.ShowDialog();
        }
    }
}
