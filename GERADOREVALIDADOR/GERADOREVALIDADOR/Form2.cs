using System;
using System.Windows.Forms;

namespace GERADOREVALIDADOR
{
    public partial class Form2 : Form
    {
        private string cpfGerado;
        private string cnpjGerado;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GeradorCpf()
        {
            Random cpf = new Random();

            int n1 = cpf.Next(0, 10);
            int n2 = cpf.Next(0, 10);
            int n3 = cpf.Next(0, 10);
            int n4 = cpf.Next(0, 10);
            int n5 = cpf.Next(0, 10);
            int n6 = cpf.Next(0, 10);
            int n7 = cpf.Next(0, 10);
            int n8 = cpf.Next(0, 10);
            int n9 = cpf.Next(0, 10);
            int soma, soma1;
            int dig1, dig2;

            soma = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

            dig1 = soma % 11;

            if (dig1 < 2)
            {
                dig1 = 0;
            }
            else
            {
                dig1 = 11 - dig1;
            }

            soma1 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + dig1 * 2;

            dig2 = soma1 % 11;

            if (dig2 < 2)
            {
                dig2 = 0;
            }
            else
            {
                dig2 = 11 - dig2;
            }

            cpfGerado = $"{n1}{n2}{n3}.{n4}{n5}{n6}.{n7}{n8}{n9}-{dig1}{dig2}";
            TxtComandoGerado1.Text = cpfGerado;
        }
        private void GeradorCnpj()
        {
            Random cnpj = new Random();
            int n1 = cnpj.Next(0, 10);
            int n2 = cnpj.Next(0, 10);
            int n3 = cnpj.Next(0, 10);
            int n4 = cnpj.Next(0, 10);
            int n5 = cnpj.Next(0, 10);
            int n6 = cnpj.Next(0, 10);
            int n7 = cnpj.Next(0, 10);
            int n8 = cnpj.Next(0, 10);
            int n9 = 0;
            int n10 = 0;
            int n11 = 0;
            int n12 = 1;
            int soma, soma1;
            int dig1, dig2;

            soma = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

            dig1 = soma % 11;
            if (dig1 < 2)
            {
                dig1 = 0;
            }
            else
            {
                dig1 = 11 - dig1;
            }
            soma1 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + dig1 * 2;

            dig2 = soma1 % 11;
            if (dig2 < 2)
            {
                dig2 = 0;
            }
            else
            {
                dig2 = 11 - dig2;
            }
            cnpjGerado = $"{n1}{n2}.{n3}{n4}{n5}.{n6}{n7}{n8}/{n9}{n10}{n11}{n12}-{dig1}{dig2}";
            TxtComandoGerado1.Text = cnpjGerado;
        }




        private void RBNGerarCpf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtComandoGerado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (RBNGerarCpf.Checked)
            {
                GeradorCpf();
            }
            else if (RBNGerarCnpj.Checked)
            {
                GeradorCnpj();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma opção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}