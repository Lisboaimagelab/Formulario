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
            this.buttonStart = new System.Windows.Forms.Button();
            this.tipoDeJanela = new System.Windows.Forms.ComboBox();
            this.labelTipoDeJanela = new System.Windows.Forms.Label();
            this.motorX = new System.Windows.Forms.ProgressBar();
            this.checkBoxSensorHomeX = new System.Windows.Forms.CheckBox();
            this.checkBoxSensorHomeY1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensorHomeY2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.home = new System.Windows.Forms.Button();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tamanhoYshadow = new System.Windows.Forms.PictureBox();
            this.tamanhoXshadow = new System.Windows.Forms.PictureBox();
            this.TrackBarMotorX = new MetroFramework.Controls.MetroTrackBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.X = new MetroFramework.Controls.MetroToggle();
            this.lableMotorX = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.metroTrackBar3 = new MetroFramework.Controls.MetroTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoYshadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoXshadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tamanhoX
            // 
            this.tamanhoX.BackColor = System.Drawing.SystemColors.Window;
            this.tamanhoX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tamanhoX, "tamanhoX");
            this.tamanhoX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tamanhoX.Name = "tamanhoX";
            this.tamanhoX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tamanhoY
            // 
            this.tamanhoY.BackColor = System.Drawing.SystemColors.Window;
            this.tamanhoY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tamanhoY, "tamanhoY");
            this.tamanhoY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tamanhoY.Name = "tamanhoY";
            this.tamanhoY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Green;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoDeJanela
            // 
            this.tipoDeJanela.AllowDrop = true;
            this.tipoDeJanela.DropDownHeight = 180;
            resources.ApplyResources(this.tipoDeJanela, "tipoDeJanela");
            this.tipoDeJanela.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tipoDeJanela.FormattingEnabled = true;
            this.tipoDeJanela.Items.AddRange(new object[] {
            resources.GetString("tipoDeJanela.Items"),
            resources.GetString("tipoDeJanela.Items1"),
            resources.GetString("tipoDeJanela.Items2"),
            resources.GetString("tipoDeJanela.Items3"),
            resources.GetString("tipoDeJanela.Items4"),
            resources.GetString("tipoDeJanela.Items5"),
            resources.GetString("tipoDeJanela.Items6"),
            resources.GetString("tipoDeJanela.Items7")});
            this.tipoDeJanela.Name = "tipoDeJanela";
            this.tipoDeJanela.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTipoDeJanela
            // 
            resources.ApplyResources(this.labelTipoDeJanela, "labelTipoDeJanela");
            this.labelTipoDeJanela.Name = "labelTipoDeJanela";
            this.labelTipoDeJanela.Click += new System.EventHandler(this.label3_Click);
            // 
            // motorX
            // 
            resources.ApplyResources(this.motorX, "motorX");
            this.motorX.Maximum = 3000;
            this.motorX.Name = "motorX";
            this.motorX.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // checkBoxSensorHomeX
            // 
            resources.ApplyResources(this.checkBoxSensorHomeX, "checkBoxSensorHomeX");
            this.checkBoxSensorHomeX.Name = "checkBoxSensorHomeX";
            this.checkBoxSensorHomeX.UseVisualStyleBackColor = true;
            this.checkBoxSensorHomeX.CheckedChanged += new System.EventHandler(this.checkBoxSensorHomeX_CheckedChanged);
            // 
            // checkBoxSensorHomeY1
            // 
            resources.ApplyResources(this.checkBoxSensorHomeY1, "checkBoxSensorHomeY1");
            this.checkBoxSensorHomeY1.Name = "checkBoxSensorHomeY1";
            this.checkBoxSensorHomeY1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensorHomeY2
            // 
            resources.ApplyResources(this.checkBoxSensorHomeY2, "checkBoxSensorHomeY2");
            this.checkBoxSensorHomeY2.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxSensorHomeY2.Name = "checkBoxSensorHomeY2";
            this.checkBoxSensorHomeY2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.UseWaitCursor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // home
            // 
            resources.ApplyResources(this.home, "home");
            this.home.Name = "home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxFuroDobradicaDireita
            // 
            resources.ApplyResources(this.checkBoxFuroDobradicaDireita, "checkBoxFuroDobradicaDireita");
            this.checkBoxFuroDobradicaDireita.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxFuroDobradicaDireita.Name = "checkBoxFuroDobradicaDireita";
            this.checkBoxFuroDobradicaDireita.UseVisualStyleBackColor = true;
            this.checkBoxFuroDobradicaDireita.UseWaitCursor = true;
            this.checkBoxFuroDobradicaDireita.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBoxFuroDobradicaEsquerda
            // 
            resources.ApplyResources(this.checkBoxFuroDobradicaEsquerda, "checkBoxFuroDobradicaEsquerda");
            this.checkBoxFuroDobradicaEsquerda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxFuroDobradicaEsquerda.Name = "checkBoxFuroDobradicaEsquerda";
            this.checkBoxFuroDobradicaEsquerda.UseVisualStyleBackColor = true;
            this.checkBoxFuroDobradicaEsquerda.UseWaitCursor = true;
            this.checkBoxFuroDobradicaEsquerda.CheckedChanged += new System.EventHandler(this.checkBoxFuroDobradicaEsquerda_CheckedChanged);
            // 
            // motorY1
            // 
            resources.ApplyResources(this.motorY1, "motorY1");
            this.motorY1.Maximum = 3000;
            this.motorY1.Name = "motorY1";
            // 
            // motorY2
            // 
            resources.ApplyResources(this.motorY2, "motorY2");
            this.motorY2.Name = "motorY2";
            // 
            // motorManeteX
            // 
            resources.ApplyResources(this.motorManeteX, "motorManeteX");
            this.motorManeteX.Name = "motorManeteX";
            // 
            // motorManeteZ
            // 
            resources.ApplyResources(this.motorManeteZ, "motorManeteZ");
            this.motorManeteZ.Name = "motorManeteZ";
            // 
            // motorMontagemD
            // 
            resources.ApplyResources(this.motorMontagemD, "motorMontagemD");
            this.motorMontagemD.Name = "motorMontagemD";
            // 
            // motorMontagemE
            // 
            resources.ApplyResources(this.motorMontagemE, "motorMontagemE");
            this.motorMontagemE.Name = "motorMontagemE";
            // 
            // progressBar8
            // 
            resources.ApplyResources(this.progressBar8, "progressBar8");
            this.progressBar8.Name = "progressBar8";
            // 
            // progressBar9
            // 
            resources.ApplyResources(this.progressBar9, "progressBar9");
            this.progressBar9.Name = "progressBar9";
            // 
            // progressBar10
            // 
            resources.ApplyResources(this.progressBar10, "progressBar10");
            this.progressBar10.Name = "progressBar10";
            // 
            // labelMotorX
            // 
            resources.ApplyResources(this.labelMotorX, "labelMotorX");
            this.labelMotorX.Name = "labelMotorX";
            this.labelMotorX.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelMotorY1
            // 
            resources.ApplyResources(this.labelMotorY1, "labelMotorY1");
            this.labelMotorY1.Name = "labelMotorY1";
            this.labelMotorY1.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelMotorManeteX
            // 
            resources.ApplyResources(this.labelMotorManeteX, "labelMotorManeteX");
            this.labelMotorManeteX.Name = "labelMotorManeteX";
            // 
            // labelMotorY2
            // 
            resources.ApplyResources(this.labelMotorY2, "labelMotorY2");
            this.labelMotorY2.Name = "labelMotorY2";
            // 
            // labelMotorManeteZ
            // 
            resources.ApplyResources(this.labelMotorManeteZ, "labelMotorManeteZ");
            this.labelMotorManeteZ.Name = "labelMotorManeteZ";
            // 
            // checkBoxFrezadoManeteX
            // 
            resources.ApplyResources(this.checkBoxFrezadoManeteX, "checkBoxFrezadoManeteX");
            this.checkBoxFrezadoManeteX.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxFrezadoManeteX.Name = "checkBoxFrezadoManeteX";
            this.checkBoxFrezadoManeteX.UseVisualStyleBackColor = true;
            this.checkBoxFrezadoManeteX.UseWaitCursor = true;
            this.checkBoxFrezadoManeteX.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.UseWaitCursor = true;
            // 
            // checkBoxManeteManeteX
            // 
            resources.ApplyResources(this.checkBoxManeteManeteX, "checkBoxManeteManeteX");
            this.checkBoxManeteManeteX.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBoxManeteManeteX.Name = "checkBoxManeteManeteX";
            this.checkBoxManeteManeteX.UseVisualStyleBackColor = true;
            this.checkBoxManeteManeteX.UseWaitCursor = true;
            this.checkBoxManeteManeteX.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alertErro
            // 
            resources.ApplyResources(this.alertErro, "alertErro");
            this.alertErro.ForeColor = System.Drawing.Color.Red;
            this.alertErro.Name = "alertErro";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // tamanhoYshadow
            // 
            this.tamanhoYshadow.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tamanhoYshadow, "tamanhoYshadow");
            this.tamanhoYshadow.Name = "tamanhoYshadow";
            this.tamanhoYshadow.TabStop = false;
            // 
            // tamanhoXshadow
            // 
            this.tamanhoXshadow.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tamanhoXshadow, "tamanhoXshadow");
            this.tamanhoXshadow.Name = "tamanhoXshadow";
            this.tamanhoXshadow.TabStop = false;
            // 
            // TrackBarMotorX
            // 
            this.TrackBarMotorX.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TrackBarMotorX, "TrackBarMotorX");
            this.TrackBarMotorX.LargeChange = 1;
            this.TrackBarMotorX.Maximum = 3000;
            this.TrackBarMotorX.MouseWheelBarPartitions = 1;
            this.TrackBarMotorX.Name = "TrackBarMotorX";
            this.TrackBarMotorX.SmallChange = 0;
            this.TrackBarMotorX.Style = MetroFramework.MetroColorStyle.Green;
            this.TrackBarMotorX.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TrackBarMotorX.Value = 0;
            this.TrackBarMotorX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // X
            // 
            resources.ApplyResources(this.X, "X");
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.DisplayStatus = false;
            this.X.Name = "X";
            this.X.Style = MetroFramework.MetroColorStyle.Green;
            this.X.UseStyleColors = true;
            this.X.UseVisualStyleBackColor = true;
            this.X.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // lableMotorX
            // 
            resources.ApplyResources(this.lableMotorX, "lableMotorX");
            this.lableMotorX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lableMotorX.Name = "lableMotorX";
            this.lableMotorX.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // metroToggle1
            // 
            resources.ApplyResources(this.metroToggle1, "metroToggle1");
            this.metroToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToggle1.UseStyleColors = true;
            this.metroToggle1.UseVisualStyleBackColor = true;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.metroTrackBar1, "metroTrackBar1");
            this.metroTrackBar1.LargeChange = 1;
            this.metroTrackBar1.Maximum = 3000;
            this.metroTrackBar1.MouseWheelBarPartitions = 1;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.SmallChange = 0;
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar1.Value = 0;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Name = "label2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // metroToggle2
            // 
            resources.ApplyResources(this.metroToggle2, "metroToggle2");
            this.metroToggle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggle2.DisplayStatus = false;
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToggle2.UseStyleColors = true;
            this.metroToggle2.UseVisualStyleBackColor = true;
            // 
            // metroTrackBar2
            // 
            this.metroTrackBar2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.metroTrackBar2, "metroTrackBar2");
            this.metroTrackBar2.LargeChange = 1;
            this.metroTrackBar2.Maximum = 3000;
            this.metroTrackBar2.MouseWheelBarPartitions = 1;
            this.metroTrackBar2.Name = "metroTrackBar2";
            this.metroTrackBar2.SmallChange = 0;
            this.metroTrackBar2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTrackBar2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar2.Value = 0;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Name = "label3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // metroToggle3
            // 
            resources.ApplyResources(this.metroToggle3, "metroToggle3");
            this.metroToggle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggle3.DisplayStatus = false;
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToggle3.UseStyleColors = true;
            this.metroToggle3.UseVisualStyleBackColor = true;
            // 
            // metroTrackBar3
            // 
            this.metroTrackBar3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.metroTrackBar3, "metroTrackBar3");
            this.metroTrackBar3.LargeChange = 1;
            this.metroTrackBar3.Maximum = 3000;
            this.metroTrackBar3.MouseWheelBarPartitions = 1;
            this.metroTrackBar3.Name = "metroTrackBar3";
            this.metroTrackBar3.SmallChange = 0;
            this.metroTrackBar3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTrackBar3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar3.Value = 0;
            // 
            // Janelerator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.metroToggle3);
            this.Controls.Add(this.metroTrackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.metroToggle2);
            this.Controls.Add(this.metroTrackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.lableMotorX);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.tipoDeJanela);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.TrackBarMotorX);
            this.Controls.Add(this.tamanhoX);
            this.Controls.Add(this.tamanhoXshadow);
            this.Controls.Add(this.tamanhoY);
            this.Controls.Add(this.tamanhoYshadow);
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
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBoxSensorHomeY2);
            this.Controls.Add(this.checkBoxSensorHomeY1);
            this.Controls.Add(this.checkBoxSensorHomeX);
            this.Controls.Add(this.motorX);
            this.Controls.Add(this.labelTipoDeJanela);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HelpButton = true;
            this.Name = "Janelerator";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Janelerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoYshadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoXshadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tamanhoX;
        private System.Windows.Forms.TextBox tamanhoY;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox tipoDeJanela;
        private System.Windows.Forms.Label labelTipoDeJanela;
        private System.Windows.Forms.ProgressBar motorX;
        private System.Windows.Forms.CheckBox checkBoxSensorHomeX;
        private System.Windows.Forms.CheckBox checkBoxSensorHomeY1;
        private System.Windows.Forms.CheckBox checkBoxSensorHomeY2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button home;
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox tamanhoYshadow;
        private System.Windows.Forms.PictureBox tamanhoXshadow;
        private MetroFramework.Controls.MetroTrackBar TrackBarMotorX;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lableMotorX;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroToggle X;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar3;
    }
}

