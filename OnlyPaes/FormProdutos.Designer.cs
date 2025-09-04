namespace OnlyPaes
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblDescricaoApagar = new System.Windows.Forms.Label();
            this.btnApagarProduto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(42, 6);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(535, 277);
            this.dgvProdutos.TabIndex = 0;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.lblCategoria);
            this.grbCadastrar.Controls.Add(this.txbPreco);
            this.grbCadastrar.Controls.Add(this.lblPreco);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastro);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(32, 291);
            this.grbCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastrar.Size = new System.Drawing.Size(300, 207);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(29, 26);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(49, 16);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(100, 17);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(166, 25);
            this.txbNomeCadastro.TabIndex = 1;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(100, 56);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(166, 25);
            this.txbPreco.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(32, 65);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 16);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(7, 97);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(71, 16);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(100, 91);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(166, 24);
            this.cmbCategoriaCadastro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(35, 141);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(231, 53);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.button1);
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(551, 291);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(4);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(4);
            this.grbEditar.Size = new System.Drawing.Size(300, 207);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(32, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(100, 91);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(166, 24);
            this.cmbCategoriaEditar.TabIndex = 5;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(7, 97);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(71, 16);
            this.lblCategoriaEditar.TabIndex = 4;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(100, 56);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(166, 25);
            this.txbPrecoEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(32, 65);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(46, 16);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(100, 17);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(166, 25);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(29, 26);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(49, 16);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagarProduto);
            this.grbApagar.Controls.Add(this.lblDescricaoApagar);
            this.grbApagar.Location = new System.Drawing.Point(32, 514);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(782, 100);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblDescricaoApagar
            // 
            this.lblDescricaoApagar.AutoSize = true;
            this.lblDescricaoApagar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoApagar.Location = new System.Drawing.Point(28, 36);
            this.lblDescricaoApagar.Name = "lblDescricaoApagar";
            this.lblDescricaoApagar.Size = new System.Drawing.Size(302, 20);
            this.lblDescricaoApagar.TabIndex = 0;
            this.lblDescricaoApagar.Text = "Selecione o produto que deseja apagar";
            // 
            // btnApagarProduto
            // 
            this.btnApagarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarProduto.ForeColor = System.Drawing.Color.Red;
            this.btnApagarProduto.Location = new System.Drawing.Point(558, 29);
            this.btnApagarProduto.Name = "btnApagarProduto";
            this.btnApagarProduto.Size = new System.Drawing.Size(161, 36);
            this.btnApagarProduto.TabIndex = 1;
            this.btnApagarProduto.Text = "Apagar";
            this.btnApagarProduto.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__21_52_05;
            this.pictureBox1.Location = new System.Drawing.Point(631, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 22F);
            this.lblTitulo.Location = new System.Drawing.Point(584, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 31);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Gerenciador de Produtos";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(899, 626);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagarProduto;
        private System.Windows.Forms.Label lblDescricaoApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
    }
}