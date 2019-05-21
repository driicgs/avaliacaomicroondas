namespace TesteMicroOndasAdriane
{
    partial class Form1
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
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.txtpotencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btnrapido = new System.Windows.Forms.Button();
            this.txtempo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnomeprograma = new System.Windows.Forms.TextBox();
            this.btnnovo = new System.Windows.Forms.Button();
            this.gpprogramas = new System.Windows.Forms.GroupBox();
            this.txtcaracter = new System.Windows.Forms.TextBox();
            this.llbcaracter = new System.Windows.Forms.Label();
            this.txtinstrucoes = new System.Windows.Forms.TextBox();
            this.txtprogtempo = new System.Windows.Forms.TextBox();
            this.txtprogpotencia = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cblistaprogramas = new System.Windows.Forms.ComboBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpprogramas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtdisplay.Enabled = false;
            this.txtdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay.ForeColor = System.Drawing.Color.Honeydew;
            this.txtdisplay.Location = new System.Drawing.Point(1, 1);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(313, 99);
            this.txtdisplay.TabIndex = 0;
            this.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpotencia
            // 
            this.txtpotencia.Location = new System.Drawing.Point(116, 47);
            this.txtpotencia.MaxLength = 3;
            this.txtpotencia.Name = "txtpotencia";
            this.txtpotencia.Size = new System.Drawing.Size(89, 20);
            this.txtpotencia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tempo(segundos)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Potência";
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(-3, 509);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(93, 37);
            this.btniniciar.TabIndex = 5;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btnrapido
            // 
            this.btnrapido.Location = new System.Drawing.Point(96, 509);
            this.btnrapido.Name = "btnrapido";
            this.btnrapido.Size = new System.Drawing.Size(118, 37);
            this.btnrapido.TabIndex = 6;
            this.btnrapido.Text = "Início Rápido";
            this.btnrapido.UseVisualStyleBackColor = true;
            this.btnrapido.Click += new System.EventHandler(this.btnrapido_Click);
            // 
            // txtempo
            // 
            this.txtempo.Location = new System.Drawing.Point(9, 46);
            this.txtempo.MaxLength = 4;
            this.txtempo.Name = "txtempo";
            this.txtempo.Size = new System.Drawing.Size(89, 20);
            this.txtempo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpesquisa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtnomeprograma);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Controls.Add(this.gpprogramas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cblistaprogramas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpotencia);
            this.groupBox1.Controls.Add(this.txtempo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 400);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe tempo e potência ou selecione um programa";
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Location = new System.Drawing.Point(214, 91);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(79, 34);
            this.btnpesquisa.TabIndex = 13;
            this.btnpesquisa.Text = "Pesquisar Programa";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nome do Programa:";
            // 
            // txtnomeprograma
            // 
            this.txtnomeprograma.Location = new System.Drawing.Point(9, 99);
            this.txtnomeprograma.MaxLength = 30;
            this.txtnomeprograma.Name = "txtnomeprograma";
            this.txtnomeprograma.Size = new System.Drawing.Size(196, 20);
            this.txtnomeprograma.TabIndex = 11;
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(165, 155);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(128, 21);
            this.btnnovo.TabIndex = 10;
            this.btnnovo.Text = "Novo Programa";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // gpprogramas
            // 
            this.gpprogramas.Controls.Add(this.btnsalvar);
            this.gpprogramas.Controls.Add(this.txtcaracter);
            this.gpprogramas.Controls.Add(this.llbcaracter);
            this.gpprogramas.Controls.Add(this.txtinstrucoes);
            this.gpprogramas.Controls.Add(this.txtprogtempo);
            this.gpprogramas.Controls.Add(this.txtprogpotencia);
            this.gpprogramas.Controls.Add(this.txtnome);
            this.gpprogramas.Controls.Add(this.label8);
            this.gpprogramas.Controls.Add(this.label7);
            this.gpprogramas.Controls.Add(this.label6);
            this.gpprogramas.Controls.Add(this.label5);
            this.gpprogramas.Location = new System.Drawing.Point(3, 182);
            this.gpprogramas.Name = "gpprogramas";
            this.gpprogramas.Size = new System.Drawing.Size(287, 215);
            this.gpprogramas.TabIndex = 9;
            this.gpprogramas.TabStop = false;
            // 
            // txtcaracter
            // 
            this.txtcaracter.Location = new System.Drawing.Point(185, 71);
            this.txtcaracter.MaxLength = 4;
            this.txtcaracter.Name = "txtcaracter";
            this.txtcaracter.Size = new System.Drawing.Size(92, 20);
            this.txtcaracter.TabIndex = 16;
            // 
            // llbcaracter
            // 
            this.llbcaracter.AutoSize = true;
            this.llbcaracter.Location = new System.Drawing.Point(182, 55);
            this.llbcaracter.Name = "llbcaracter";
            this.llbcaracter.Size = new System.Drawing.Size(50, 13);
            this.llbcaracter.TabIndex = 15;
            this.llbcaracter.Text = "Caracter:";
            // 
            // txtinstrucoes
            // 
            this.txtinstrucoes.Location = new System.Drawing.Point(6, 110);
            this.txtinstrucoes.MaxLength = 150;
            this.txtinstrucoes.Multiline = true;
            this.txtinstrucoes.Name = "txtinstrucoes";
            this.txtinstrucoes.Size = new System.Drawing.Size(271, 63);
            this.txtinstrucoes.TabIndex = 14;
            // 
            // txtprogtempo
            // 
            this.txtprogtempo.Location = new System.Drawing.Point(93, 71);
            this.txtprogtempo.MaxLength = 4;
            this.txtprogtempo.Name = "txtprogtempo";
            this.txtprogtempo.Size = new System.Drawing.Size(74, 20);
            this.txtprogtempo.TabIndex = 13;
            // 
            // txtprogpotencia
            // 
            this.txtprogpotencia.Location = new System.Drawing.Point(7, 71);
            this.txtprogpotencia.MaxLength = 4;
            this.txtprogpotencia.Name = "txtprogpotencia";
            this.txtprogpotencia.Size = new System.Drawing.Size(69, 20);
            this.txtprogpotencia.TabIndex = 12;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(6, 32);
            this.txtnome.MaxLength = 30;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(271, 20);
            this.txtnome.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tempo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Potência:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Instruções de Uso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Programas";
            // 
            // cblistaprogramas
            // 
            this.cblistaprogramas.FormattingEnabled = true;
            this.cblistaprogramas.Location = new System.Drawing.Point(6, 155);
            this.cblistaprogramas.Name = "cblistaprogramas";
            this.cblistaprogramas.Size = new System.Drawing.Size(153, 21);
            this.cblistaprogramas.TabIndex = 6;
            this.cblistaprogramas.SelectedIndexChanged += new System.EventHandler(this.cblistaprogramas_SelectedIndexChanged);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(113, 183);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(66, 29);
            this.btnsalvar.TabIndex = 14;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnrapido);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.btniniciar);
            this.Name = "Form1";
            this.Text = "Micro-Ondas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpprogramas.ResumeLayout(false);
            this.gpprogramas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.TextBox txtpotencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnrapido;
        private System.Windows.Forms.TextBox txtempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cblistaprogramas;
        private System.Windows.Forms.GroupBox gpprogramas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtinstrucoes;
        private System.Windows.Forms.TextBox txtprogtempo;
        private System.Windows.Forms.TextBox txtprogpotencia;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnomeprograma;
        private System.Windows.Forms.TextBox txtcaracter;
        private System.Windows.Forms.Label llbcaracter;
        private System.Windows.Forms.Button btnsalvar;
    }
}

