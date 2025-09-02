namespace OnlyPaes
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.txbEmailCadastro = new System.Windows.Forms.TextBox();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(49, 13);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(532, 280);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txbSenhaCadastro);
            this.grbCadastro.Controls.Add(this.txbEmailCadastro);
            this.grbCadastro.Controls.Add(this.txbNomeCadastro);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenhaCadastro);
            this.grbCadastro.Controls.Add(this.lblEmailCadastro);
            this.grbCadastro.Controls.Add(this.lblNomeCadastro);
            this.grbCadastro.Location = new System.Drawing.Point(49, 318);
            this.grbCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastro.Size = new System.Drawing.Size(349, 206);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblNomeCadastro.Location = new System.Drawing.Point(5, 24);
            this.lblNomeCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(114, 16);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome Completo:";
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblEmailCadastro.Location = new System.Drawing.Point(70, 56);
            this.lblEmailCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(47, 16);
            this.lblEmailCadastro.TabIndex = 1;
            this.lblEmailCadastro.Text = "Email:";
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblSenhaCadastro.Location = new System.Drawing.Point(68, 88);
            this.lblSenhaCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(49, 16);
            this.lblSenhaCadastro.TabIndex = 2;
            this.lblSenhaCadastro.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(41, 127);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(267, 60);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(122, 20);
            this.txbNomeCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(163, 22);
            this.txbNomeCadastro.TabIndex = 4;
            // 
            // txbEmailCadastro
            // 
            this.txbEmailCadastro.Location = new System.Drawing.Point(122, 56);
            this.txbEmailCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmailCadastro.Name = "txbEmailCadastro";
            this.txbEmailCadastro.Size = new System.Drawing.Size(163, 22);
            this.txbEmailCadastro.TabIndex = 5;
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(122, 88);
            this.txbSenhaCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(163, 22);
            this.txbSenhaCadastro.TabIndex = 6;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txbSenhaEditar);
            this.grbEditar.Controls.Add(this.txbEmailEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(523, 318);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEditar.Size = new System.Drawing.Size(349, 206);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.Location = new System.Drawing.Point(122, 88);
            this.txbSenhaEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(163, 22);
            this.txbSenhaEditar.TabIndex = 6;
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.Location = new System.Drawing.Point(122, 56);
            this.txbEmailEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(164, 22);
            this.txbEmailEditar.TabIndex = 5;
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(122, 20);
            this.txbNomeEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(163, 22);
            this.txbNomeEditar.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.btnEditar.Location = new System.Drawing.Point(41, 127);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(267, 60);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblSenhaEditar.Location = new System.Drawing.Point(29, 88);
            this.lblSenhaEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(87, 16);
            this.lblSenhaEditar.TabIndex = 2;
            this.lblSenhaEditar.Text = "Nova Senha:";
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblEmailEditar.Location = new System.Drawing.Point(69, 62);
            this.lblEmailEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(47, 16);
            this.lblEmailEditar.TabIndex = 1;
            this.lblEmailEditar.Text = "Email:";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblNomeEditar.Location = new System.Drawing.Point(2, 24);
            this.lblNomeEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(114, 16);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(49, 531);
            this.grbApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbApagar.Size = new System.Drawing.Size(822, 74);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(22, 34);
            this.lblApagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(300, 23);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione um usuario para apagar:";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(583, 18);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(214, 47);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // ptbFoto
            // 
            this.ptbFoto.BackColor = System.Drawing.Color.Transparent;
            this.ptbFoto.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__21_52_05;
            this.ptbFoto.Location = new System.Drawing.Point(602, 72);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(285, 208);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 4;
            this.ptbFoto.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(588, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 30);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gerenciador de usuarios";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(899, 626);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ptbFoto);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.TextBox txbEmailCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Label lblTitulo;
    }
}