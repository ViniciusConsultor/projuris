namespace BaseCore
{
    partial class GridView
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
            
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
												this.dataGridView = new System.Windows.Forms.DataGridView();
												this.lbDescription = new System.Windows.Forms.Label();
												this.txtFiltro = new System.Windows.Forms.TextBox();
												this.lblFiltroColuna = new System.Windows.Forms.Label();
												this.lblReload = new System.Windows.Forms.Label();
												this.pictureBox1 = new System.Windows.Forms.PictureBox();
												this.btnExcluir = new System.Windows.Forms.Button();
												this.btnAbrir = new System.Windows.Forms.Button();
												this.btnNovo = new System.Windows.Forms.Button();
												((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
												this.SuspendLayout();
												// 
												// dataGridView
												// 
												this.dataGridView.AllowUserToAddRows = false;
												this.dataGridView.AllowUserToDeleteRows = false;
												this.dataGridView.AllowUserToOrderColumns = true;
												this.dataGridView.AllowUserToResizeRows = false;
												this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
																								| System.Windows.Forms.AnchorStyles.Left)
																								| System.Windows.Forms.AnchorStyles.Right)));
												this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
												this.dataGridView.Location = new System.Drawing.Point(0, 69);
												this.dataGridView.MultiSelect = false;
												this.dataGridView.Name = "dataGridView";
												this.dataGridView.ReadOnly = true;
												this.dataGridView.Size = new System.Drawing.Size(395, 282);
												this.dataGridView.TabIndex = 0;
												this.dataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
												// 
												// lbDescription
												// 
												this.lbDescription.AutoSize = true;
												this.lbDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
												this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.lbDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
												this.lbDescription.Location = new System.Drawing.Point(3, 50);
												this.lbDescription.Name = "lbDescription";
												this.lbDescription.Size = new System.Drawing.Size(51, 16);
												this.lbDescription.TabIndex = 3;
												this.lbDescription.Text = "label1";
												// 
												// txtFiltro
												// 
												this.txtFiltro.Dock = System.Windows.Forms.DockStyle.Bottom;
												this.txtFiltro.Location = new System.Drawing.Point(0, 334);
												this.txtFiltro.Name = "txtFiltro";
												this.txtFiltro.Size = new System.Drawing.Size(395, 20);
												this.txtFiltro.TabIndex = 6;
												this.txtFiltro.Visible = false;
												this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
												// 
												// lblFiltroColuna
												// 
												this.lblFiltroColuna.Dock = System.Windows.Forms.DockStyle.Bottom;
												this.lblFiltroColuna.Location = new System.Drawing.Point(0, 311);
												this.lblFiltroColuna.Name = "lblFiltroColuna";
												this.lblFiltroColuna.Size = new System.Drawing.Size(395, 23);
												this.lblFiltroColuna.TabIndex = 7;
												this.lblFiltroColuna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												this.lblFiltroColuna.Visible = false;
												// 
												// lblReload
												// 
												this.lblReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
												this.lblReload.BackColor = System.Drawing.SystemColors.ActiveCaption;
												this.lblReload.Cursor = System.Windows.Forms.Cursors.Hand;
												this.lblReload.Image = global::BaseCore.Properties.Resources.refresh_16x16;
												this.lblReload.Location = new System.Drawing.Point(372, 50);
												this.lblReload.Name = "lblReload";
												this.lblReload.Size = new System.Drawing.Size(18, 16);
												this.lblReload.TabIndex = 5;
												this.lblReload.Click += new System.EventHandler(this.lblReload_Click);
												this.lblReload.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblReload_MouseDown);
												this.lblReload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblReload_MouseUp);
												// 
												// pictureBox1
												// 
												this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
																								| System.Windows.Forms.AnchorStyles.Right)));
												this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
												this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
												this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
												this.pictureBox1.Location = new System.Drawing.Point(0, 46);
												this.pictureBox1.Name = "pictureBox1";
												this.pictureBox1.Size = new System.Drawing.Size(395, 25);
												this.pictureBox1.TabIndex = 2;
												this.pictureBox1.TabStop = false;
												// 
												// btnExcluir
												// 
												this.btnExcluir.Image = global::BaseCore.Properties.Resources.emblem_unreadable_003;
												this.btnExcluir.Location = new System.Drawing.Point(162, 9);
												this.btnExcluir.Name = "btnExcluir";
												this.btnExcluir.Size = new System.Drawing.Size(75, 31);
												this.btnExcluir.TabIndex = 1;
												this.btnExcluir.Text = "Excluir";
												this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
												this.btnExcluir.UseVisualStyleBackColor = true;
												this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
												// 
												// btnAbrir
												// 
												this.btnAbrir.Image = global::BaseCore.Properties.Resources.edit_document_16x16;
												this.btnAbrir.Location = new System.Drawing.Point(81, 9);
												this.btnAbrir.Name = "btnAbrir";
												this.btnAbrir.Size = new System.Drawing.Size(75, 31);
												this.btnAbrir.TabIndex = 1;
												this.btnAbrir.Text = "Abrir";
												this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
												this.btnAbrir.UseVisualStyleBackColor = true;
												this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
												// 
												// btnNovo
												// 
												this.btnNovo.Image = global::BaseCore.Properties.Resources.export_16x16;
												this.btnNovo.Location = new System.Drawing.Point(0, 9);
												this.btnNovo.Name = "btnNovo";
												this.btnNovo.Size = new System.Drawing.Size(75, 31);
												this.btnNovo.TabIndex = 1;
												this.btnNovo.Text = "Novo";
												this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
												this.btnNovo.UseVisualStyleBackColor = true;
												this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
												// 
												// GridView
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
												this.Controls.Add(this.lblFiltroColuna);
												this.Controls.Add(this.txtFiltro);
												this.Controls.Add(this.lblReload);
												this.Controls.Add(this.lbDescription);
												this.Controls.Add(this.pictureBox1);
												this.Controls.Add(this.btnExcluir);
												this.Controls.Add(this.btnAbrir);
												this.Controls.Add(this.btnNovo);
												this.Controls.Add(this.dataGridView);
												this.Name = "GridView";
												this.Size = new System.Drawing.Size(395, 354);
												this.Load += new System.EventHandler(this.GridView_Load);
												((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
												this.ResumeLayout(false);
												this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox1;
								private System.Windows.Forms.Label lbDescription;
								private System.Windows.Forms.Label lblReload;
								private System.Windows.Forms.TextBox txtFiltro;
								private System.Windows.Forms.Label lblFiltroColuna;
    }
}
