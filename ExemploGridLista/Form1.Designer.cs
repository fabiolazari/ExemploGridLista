
namespace ExemploGridLista
{
    partial class FrmPopula
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvContrato = new System.Windows.Forms.DataGridView();
            this.btnPopula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvContrato
            // 
            this.DgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContrato.Location = new System.Drawing.Point(12, 12);
            this.DgvContrato.Name = "DgvContrato";
            this.DgvContrato.Size = new System.Drawing.Size(1204, 215);
            this.DgvContrato.TabIndex = 0;
            // 
            // btnPopula
            // 
            this.btnPopula.Location = new System.Drawing.Point(12, 233);
            this.btnPopula.Name = "btnPopula";
            this.btnPopula.Size = new System.Drawing.Size(75, 23);
            this.btnPopula.TabIndex = 1;
            this.btnPopula.Text = "&Popula";
            this.btnPopula.UseVisualStyleBackColor = true;
            this.btnPopula.Click += new System.EventHandler(this.btnPopula_Click);
            // 
            // FrmPopula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 301);
            this.Controls.Add(this.btnPopula);
            this.Controls.Add(this.DgvContrato);
            this.Name = "FrmPopula";
            this.Text = "Popula Grid com lista";
            ((System.ComponentModel.ISupportInitialize)(this.DgvContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvContrato;
        private System.Windows.Forms.Button btnPopula;
    }
}

