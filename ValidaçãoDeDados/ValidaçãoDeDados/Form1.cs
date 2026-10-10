using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidaçãoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { 
               e.Handled = true; //Verifica as teclas precionadas
                MessageBox.Show("SÓ PERMITE LETRAS", "AVISO!!");
            }

            if (e.KeyChar==13) //A tecla enter 13 foi precionada
            {
                if (txt_Nome.Text != "") //Verifica se o Text esta vazio
                {
                    txt_Idade.Focus(); //Passa e vai para o proximo campo TXT idade
                }

                else

                { 
                   MessageBox.Show("O NOME NÃO FOI DIGITADO...", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //OBS: Deixar eles fazerem o Cpf
                }
            }
        }

        private void txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Só Permite Números", "AVISO!!");
            }

            if (e.KeyChar == 13)
            {
                if (txt_Idade.Text != "")
                {
                    txt_Cpf.Focus();
                }

                else

                {
                    MessageBox.Show("A Idade Não foi Digitada...", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
                MessageBox.Show("Só Permite Números", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar == 13)
            {
                if (txt_Cpf.Text.Trim() == "")
                {
                    MessageBox.Show("O CPF Não Foi Digitado...", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nome.Text) && string.IsNullOrWhiteSpace(txt_Idade.Text) && string.IsNullOrWhiteSpace(txt_Cpf.Text)) // verifica se todas as areas estão vazias
            {
                MessageBox.Show("Nenhuma informação Digitada", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txt_Nome.Clear();
            txt_Idade.Clear();
            txt_Cpf.Clear();
            MessageBox.Show("Dados Enviados Com Sucesso!!", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
