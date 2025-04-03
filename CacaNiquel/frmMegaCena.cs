using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaNiquel
{
    public partial class frmMegaCena : Form
    {
        //inicio da Classe - Criação de objetos, variáveis, tipos que serão privados
        //a classes que serão visiveis à toda classe
        private Random Mega = new Random();
        private int numeroSorteado;
        private int[,] cartao;

        public frmMegaCena()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            //consistência de dados - Verificano a qtd de cartões
            if (String.IsNullOrEmpty(qtdeCartoes.Text))
            {
                MessageBox.Show("Informe a quantidade de cartôes desejadas: ", "Mega Sena.",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            cartao = new int[Convert.ToInt32(qtdeCartoes.Text),6 ];
            GerarCartoes();

        }
        private void GerarCartoes()
        {
            for (int i=0; i<Convert.ToInt32(qtdeCartoes);i++) 
            {
                for (int j = 0; j < 6; j++)
                {
                    numeroSorteado = Mega.Next(1, 61);
                    cartao[i, j] = numeroSorteado;
                    lblResultado.Text = numeroSorteado.ToString("00");
                    //lblResultado.Text = Convert.ToString(numeroSorteado) + " - ";
                }
                lstCartoes.Items.Add(lblResultado.Text);
                lblResultado.Text = "";
            }
        }
       
    }
}
