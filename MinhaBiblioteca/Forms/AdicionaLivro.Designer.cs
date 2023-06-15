namespace MinhaBiblioteca.Forms
{
    partial class AdicionaLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionaLivro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.Label();
            this.comboNewAvaliacao = new System.Windows.Forms.ComboBox();
            this.radioNao = new System.Windows.Forms.RadioButton();
            this.radioSim = new System.Windows.Forms.RadioButton();
            this.txtNewAno = new System.Windows.Forms.TextBox();
            this.txtNewLivro = new System.Windows.Forms.TextBox();
            this.comboNewEditora = new System.Windows.Forms.ComboBox();
            this.comboNewAutor = new System.Windows.Forms.ComboBox();
            this.btnSaveLivro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnNovoLivro);
            this.panel2.Controls.Add(this.txtRetorno);
            this.panel2.Controls.Add(this.comboNewAvaliacao);
            this.panel2.Controls.Add(this.radioNao);
            this.panel2.Controls.Add(this.radioSim);
            this.panel2.Controls.Add(this.txtNewAno);
            this.panel2.Controls.Add(this.txtNewLivro);
            this.panel2.Controls.Add(this.comboNewEditora);
            this.panel2.Controls.Add(this.comboNewAutor);
            this.panel2.Controls.Add(this.btnSaveLivro);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(601, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 491);
            this.panel2.TabIndex = 5;
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.BackColor = System.Drawing.Color.White;
            this.btnNovoLivro.Location = new System.Drawing.Point(104, 409);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(98, 23);
            this.btnNovoLivro.TabIndex = 15;
            this.btnNovoLivro.Text = "Novo Livro";
            this.btnNovoLivro.UseVisualStyleBackColor = false;
            this.btnNovoLivro.Visible = false;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.AutoSize = true;
            this.txtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetorno.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtRetorno.Location = new System.Drawing.Point(23, 451);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(0, 18);
            this.txtRetorno.TabIndex = 14;
            this.txtRetorno.Visible = false;
            // 
            // comboNewAvaliacao
            // 
            this.comboNewAvaliacao.FormattingEnabled = true;
            this.comboNewAvaliacao.Items.AddRange(new object[] {
            "SEM AVALIAÇÃO",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboNewAvaliacao.Location = new System.Drawing.Point(103, 352);
            this.comboNewAvaliacao.Name = "comboNewAvaliacao";
            this.comboNewAvaliacao.Size = new System.Drawing.Size(109, 21);
            this.comboNewAvaliacao.TabIndex = 13;
            this.comboNewAvaliacao.Text = "SEM AVALIAÇÃO";
            // 
            // radioNao
            // 
            this.radioNao.AutoSize = true;
            this.radioNao.Location = new System.Drawing.Point(254, 300);
            this.radioNao.Name = "radioNao";
            this.radioNao.Size = new System.Drawing.Size(45, 17);
            this.radioNao.TabIndex = 12;
            this.radioNao.TabStop = true;
            this.radioNao.Text = "Não";
            this.radioNao.UseVisualStyleBackColor = true;
            // 
            // radioSim
            // 
            this.radioSim.AutoSize = true;
            this.radioSim.Location = new System.Drawing.Point(206, 300);
            this.radioSim.Name = "radioSim";
            this.radioSim.Size = new System.Drawing.Size(42, 17);
            this.radioSim.TabIndex = 11;
            this.radioSim.TabStop = true;
            this.radioSim.Text = "Sim";
            this.radioSim.UseVisualStyleBackColor = true;
            // 
            // txtNewAno
            // 
            this.txtNewAno.Location = new System.Drawing.Point(64, 298);
            this.txtNewAno.Name = "txtNewAno";
            this.txtNewAno.Size = new System.Drawing.Size(58, 20);
            this.txtNewAno.TabIndex = 10;
            // 
            // txtNewLivro
            // 
            this.txtNewLivro.Location = new System.Drawing.Point(26, 109);
            this.txtNewLivro.Name = "txtNewLivro";
            this.txtNewLivro.Size = new System.Drawing.Size(295, 20);
            this.txtNewLivro.TabIndex = 4;
            // 
            // comboNewEditora
            // 
            this.comboNewEditora.FormattingEnabled = true;
            this.comboNewEditora.Location = new System.Drawing.Point(26, 247);
            this.comboNewEditora.Name = "comboNewEditora";
            this.comboNewEditora.Size = new System.Drawing.Size(295, 21);
            this.comboNewEditora.TabIndex = 9;
            // 
            // comboNewAutor
            // 
            this.comboNewAutor.FormattingEnabled = true;
            this.comboNewAutor.Location = new System.Drawing.Point(25, 171);
            this.comboNewAutor.Name = "comboNewAutor";
            this.comboNewAutor.Size = new System.Drawing.Size(295, 21);
            this.comboNewAutor.TabIndex = 8;
            // 
            // btnSaveLivro
            // 
            this.btnSaveLivro.BackColor = System.Drawing.Color.White;
            this.btnSaveLivro.Location = new System.Drawing.Point(23, 409);
            this.btnSaveLivro.Name = "btnSaveLivro";
            this.btnSaveLivro.Size = new System.Drawing.Size(98, 23);
            this.btnSaveLivro.TabIndex = 6;
            this.btnSaveLivro.Text = "Salvar";
            this.btnSaveLivro.UseVisualStyleBackColor = false;
            this.btnSaveLivro.Click += new System.EventHandler(this.btnSaveLivro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Avaliação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Já lido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Editora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Livro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "_______________________________";
            // 
            // AdicionaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Biblioteca | Add/Edit Livro";
            this.Load += new System.EventHandler(this.AdicionaLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.Label txtRetorno;
        private System.Windows.Forms.ComboBox comboNewAvaliacao;
        private System.Windows.Forms.RadioButton radioNao;
        private System.Windows.Forms.RadioButton radioSim;
        private System.Windows.Forms.TextBox txtNewAno;
        private System.Windows.Forms.TextBox txtNewLivro;
        private System.Windows.Forms.ComboBox comboNewEditora;
        private System.Windows.Forms.ComboBox comboNewAutor;
        private System.Windows.Forms.Button btnSaveLivro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}