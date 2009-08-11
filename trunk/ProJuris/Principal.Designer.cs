namespace ProJuris
{
    partial class Principal
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tsbAgenda = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.stLogin = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.AutoSize = false;
			this.menuStrip.Enabled = false;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripButton2,
            this.tsbAgenda});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip.Size = new System.Drawing.Size(1016, 58);
			this.menuStrip.Stretch = false;
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// cadastrosToolStripMenuItem
			// 
			this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
			this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
			this.cadastrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
			this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(119, 54);
			this.cadastrosToolStripMenuItem.Text = "Cadastros";
			this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
			// 
			// sToolStripMenuItem
			// 
			this.sToolStripMenuItem.Name = "sToolStripMenuItem";
			this.sToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.sToolStripMenuItem.Text = "Clientes";
			// 
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
			this.relatóriosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(119, 54);
			this.relatóriosToolStripMenuItem.Text = "Relatórios";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
			this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 54);
			this.toolStripMenuItem1.Text = "Auditoria";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(73, 51);
			this.toolStripButton2.Text = "Sobre";
			// 
			// tsbAgenda
			// 
			this.tsbAgenda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbAgenda.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgenda.Image")));
			this.tsbAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgenda.Name = "tsbAgenda";
			this.tsbAgenda.Size = new System.Drawing.Size(100, 51);
			this.tsbAgenda.Text = "Agenda";
			this.tsbAgenda.Click += new System.EventHandler(this.tsbAgenda_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.AllowItemReorder = true;
			this.statusStrip.AutoSize = false;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLogin});
			this.statusStrip.Location = new System.Drawing.Point(0, 700);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1016, 34);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// stLogin
			// 
			this.stLogin.Image = ((System.Drawing.Image)(resources.GetObject("stLogin.Image")));
			this.stLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.stLogin.Name = "stLogin";
			this.stLogin.Size = new System.Drawing.Size(69, 24);
			this.stLogin.Text = "Login";
			this.stLogin.Click += new System.EventHandler(this.stLogin_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Principal";
			this.Text = "ProJuris - Sistema de Controle de Processos";
			this.Load += new System.EventHandler(this.Principal_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

        }
        #endregion

		private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel stLogin;
		public System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripButton tsbAgenda;
		private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}



