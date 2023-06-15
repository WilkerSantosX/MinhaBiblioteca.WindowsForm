namespace MinhaBiblioteca.Forms
{
    partial class AdicionaEditora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionaEditora));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.comboDeleteEditora = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.btnInserirNovaEditora = new System.Windows.Forms.Button();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.btnInserirEditora = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(166, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 229);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeletar);
            this.panel2.Controls.Add(this.comboDeleteEditora);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblRetorno);
            this.panel2.Controls.Add(this.btnInserirNovaEditora);
            this.panel2.Controls.Add(this.txtEditora);
            this.panel2.Controls.Add(this.btnInserirEditora);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(515, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 367);
            this.panel2.TabIndex = 7;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(23, 312);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(98, 23);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // comboDeleteEditora
            // 
            this.comboDeleteEditora.FormattingEnabled = true;
            this.comboDeleteEditora.Location = new System.Drawing.Point(25, 274);
            this.comboDeleteEditora.Name = "comboDeleteEditora";
            this.comboDeleteEditora.Size = new System.Drawing.Size(295, 21);
            this.comboDeleteEditora.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Excluir Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "_______________________________";
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.ForeColor = System.Drawing.Color.Green;
            this.lblRetorno.Location = new System.Drawing.Point(23, 187);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(0, 18);
            this.lblRetorno.TabIndex = 8;
            // 
            // btnInserirNovaEditora
            // 
            this.btnInserirNovaEditora.BackColor = System.Drawing.Color.White;
            this.btnInserirNovaEditora.Location = new System.Drawing.Point(20, 152);
            this.btnInserirNovaEditora.Name = "btnInserirNovaEditora";
            this.btnInserirNovaEditora.Size = new System.Drawing.Size(98, 23);
            this.btnInserirNovaEditora.TabIndex = 7;
            this.btnInserirNovaEditora.Text = "Nova Editora";
            this.btnInserirNovaEditora.UseVisualStyleBackColor = false;
            this.btnInserirNovaEditora.Visible = false;
            this.btnInserirNovaEditora.Click += new System.EventHandler(this.btnInserirNovaEditora_Click);
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(26, 109);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(295, 20);
            this.txtEditora.TabIndex = 4;
            // 
            // btnInserirEditora
            // 
            this.btnInserirEditora.BackColor = System.Drawing.Color.White;
            this.btnInserirEditora.Location = new System.Drawing.Point(18, 152);
            this.btnInserirEditora.Name = "btnInserirEditora";
            this.btnInserirEditora.Size = new System.Drawing.Size(98, 23);
            this.btnInserirEditora.TabIndex = 6;
            this.btnInserirEditora.Text = "Salvar";
            this.btnInserirEditora.UseVisualStyleBackColor = false;
            this.btnInserirEditora.Click += new System.EventHandler(this.btnInserirEditora_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Editora";
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
            // AdicionaEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1028, 562);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionaEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Biblioteca | Add/Edit Livro";
            this.Load += new System.EventHandler(this.AdicionaEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ComboBox comboDeleteEditora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Button btnInserirNovaEditora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Button btnInserirEditora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}