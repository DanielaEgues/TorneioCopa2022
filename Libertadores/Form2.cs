using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libertadores
{
    public partial class Form2 : Form
    {   
        int verificarMaior2(int num5, int num6)
        {
            if (num5> num6)
            {
                return num5;

            }
            else
            {
                return num6;
            }
        }
        int verificarMaior1 (int num3, int num4)
        {
            if (num3 > num4)
            {
                return num3;
            }
            else
            {
                return num4;
            }
                
        }
       int verificarMaior (int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public Form2(string nome)

        {
            InitializeComponent();
            labelTime1.Text = nome;

           

       
        }

   

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a aplicação?",
                                "FECHAR",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void buttonVencedor_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("Time Vencedor da Copa Libertadores é o " + comboBoxVencedor.Text + "!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Time1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void bntResultado_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            txtMaior.Text = verificarMaior(a, b).ToString();


        }

        private void bntResultado1_Click(object sender, EventArgs e)
        {
            int c, d;
            c = Convert.ToInt32(txtC.Text);
            d = Convert.ToInt32(txtD.Text);

            txtMaior1.Text = verificarMaior1(c, d).ToString();
        }

        private void bntResultado2_Click(object sender, EventArgs e)
        {
            int j, f;
            j = Convert.ToInt32(txtJ.Text);
            f = Convert.ToInt32(txtF.Text);
            txtMaior2.Text = verificarMaior2(j, f).ToString();
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtMaior1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtMaior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtMaior2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
    }
    
