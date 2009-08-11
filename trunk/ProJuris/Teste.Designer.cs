namespace ProJuris
{
    partial class Teste
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
			this.gridView1 = new BaseCore.GridView();
			this.SuspendLayout();
			// 
			// gridView1
			// 
			this.gridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gridView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gridView1.Description = null;
			this.gridView1.Location = new System.Drawing.Point(4, -1);
			this.gridView1.Name = "gridView1";
			this.gridView1.NovoForm = "NovoTeste";
			this.gridView1.Size = new System.Drawing.Size(468, 295);
			this.gridView1.TabIndex = 2;
			this.gridView1.Table = null;
			// 
			// Teste
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 336);
			this.Controls.Add(this.gridView1);
			this.Name = "Teste";
			this.Text = "Teste";
			this.Controls.SetChildIndex(this.gridView1, 0);
			this.ResumeLayout(false);

        }

        #endregion

        private BaseCore.GridView gridView1;

    }
}