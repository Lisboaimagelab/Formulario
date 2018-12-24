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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Janelerator));
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tamanhoX
            // 
            this.tamanhoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanhoX.Location = new System.Drawing.Point(159, 178);
            this.tamanhoX.Name = "tamanhoX";
            this.tamanhoX.Size = new System.Drawing.Size(120, 26);
            this.tamanhoX.TabIndex = 0;
            this.tamanhoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tamanhoX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tamanhoY
            // 
            this.tamanhoY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tamanhoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanhoY.Location = new System.Drawing.Point(306, 259);
            this.tamanhoY.Name = "tamanhoY";
            this.tamanhoY.Size = new System.Drawing.Size(120, 26);
            this.tamanhoY.TabIndex = 2;
            this.tamanhoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tamanhoY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelTamanhoX
            // 
            this.labelTamanhoX.BackColor = System.Drawing.Color.Green;
            this.labelTamanhoX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanhoX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTamanhoX.Location = new System.Drawing.Point(170, 156);
            this.labelTamanhoX.Name = "labelTamanhoX";
            this.labelTamanhoX.Size = new System.Drawing.Size(99, 25);
            this.labelTamanhoX.TabIndex = 3;
            this.labelTamanhoX.Text = "LARGURA";
            this.labelTamanhoX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTamanhoX.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTamanhoY
            // 
            this.labelTamanhoY.BackColor = System.Drawing.Color.Green;
            this.labelTamanhoY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanhoY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTamanhoY.Location = new System.Drawing.Point(324, 237);
            this.labelTamanhoY.Name = "labelTamanhoY";
            this.labelTamanhoY.Size = new System.Drawing.Size(84, 25);
            this.labelTamanhoY.TabIndex = 4;
            this.labelTamanhoY.Text = "ALTURA";
            this.labelTamanhoY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTamanhoY.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Green;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Location = new System.Drawing.Point(606, 40);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(187, 57);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoDeJanela
            // 
            this.tipoDeJanela.AllowDrop = true;
            this.tipoDeJanela.DropDownHeight = 180;
            this.tipoDeJanela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDeJanela.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tipoDeJanela.FormattingEnabled = true;
            this.tipoDeJanela.IntegralHeight = false;
            this.tipoDeJanela.ItemHeight = 21;
            this.tipoDeJanela.Items.AddRange(new object[] {
            "arroCortizo 2 Dobradiças",
            "arroCortizo 4 Dobradiças",
            "arroAvangard 2 Dobradiças",
            "arroAvangard 4 Dobradiças",
            "folhaCortizo",
            "folhaAvangard"});
            this.tipoDeJanela.Location = new System.Drawing.Point(57, 69);
            this.tipoDeJanela.Name = "tipoDeJanela";
            this.tipoDeJanela.Size = new System.Drawing.Size(320, 29);
            this.tipoDeJanela.TabIndex = 10;
            this.tipoDeJanela.Text = "Escolhe um tipo de janela";
            this.tipoDeJanela.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTipoDeJanela
            // 
            this.labelTipoDeJanela.AutoSize = true;
            this.labelTipoDeJanela.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDeJanela.Location = new System.Drawing.Point(52, 37);
            this.labelTipoDeJanela.Name = "labelTipoDeJanela";
            this.labelTipoDeJanela.Size = new System.Drawing.Size(136, 25);
            this.labelTipoDeJanela.TabIndex = 11;
            this.labelTipoDeJanela.Text = "Tipo de janela\r\n";
            this.labelTipoDeJanela.Click += new System.EventHandler(this.label3_Click);
            // 
            // motorX
            // 
            this.motorX.Location = new System.Drawing.Point(542, 271);
            this.motorX.Maximum = 3000;
            this.motorX.Name = "motorX";
            this.motorX.Size = new System.Drawing.Size(251, 23);
            this.motorX.TabIndex = 12;
            this.motorX.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // checkBoxSensorHomeX
            // 
            this.checkBoxSensorHomeX.AutoSize = true;
            this.checkBoxSensorHomeX.Location = new System.Drawing.Point(800, 271);
            this.checkBoxSensorHomeX.Name = "checkBoxSensorHomeX";
            this.checkBoxSensorHomeX.Size = new System.Drawing.Size(35, 21);
            this.checkBoxSensorHomeX.TabIndex = 20;
            this.checkBoxSensorHomeX.Text = "X";
            this.checkBoxSensorHomeX.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensorHomeY1
            // 
            this.checkBoxSensorHomeY1.AutoSize = true;
            this.checkBoxSensorHomeY1.Location = new System.Drawing.Point(800, 301);
            this.checkBoxSensorHomeY1.Name = "checkBoxSensorHomeY1";
            this.checkBoxSensorHomeY1.Size = new System.Drawing.Size(53, 21);
            this.checkBoxSensorHomeY1.TabIndex = 21;
            this.checkBoxSensorHomeY1.Text = "Y-S1";
            this.checkBoxSensorHomeY1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensorHomeY2
            // 
            this.checkBoxSensorHomeY2.AutoSize = true;
            this.checkBoxSensorHomeY2.Location = new System.Drawing.Point(800, 330);
            this.checkBoxSensorHomeY2.Name = "checkBoxSensorHomeY2";
            this.checkBoxSensorHomeY2.Size = new System.Drawing.Size(53, 21);
            this.checkBoxSensorHomeY2.TabIndex = 22;
            this.checkBoxSensorHomeY2.Text = "Y-S2";
            this.checkBoxSensorHomeY2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox4.Location = new System.Drawing.Point(705, 200);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 22);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.UseWaitCursor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
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
            this.checkBoxFuroDobradicaDireita.Location = new System.Drawing.Point(862, 329);
            this.checkBoxFuroDobradicaDireita.Name = "checkBoxFuroDobradicaDireita";
            this.checkBoxFuroDobradicaDireita.Size = new System.Drawing.Size(81, 22);
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
            this.checkBoxFuroDobradicaEsquerda.Location = new System.Drawing.Point(939, 329);
            this.checkBoxFuroDobradicaEsquerda.Name = "checkBoxFuroDobradicaEsquerda";
            this.checkBoxFuroDobradicaEsquerda.Size = new System.Drawing.Size(79, 22);
            this.checkBoxFuroDobradicaEsquerda.TabIndex = 26;
            this.checkBoxFuroDobradicaEsquerda.Text = "Furo DE";
            this.checkBoxFuroDobradicaEsquerda.UseVisualStyleBackColor = true;
            this.checkBoxFuroDobradicaEsquerda.UseWaitCursor = true;
            // 
            // motorY1
            // 
            this.motorY1.Location = new System.Drawing.Point(542, 301);
            this.motorY1.Name = "motorY1";
            this.motorY1.Size = new System.Drawing.Size(251, 23);
            this.motorY1.TabIndex = 27;
            // 
            // motorY2
            // 
            this.motorY2.Location = new System.Drawing.Point(542, 330);
            this.motorY2.Name = "motorY2";
            this.motorY2.Size = new System.Drawing.Size(251, 23);
            this.motorY2.TabIndex = 28;
            // 
            // motorManeteX
            // 
            this.motorManeteX.Location = new System.Drawing.Point(542, 361);
            this.motorManeteX.Name = "motorManeteX";
            this.motorManeteX.Size = new System.Drawing.Size(251, 23);
            this.motorManeteX.TabIndex = 29;
            // 
            // motorManeteZ
            // 
            this.motorManeteZ.Location = new System.Drawing.Point(542, 390);
            this.motorManeteZ.Name = "motorManeteZ";
            this.motorManeteZ.Size = new System.Drawing.Size(251, 23);
            this.motorManeteZ.TabIndex = 30;
            // 
            // motorMontagemD
            // 
            this.motorMontagemD.Location = new System.Drawing.Point(542, 421);
            this.motorMontagemD.Name = "motorMontagemD";
            this.motorMontagemD.Size = new System.Drawing.Size(251, 23);
            this.motorMontagemD.TabIndex = 31;
            // 
            // motorMontagemE
            // 
            this.motorMontagemE.Location = new System.Drawing.Point(542, 450);
            this.motorMontagemE.Name = "motorMontagemE";
            this.motorMontagemE.Size = new System.Drawing.Size(251, 23);
            this.motorMontagemE.TabIndex = 32;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(542, 481);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(251, 23);
            this.progressBar8.TabIndex = 33;
            // 
            // progressBar9
            // 
            this.progressBar9.Location = new System.Drawing.Point(542, 510);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(251, 23);
            this.progressBar9.TabIndex = 34;
            // 
            // progressBar10
            // 
            this.progressBar10.Location = new System.Drawing.Point(542, 541);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(251, 23);
            this.progressBar10.TabIndex = 35;
            // 
            // labelMotorX
            // 
            this.labelMotorX.AutoSize = true;
            this.labelMotorX.Location = new System.Drawing.Point(486, 275);
            this.labelMotorX.Name = "labelMotorX";
            this.labelMotorX.Size = new System.Drawing.Size(52, 17);
            this.labelMotorX.TabIndex = 36;
            this.labelMotorX.Text = "motorX";
            this.labelMotorX.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelMotorY1
            // 
            this.labelMotorY1.AutoSize = true;
            this.labelMotorY1.Location = new System.Drawing.Point(480, 303);
            this.labelMotorY1.Name = "labelMotorY1";
            this.labelMotorY1.Size = new System.Drawing.Size(58, 17);
            this.labelMotorY1.TabIndex = 37;
            this.labelMotorY1.Text = "motorY1";
            this.labelMotorY1.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelMotorManeteX
            // 
            this.labelMotorManeteX.AutoSize = true;
            this.labelMotorManeteX.Location = new System.Drawing.Point(442, 363);
            this.labelMotorManeteX.Name = "labelMotorManeteX";
            this.labelMotorManeteX.Size = new System.Drawing.Size(96, 17);
            this.labelMotorManeteX.TabIndex = 38;
            this.labelMotorManeteX.Text = "motorManeteX";
            // 
            // labelMotorY2
            // 
            this.labelMotorY2.AutoSize = true;
            this.labelMotorY2.Location = new System.Drawing.Point(480, 333);
            this.labelMotorY2.Name = "labelMotorY2";
            this.labelMotorY2.Size = new System.Drawing.Size(58, 17);
            this.labelMotorY2.TabIndex = 38;
            this.labelMotorY2.Text = "motorY2";
            // 
            // labelMotorManeteZ
            // 
            this.labelMotorManeteZ.AutoSize = true;
            this.labelMotorManeteZ.Location = new System.Drawing.Point(443, 394);
            this.labelMotorManeteZ.Name = "labelMotorManeteZ";
            this.labelMotorManeteZ.Size = new System.Drawing.Size(95, 17);
            this.labelMotorManeteZ.TabIndex = 39;
            this.labelMotorManeteZ.Text = "motorManeteZ";
            // 
            // checkBoxFrezadoManeteX
            // 
            this.checkBoxFrezadoManeteX.AutoSize = true;
            this.checkBoxFrezadoManeteX.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxFrezadoManeteX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFrezadoManeteX.Location = new System.Drawing.Point(800, 361);
            this.checkBoxFrezadoManeteX.Name = "checkBoxFrezadoManeteX";
            this.checkBoxFrezadoManeteX.Size = new System.Drawing.Size(104, 22);
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
            this.checkBox8.Location = new System.Drawing.Point(800, 390);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(103, 22);
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
            this.checkBoxManeteManeteX.Location = new System.Drawing.Point(900, 361);
            this.checkBoxManeteManeteX.Name = "checkBoxManeteManeteX";
            this.checkBoxManeteManeteX.Size = new System.Drawing.Size(83, 22);
            this.checkBoxManeteManeteX.TabIndex = 42;
            this.checkBoxManeteManeteX.Text = "Furo MX";
            this.checkBoxManeteManeteX.UseVisualStyleBackColor = true;
            this.checkBoxManeteManeteX.UseWaitCursor = true;
            this.checkBoxManeteManeteX.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "motorMontagemD";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
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
            this.alertErro.Location = new System.Drawing.Point(57, 110);
            this.alertErro.Name = "alertErro";
            this.alertErro.Size = new System.Drawing.Size(2, 20);
            this.alertErro.TabIndex = 45;
            this.alertErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 25);
            this.textBox1.TabIndex = 47;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(39, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 320);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // Janelerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 638);
            this.Controls.Add(this.labelTamanhoY);
            this.Controls.Add(this.tamanhoY);
            this.Controls.Add(this.labelTamanhoX);
            this.Controls.Add(this.tamanhoX);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Janelerator";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Janelerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

