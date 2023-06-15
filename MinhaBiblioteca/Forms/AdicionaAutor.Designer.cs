namespace MinhaBiblioteca.Forms
{
    partial class AdicionaAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionaAutor));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.comboDeleteAutor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.btnInserirNovoAutor = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnInserirAutor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(153, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeletar);
            this.panel2.Controls.Add(this.comboDeleteAutor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblRetorno);
            this.panel2.Controls.Add(this.btnInserirNovoAutor);
            this.panel2.Controls.Add(this.txtAutor);
            this.panel2.Controls.Add(this.btnInserirAutor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(529, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 387);
            this.panel2.TabIndex = 6;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(23, 324);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(98, 23);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // comboDeleteAutor
            // 
            this.comboDeleteAutor.FormattingEnabled = true;
            this.comboDeleteAutor.Location = new System.Drawing.Point(25, 286);
            this.comboDeleteAutor.Name = "comboDeleteAutor";
            this.comboDeleteAutor.Size = new System.Drawing.Size(295, 21);
            this.comboDeleteAutor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Excluir Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "_______________________________";
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.BackColor = System.Drawing.Color.White;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.Location = new System.Drawing.Point(23, 189);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(0, 18);
            this.lblRetorno.TabIndex = 8;
            // 
            // btnInserirNovoAutor
            // 
            this.btnInserirNovoAutor.BackColor = System.Drawing.Color.White;
            this.btnInserirNovoAutor.Location = new System.Drawing.Point(23, 151);
            this.btnInserirNovoAutor.Name = "btnInserirNovoAutor";
            this.btnInserirNovoAutor.Size = new System.Drawing.Size(98, 23);
            this.btnInserirNovoAutor.TabIndex = 7;
            this.btnInserirNovoAutor.Text = "Novo Autor";
            this.btnInserirNovoAutor.UseVisualStyleBackColor = false;
            this.btnInserirNovoAutor.Visible = false;
            this.btnInserirNovoAutor.Click += new System.EventHandler(this.btnInserirNovoAutor_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(26, 109);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(295, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // btnInserirAutor
            // 
            this.btnInserirAutor.BackColor = System.Drawing.Color.White;
            this.btnInserirAutor.Location = new System.Drawing.Point(18, 151);
            this.btnInserirAutor.Name = "btnInserirAutor";
            this.btnInserirAutor.Size = new System.Drawing.Size(98, 23);
            this.btnInserirAutor.TabIndex = 6;
            this.btnInserirAutor.Text = "Salvar";
            this.btnInserirAutor.UseVisualStyleBackColor = false;
            this.btnInserirAutor.Click += new System.EventHandler(this.btnInserirAutor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Autor";
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
            // AdicionaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionaAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Biblioteca | Add/Edit Livro";
            this.Load += new System.EventHandler(this.AdicionaAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ComboBox comboDeleteAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Button btnInserirNovoAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnInserirAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}