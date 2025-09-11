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
    public partial class FormComandas : Form
    {
        Model.Usuario usuario;
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.Listar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            // Colocar o Id do produto no campo de codigo
            txbCodProdutoInfo.Text = dgvProdutos.Rows[ls].Cells[0].Value.ToString();
            // Colocar o nome do produto no campo de informações
            txbProduto.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estao vazios:
            if (txbComandaInfo.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCodProdutoInfo.Text.Length == 0)
            {
                MessageBox.Show("informe o codigo do produto!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Desativar o grbInfos:
                grbInfo.Enabled = false;
                // Ativar o grbLançamento
                grbLancamento.Enabled = true;

            }

        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estao vazios:
            if (txbComandaInfo.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComandaInfo.Text);
                ordemComanda.IdProduto = int.Parse(txbCodProdutoInfo.Text);
                ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                ordemComanda.IdResp = usuario.Id;

                if (ordemComanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao efetuar o lançamento!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetarCampos()
        {
            txbCodProdutoInfo.Clear();
            txbQuantidade.Clear();
            txbProduto.Clear();
            txbComandaInfo.Clear();
            //Resetar os groupBox:
            grbLancamento.Enabled = false;
            grbInfo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
    
