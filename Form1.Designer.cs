namespace Gerenciando_SQL_Server_Compact_4
{
    partial class Form1
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
            this.btnCriarBD = new System.Windows.Forms.Button();
            this.btnCriarTabelas = new System.Windows.Forms.Button();
            this.btnCarregarTabela = new System.Windows.Forms.Button();
            this.btnCarregarGrid = new System.Windows.Forms.Button();
            this.btnLerRegistros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarBD
            // 
            this.btnCriarBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarBD.Location = new System.Drawing.Point(277, 29);
            this.btnCriarBD.Name = "btnCriarBD";
            this.btnCriarBD.Size = new System.Drawing.Size(165, 34);
            this.btnCriarBD.TabIndex = 0;
            this.btnCriarBD.Text = "Criar Banco de Dados";
            this.btnCriarBD.UseVisualStyleBackColor = true;
            this.btnCriarBD.Click += new System.EventHandler(this.btnCriarBD_Click);
            // 
            // btnCriarTabelas
            // 
            this.btnCriarTabelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTabelas.Location = new System.Drawing.Point(277, 69);
            this.btnCriarTabelas.Name = "btnCriarTabelas";
            this.btnCriarTabelas.Size = new System.Drawing.Size(165, 35);
            this.btnCriarTabelas.TabIndex = 0;
            this.btnCriarTabelas.Text = "Criar Tabelas";
            this.btnCriarTabelas.UseVisualStyleBackColor = true;
            this.btnCriarTabelas.Click += new System.EventHandler(this.btnCriarTabelas_Click);
            // 
            // btnCarregarTabela
            // 
            this.btnCarregarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarTabela.Location = new System.Drawing.Point(277, 110);
            this.btnCarregarTabela.Name = "btnCarregarTabela";
            this.btnCarregarTabela.Size = new System.Drawing.Size(165, 37);
            this.btnCarregarTabela.TabIndex = 0;
            this.btnCarregarTabela.Text = "Carregar Tabela";
            this.btnCarregarTabela.UseVisualStyleBackColor = true;
            this.btnCarregarTabela.Click += new System.EventHandler(this.btnCarregarTabela_Click);
            // 
            // btnCarregarGrid
            // 
            this.btnCarregarGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarGrid.Location = new System.Drawing.Point(277, 153);
            this.btnCarregarGrid.Name = "btnCarregarGrid";
            this.btnCarregarGrid.Size = new System.Drawing.Size(165, 39);
            this.btnCarregarGrid.TabIndex = 0;
            this.btnCarregarGrid.Text = "Carregar Grid";
            this.btnCarregarGrid.UseVisualStyleBackColor = true;
            this.btnCarregarGrid.Click += new System.EventHandler(this.btnCarregarGrid_Click);
            // 
            // btnLerRegistros
            // 
            this.btnLerRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerRegistros.Location = new System.Drawing.Point(277, 198);
            this.btnLerRegistros.Name = "btnLerRegistros";
            this.btnLerRegistros.Size = new System.Drawing.Size(165, 35);
            this.btnLerRegistros.TabIndex = 0;
            this.btnLerRegistros.Text = "Ler Registros";
            this.btnLerRegistros.UseVisualStyleBackColor = true;
            this.btnLerRegistros.Click += new System.EventHandler(this.btnLerRegistros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultado";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(16, 250);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(426, 150);
            this.dgvDados.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(16, 35);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(246, 198);
            this.lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 412);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLerRegistros);
            this.Controls.Add(this.btnCarregarGrid);
            this.Controls.Add(this.btnCarregarTabela);
            this.Controls.Add(this.btnCriarTabelas);
            this.Controls.Add(this.btnCriarBD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Compact  - Criando e acessando Banco de dados, Tabelas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarBD;
        private System.Windows.Forms.Button btnCriarTabelas;
        private System.Windows.Forms.Button btnCarregarTabela;
        private System.Windows.Forms.Button btnCarregarGrid;
        private System.Windows.Forms.Button btnLerRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblResultado;
    }
}

