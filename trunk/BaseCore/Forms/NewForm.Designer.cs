namespace BaseCore
{
    partial class NewForm
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
												this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
												this.btnCancel = new System.Windows.Forms.Button();
												this.btnOk = new System.Windows.Forms.Button();
												this.flowLayoutPanel1.SuspendLayout();
												this.SuspendLayout();
												// 
												// flowLayoutPanel1
												// 
												this.flowLayoutPanel1.Controls.Add(this.btnCancel);
												this.flowLayoutPanel1.Controls.Add(this.btnOk);
												this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
												this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
												this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 209);
												this.flowLayoutPanel1.Name = "flowLayoutPanel1";
												this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 36);
												this.flowLayoutPanel1.TabIndex = 1;
												this.flowLayoutPanel1.WrapContents = false;
												// 
												// btnCancel
												// 
												this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
												this.btnCancel.Image = global::BaseCore.Properties.Resources.block_16x16;
												this.btnCancel.Location = new System.Drawing.Point(268, 3);
												this.btnCancel.Name = "btnCancel";
												this.btnCancel.Size = new System.Drawing.Size(75, 31);
												this.btnCancel.TabIndex = 0;
												this.btnCancel.Text = "Cancel";
												this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
												this.btnCancel.UseVisualStyleBackColor = true;
												this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
												// 
												// btnOk
												// 
												this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
												this.btnOk.Image = global::BaseCore.Properties.Resources.ok_16x16;
												this.btnOk.Location = new System.Drawing.Point(187, 3);
												this.btnOk.Name = "btnOk";
												this.btnOk.Size = new System.Drawing.Size(75, 31);
												this.btnOk.TabIndex = 0;
												this.btnOk.Text = "Ok";
												this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
												this.btnOk.UseVisualStyleBackColor = true;
												this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
												// 
												// NovoForm
												// 
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
												this.ClientSize = new System.Drawing.Size(346, 245);
												this.Controls.Add(this.flowLayoutPanel1);
												this.Name = "NovoForm";
												this.ShowIcon = false;
												this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
												this.Load += new System.EventHandler(this.NovoForm_Load);
												this.flowLayoutPanel1.ResumeLayout(false);
												this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}