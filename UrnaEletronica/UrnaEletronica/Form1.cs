using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    

    public partial class Form1 : Form
    {
        int segundo = 15; // Tempo de duração das eleições.
        Button botaoClicado;
        int votos_bolsonaro = 0, votos_dilma = 0, votos_lula = 0;
        int votos_satan = 0, votos_boss = 0, votos_nemesis = 0;

        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Botões numéricos.
        private void button1_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = botaoClicado.Text;
        }
        
        private void Numero2_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero3_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero4_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero5_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero6_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero7_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero8_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero9_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }

        private void Numero0_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            texto1.Text = texto1.Text + botaoClicado.Text;
        }
          // Botões : Confirmar, Corrigir e Branco.
        private void confirmar_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            if (texto1.Text == "13")
            {
                String partido = "P T";
                pictureBox1.Image = Properties.Resources.dilma;
                votos_dilma += 1;
                texto1.Clear();
                label11.Text = "Dilma";
                label12.Text = partido;
            }
            else if (texto1.Text == "12")
            {
                String partido = "PMDB";
                pictureBox1.Image = Properties.Resources.bolsonaro;
                votos_bolsonaro += 1;
                label11.Text = "Bolsonaro";
                label12.Text = partido;
                texto1.Clear();
            }
            else if (texto1.Text == "14")
            {
                String partido = "P T";
                pictureBox1.Image = Properties.Resources.lula;
                votos_lula += 1;
                texto1.Clear();
                label11.Text = "Lula";
                label12.Text = partido;
            }
            else if (texto1.Text == "15")
            {
                String partido = "DBZ";
                pictureBox1.Image = Properties.Resources.mrsatan;
                votos_satan += 1;
                texto1.Clear();
                label11.Text = "Mr. Satan";
                label12.Text = partido;
            }
            else if (texto1.Text == "16")
            {
                String partido = "Diamond Dogs";
                pictureBox1.Image = Properties.Resources.bigboss;
                votos_boss += 1;
                texto1.Clear();
                label11.Text = "Big Boss";
                label12.Text = partido;
            }
            else if (texto1.Text == "17")
            {
                String partido = "Umbrella";
                pictureBox1.Image = Properties.Resources.nemesis;
                votos_nemesis += 1;
                texto1.Clear();
                label11.Text = "Nemesis";
                label12.Text = partido;
            }
            else
            {
                MessageBox.Show("Você optou por votar nulo." + "\n" + "Digitando um número que não está concorrendo nas eleições.");
                texto1.Clear();
            }
        }
        private void branco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por participar das eleições" + "\n" + "Seu voto foi contabilizado como voto em branco." + "\n" + "Não somando com os demais.");
            texto1.Clear();
        }
        private void corrigir_Click(object sender, EventArgs e)
        {
            texto1.Clear();

        }

        // Lista de candidatos.
        private void candidatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Os candidatos são:"+ "\n" +"Bolsonaro Nº12" + "\n " + "Dilma Nº 13" + "\n " + "Lula Nº 14" + "\n" + "Mr.Satan Nº 15" + "\n" + "Big Boss Nº 16" + "\n" + "Nemesis Nº 17");
        }
        // Tempo de votação.
        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo1.Text = "As eleições se ecerrarão em " + segundo.ToString() + " Segundos.";
            segundo--;
            
            if(segundo == 0)
            {
                tempo1.Text = "As eleições estão encerradas.";
                confirmar.Enabled = false; //Desabilita o botão Confirmar.
                corrigir.Enabled = false; //Desabilita o botão Corrigir.
                branco.Enabled = false; //Desabilita o botão Branco.
                timer1.Stop();
                MessageBox.Show("As eleições estão encerradas. Confira o resultado da votação:");
                pictureBox1.Image = Properties.Resources.interrogacao;
                label11.Text = "";
                label12.Text = "";
                MessageBox.Show("O resultado das eleições: \n" + "Nemesis" + " "+ votos_nemesis + "\n" + "Big Boss" + " " + votos_boss + "\n" + "Mr. Satan" + " " + votos_satan + "\n" + "Lula" + " " + votos_lula + "\n" + "Dilma" + " "+ votos_dilma + "\n" + "Bolsonaro" + " " + votos_bolsonaro );
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void texto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cont_satan_Click(object sender, EventArgs e)
        {

        }

        private void cont_bolsonaro_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cont_dilma_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cont_lula_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void cont_nemesis_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}