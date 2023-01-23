﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_ProjetoPessoal
{
	public partial class FrmCalculadora : Form
	{
		public FrmCalculadora()
		{
			InitializeComponent();
		}

		private void btntecla_0_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "0";
				
		}

		private void btntecla_1_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "1";
		}

		private void btntecla_2_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "2";
		}

		private void btntecla_3_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "3";
		}

		private void btntecla_4_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "4";
		}

		private void btntecla_5_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "5";
		}

		private void btntecla_6_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "6";
		}

		private void btntecla_7_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "7";
		}

		private void btntecla_8_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "8";
		}

		private void btntecla_9_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "9";
		}

		private void btntecla_soma_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "+";
		}

		private void btntecla_subtracao_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "-";
		}

		private void btntecla_multiplicacao_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "*";
		}

		private void btntecla_divisao_Click(object sender, EventArgs e)
		{
			txtVisor.Text += "/";
		}

		private void btntecla_backspace_Click(object sender, EventArgs e)
		{
			if (txtVisor.Text != "")
			{
				int tam = txtVisor.Text.Length;
				txtVisor.Text = txtVisor.Text.Remove(tam -1);
			}
			
		}

		private void btntecla_limpar_Click(object sender, EventArgs e)
		{
			txtVisor.Clear();
		}

		private void btntecla_resul_Click(object sender, EventArgs e)
		{
			//string[] numeros = txtVisor.Text.Split('+');
			//var tam = numeros.Count();
			var tam = txtVisor.Text.Length;
			int resultado = 0;
			for (int j = 0; j <= tam; j++)
			{
				int i = 0;
				string numero = null;
				string numero2 = null;
				
				while(txtVisor.Text[i] != '+' && txtVisor.Text[i] != '-' && txtVisor.Text[i] != '*' && txtVisor.Text[i] != '/')
				{
					numero = numero + txtVisor.Text[i];
					i++;
				}
				int posicao = 0;
				posicao = i;

				i++;
				while ( i<tam && txtVisor.Text[i] != '+' && txtVisor.Text[i] != '-' && txtVisor.Text[i] != '*' && txtVisor.Text[i] != '/' && txtVisor.Text != null)
				{
					numero2 = numero2 + txtVisor.Text[i];
					i++;
				}
				if (txtVisor.Text[posicao] == '+')
				{
					resultado = Convert.ToInt32(numero) + Convert.ToInt32(numero2);
					i++;
				}
				else if (txtVisor.Text[posicao] == '-')
				{
					resultado = Convert.ToInt32(numero) - Convert.ToInt32(numero2);
					i++;
				}
				else if (txtVisor.Text[posicao] == '*')
				{
					resultado = Convert.ToInt32(numero) * Convert.ToInt32(numero2);
					i++;
				}
				else if (txtVisor.Text[posicao] == '/')
				{
					resultado = Convert.ToInt32(numero) / Convert.ToInt32(numero2);
					i++;
				}
				txtVisor.Text = txtVisor.Text.Remove(0, i-1);
				txtVisor.Text = txtVisor.Text.Insert(0, Convert.ToString(resultado));
				
				tam = txtVisor.Text.Length;
			}

			/*int resultado = 0;
			for (int i = 0; i < tam; i++)
			{
				 resultado = Convert.ToInt32(numeros[i]) + resultado;
				
			}

			for (int i = 0; i < tam; i++)
			{
				if(txtVisor.Text[i] == '-')
				{
					int subtracao = Convert.ToInt32(txtVisor.Text[i - 1]) - Convert.ToInt32(txtVisor.Text[i + 1]);				
				}
			}
			txtVisor.Text = Convert.ToString(resultado);*/
		}
	}
}
