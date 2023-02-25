namespace Projeto_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Grb_Sexo = new System.Windows.Forms.GroupBox();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Rdb_feminino = new System.Windows.Forms.RadioButton();
            this.Grb_Exames = new System.Windows.Forms.GroupBox();
            this.Chb_Sangue = new System.Windows.Forms.CheckBox();
            this.Chb_Prostata = new System.Windows.Forms.CheckBox();
            this.Chb_Coracao = new System.Windows.Forms.CheckBox();
            this.Chb_Ortopedico = new System.Windows.Forms.CheckBox();
            this.Chb_Mamografia = new System.Windows.Forms.CheckBox();
            this.Chb_Gravidez = new System.Windows.Forms.CheckBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Grb_Sexo.SuspendLayout();
            this.Grb_Exames.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(36, 57);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(299, 20);
            this.Txt_Nome.TabIndex = 1;
            // 
            // Grb_Sexo
            // 
            this.Grb_Sexo.Controls.Add(this.Rdb_Masculino);
            this.Grb_Sexo.Controls.Add(this.Rdb_feminino);
            this.Grb_Sexo.Location = new System.Drawing.Point(36, 83);
            this.Grb_Sexo.Name = "Grb_Sexo";
            this.Grb_Sexo.Size = new System.Drawing.Size(90, 100);
            this.Grb_Sexo.TabIndex = 2;
            this.Grb_Sexo.TabStop = false;
            this.Grb_Sexo.Text = "Sexo";
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(6, 42);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(73, 17);
            this.Rdb_Masculino.TabIndex = 1;
            this.Rdb_Masculino.Text = "Masculino";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            this.Rdb_Masculino.Click += new System.EventHandler(this.Rdb_Masculino_Click);
            // 
            // Rdb_feminino
            // 
            this.Rdb_feminino.AutoSize = true;
            this.Rdb_feminino.Checked = true;
            this.Rdb_feminino.Location = new System.Drawing.Point(6, 19);
            this.Rdb_feminino.Name = "Rdb_feminino";
            this.Rdb_feminino.Size = new System.Drawing.Size(67, 17);
            this.Rdb_feminino.TabIndex = 0;
            this.Rdb_feminino.TabStop = true;
            this.Rdb_feminino.Text = "Feminino";
            this.Rdb_feminino.UseVisualStyleBackColor = true;
            this.Rdb_feminino.Click += new System.EventHandler(this.Rdb_feminino_Click);
            // 
            // Grb_Exames
            // 
            this.Grb_Exames.Controls.Add(this.Chb_Sangue);
            this.Grb_Exames.Controls.Add(this.Chb_Prostata);
            this.Grb_Exames.Controls.Add(this.Chb_Coracao);
            this.Grb_Exames.Controls.Add(this.Chb_Ortopedico);
            this.Grb_Exames.Controls.Add(this.Chb_Mamografia);
            this.Grb_Exames.Controls.Add(this.Chb_Gravidez);
            this.Grb_Exames.Location = new System.Drawing.Point(132, 83);
            this.Grb_Exames.Name = "Grb_Exames";
            this.Grb_Exames.Size = new System.Drawing.Size(270, 100);
            this.Grb_Exames.TabIndex = 3;
            this.Grb_Exames.TabStop = false;
            this.Grb_Exames.Text = "Exames";
            // 
            // Chb_Sangue
            // 
            this.Chb_Sangue.AutoSize = true;
            this.Chb_Sangue.Location = new System.Drawing.Point(80, 65);
            this.Chb_Sangue.Name = "Chb_Sangue";
            this.Chb_Sangue.Size = new System.Drawing.Size(63, 17);
            this.Chb_Sangue.TabIndex = 6;
            this.Chb_Sangue.Text = "Sangue";
            this.Chb_Sangue.UseVisualStyleBackColor = true;
            this.Chb_Sangue.Click += new System.EventHandler(this.Chb_Sangue_Click);
            // 
            // Chb_Prostata
            // 
            this.Chb_Prostata.AutoSize = true;
            this.Chb_Prostata.Location = new System.Drawing.Point(6, 65);
            this.Chb_Prostata.Name = "Chb_Prostata";
            this.Chb_Prostata.Size = new System.Drawing.Size(65, 17);
            this.Chb_Prostata.TabIndex = 4;
            this.Chb_Prostata.Text = "Próstata";
            this.Chb_Prostata.UseVisualStyleBackColor = true;
            this.Chb_Prostata.Click += new System.EventHandler(this.Chb_Prostata_Click);
            // 
            // Chb_Coracao
            // 
            this.Chb_Coracao.AutoSize = true;
            this.Chb_Coracao.Location = new System.Drawing.Point(6, 19);
            this.Chb_Coracao.Name = "Chb_Coracao";
            this.Chb_Coracao.Size = new System.Drawing.Size(66, 17);
            this.Chb_Coracao.TabIndex = 3;
            this.Chb_Coracao.Text = "Coração";
            this.Chb_Coracao.UseVisualStyleBackColor = true;
            this.Chb_Coracao.Click += new System.EventHandler(this.Chb_Coracao_Click);
            // 
            // Chb_Ortopedico
            // 
            this.Chb_Ortopedico.AutoSize = true;
            this.Chb_Ortopedico.Location = new System.Drawing.Point(80, 42);
            this.Chb_Ortopedico.Name = "Chb_Ortopedico";
            this.Chb_Ortopedico.Size = new System.Drawing.Size(78, 17);
            this.Chb_Ortopedico.TabIndex = 2;
            this.Chb_Ortopedico.Text = "Ortopédico";
            this.Chb_Ortopedico.UseVisualStyleBackColor = true;
            this.Chb_Ortopedico.Click += new System.EventHandler(this.Chb_Ortopedico_Click);
            // 
            // Chb_Mamografia
            // 
            this.Chb_Mamografia.AutoSize = true;
            this.Chb_Mamografia.Location = new System.Drawing.Point(80, 19);
            this.Chb_Mamografia.Name = "Chb_Mamografia";
            this.Chb_Mamografia.Size = new System.Drawing.Size(81, 17);
            this.Chb_Mamografia.TabIndex = 1;
            this.Chb_Mamografia.Text = "Mamografia";
            this.Chb_Mamografia.UseVisualStyleBackColor = true;
            this.Chb_Mamografia.Click += new System.EventHandler(this.Chb_Mamografia_Click);
            // 
            // Chb_Gravidez
            // 
            this.Chb_Gravidez.AutoSize = true;
            this.Chb_Gravidez.Location = new System.Drawing.Point(6, 42);
            this.Chb_Gravidez.Name = "Chb_Gravidez";
            this.Chb_Gravidez.Size = new System.Drawing.Size(68, 17);
            this.Chb_Gravidez.TabIndex = 0;
            this.Chb_Gravidez.Text = "Gravidez";
            this.Chb_Gravidez.UseVisualStyleBackColor = true;
            this.Chb_Gravidez.Click += new System.EventHandler(this.Chb_Gravidez_Click);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(357, 201);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(45, 24);
            this.Lbl_Total.TabIndex = 4;
            this.Lbl_Total.Text = "0,00";
            this.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 326);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Grb_Exames);
            this.Controls.Add(this.Grb_Sexo);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Clínica UNIFUNEC - 2023";
            this.Grb_Sexo.ResumeLayout(false);
            this.Grb_Sexo.PerformLayout();
            this.Grb_Exames.ResumeLayout(false);
            this.Grb_Exames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.GroupBox Grb_Sexo;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.RadioButton Rdb_feminino;
        private System.Windows.Forms.GroupBox Grb_Exames;
        private System.Windows.Forms.CheckBox Chb_Sangue;
        private System.Windows.Forms.CheckBox Chb_Prostata;
        private System.Windows.Forms.CheckBox Chb_Coracao;
        private System.Windows.Forms.CheckBox Chb_Ortopedico;
        private System.Windows.Forms.CheckBox Chb_Mamografia;
        private System.Windows.Forms.CheckBox Chb_Gravidez;
        private System.Windows.Forms.Label Lbl_Total;
    }
}

