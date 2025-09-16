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

    public partial class FormCaixa : Form
    {
        Model.Usuario usuario;
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo esta vazio
            if (txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o numero da comanda!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();

                ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                // Tabela para receber o resultado da consulta SELECT
                DataTable resultado = ordemComanda.BuscarFichas();

                // Verificar se existem linhas em "Resultado":
                if (resultado.Rows.Count > 0)
                {
                    // Mostrar no dgv:
                    dgvComanda.DataSource = resultado;
                    // Calcular o total e mostrar o lblPreco:
                    lblPreco.Text = "R$" + resultado.Compute("Sum(Total_item)", "True").ToString();

                }
                else
                {
                    // Limpar o dgv:
                    dgvComanda.DataSource = null;
                    // Mostrar menesagem de erro:
                    MessageBox.Show("Não existem lançamentos nessa comanda!", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbPagamento.Checked;
        }


        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar essa comanda?",
                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Encerrrar a comanda:

                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);

                if (ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("Comanda encerrada!", "Show",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //exevutar update para encerrar a comanda:
                    txbComanda.Clear();
                    dgvComanda.DataSource = null;
                    chbPagamento.Checked = false;
                    btnEncerrar.Enabled = false;
                    lblPreco.Text = "R$   - ";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}