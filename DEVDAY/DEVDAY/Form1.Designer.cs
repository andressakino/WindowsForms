namespace DEVDAY
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.button_Cep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Cep
            // 
            this.button_Cep.Location = new System.Drawing.Point(549, 334);
            this.button_Cep.Name = "button_Cep";
            this.button_Cep.Size = new System.Drawing.Size(75, 23);
            this.button_Cep.TabIndex = 0;
            this.button_Cep.Text = "Buscar Cep";
            this.button_Cep.UseVisualStyleBackColor = true;
            this.button_Cep.Click += new System.EventHandler(this.button_Cep_Click);
=======
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.btncep = new System.Windows.Forms.Button();
            this.txtlogradouro = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radiofeminino = new System.Windows.Forms.RadioButton();
            this.radiomasculino = new System.Windows.Forms.RadioButton();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEP";
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSize = true;
            this.Logradouro.Location = new System.Drawing.Point(41, 138);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Logradouro.TabIndex = 2;
            this.Logradouro.Text = "Logradouro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado (UF)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Nascimento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(120, 55);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(261, 20);
            this.txtnome.TabIndex = 6;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(120, 98);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(100, 20);
            this.txtcep.TabIndex = 7;
            // 
            // btncep
            // 
            this.btncep.Location = new System.Drawing.Point(245, 96);
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(75, 23);
            this.btncep.TabIndex = 8;
            this.btncep.Text = "Buscar CEP";
            this.btncep.UseVisualStyleBackColor = true;
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Location = new System.Drawing.Point(120, 135);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(261, 20);
            this.txtlogradouro.TabIndex = 9;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(120, 203);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 20);
            this.txtcidade.TabIndex = 10;
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(323, 203);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(58, 20);
            this.txtuf.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Idade";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(120, 278);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gênero";
            // 
            // radiofeminino
            // 
            this.radiofeminino.AutoSize = true;
            this.radiofeminino.Location = new System.Drawing.Point(120, 317);
            this.radiofeminino.Name = "radiofeminino";
            this.radiofeminino.Size = new System.Drawing.Size(67, 17);
            this.radiofeminino.TabIndex = 17;
            this.radiofeminino.TabStop = true;
            this.radiofeminino.Text = "Feminino";
            this.radiofeminino.UseVisualStyleBackColor = true;
            // 
            // radiomasculino
            // 
            this.radiomasculino.AutoSize = true;
            this.radiomasculino.Location = new System.Drawing.Point(245, 317);
            this.radiomasculino.Name = "radiomasculino";
            this.radiomasculino.Size = new System.Drawing.Size(73, 17);
            this.radiomasculino.TabIndex = 18;
            this.radiomasculino.TabStop = true;
            this.radiomasculino.Text = "Masculino";
            this.radiomasculino.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(120, 374);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 19;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(245, 374);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(136, 23);
            this.btnlimpar.TabIndex = 20;
            this.btnlimpar.Text = "Limpar todos os campos";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(41, 170);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(34, 13);
            this.text.TabIndex = 21;
            this.text.Text = "Bairro";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(120, 167);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(100, 20);
            this.txtbairro.TabIndex = 22;
>>>>>>> Lucas
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.button_Cep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
=======
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.text);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.radiomasculino);
            this.Controls.Add(this.radiofeminino);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtlogradouro);
            this.Controls.Add(this.btncep);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Logradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> Lucas

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button button_Cep;
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Logradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Button btncep;
        private System.Windows.Forms.TextBox txtlogradouro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radiofeminino;
        private System.Windows.Forms.RadioButton radiomasculino;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label6;
>>>>>>> Lucas
    }
}

