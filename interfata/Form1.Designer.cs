
namespace Interfata
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nume = new System.Windows.Forms.Label();
            this.nrcapsule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numar = new System.Windows.Forms.TextBox();
            this.data_expirare = new System.Windows.Forms.TextBox();
            this.afectiune = new System.Windows.Forms.TextBox();
            this.afisare = new System.Windows.Forms.ListBox();
            this.adaugare = new System.Windows.Forms.Button();
            this.afisare_med = new System.Windows.Forms.Button();
            this.cautare = new System.Windows.Forms.Button();
            this.modificare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(48, 32);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(49, 20);
            this.nume.TabIndex = 0;
            this.nume.Text = "Nume";
            // 
            // nrcapsule
            // 
            this.nrcapsule.AutoSize = true;
            this.nrcapsule.Location = new System.Drawing.Point(240, 32);
            this.nrcapsule.Name = "nrcapsule";
            this.nrcapsule.Size = new System.Drawing.Size(110, 20);
            this.nrcapsule.TabIndex = 1;
            this.nrcapsule.Text = "Numar Capsule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Afisare";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(48, 136);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(120, 20);
            this.data.TabIndex = 3;
            this.data.Text = "Data de expirare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Afectiune";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numar
            // 
            this.numar.Location = new System.Drawing.Point(240, 78);
            this.numar.Name = "numar";
            this.numar.Size = new System.Drawing.Size(125, 27);
            this.numar.TabIndex = 6;
            // 
            // data_expirare
            // 
            this.data_expirare.Location = new System.Drawing.Point(48, 190);
            this.data_expirare.Name = "data_expirare";
            this.data_expirare.Size = new System.Drawing.Size(125, 27);
            this.data_expirare.TabIndex = 7;
            // 
            // afectiune
            // 
            this.afectiune.Location = new System.Drawing.Point(240, 190);
            this.afectiune.Name = "afectiune";
            this.afectiune.Size = new System.Drawing.Size(125, 27);
            this.afectiune.TabIndex = 8;
            // 
            // afisare
            // 
            this.afisare.FormattingEnabled = true;
            this.afisare.ItemHeight = 20;
            this.afisare.Location = new System.Drawing.Point(376, 33);
            this.afisare.Name = "afisare";
            this.afisare.Size = new System.Drawing.Size(380, 184);
            this.afisare.TabIndex = 9;
            // 
            // adaugare
            // 
            this.adaugare.Location = new System.Drawing.Point(44, 377);
            this.adaugare.Name = "adaugare";
            this.adaugare.Size = new System.Drawing.Size(94, 29);
            this.adaugare.TabIndex = 10;
            this.adaugare.Text = "Adaugare";
            this.adaugare.UseVisualStyleBackColor = true;
            this.adaugare.Click += new System.EventHandler(this.adaugare_Click);
            // 
            // afisare_med
            // 
            this.afisare_med.Location = new System.Drawing.Point(214, 377);
            this.afisare_med.Name = "afisare_med";
            this.afisare_med.Size = new System.Drawing.Size(94, 29);
            this.afisare_med.TabIndex = 11;
            this.afisare_med.Text = "Afisare";
            this.afisare_med.UseVisualStyleBackColor = true;
            this.afisare_med.Click += new System.EventHandler(this.afisare_med_Click);
            // 
            // cautare
            // 
            this.cautare.Location = new System.Drawing.Point(376, 377);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(94, 29);
            this.cautare.TabIndex = 12;
            this.cautare.Text = "Cautare";
            this.cautare.UseVisualStyleBackColor = true;
            this.cautare.Click += new System.EventHandler(this.cautare_Click);
            // 
            // modificare
            // 
            this.modificare.Location = new System.Drawing.Point(527, 377);
            this.modificare.Name = "modificare";
            this.modificare.Size = new System.Drawing.Size(94, 29);
            this.modificare.TabIndex = 13;
            this.modificare.Text = "Modificare";
            this.modificare.UseVisualStyleBackColor = true;
            this.modificare.Click += new System.EventHandler(this.modificare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescriptie";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "fara reteta";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "retata";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(386, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "sticla";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "comprimate";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modificare);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.afisare_med);
            this.Controls.Add(this.adaugare);
            this.Controls.Add(this.afisare);
            this.Controls.Add(this.afectiune);
            this.Controls.Add(this.data_expirare);
            this.Controls.Add(this.numar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nrcapsule);
            this.Controls.Add(this.nume);
            this.Name = "Form1";
            this.Text = "Medicament";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label nrcapsule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox numar;
        private System.Windows.Forms.TextBox data_expirare;
        private System.Windows.Forms.TextBox afectiune;
        private System.Windows.Forms.ListBox afisare;
        private System.Windows.Forms.Button adaugare;
        private System.Windows.Forms.Button afisare_med;
        private System.Windows.Forms.Button cautare;
        private System.Windows.Forms.Button modificare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

