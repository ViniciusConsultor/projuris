namespace BaseCore
{
    partial class Login
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
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.chbSSIP = new System.Windows.Forms.CheckBox();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbLogin
			// 
			this.tbLogin.Enabled = false;
			this.tbLogin.Location = new System.Drawing.Point(200, 48);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(114, 20);
			this.tbLogin.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(159, 111);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(76, 42);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "Ok";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// chbSSIP
			// 
			this.chbSSIP.AutoSize = true;
			this.chbSSIP.Checked = true;
			this.chbSSIP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbSSIP.Location = new System.Drawing.Point(159, 26);
			this.chbSSIP.Name = "chbSSIP";
			this.chbSSIP.Size = new System.Drawing.Size(50, 17);
			this.chbSSIP.TabIndex = 3;
			this.chbSSIP.Text = "SSIP";
			this.chbSSIP.UseVisualStyleBackColor = true;
			this.chbSSIP.CheckedChanged += new System.EventHandler(this.chbSSIP_CheckedChanged);
			// 
			// tbSenha
			// 
			this.tbSenha.Enabled = false;
			this.tbSenha.Location = new System.Drawing.Point(200, 74);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.Size = new System.Drawing.Size(114, 20);
			this.tbSenha.TabIndex = 1;
			this.tbSenha.UseSystemPasswordChar = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(4, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 127);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(146, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(146, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Senha:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(241, 111);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(76, 42);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 176);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.chbSSIP);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tbSenha);
			this.Controls.Add(this.tbLogin);
			this.Name = "Login";
			this.ShowIcon = false;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chbSSIP;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancel;

    }
}