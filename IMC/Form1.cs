using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Não há campos preenchidos para limpar.","Mesagem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
                if (MessageBox.Show("Este botão tem como função limpar os campos que estiverem preenchidos.\n\nDeseja realmente limpar os campos?", "Limpar campos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                }

        }

        private void CalculaIMC()
        {
            double resultado = Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text));
            textBox3.Text = Convert.ToString(Math.Round(resultado, 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERRO:\nPor favor insira valores no campo PESO!!!!!!");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("ERRO:\nPor favor insira valores no campo ALTURA!!!!!!");
                textBox2.Focus();
            }
            else
            {
                CalculaIMC();

                if (Convert.ToDouble(textBox3.Text) <= 18.5)
                {
                    MessageBox.Show("IMC = " + textBox3.Text + "\n\nBAIXO PESO: Nesse ponto, o corpo magro deixa de ser saudável e o organismo fica vulneravel a infecções. Se o baixo peso persistir, mesmo com alimentação normal, procure ajuda médica; a dificuldade para engordar pode ser sintoma de alguma doença insidiosa, como o diabetes.");
                }
                else
                    if (Convert.ToDouble(textBox3.Text) > 18.5 && Convert.ToDouble(textBox3.Text) <= 24.9)
                    {
                        MessageBox.Show("IMC = " + textBox3.Text + "\n\nPESO IDEAL: Seu peso esta adequado à altura. É importante manter a educação alimentar e a atividade fisica. Fique atento caso seu valor esteja perto dos limites para os estagios de Baixo Peso ou Sobrepeso.");

                    }
                    else
                        if (Convert.ToDouble(textBox3.Text) > 24.9 && Convert.ToDouble(textBox3.Text) <= 29.9)
                        {

                            MessageBox.Show("IMC = " + textBox3.Text + "\n\nSOBREPESO: Esta faixa indica que você está com predisposiçãoá obesidade; dependendo do seu historico familiar e pessoal, pode haver um quadro de pré - diabetes e hipertensão. Procure orientação médica para evitar o proximo estagio, Obesidade 1. Quanto mais quilos extras, maior a dificuldade para emagrecer.");
                        }
                        else
                            if (Convert.ToDouble(textBox3.Text) > 29.9 && Convert.ToDouble(textBox3.Text) <= 34.9)
                            {
                                MessageBox.Show("IMC = " + textBox3.Text + "\n\nOBESIDADE GRAU 1: O risco de desenvolver diabetes, para quem esta nesta faixa de peso, é de 20%, e o de hipertensão ultrapassa o de 25%. Há o risco maior de outras doenças cardiovasculares, articulares, disturbios psiquiatricos, apnéia do sono e até certos tipos de câncer.");
                            }
                            else
                                if (Convert.ToDouble(textBox3.Text) > 34.9 && Convert.ToDouble(textBox3.Text) <= 39.9)
                                {
                                    MessageBox.Show("IMC = " + textBox3.Text + "\n\nOBESIDADE GRAU 2: O risco de desenvolver diabetes chega a 40%, e a chance de surgirem doenças associadas à obesidade, como reumatismos, cancêr, apneia do sono, hipertensão e outros problemas cardiovasculares pode chegar a 50%. Procure orientação médica.");
                                }
                                else
                                    if (Convert.ToDouble(textBox3.Text) >= 40)
                                    {
                                        MessageBox.Show("IMC = " + textBox3.Text + "\n\nOBESIDADE GRAU 3: O risco de desenvolver doenças associadas ao excesso de peso, como diabetes, reumatismos, cancêr, apneia do sono, hipertensão e outros problemas cardiovasculares chega a até 90%. Nesse estagio, a cirurgia de redução de estomago pode ser indicada. Procure orientação médica imedistsmente.");
                                    }
                            }
                    }

            

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa de cálculo de IMC?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O IMC (Indice de Massa Corpórea) é reconhecido pela OMS como a principal referência para classificação das diferentes faixas de peso. Mas, atenção: não deve ser o unico parâmetro para definir os riscos relacionados à obesidade. Outros fatores, como circunferência abdominal e taxa de colesterol, também são muito importantes. Procure orientação médica para saber a melhor forma de se manter no peso ideal.");
        }

    }
}