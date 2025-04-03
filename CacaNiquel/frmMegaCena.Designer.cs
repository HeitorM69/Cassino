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
            qtdeCartoes = new NumericUpDown();
            lstCartoes = new ListBox();
            ((System.ComponentModel.ISupportInitialize)qtdeCartoes).BeginInit();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(23, 100);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(315, 58);
            lblResultado.TabIndex = 0;
            // 
            // btnSorteio
            // 
            btnSorteio.Location = new Point(131, 373);
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
            // qtdeCartoes
            // 
            qtdeCartoes.Location = new Point(131, 21);
            qtdeCartoes.Name = "qtdeCartoes";
            qtdeCartoes.Size = new Size(120, 23);
            qtdeCartoes.TabIndex = 3;
            // 
            // lstCartoes
            // 
            lstCartoes.FormattingEnabled = true;
            lstCartoes.ItemHeight = 15;
            lstCartoes.Location = new Point(23, 186);
            lstCartoes.Name = "lstCartoes";
            lstCartoes.Size = new Size(315, 169);
            lstCartoes.TabIndex = 4;
            // 
            // frmMegaCena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 493);
            Controls.Add(lstCartoes);
            Controls.Add(qtdeCartoes);
            Controls.Add(lblCartoes);
            Controls.Add(btnSorteio);
            Controls.Add(lblResultado);
            Name = "frmMegaCena";
            Text = "frmMegaCena";
            ((System.ComponentModel.ISupportInitialize)qtdeCartoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnSorteio;
        private Label lblCartoes;
        private NumericUpDown qtdeCartoes;
        private ListBox lstCartoes;
    }
}