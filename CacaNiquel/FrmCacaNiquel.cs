namespace CacaNiquel
{
    public partial class FrmCacaNiquel : Form
    {
        private Random sorteio = new Random(); 
        private int niquel1, niquel2, niquel3;
        public FrmCacaNiquel()
        {
            InitializeComponent();
        }
        public void btlGirar_Click (object sender, EventArgs e)
        {
            MostraNiquel();
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
            MostraNiquel();
        }
    }
}
