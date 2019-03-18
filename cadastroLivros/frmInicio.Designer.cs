namespace cadastroLivros
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inclusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inclusãoToolStripMenuItem,
            this.manutençãoConsultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inclusãoToolStripMenuItem
            // 
            this.inclusãoToolStripMenuItem.Name = "inclusãoToolStripMenuItem";
            this.inclusãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.inclusãoToolStripMenuItem.Text = "Inclusão";
            this.inclusãoToolStripMenuItem.Click += new System.EventHandler(this.inclusãoToolStripMenuItem_Click);
            // 
            // manutençãoConsultaToolStripMenuItem
            // 
            this.manutençãoConsultaToolStripMenuItem.Name = "manutençãoConsultaToolStripMenuItem";
            this.manutençãoConsultaToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.manutençãoConsultaToolStripMenuItem.Text = "Manutenção/Consulta";
            this.manutençãoConsultaToolStripMenuItem.Click += new System.EventHandler(this.manutençãoConsultaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cadastroLivros.Properties.Resources.loguinho_sem_transparencia;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inclusãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoConsultaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

