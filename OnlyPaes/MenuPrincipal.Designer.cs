namespace OnlyPaes
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblOla = new System.Windows.Forms.Label();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnComandas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenu.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Peru;
            this.lblMenu.Location = new System.Drawing.Point(139, 9);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(326, 31);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Principal ☻ OnlyPaes";
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnCaixa.Location = new System.Drawing.Point(70, 281);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(519, 50);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnUsuario.Location = new System.Drawing.Point(70, 225);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(519, 50);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.BackColor = System.Drawing.Color.Transparent;
            this.lblOla.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOla.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblOla.Location = new System.Drawing.Point(78, 73);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(490, 23);
            this.lblOla.TabIndex = 5;
            this.lblOla.Text = "Olá Administrador da silva!! Escolha uma opção abaixo:";
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnProdutos.Location = new System.Drawing.Point(70, 169);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(519, 50);
            this.btnProdutos.TabIndex = 6;
            this.btnProdutos.Text = "produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            // 
            // btnComandas
            // 
            this.btnComandas.BackColor = System.Drawing.Color.Transparent;
            this.btnComandas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComandas.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnComandas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComandas.Location = new System.Drawing.Point(70, 113);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(519, 50);
            this.btnComandas.TabIndex = 7;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = false;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImage = global::OnlyPaes.Properties.Resources.ChatGPT_Image_28_de_ago__de_2025__19_35_48;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(656, 440);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.lblMenu);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnComandas;
    }
}