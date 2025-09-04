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
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
                cmbCategoriaCadastro.Items.Add($"{dr["dr"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["dr"]} - {dr["nome"]}");
            }


        }
    }
}
