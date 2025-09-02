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
    
    public partial class FormUsuario : Form
    {

        //Objetos globais
        Model.Usuario usuario;

        public FormUsuario(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualzarDgv();
        }
        public void AtualzarDgv()
        {
            // Mostrar as informações do bd no Datagridview:
            dgvUsuarios.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar Campos
            if (txbNomeCadastro.Text.Length < 5)
            {
                MessageBox.Show("O nome dever ter no minimo 5 caracteres.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastro.Text.Length < 7) //a@a.co
            {
                MessageBox.Show("O Email dever ter no minimo 7 caracteres.",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha dever ter no minimo 6 caracteres.",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Usuario usuarioCadastro = new Model.Usuario();

                // Salvar os valotes dos campos nos atributos do obj:
                usuarioCadastro.NomeCompleto = txbNomeCadastro.Text;
                usuarioCadastro.Email = txbEmailCadastro.Text;
                usuarioCadastro.senha = txbSenhaCadastro.Text;

                // Executar o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Chave!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    AtualzarDgv();

                    // Apagar os campos de cadastro:
                    txbNomeCadastro.Clear();
                    txbEmailCadastro.Clear();
                    txbSenhaCadastro.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário.",
                        "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
        }
    }
}
