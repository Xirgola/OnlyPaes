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
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verificar se a pessoa digitou o email e a senha:
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um email valido!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbSenha.Text.Length < 3)
            {
                MessageBox.Show("Digite uma senha valida!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Proseguir...
                Model.Usuario usuario = new Model.Usuario();

                //Colocar os valores dos campos nos atributos do usuario:
                usuario.Email =txbEmail.Text;
                usuario.senha =txbSenha.Text;
            }
        }
    }
}
