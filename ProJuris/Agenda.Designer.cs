namespace ProJuris
{
	partial class Agenda
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
			this.gvAgenda = new BaseCore.GridView();
			this.SuspendLayout();
			// 
			// gvAgenda
			// 
			this.gvAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gvAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gvAgenda.ColunaFill = "cep";
			this.gvAgenda.Description = "Agenda Telefônica";
			this.gvAgenda.Location = new System.Drawing.Point(4, 1);
			this.gvAgenda.Name = "gvAgenda";
			this.gvAgenda.NovoForm = "NovoAgenda";
			this.gvAgenda.OrderBy = "denominacao";
			this.gvAgenda.Size = new System.Drawing.Size(492, 347);
			this.gvAgenda.TabIndex = 0;
			this.gvAgenda.Table = "Agenda";
			// 
			// Agenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 351);
			this.Controls.Add(this.gvAgenda);
			this.Name = "Agenda";
			this.ShowIcon = false;
			this.Text = "Agenda";
			this.ResumeLayout(false);

		}

		#endregion

		private BaseCore.GridView gvAgenda;
	}
}