using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace WindowsFormsApp1
{
    public partial class Janelerator : MetroForm
    {
        int z;
        bool movimentoNeg = false;
        int velocidade = 100;
        int n = 10; // valor de intervalo
        int caseSwitch = 1;
        int repeat = 1;
        
        void Repeat()
        {
            Random random = new Random();
            z = random.Next(500, 2700);
            movimentoNeg = false;
            timer1.Enabled = true;
        }
        void MoveToHome(MetroTrackBar metroTrackBar, MetroToggle metroToggle, TextBox textBox)
        {
            
            timer1.Interval = 1;
            if (z >= 0 && movimentoNeg == false && metroToggle.Checked == false) // movimento negativo rapido 
            {
                metroTrackBar.Value = z;
                textBox.Text = z.ToString();
                z--;
            }
            if (z >= 0 && movimentoNeg == false && metroToggle.Checked == true && velocidade != 0) // movimento negativo lento
            {
                timer1.Interval = n;
                metroTrackBar.Value = z;
                textBox.Text = z.ToString();
                z--;
                n++;
                velocidade--;
                if (velocidade == 0)
                {
                    movimentoNeg = true;
                }
            }
            if (z >= 0 && movimentoNeg == true && metroToggle.Checked == true && velocidade == 0) //
            {
                timer1.Interval = 100;
                metroTrackBar.Value = z;
                textBox.Text = z.ToString();
                z++;
                
            }
            if (z >= 0 && movimentoNeg == true && metroToggle.Checked == false) //
            {
                
                timer1.Stop();
                velocidade = 100;
                n = 10; // valor de intervalo
                caseSwitch++;
                Repeat();
            }

        }
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
                buttonStart.Enabled = true;
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
            if (tipoDeJanela.SelectedIndex > -1)
            {
                tamanhoX.Visible = true;
                tamanhoY.Visible = true;
                tamanhoXshadow.Visible = true;
                tamanhoYshadow.Visible = true;
            }
            if (tipoDeJanela.SelectedIndex == 0)
            {
                pictureBox3.Image = Image.FromFile("../img/arroCortizoDF.png");
            }
            if (tipoDeJanela.SelectedIndex == 1)
            {
                pictureBox3.Image = Image.FromFile("../img/arroCortizoME.png");
            }
            if (tipoDeJanela.SelectedIndex == 2)
            {
                pictureBox3.Image = Image.FromFile("../img/arroCortizoMD.png");
            }
            if (tipoDeJanela.SelectedIndex == 3)
            {
                pictureBox3.Image = Image.FromFile("../img/folhaCortizo.png");
            }
            if (tipoDeJanela.SelectedIndex == 4)
            {
                pictureBox3.Image = Image.FromFile("../img/arroDobroplasDF.png");
            }
            if (tipoDeJanela.SelectedIndex == 5)
            {
                pictureBox3.Image = Image.FromFile("../img/arroDobroplasME.png");
            }
            if (tipoDeJanela.SelectedIndex == 6)
            {
                pictureBox3.Image = Image.FromFile("../img/arroDobroplasMD.png");
            }
            if (tipoDeJanela.SelectedIndex == 7)
            {
                pictureBox3.Image = Image.FromFile("../img/folhaDobroplas.png");
            }
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
                    TrackBarMotorX.Value = x;
                    TrackBarMotorY.Value = y;
                    metroToggle2.Checked = true;
                }
            };
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repeat();
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
                buttonStart.Enabled = true;
            }
            //FIM - Verificação por intradução só numeros;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroTextBox1.Text = Convert.ToString(caseSwitch);
            metroTextBox2.Text = z.ToString();
            metroTextBox3.Text = movimentoNeg.ToString();
            metroTextBox4.Text = velocidade.ToString();
            metroTextBox5.Text = n.ToString();
            //--->>> MotorX <<<---//
            switch (caseSwitch)
            {
                case 1:
                    MoveToHome(TrackBarMotorMontagemE, sensorMotorMontagemE, textBoxMotorMontagemE);
                    break;
                case 2:
                    MoveToHome(TrackBarMotorAgua, sensorMotorAgua, textBoxMotorAgua);
                    break;
                case 3:
                    MoveToHome(TrackBarMotorManeteZ, sensorMotorManeteZ, textBoxMotorManeteZ);
                    break;
                case 4:
                    MoveToHome(TrackBarMotorManeteX, sensorMotorManeteX, textBoxMotorManeteX);
                    break;
                case 5:
                    MoveToHome(TrackBarMontagemD, sensorMontagemD, textBoxMontagemD);
                    break;
                case 6:
                    MoveToHome(TrackBarMotorX, sensorMotorX, textBoxMotorX);
                    break;
                case 7:
                    MoveToHome(TrackBarMotorY, sensorMotorY, textBoxMotorY);
                    break;
                case 8:
                    MoveToHome(TrackBarMotorY2, sensorMotorY2, textBoxMotorY2);
                    break;
            }
                     
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Janelerator_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxFuroDobradicaEsquerda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSensorHomeX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMotorX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
