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

        int idSelecionado = 0; // Aramazenar o id do usuario selecionado para apagar ou editar

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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // Colocar os valores das celulas no txbs de edição:
            txbNomeEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID do quem foi selecionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes do grbApagar:
            lblApagar.Text = $"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar
            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que desja apagar este jovem?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Proseguir com o apagação
                Model.Usuario usuarioApagar = new Model.Usuario();
                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuario apagado com sucesso!", "Chave!!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetarCampos()
        {

            //atualizar o dgc
            AtualzarDgv();

            //limpar campos de ediçãp
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();
            txbNomeEditar.Clear();

            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            // Retornar o texto padrão de "apagar":
            lblApagar.Text = "Selecionar o usuario que deseja apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome dever ter no minimo 5 caracteres.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7) //a@a.co
            {
                MessageBox.Show("O Email dever ter no minimo 7 caracteres.",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha dever ter no minimo 6 caracteres.",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Proseguir com a edição:
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuario modificado com sucesso!", "Chave!!",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuário!",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
