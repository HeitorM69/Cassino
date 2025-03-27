namespace CacaNiquel
{
    public partial class FrmCacaNiquel : Form
    {
        private int contaNiquel = 1;
        private int contaGiro = 0;
        private Random sorteio = new Random(); 
        private int niquel1, niquel2, niquel3;
        public FrmCacaNiquel()
        {
            InitializeComponent();
        }
        public void btlGirar_Click (object sender, EventArgs e)
        {
            MostraNiquel();
            if ((niquel1 == niquel2) && (niquel3 == niquel2) )
                MessageBox.Show("Parabéns você ganhou no Tigrinho!!! \n\n" +
                        "sequencia: " + niquel1.ToString() + " - " +
                                       niquel2.ToString() + " - " +
                                       niquel3.ToString(),
                             "Tigrinho wins !!!",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if ((niquel1 == niquel2) || (niquel2 == niquel3) || (niquel1 == niquel3))
            {
                MessageBox.Show("Parabéns você acaba de ganhar meio milhão!!!!");
            }
            else
            {
                MessageBox.Show("Você acaba de perder tudo!!!!");
            }

        }
        private void MostraNiquel()
        {
            niquel1 = sorteio.Next(10);
            niquel2 = sorteio.Next(10);
            niquel3 = sorteio.Next(10);
            lblCacaNiquel1.Text = niquel1.ToString();
            lblCacaNiquel2.Text = niquel2.ToString();
            lblCacaNiquel3.Text = niquel3.ToString();

        }
        private void tmrSorteioGeral_Tick(object sender, EventArgs e)
        {
            //MostraNiquel();
        }
        private void tmrNiquel_Tick(object sender, EventArgs e)
        {
             
            
            if (contaNiquel == 1)
            {
                niquel1 = sorteio.Next(10);
                lblCacaNiquel1.Text = niquel1.ToString();
            }
            else if (contaNiquel == 2)
            {
                niquel2 = sorteio.Next(10);
                lblCacaNiquel2.Text= niquel2.ToString();
            }
            else if(contaNiquel == 3)
            {
                niquel3 = sorteio.Next(10);
                lblCacaNiquel3.Text= niquel3.ToString();
            }
            else
            {
                tmrNiquel.Enabled = false;
                if(niquel1 == niquel2 && niquel3 == niquel2 && niquel1 == niquel3)
                    MessageBox.Show("Parabéns você ganhou no Tigrinho!!! \n\n"+ 
                            "sequencia: "+ niquel1.ToString() + " - "+
                                           niquel2.ToString() + " - "+
                                           niquel3.ToString(),
                                 "Tigrinho wins !!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (niquel1 == niquel2 || niquel2 == niquel3 || niquel1 == niquel3)
                {
                    MessageBox.Show("Parabéns você acaba de ganhar meio milhão!!!!");
                }
                else
                {
                    MessageBox.Show("Você acaba de perder tudo!!!!");
                }
                lblCacaNiquel1.Text = String.Empty;
                lblCacaNiquel2.Text = String.Empty;
                lblCacaNiquel3.Text = String.Empty;
                btnJogar.Text = "&Jogar";
                contaNiquel = 1;
                lstNiquel.Items.Add(niquel1 + "-" + niquel2 + "-" + niquel3);

            }
            if (contaGiro == 10) 
            {
                contaNiquel++;
                contaGiro = 0;
            }
            contaGiro++;

        }
        public void btnJogar_Click(object sender, EventArgs e)
        {
            
            btnJogar.Text = "&STOP";
            tmrNiquel.Enabled = true;

        }
    }
}
