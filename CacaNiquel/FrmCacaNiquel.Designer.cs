namespace CacaNiquel
{
    partial class FrmCacaNiquel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblCacaNiquel1 = new Label();
            lblCacaNiquel2 = new Label();
            lblCacaNiquel3 = new Label();
            btlGirar = new Button();
            tmrSorteioGeral = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblCacaNiquel1
            // 
            lblCacaNiquel1.BackColor = Color.Gold;
            lblCacaNiquel1.BorderStyle = BorderStyle.FixedSingle;
            lblCacaNiquel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblCacaNiquel1.Location = new Point(35, 76);
            lblCacaNiquel1.Name = "lblCacaNiquel1";
            lblCacaNiquel1.Size = new Size(61, 64);
            lblCacaNiquel1.TabIndex = 0;
            lblCacaNiquel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCacaNiquel2
            // 
            lblCacaNiquel2.BackColor = Color.Lime;
            lblCacaNiquel2.BorderStyle = BorderStyle.FixedSingle;
            lblCacaNiquel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblCacaNiquel2.Location = new Point(147, 76);
            lblCacaNiquel2.Name = "lblCacaNiquel2";
            lblCacaNiquel2.Size = new Size(61, 63);
            lblCacaNiquel2.TabIndex = 1;
            lblCacaNiquel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCacaNiquel3
            // 
            lblCacaNiquel3.BackColor = Color.Pink;
            lblCacaNiquel3.BorderStyle = BorderStyle.FixedSingle;
            lblCacaNiquel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblCacaNiquel3.Location = new Point(252, 77);
            lblCacaNiquel3.Name = "lblCacaNiquel3";
            lblCacaNiquel3.Size = new Size(61, 63);
            lblCacaNiquel3.TabIndex = 2;
            lblCacaNiquel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btlGirar
            // 
            btlGirar.Location = new Point(126, 297);
            btlGirar.Name = "btlGirar";
            btlGirar.Size = new Size(98, 71);
            btlGirar.TabIndex = 3;
            btlGirar.Text = "&Girar";
            btlGirar.UseVisualStyleBackColor = true;
            btlGirar.Click += btlGirar_Click;
            // 
            // tmrSorteioGeral
            // 
            tmrSorteioGeral.Enabled = true;
            tmrSorteioGeral.Interval = 1000;
            tmrSorteioGeral.Tick += this.tmrSorteioGeral_Tick;
            // 
            // FrmCacaNiquel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 504);
            Controls.Add(btlGirar);
            Controls.Add(lblCacaNiquel3);
            Controls.Add(lblCacaNiquel2);
            Controls.Add(lblCacaNiquel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "FrmCacaNiquel";
            Text = "Caça Níquel";
            ResumeLayout(false);
        }

        #endregion

        private Label lblCacaNiquel1;
        private Label lblCacaNiquel2;
        private Label lblCacaNiquel3;
        private Button btlGirar;
        private System.Windows.Forms.Timer tmrSorteioGeral;
    }
}
