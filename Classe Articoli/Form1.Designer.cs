﻿namespace Classe_Articoli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.aggiungi = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descrizione = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.scontrino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(373, 26);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(66, 17);
            this.checkbox.TabIndex = 0;
            this.checkbox.Text = "Alimento";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(371, 108);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(85, 41);
            this.aggiungi.TabIndex = 1;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(11, 25);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(170, 20);
            this.nome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Articolo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codice Articolo:";
            // 
            // codice
            // 
            this.codice.Location = new System.Drawing.Point(192, 25);
            this.codice.Name = "codice";
            this.codice.Size = new System.Drawing.Size(173, 20);
            this.codice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrizione Articolo:";
            // 
            // descrizione
            // 
            this.descrizione.Location = new System.Drawing.Point(11, 72);
            this.descrizione.Name = "descrizione";
            this.descrizione.Size = new System.Drawing.Size(170, 20);
            this.descrizione.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prezzo Articolo:";
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(192, 72);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(173, 20);
            this.costo.TabIndex = 9;
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(452, 26);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(89, 17);
            this.checkbox2.TabIndex = 10;
            this.checkbox2.Text = "Non Alimento";
            this.checkbox2.UseVisualStyleBackColor = true;
            this.checkbox2.CheckedChanged += new System.EventHandler(this.checkbox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(373, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "In Possesso";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Carta Fedeltà:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Scadenza";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "È Fresco?";
            this.label7.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(192, 129);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(35, 17);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Si";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Entro Quando (max 5):";
            this.label8.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Materiale Principale:";
            this.label9.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "È Riciclabile?";
            this.label10.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(192, 129);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(35, 17);
            this.checkBox4.TabIndex = 24;
            this.checkBox4.Text = "Si";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cos\'è?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "Paga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 27;
            this.textBox3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Finito";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // scontrino
            // 
            this.scontrino.Location = new System.Drawing.Point(11, 155);
            this.scontrino.Multiline = true;
            this.scontrino.Name = "scontrino";
            this.scontrino.Size = new System.Drawing.Size(529, 147);
            this.scontrino.TabIndex = 32;
            this.scontrino.TextChanged += new System.EventHandler(this.scontrino_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 336);
            this.Controls.Add(this.scontrino);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkbox2);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descrizione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.checkbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descrizione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox scontrino;
    }
}

