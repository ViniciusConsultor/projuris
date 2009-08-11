using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using BaseCore;

namespace ProJuris
{
	public partial class NovoAgenda : NewForm
	{
		private CepSeeker cs;
		public NovoAgenda()
		{
			InitializeComponent();
		}

		private void mtbCep_Leave(object sender, EventArgs e)
		{
			pbLoading.Visible = true;
			bwCEP.RunWorkerAsync();						
		}

		private void bwCEP_DoWork(object sender, DoWorkEventArgs e)
		{
			cs = new CepSeeker(cep.Text);
			
		}

		private void bwCEP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			pbLoading.Visible = false;
			bairro.Text = cs.Bairro;
			Rua.Text = cs.Endereco;
			uf.Text = cs.UF;
			cidade.Text = cs.Cidade;
		}

	}	
}
