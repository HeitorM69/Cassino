namespace CacaNiquel
{
    partial class frmMegaCena
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
            lblResultado = new Label();
            btnSorteio = new Button();
            lblCartoes = new Label();
            numCartao = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCartao).BeginInit();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(90, 100);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(248, 53);
            lblResultado.TabIndex = 0;
            // 
            // btnSorteio
            // 
            btnSorteio.Location = new Point(167, 365);
            btnSorteio.Name = "btnSorteio";
            btnSorteio.Size = new Size(95, 57);
            btnSorteio.TabIndex = 1;
            btnSorteio.Text = "Sortear numeros";
            btnSorteio.UseVisualStyleBackColor = true;
            btnSorteio.Click += btnSorteio_Click;
            // 
            // lblCartoes
            // 
            lblCartoes.AutoSize = true;
            lblCartoes.BorderStyle = BorderStyle.FixedSingle;
            lblCartoes.Location = new Point(23, 23);
            lblCartoes.Name = "lblCartoes";
            lblCartoes.Size = new Size(86, 17);
            lblCartoes.TabIndex = 2;
            lblCartoes.Text = "Qtd de cartões";
            // 
            // numCartao
            // 
            numCartao.Location = new Point(131, 21);
            numCartao.Name = "numCartao";
            numCartao.Size = new Size(120, 23);
            numCartao.TabIndex = 3;
            // 
            // frmMegaCena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 493);
            Controls.Add(numCartao);
            Controls.Add(lblCartoes);
            Controls.Add(btnSorteio);
            Controls.Add(lblResultado);
            Name = "frmMegaCena";
            Text = "frmMegaCena";
            ((System.ComponentModel.ISupportInitialize)numCartao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnSorteio;
        private Label lblCartoes;
        private NumericUpDown numCartao;
    }
}