namespace OnlyPaes
{
    partial class FormCaixa
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 22F);
            this.lblTitulo.Location = new System.Drawing.Point(155, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "N° Comanda:";
            // 
            // dgvComanda
            // 
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Location = new System.Drawing.Point(11, 68);
            this.dgvComanda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.Size = new System.Drawing.Size(917, 187);
            this.dgvComanda.TabIndex = 2;
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(396, 15);
            this.txbComanda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(154, 26);
            this.txbComanda.TabIndex = 3;
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Mongolian Baiti", 22F);
            this.btnListar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnListar.Location = new System.Drawing.Point(630, 15);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(181, 37);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(63, 368);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(84, 30);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "R$   -";
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Location = new System.Drawing.Point(68, 265);
            this.chbPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(160, 20);
            this.chbPagamento.TabIndex = 6;
            this.chbPagamento.Text = "Pagamento Recebido";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Mongolian Baiti", 20F);
            this.btnEncerrar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEncerrar.Location = new System.Drawing.Point(68, 302);
            this.btnEncerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(265, 51);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Mongolian Baiti", 22F);
            this.lblCaixa.Location = new System.Drawing.Point(669, 322);
            this.lblCaixa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(83, 31);
            this.lblCaixa.TabIndex = 8;
            this.lblCaixa.Text = "Caixa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlyPaes.Properties.Resources.Iconsmind_Outline_Cash_register_2_512;
            this.pictureBox1.Location = new System.Drawing.Point(756, 289);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__20_30_36;
            this.pictureBox2.Location = new System.Drawing.Point(424, 289);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(939, 407);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCaixa";
            this.Text = "FormCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}