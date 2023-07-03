using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GERADOREVALIDADOR
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.FormClosed += Form2_FormClosed; // o
            form2.Show();
            Hide(); 
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtComandoGerado.Text == "" || RBNCpf.Text == "" || RBNCnpj.Text == "")
            {
                MessageBox.Show("Por favor, escolha uma das duas opções!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (RBNCpf.Checked)
            {
                string cpf = TxtComandoGerado.Text.Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)
                {
                    MessageBox.Show("O CPF deve conter 11 dígitos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!ValidateInputCPF(cpf))
                {
                    MessageBox.Show("O CPF deve conter apenas números.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidarCPF(cpf))
                {
                    MessageBox.Show("CPF VÁLIDO!", "CORRETO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RBNCnpj.Checked)
            {
                string cnpj = TxtComandoGerado.Text.Replace(".", "").Replace("-", "").Replace("/", "");



                if (cnpj.Length != 14)
                {
                    MessageBox.Show("O CNPJ deve conter 14 dígitos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!ValidateCNPJInput(cnpj))
                {
                    MessageBox.Show("O CNPJ deve conter apenas números.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidarCNPJ(cnpj))
                {
                    MessageBox.Show("CNPJ VÁLIDO!", "CORRETO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CNPJ INVÁLIDO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void TxtComandoGerado_TextChanged(object sender, EventArgs e)
        {

        }

        private void gERADORToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gERADORToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 Gerador = new Form2();
            Gerador.ShowDialog();
        }
        private bool ValidarCPF(string cpf)
        {



            int[] mult = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult1 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int dig1 = 0;
            int dig2 = 0;
            int[] x = new int[11];
            int soma = 0, soma1 = 0;






            for (int i = 0; i < 11; i++)
            {
                x[i] = int.Parse(cpf[i].ToString());
            }





            for (int i = 0; i < 9; i++)
            {
                soma += x[i] * mult[i];
                dig1 = (soma * 10) % 11;
                if (dig1 == 10 || dig1 == 11)
                {
                    dig1 = 0;
                }
            }





            for (int i = 0; i < 10; i++)
            {
                soma1 += x[i] * mult1[i];
                dig2 = (soma1 * 10) % 11;
                if (dig2 == 10 || dig2 == 11)
                {
                    dig2 = 0;
                }
            }
            if (dig1 == x[9] && dig2 == x[10])
                return true;



            else return false;
        }
        private bool ValidarCNPJ(string cnpj)
        {
            if (!ValidateCNPJInput(cnpj))
            {
                MessageBox.Show("O CNPJ deve conter apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int[] mult1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma1 = 0, soma2 = 0;

            for (int i = 0; i < 12; i++)
            {
                soma1 += int.Parse(cnpj[i].ToString()) * mult1[i];
            }

            int digito1 = (soma1 % 11) < 2 ? 0 : 11 - (soma1 % 11);

            for (int i = 0; i < 13; i++)
            {
                soma2 += int.Parse(cnpj[i].ToString()) * mult2[i];
            }

            int digito2 = (soma2 % 11) < 2 ? 0 : 11 - (soma2 % 11);

            if (int.Parse(cnpj[12].ToString()) == digito1 && int.Parse(cnpj[13].ToString()) == digito2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidateInputCPF(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidateCNPJInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void RBNCpf_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
