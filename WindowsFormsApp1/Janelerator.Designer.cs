namespace WindowsFormsApp1
{
    partial class Janelerator
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
            this.components = new System.ComponentModel.Container();
            this.tamanhoX = new System.Windows.Forms.TextBox();
            this.tamanhoY = new System.Windows.Forms.TextBox();
            this.labelTamanhoX = new System.Windows.Forms.Label();
            this.labelTamanhoY = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tipoDeJanela = new System.Windows.Forms.ComboBox();
            this.labelTipoDeJanela = new System.Windows.Forms.Label();
            this.motorX = new System.Windows.Forms.ProgressBar();
            this.checkBoxSensorHomeX = new System.Windows.Forms.CheckBox();
            this.checkBoxSensorHomeY1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensorHomeY2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxFuroDobradicaDireita = new System.Windows.Forms.CheckBox();
            this.checkBoxFuroDobradicaEsquerda = new System.Windows.Forms.CheckBox();
            this.motorY1 = new System.Windows.Forms.ProgressBar();
            this.motorY2 = new System.Windows.Forms.ProgressBar();
            this.motorManeteX = new System.Windows.Forms.ProgressBar();
            this.motorManeteZ = new System.Windows.Forms.ProgressBar();
            this.motorMontagemD = new System.Windows.Forms.ProgressBar();
            this.motorMontagemE = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.labelMotorX = new System.Windows.Forms.Label();
            this.labelMotorY1 = new System.Windows.Forms.Label();
            this.labelMotorManeteX = new System.Windows.Forms.Label();
            this.labelMotorY2 = new System.Windows.Forms.Label();
            this.labelMotorManeteZ = new System.Windows.Forms.Label();
            this.checkBoxFrezadoManeteX = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBoxManeteManeteX = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alertErro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tamanhoX
            // 
            this.tamanhoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanhoX.Location = new System.Drawing.Point(128, 129);
            this.tamanhoX.Name = "tamanhoX";
            this.tamanhoX.Size = new System.Drawing.Size(110, 26);
            this.tamanhoX.TabIndex = 0;
            this.tamanhoX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tamanhoY
            // 
            this.tamanhoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanhoY.Location = new System.Drawing.Point(290, 129);
            this.tamanhoY.Name = "tamanhoY";
            this.tamanhoY.Size = new System.Drawing.Size(110, 26);
            this.tamanhoY.TabIndex = 2;
            this.tamanhoY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelTamanhoX
            // 
            this.labelTamanhoX.AutoSize = true;
            this.labelTamanhoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanhoX.Location = new System.Drawing.Point(103, 132);
            this.labelTamanhoX.Name = "labelTamanhoX";
            this.labelTamanhoX.Size = new System.Drawing.Size(20, 20);
            this.labelTamanhoX.TabIndex = 3;
            this.labelTamanhoX.Text = "X";
            this.labelTamanhoX.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTamanhoY
            // 
            this.labelTamanhoY.AutoSize = true;
            this.labelTamanhoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanhoY.Location = new System.Drawing.Point(268, 132);
            this.labelTamanhoY.Name = "labelTamanhoY";
            this.labelTamanhoY.Size = new System.Drawing.Size(20, 20);
            this.labelTamanhoY.TabIndex = 4;
            this.labelTamanhoY.Text = "Y";
            this.labelTamanhoY.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Location = new System.Drawing.Point(728, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(141, 52);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoDeJanela
            // 
            this.tipoDeJanela.AllowDrop = true;
            this.tipoDeJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDeJanela.FormattingEnabled = true;
            this.tipoDeJanela.ItemHeight = 20;
            this.tipoDeJanela.Items.AddRange(new object[] {
            "arroCortizo 2 Dobradiças",
            "arroCortizo 4 Dobradiças",
            "arroAvangard 2 Dobradiças",
            "arroAvangard 4 Dobradiças",
            "folhaCortizo",
            "folhaAvangard"});
            this.tipoDeJanela.Location = new System.Drawing.Point(128, 94);
            this.tipoDeJanela.Name = "tipoDeJanela";
            this.tipoDeJanela.Size = new System.Drawing.Size(272, 28);
            this.tipoDeJanela.TabIndex = 10;
            this.tipoDeJanela.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTipoDeJanela
            // 
            this.labelTipoDeJanela.AutoSize = true;
            this.labelTipoDeJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDeJanela.Location = new System.Drawing.Point(20, 98);
            this.labelTipoDeJanela.Name = "labelTipoDeJanela";
            this.labelTipoDeJanela.Size = new System.Drawing.Size(107, 20);
            this.labelTipoDeJanela.TabIndex = 11;
            this.labelTipoDeJanela.Text = "Tipo de janela\r\n";
            this.labelTipoDeJanela.Click += new System.EventHandler(this.label3_Click);
            // 
            // motorX
            // 
            this.motorX.Location = new System.Drawing.Point(128, 223);
            this.motorX.Maximum = 3000;
            this.motorX.Name = "motorX";
            this.motorX.Size = new System.Drawing.Size(215, 17);
            this.motorX.TabIndex = 12;
            this.motorX.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // checkBoxSensorHomeX
            // 
            this.checkBoxSensorHomeX.AutoSize = true;
            this.checkBoxSensorHomeX.Location = new System.Drawing.Point(349, 223);
            this.checkBoxSensorHomeX.Name = "checkBoxSensorHomeX";
            this.checkBoxSensorHomeX.Size = new System.Drawing.Size(33, 17);
            this.checkBoxSensorHomeX.TabIndex = 20;
            this.checkBoxSensorHomeX.Text = "X";
            this.checkBoxSensorHomeX.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensorHomeY1
            // 
            this.checkBoxSensorHomeY1.AutoSize = true;
            this.checkBoxSensorHomeY1.Location = new System.Drawing.Point(349, 245);
            this.checkBoxSensorHomeY1.Name = "checkBoxSensorHomeY1";
            this.checkBoxSensorHomeY1.Size = new System.Drawing.Size(49, 17);
            this.checkBoxSensorHomeY1.TabIndex = 21;
            this.checkBoxSensorHomeY1.Text = "Y-S1";
            this.checkBoxSensorHomeY1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensorHomeY2
            // 
            this.checkBoxSensorHomeY2.AutoSize = true;
            this.checkBoxSensorHomeY2.Location = new System.Drawing.Point(349, 268);
            this.checkBoxSensorHomeY2.Name = "checkBoxSensorHomeY2";
            this.checkBoxSensorHomeY2.Size = new System.Drawing.Size(49, 17);
            this.checkBoxSensorHomeY2.TabIndex = 22;
            this.checkBoxSensorHomeY2.Text = "Y-S2";
            this.checkBoxSensorHomeY2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox4.Location = new System.Drawing.Point(794, 252);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 18);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.UseWaitCursor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxFuroDobradicaDireita
            // 
            this.checkBoxFuroDobradicaDireita.AutoSize = true;
            this.checkBoxFuroDobradicaDireita.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxFuroDobradicaDireita.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFuroDobradicaDireita.Location = new System.Drawing.Point(402, 267);
            this.checkBoxFuroDobradicaDireita.Name = "checkBoxFuroDobradicaDireita";
            this.checkBoxFuroDobradicaDireita.Size = new System.Drawing.Size(72, 18);
            this.checkBoxFuroDobradicaDireita.TabIndex = 25;
            this.checkBoxFuroDobradicaDireita.Text = "Furo DD";
            this.checkBoxFuroDobradicaDireita.UseVisualStyleBackColor = true;
            this.checkBoxFuroDobradicaDireita.UseWaitCursor = true;
            this.checkBoxFuroDobradicaDireita.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBoxFuroDobradicaEsquerda
            // 
            this.checkBoxFuroDobradicaEsquerda.AutoSize = true;
            this.checkBoxFuroDobradicaEsquerda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxFuroDobradicaEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFuroDobradicaEsquerda.Location = new System.Drawing.Point(468, 267);
            this.checkBoxFuroDobradicaEsquerda.Name = "checkBoxFuroDobradicaEsquerda";
            this.checkBoxFuroDobradicaEsquerda.Size = new System.Drawing.Size(71, 18);
            this.checkBoxFuroDobradicaEsquerda.TabIndex = 26;
            this.checkBoxFuroDobradicaEsquerda.Text = "Furo DE";
            this.checkBoxFuroDobradicaEsquerda.UseVisualStyleBackColor = true;
            this.checkBoxFuroDobradicaEsquerda.UseWaitCursor = true;
            // 
            // motorY1
            // 
            this.motorY1.Location = new System.Drawing.Point(128, 245);
            this.motorY1.Name = "motorY1";
            this.motorY1.Size = new System.Drawing.Size(215, 17);
            this.motorY1.TabIndex = 27;
            // 
            // motorY2
            // 
            this.motorY2.Location = new System.Drawing.Point(128, 268);
            this.motorY2.Name = "motorY2";
            this.motorY2.Size = new System.Drawing.Size(215, 17);
            this.motorY2.TabIndex = 28;
            // 
            // motorManeteX
            // 
            this.motorManeteX.Location = new System.Drawing.Point(128, 291);
            this.motorManeteX.Name = "motorManeteX";
            this.motorManeteX.Size = new System.Drawing.Size(215, 17);
            this.motorManeteX.TabIndex = 29;
            // 
            // motorManeteZ
            // 
            this.motorManeteZ.Location = new System.Drawing.Point(128, 314);
            this.motorManeteZ.Name = "motorManeteZ";
            this.motorManeteZ.Size = new System.Drawing.Size(215, 17);
            this.motorManeteZ.TabIndex = 30;
            // 
            // motorMontagemD
            // 
            this.motorMontagemD.Location = new System.Drawing.Point(128, 337);
            this.motorMontagemD.Name = "motorMontagemD";
            this.motorMontagemD.Size = new System.Drawing.Size(215, 17);
            this.motorMontagemD.TabIndex = 31;
            // 
            // motorMontagemE
            // 
            this.motorMontagemE.Location = new System.Drawing.Point(128, 360);
            this.motorMontagemE.Name = "motorMontagemE";
            this.motorMontagemE.Size = new System.Drawing.Size(215, 17);
            this.motorMontagemE.TabIndex = 32;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(128, 383);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(215, 17);
            this.progressBar8.TabIndex = 33;
            // 
            // progressBar9
            // 
            this.progressBar9.Location = new System.Drawing.Point(128, 406);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(215, 17);
            this.progressBar9.TabIndex = 34;
            // 
            // progressBar10
            // 
            this.progressBar10.Location = new System.Drawing.Point(128, 429);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(215, 17);
            this.progressBar10.TabIndex = 35;
            // 
            // labelMotorX
            // 
            this.labelMotorX.AutoSize = true;
            this.labelMotorX.Location = new System.Drawing.Point(82, 225);
            this.labelMotorX.Name = "labelMotorX";
            this.labelMotorX.Size = new System.Drawing.Size(40, 13);
            this.labelMotorX.TabIndex = 36;
            this.labelMotorX.Text = "motorX";
            this.labelMotorX.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelMotorY1
            // 
            this.labelMotorY1.AutoSize = true;
            this.labelMotorY1.Location = new System.Drawing.Point(76, 247);
            this.labelMotorY1.Name = "labelMotorY1";
            this.labelMotorY1.Size = new System.Drawing.Size(46, 13);
            this.labelMotorY1.TabIndex = 37;
            this.labelMotorY1.Text = "motorY1";
            this.labelMotorY1.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelMotorManeteX
            // 
            this.labelMotorManeteX.AutoSize = true;
            this.labelMotorManeteX.Location = new System.Drawing.Point(46, 293);
            this.labelMotorManeteX.Name = "labelMotorManeteX";
            this.labelMotorManeteX.Size = new System.Drawing.Size(76, 13);
            this.labelMotorManeteX.TabIndex = 38;
            this.labelMotorManeteX.Text = "motorManeteX";
            // 
            // labelMotorY2
            // 
            this.labelMotorY2.AutoSize = true;
            this.labelMotorY2.Location = new System.Drawing.Point(76, 270);
            this.labelMotorY2.Name = "labelMotorY2";
            this.labelMotorY2.Size = new System.Drawing.Size(46, 13);
            this.labelMotorY2.TabIndex = 38;
            this.labelMotorY2.Text = "motorY2";
            // 
            // labelMotorManeteZ
            // 
            this.labelMotorManeteZ.AutoSize = true;
            this.labelMotorManeteZ.Location = new System.Drawing.Point(46, 316);
            this.labelMotorManeteZ.Name = "labelMotorManeteZ";
            this.labelMotorManeteZ.Size = new System.Drawing.Size(76, 13);
            this.labelMotorManeteZ.TabIndex = 39;
            this.labelMotorManeteZ.Text = "motorManeteZ";
            // 
            // checkBoxFrezadoManeteX
            // 
            this.checkBoxFrezadoManeteX.AutoSize = true;
            this.checkBoxFrezadoManeteX.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxFrezadoManeteX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFrezadoManeteX.Location = new System.Drawing.Point(349, 291);
            this.checkBoxFrezadoManeteX.Name = "checkBoxFrezadoManeteX";
            this.checkBoxFrezadoManeteX.Size = new System.Drawing.Size(89, 18);
            this.checkBoxFrezadoManeteX.TabIndex = 40;
            this.checkBoxFrezadoManeteX.Text = "Frezado MX";
            this.checkBoxFrezadoManeteX.UseVisualStyleBackColor = true;
            this.checkBoxFrezadoManeteX.UseWaitCursor = true;
            this.checkBoxFrezadoManeteX.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox8.Location = new System.Drawing.Point(349, 314);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(89, 18);
            this.checkBox8.TabIndex = 41;
            this.checkBox8.Text = "Frezado MZ";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.UseWaitCursor = true;
            // 
            // checkBoxManeteManeteX
            // 
            this.checkBoxManeteManeteX.AutoSize = true;
            this.checkBoxManeteManeteX.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxManeteManeteX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxManeteManeteX.Location = new System.Drawing.Point(435, 291);
            this.checkBoxManeteManeteX.Name = "checkBoxManeteManeteX";
            this.checkBoxManeteManeteX.Size = new System.Drawing.Size(72, 18);
            this.checkBoxManeteManeteX.TabIndex = 42;
            this.checkBoxManeteManeteX.Text = "Furo MX";
            this.checkBoxManeteManeteX.UseVisualStyleBackColor = true;
            this.checkBoxManeteManeteX.UseWaitCursor = true;
            this.checkBoxManeteManeteX.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "motorMontagemD";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "motorMontagemE";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alertErro
            // 
            this.alertErro.AutoSize = true;
            this.alertErro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.alertErro.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertErro.ForeColor = System.Drawing.Color.Red;
            this.alertErro.Location = new System.Drawing.Point(443, 94);
            this.alertErro.Name = "alertErro";
            this.alertErro.Size = new System.Drawing.Size(2, 20);
            this.alertErro.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 248);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(664, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 47;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Janelerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 585);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.alertErro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxManeteManeteX);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBoxFrezadoManeteX);
            this.Controls.Add(this.labelMotorManeteZ);
            this.Controls.Add(this.labelMotorY2);
            this.Controls.Add(this.labelMotorManeteX);
            this.Controls.Add(this.labelMotorY1);
            this.Controls.Add(this.labelMotorX);
            this.Controls.Add(this.progressBar10);
            this.Controls.Add(this.progressBar9);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.motorMontagemE);
            this.Controls.Add(this.motorMontagemD);
            this.Controls.Add(this.motorManeteZ);
            this.Controls.Add(this.motorManeteX);
            this.Controls.Add(this.motorY2);
            this.Controls.Add(this.motorY1);
            this.Controls.Add(this.checkBoxFuroDobradicaEsquerda);
            this.Controls.Add(this.checkBoxFuroDobradicaDireita);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBoxSensorHomeY2);
            this.Controls.Add(this.checkBoxSensorHomeY1);
            this.Controls.Add(this.checkBoxSensorHomeX);
            this.Controls.Add(this.motorX);
            this.Controls.Add(this.labelTipoDeJanela);
            this.Controls.Add(this.tipoDeJanela);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTamanhoY);
            this.Controls.Add(this.labelTamanhoX);
            this.Controls.Add(this.tamanhoY);
            this.Controls.Add(this.tamanhoX);
            this.Name = "Janelerator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tamanhoX;
        private System.Windows.Forms.TextBox tamanhoY;
        private System.Windows.Forms.Label labelTamanhoX;
        private System.Windows.Forms.Label labelTamanhoY;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox tipoDeJanela;
        private System.Windows.Forms.Label labelTipoDeJanela;
        private System.Windows.Forms.ProgressBar motorX;
        private System.Windows.Forms.CheckBox checkBoxSensorHomeX;
        private System.Windows.Forms.CheckBox checkBoxSensorHomeY1;
        private System.Windows.Forms.CheckBox checkBoxSensorHomeY2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxFuroDobradicaDireita;
        private System.Windows.Forms.CheckBox checkBoxFuroDobradicaEsquerda;
        private System.Windows.Forms.ProgressBar motorY1;
        private System.Windows.Forms.ProgressBar motorY2;
        private System.Windows.Forms.ProgressBar motorManeteX;
        private System.Windows.Forms.ProgressBar motorManeteZ;
        private System.Windows.Forms.ProgressBar motorMontagemD;
        private System.Windows.Forms.ProgressBar motorMontagemE;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.ProgressBar progressBar10;
        private System.Windows.Forms.Label labelMotorX;
        private System.Windows.Forms.Label labelMotorY1;
        private System.Windows.Forms.Label labelMotorManeteX;
        private System.Windows.Forms.Label labelMotorY2;
        private System.Windows.Forms.Label labelMotorManeteZ;
        private System.Windows.Forms.CheckBox checkBoxFrezadoManeteX;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBoxManeteManeteX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label alertErro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

