using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmSebbysCalculator : Form
    {
        public FrmSebbysCalculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtValor1.Clear();
            txtValor2.Clear();
            txtSinal.Clear();
            txtValor1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "" && txtSinal.Text == "" && txtValor2.Text == "")
            {
                MessageBox.Show("Os campos Valor1, Sinal e Valor2 tem que estar preenchidos");
            }
            else
            {
                if (txtValor1.Text == "" && txtSinal.Text == "")
                {
                    MessageBox.Show("Os campos Valor1 e Sinal tem que estar preenchidos");
                }
                else
                {
                    if (txtValor1.Text == "" && txtValor2.Text == "")
                    {
                        MessageBox.Show("Os campos Valor1 e Valor2 tem que estar preenchidos");
                    }
                    else
                    {
                        if (txtValor2.Text == "" && txtSinal.Text == "")
                        {
                            MessageBox.Show("Os campos Sinal e Valor2 tem que estar preenchidos");
                        }
                        else
                        {
                            if (txtValor1.Text == "")
                            {
                                MessageBox.Show("O campo Valor1 tem que estar preenchido");
                            }
                            else
                            {
                                if (txtSinal.Text == "")
                                {
                                    MessageBox.Show("O campo Sinal tem que estar preenchido");
                                }
                                else
                                {
                                    if (txtValor2.Text == "")
                                    {
                                        MessageBox.Show("O campo Valor2 tem que estar preenchido");
                                    }
                                    else
                                    {
                                        {
                                            double numeric;
                                            if (double.TryParse(txtValor1.Text, out numeric) && (double.TryParse(txtValor2.Text, out numeric)))
                                            {
                                                double resultado = 0;
                                                double n1 = Convert.ToDouble(txtValor1.Text);
                                                double n2 = Convert.ToDouble(txtValor2.Text);
                                                if (txtSinal.Text.Trim() == "+")
                                                {
                                                    resultado = n1 + n2;
                                                    txtResultado.Text = Convert.ToString(resultado);
                                                }
                                                else
                                                {
                                                    if (txtSinal.Text.Trim() == "-")
                                                    {
                                                        resultado = n1 - n2;
                                                        txtResultado.Text = Convert.ToString(resultado);
                                                    }
                                                    else
                                                    {
                                                        if (txtSinal.Text.Trim() == "*" || txtSinal.Text.Trim() == "x" || txtSinal.Text.Trim() == "X")
                                                        {
                                                            resultado = n1 * n2;
                                                            txtResultado.Text = Convert.ToString(resultado);
                                                        }
                                                        else
                                                        {if (txtSinal.Text.Trim() == "/")
                                                            {
                                                            
                                                                if (n2 == 0)
                                                                {
                                                                    MessageBox.Show("O valor da divisão não pode ser 0");
                                                                }
                                                                else
                                                                {
                                                                    resultado = n1 / n2;
                                                                    txtResultado.Text = Convert.ToString(resultado);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Sinal invalido");
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Valor1 ou Valor2 invalidos");
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }
        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "" && txtSinal.Text == "" && txtValor2.Text == "")
            {
                MessageBox.Show("Os campos Valor1, Sinal e Valor2 tem que estar preenchidos");
            }
            else
            {
                if (txtValor1.Text == "" && txtSinal.Text == "")
                {
                    MessageBox.Show("Os campos Valor1 e Sinal tem que estar preenchidos");
                }
                else
                {
                    if (txtValor1.Text == "" && txtValor2.Text == "")
                    {
                        MessageBox.Show("Os campos Valor1 e Valor2 tem que estar preenchidos");
                    }
                    else
                    {
                        if (txtValor2.Text == "" && txtSinal.Text == "")
                        {
                            MessageBox.Show("Os campos Sinal e Valor2 tem que estar preenchidos");
                        }
                        else
                        {
                            if (txtValor1.Text == "")
                            {
                                MessageBox.Show("O campo Valor1 tem que estar preenchido");
                            }
                            else
                            {
                                    if (txtValor2.Text == "")
                                    {
                                        MessageBox.Show("O campo Valor2 tem que estar preenchido");
                                    }
                                    else
                                    {
                                        double numeric;
                                        if(double.TryParse(txtValor1.Text,out numeric) && (double.TryParse(txtValor2.Text,out numeric)))
                                        {
                                        double resultado = 0;
                                        double n1 = Convert.ToDouble(txtValor1.Text);
                                        double n2 = Convert.ToDouble(txtValor2.Text);
                                        if (rdoSoma.Checked == true)
                                        {
                                            resultado = n1 + n2;
                                            txtResultado.Text = Convert.ToString(resultado);
                                        }
                                        else
                                            {
                                            if (rdoSubtracao.Checked == true)
                                            {
                                                resultado = n1 - n2;
                                                txtResultado.Text = Convert.ToString(resultado);
                                            }
                                            else
                                            {
                                                if (rdoMultiplicacao.Checked == true)
                                                {
                                                    resultado = n1 * n2;
                                                    txtResultado.Text = Convert.ToString(resultado);
                                                }
                                                else
                                                {
                                                    if (rdoDivisao.Checked == true)
                                                    {
                                                        if (n2 == 0)
                                                        {
                                                            MessageBox.Show("O valor da divisão não pode ser 0");
                                                        }
                                                        else
                                                        {
                                                            resultado = n1 / n2;
                                                            txtResultado.Text = Convert.ToString(resultado);
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Voce precisa selecionar o sinal da operação");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                        else
                                        {
                                            MessageBox.Show("Valor1 ou Valor2 invalidos");
                                        }
                                    }
                            }

                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoSoma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitado.Checked == true)
            {
                txtResultado.Enabled = true;
                txtSinal.Enabled = true;
                txtValor1.Enabled = true;
                txtValor2.Enabled = true;
                rdoDivisao.Enabled = true;
                rdoMultiplicacao.Enabled = true;
                rdoSoma.Enabled = true;
                rdoSubtracao.Enabled = true;
                btnCalcular.Enabled = true;
                btnCalcular2.Enabled = true;
                btnLimpar.Enabled = true;
                lblResultado.Enabled = true;
                lblSinal.Enabled = true;
                lblValor1.Enabled = true;
                lblValor2.Enabled = true;
            }
            else
            {
                txtResultado.Enabled = false;
                txtSinal.Enabled = false;
                txtValor1.Enabled = false;
                txtValor2.Enabled = false;
                rdoDivisao.Enabled = false;
                rdoMultiplicacao.Enabled = false;
                rdoSoma.Enabled = false;
                rdoSubtracao.Enabled = false;
                btnCalcular.Enabled = false;
                btnCalcular2.Enabled = false;
                btnLimpar.Enabled = false;
                lblResultado.Enabled = false;
                lblSinal.Enabled = false;
                lblValor1.Enabled = false;
                lblValor2.Enabled = false;
            }
        }

        private void chkVisivel_CheckedChanged(object sender, EventArgs e)
        {
            if(chkVisivel.Checked == true)
            {
                lblResultado.Visible = true;
                lblSinal.Visible = true;
                lblValor1.Visible = true;
                lblValor2.Visible = true;
                txtResultado.Visible = true;
                txtSinal.Visible = true;
                txtValor1.Visible = true;
                txtValor2.Visible = true;
                btnCalcular.Visible = true;
                btnCalcular2.Visible = true;
                btnLimpar.Visible = true;
                rdoDivisao.Visible = true;
                rdoMultiplicacao.Visible = true;
                rdoSoma.Visible = true;
                rdoSubtracao.Visible = true;
                chkHabilitado.Visible = true;
            }
            else
            {
                lblResultado.Visible = false;
                lblSinal.Visible = false;
                lblValor1.Visible = false;
                lblValor2.Visible = false;
                txtResultado.Visible = false;
                txtSinal.Visible = false;
                txtValor1.Visible = false;
                txtValor2.Visible = false;
                btnCalcular.Visible = false;
                btnCalcular2.Visible = false;
                btnLimpar.Visible = false;
                rdoDivisao.Visible = false;
                rdoMultiplicacao.Visible = false;
                rdoSoma.Visible = false;
                rdoSubtracao.Visible = false;
                chkHabilitado.Visible = false;
            }
        }
    }
}
