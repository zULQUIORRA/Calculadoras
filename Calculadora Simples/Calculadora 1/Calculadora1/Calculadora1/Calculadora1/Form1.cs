﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "soma")
            {
               txtResultado.Text = Convert.ToString(valor1 + valor2);
            } 
            else if (operacao == "subtração")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } 
            else if (operacao == "multiplicação")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            } 
            else if (operacao == "divisão")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "subtração";
                lbloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("ERROR!!! Por favor coloque algum número para efetuar a conta!!!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "multiplicação";
                lbloperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("ERROR!!! Por favor coloque algum número para efetuar a conta!!!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "divisão";
                lbloperacao.Text = "/";
            } 
            else
            {
                MessageBox.Show("ERROR!!! Por favor coloque algum número para efetuar a conta!!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbloperacao.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lbloperacao.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "soma";
                lbloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("ERROR!!! Por favor coloque algum número para efetuar a conta!!!");
            }
        }
    }
    }
   
