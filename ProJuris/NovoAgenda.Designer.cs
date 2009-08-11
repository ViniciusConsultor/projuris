namespace ProJuris
{
	partial class NovoAgenda
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoAgenda));
			this.label1 = new System.Windows.Forms.Label();
			this.denominacao = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Rua = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.telefone = new System.Windows.Forms.MaskedTextBox();
			this.cep = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.bairro = new System.Windows.Forms.TextBox();
			this.cidade = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.uf = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pbLoading = new System.Windows.Forms.PictureBox();
			this.bwCEP = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nome:";
			// 
			// denominacao
			// 
			this.denominacao.Location = new System.Drawing.Point(63, 18);
			this.denominacao.Name = "denominacao";
			this.denominacao.Size = new System.Drawing.Size(239, 20);
			this.denominacao.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Telefone:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(183, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "CEP:";
			// 
			// Rua
			// 
			this.Rua.Location = new System.Drawing.Point(63, 70);
			this.Rua.Name = "Rua";
			this.Rua.Size = new System.Drawing.Size(239, 20);
			this.Rua.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Bairro:";
			// 
			// telefone
			// 
			this.telefone.Location = new System.Drawing.Point(63, 44);
			this.telefone.Mask = "(00) 0000-0000";
			this.telefone.Name = "telefone";
			this.telefone.Size = new System.Drawing.Size(118, 20);
			this.telefone.TabIndex = 4;
			// 
			// cep
			// 
			this.cep.Location = new System.Drawing.Point(213, 43);
			this.cep.Mask = "00000-999";
			this.cep.Name = "cep";
			this.cep.Size = new System.Drawing.Size(89, 20);
			this.cep.TabIndex = 4;
			this.cep.Leave += new System.EventHandler(this.mtbCep_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Rua:";
			// 
			// bairro
			// 
			this.bairro.Location = new System.Drawing.Point(63, 95);
			this.bairro.Name = "bairro";
			this.bairro.Size = new System.Drawing.Size(239, 20);
			this.bairro.TabIndex = 3;
			// 
			// cidade
			// 
			this.cidade.Location = new System.Drawing.Point(63, 121);
			this.cidade.Name = "cidade";
			this.cidade.Size = new System.Drawing.Size(118, 20);
			this.cidade.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Cidade:";
			// 
			// uf
			// 
			this.uf.Location = new System.Drawing.Point(213, 121);
			this.uf.Name = "uf";
			this.uf.Size = new System.Drawing.Size(89, 20);
			this.uf.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(183, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "UF:";
			// 
			// pbLoading
			// 
			this.pbLoading.BackColor = System.Drawing.Color.White;
			this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
			this.pbLoading.Location = new System.Drawing.Point(284, 44);
			this.pbLoading.Name = "pbLoading";
			this.pbLoading.Size = new System.Drawing.Size(18, 18);
			this.pbLoading.TabIndex = 5;
			this.pbLoading.TabStop = false;
			this.pbLoading.Visible = false;
			// 
			// bwCEP
			// 
			this.bwCEP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCEP_DoWork);
			this.bwCEP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCEP_RunWorkerCompleted);
			// 
			// NovoAgenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 202);
			this.Controls.Add(this.pbLoading);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.telefone);
			this.Controls.Add(this.cep);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.denominacao);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Rua);
			this.Controls.Add(this.bairro);
			this.Controls.Add(this.uf);
			this.Controls.Add(this.cidade);
			this.Name = "NovoAgenda";
			this.Procedure = "pr_geraAgenda";
			this.Text = "a;Agenda";
			this.Controls.SetChildIndex(this.cidade, 0);
			this.Controls.SetChildIndex(this.uf, 0);
			this.Controls.SetChildIndex(this.bairro, 0);
			this.Controls.SetChildIndex(this.Rua, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.denominacao, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.cep, 0);
			this.Controls.SetChildIndex(this.telefone, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pbLoading, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox denominacao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Rua;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox telefone;
		private System.Windows.Forms.MaskedTextBox cep;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox bairro;
		private System.Windows.Forms.TextBox cidade;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox uf;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pbLoading;
		private System.ComponentModel.BackgroundWorker bwCEP;
	}
}