using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Janelerator : Form
    {
        int z = 1000;
        bool movimentoNeg = false;
        int velocidade = 100;

        public Janelerator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //INÍCIO - Verificação por intradução só numeros;
            double num = 0.0;

            if (double.TryParse(tamanhoX.Text, out num))
            {
                
            }
            else
            {
                tamanhoX.Text = "Só numeros!";
            }
            //FIM - Verificação por intradução só numeros;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INÍCIO - Verifica campos X e Y vazios;
            if (tamanhoX.Text == "" || tamanhoY.Text == "")
            {
                alertErro.Text = "Os campos X e Y não podem ficar vasios!";
            }
            //FIM - Verifica campos X e Y vazios;
            else
            {
                int x, y;
                x = Convert.ToInt16(tamanhoX.Text);
                y = Convert.ToInt16(tamanhoY.Text);
                alertErro.Text = "";
                if (tipoDeJanela.SelectedIndex == -1)
                {
                    alertErro.Text = "Escolhe um tipo de janela!";
                };
                if (x > 3000 || x < 100 || tamanhoX.Text == "")
                {
                    alertErro.Text = "Dimenção X fora de magem!";
                };
                if (y > 3000 || y < 100)
                {
                    alertErro.Text = "Dimenção Y fora de magem!";
                };

                if (x <= 3000 && y <= 3000 && x > 100 && y > 100)
                {
                    motorX.Value = x / 30;
                    motorY1.Value = y / 30;
                    checkBoxFuroDobradicaDireita.Checked = true;
                }
            };
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movimentoNeg = false;
            timer1.Enabled = true;
            motorX.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //INÍCIO - Verificação por intradução só numeros;
            double num = 0.0;

            if (double.TryParse(tamanhoY.Text, out num))
            {

            }
            else
            {
                tamanhoY.Text = "Só numeros!";
            }
            //FIM - Verificação por intradução só numeros;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (z >= 0 && movimentoNeg == false && checkBoxSensorHomeX.Checked == false) // movimento negativo rapido 
            {
                motorX.Value = z;
                textBox1.Text = z.ToString();
                z--;
            }
            if (z >= 0 && movimentoNeg == false && checkBoxSensorHomeX.Checked == true && velocidade != 0) // movimento negativo lento
            {
                int n = 50; // valor de intervalo
                timer1.Interval = n; 
                motorX.Value = z;
                textBox1.Text = z.ToString();
                z--;
                n++;
                velocidade--;

                if(velocidade == 0)
                {
                    movimentoNeg = true;
                }
            }
            if (z >= 0 && movimentoNeg == true && checkBoxSensorHomeX.Checked == true && velocidade == 0) //
            {
                timer1.Interval = 100;
                motorX.Value = z;
                textBox1.Text = z.ToString();
                z++;
            }
            if (z >= 0 && movimentoNeg == true && checkBoxSensorHomeX.Checked == false) //
            {
                timer1.Stop();
                z = 0;
            }
            /*           else
                        {
                            timer1.Stop();
                            z = 0;
                            movimentoNeg = true;
                        }
            */

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
