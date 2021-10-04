
namespace CalculoMédiaAluno
{
    partial class TelaEntradaDados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dTPNacimento = new System.Windows.Forms.DateTimePicker();
            this.nAtiv01 = new System.Windows.Forms.NumericUpDown();
            this.nAtiv02 = new System.Windows.Forms.NumericUpDown();
            this.nAtiv03 = new System.Windows.Forms.NumericUpDown();
            this.nAtiv04 = new System.Windows.Forms.NumericUpDown();
            this.nMedia = new System.Windows.Forms.NumericUpDown();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lBResul = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculando a Média dos Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(62, 115);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(265, 31);
            this.tbNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Insira as Notas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Atividade 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Atividade 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Atividade 3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Atividade 4:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Média:";
            // 
            // dTPNacimento
            // 
            this.dTPNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNacimento.Location = new System.Drawing.Point(421, 115);
            this.dTPNacimento.Name = "dTPNacimento";
            this.dTPNacimento.Size = new System.Drawing.Size(152, 31);
            this.dTPNacimento.TabIndex = 10;
            // 
            // nAtiv01
            // 
            this.nAtiv01.Location = new System.Drawing.Point(214, 203);
            this.nAtiv01.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv01.Name = "nAtiv01";
            this.nAtiv01.Size = new System.Drawing.Size(70, 31);
            this.nAtiv01.TabIndex = 11;
            this.nAtiv01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nAtiv02
            // 
            this.nAtiv02.Location = new System.Drawing.Point(214, 239);
            this.nAtiv02.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv02.Name = "nAtiv02";
            this.nAtiv02.Size = new System.Drawing.Size(70, 31);
            this.nAtiv02.TabIndex = 12;
            this.nAtiv02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nAtiv03
            // 
            this.nAtiv03.Location = new System.Drawing.Point(214, 277);
            this.nAtiv03.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv03.Name = "nAtiv03";
            this.nAtiv03.Size = new System.Drawing.Size(70, 31);
            this.nAtiv03.TabIndex = 13;
            this.nAtiv03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nAtiv04
            // 
            this.nAtiv04.Location = new System.Drawing.Point(214, 311);
            this.nAtiv04.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv04.Name = "nAtiv04";
            this.nAtiv04.Size = new System.Drawing.Size(70, 31);
            this.nAtiv04.TabIndex = 14;
            this.nAtiv04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nMedia
            // 
            this.nMedia.Location = new System.Drawing.Point(214, 348);
            this.nMedia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nMedia.Name = "nMedia";
            this.nMedia.Size = new System.Drawing.Size(70, 31);
            this.nMedia.TabIndex = 15;
            this.nMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(140, 394);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(112, 34);
            this.btnMedia.TabIndex = 16;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lBResul
            // 
            this.lBResul.FormattingEnabled = true;
            this.lBResul.ItemHeight = 25;
            this.lBResul.Location = new System.Drawing.Point(342, 174);
            this.lBResul.Name = "lBResul";
            this.lBResul.Size = new System.Drawing.Size(275, 254);
            this.lBResul.TabIndex = 17;
            // 
            // TelaEntradaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.lBResul);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.nMedia);
            this.Controls.Add(this.nAtiv04);
            this.Controls.Add(this.nAtiv03);
            this.Controls.Add(this.nAtiv02);
            this.Controls.Add(this.nAtiv01);
            this.Controls.Add(this.dTPNacimento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaEntradaDados";
            this.Text = "Média dos Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dTPNacimento;
        private System.Windows.Forms.NumericUpDown nAtiv01;
        private System.Windows.Forms.NumericUpDown nAtiv02;
        private System.Windows.Forms.NumericUpDown nAtiv03;
        private System.Windows.Forms.NumericUpDown nAtiv04;
        private System.Windows.Forms.NumericUpDown nMedia;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.ListBox lBResul;
    }
}

