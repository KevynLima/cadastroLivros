namespace cadastroLivros
{
    partial class frmInclusao
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.picCapa = new System.Windows.Forms.PictureBox();
            this.btnCapa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbSInopse = new System.Windows.Forms.RichTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(164, 42);
            this.mskCodigo.Mask = "99999";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(36, 20);
            this.mskCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(338, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gênero";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "",
            "Aventura",
            "Ação",
            "Terror",
            "Psicologia",
            "Romance",
            "Ficção",
            "Ficção Científica",
            "Infanto Juvenil"});
            this.cboGenero.Location = new System.Drawing.Point(164, 103);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Lançamento";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(338, 103);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nota Pessoal";
            // 
            // nudNota
            // 
            this.nudNota.Location = new System.Drawing.Point(164, 159);
            this.nudNota.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(36, 20);
            this.nudNota.TabIndex = 10;
            this.nudNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // picCapa
            // 
            this.picCapa.Location = new System.Drawing.Point(15, 12);
            this.picCapa.Name = "picCapa";
            this.picCapa.Size = new System.Drawing.Size(140, 193);
            this.picCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapa.TabIndex = 11;
            this.picCapa.TabStop = false;
            // 
            // btnCapa
            // 
            this.btnCapa.Location = new System.Drawing.Point(28, 211);
            this.btnCapa.Name = "btnCapa";
            this.btnCapa.Size = new System.Drawing.Size(115, 46);
            this.btnCapa.TabIndex = 12;
            this.btnCapa.Text = "Adicionar Foto...";
            this.btnCapa.UseVisualStyleBackColor = true;
            this.btnCapa.Click += new System.EventHandler(this.btnCapa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sinopse(Opcional)";
            // 
            // rtbSInopse
            // 
            this.rtbSInopse.Location = new System.Drawing.Point(335, 158);
            this.rtbSInopse.Name = "rtbSInopse";
            this.rtbSInopse.Size = new System.Drawing.Size(231, 96);
            this.rtbSInopse.TabIndex = 14;
            this.rtbSInopse.Text = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(197, 264);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 46);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Incluir Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmInclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(585, 322);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rtbSInopse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCapa);
            this.Controls.Add(this.picCapa);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInclusao";
            this.Text = "Inclusão";
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.PictureBox picCapa;
        private System.Windows.Forms.Button btnCapa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbSInopse;
        private System.Windows.Forms.Button btnCadastrar;
    }
}