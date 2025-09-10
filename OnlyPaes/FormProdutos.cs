using EasyEncryption;
using MySqlConnector;
using OnlyPaes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlyPaes
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        Model.Produto produto = new Produto();
          
        int idSelecionado = 0;


        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualzarDgv();
            ListaCategoriasCmb();
        }
        public void AtualzarDgv()
        {
            // Mostrar as informações do bd no Datagridview:
            dgvProdutos.DataSource = produto.Listar();
        }
        public void ListaCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela para receber o resultado do SELEC:
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1 - Salgados
                // 2 - Bebidas
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            double preco = double.Parse(txbPrecoProduto.Text);

            if (txbNomeCadastro.Text.Length < 3)
            {
                MessageBox.Show("O nome do produto dever ter no minimo 3 caracteres.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (preco <= 0)
            {
                MessageBox.Show("O preço do produto dever ser maior que R$0.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Model.Produto produtoCadastro = new Model.Produto();

                // Salvar os valotes dos campos nos atributos do obj:
                produtoCadastro.Nome = txbNomeCadastro.Text;
                produtoCadastro.Preco = preco;

                string produtoSelecionado = cmbCategoriaCadastro.SelectedItem.ToString();
                string numero_categoria = produtoSelecionado.Split('-')[0].Trim();
                produtoCadastro.IdCategoria = int.Parse(numero_categoria);
                produtoCadastro.IdRespCadastro = usuario.Id;


                // Executar o INSERT:
                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Chave!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    AtualzarDgv();

                    // Apagar os campos de cadastro:
                    txbNomeCadastro.Clear();
                    txbPrecoProduto.Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o produto.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            double preco = double.Parse(txbPrecoEditar.Text);

            if (txbNomeEditar.Text.Length < 3)
            {
                MessageBox.Show("O nome do produto dever ter no minimo 3 caracteres.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (preco <= 0)
            {
                MessageBox.Show("O preço do produto dever ser maior que R$0.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Model.Produto produtoEditar = new Model.Produto();

                // Salvar os valotes dos campos nos atributos do obj:
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = preco;

                string produtoSelecionado = cmbCategoriaEditar.SelectedItem.ToString();
                string numero_categoria = produtoSelecionado.Split('-')[0].Trim();
                produtoEditar.IdCategoria = int.Parse(numero_categoria);
                produtoEditar.IdRespCadastro = usuario.Id;
                produtoEditar.Id = idSelecionado;

                // Executar o INSERT:
                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Produto Editado com sucesso!", "Chave!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    AtualzarDgv();

                    // Apagar os campos de cadastro:
                    txbNomeCadastro.Clear();
                    txbPrecoProduto.Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao editar o produto.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnApagarProduto_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que desja apagar este Produto?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Proseguir com o apagação
                Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = idSelecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Chave!!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetarCampos()
        {

            //atualizar o dgc
            AtualzarDgv();

            //limpar campos de ediçãp
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();
           

            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            // Retornar o texto padrão de "apagar":
            lblDescricaoApagar.Text = "Selecionar o produto que deseja apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            // Colocar os valores das celulas no txbs de edição:
            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID do quem foi selecionado:
            idSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes do grbApagar:
            lblDescricaoApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar
            grbApagar.Enabled = true;
        }
    }
}
