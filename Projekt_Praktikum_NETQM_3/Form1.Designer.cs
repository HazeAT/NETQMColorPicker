namespace Projekt_Praktikum_NETQM_3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.buttonError = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonWarning = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxFastBlinkError = new System.Windows.Forms.CheckBox();
            this.checkBoxSlowBlinkError = new System.Windows.Forms.CheckBox();
            this.checkBoxSteadyBlinkError = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxLightShow = new System.Windows.Forms.CheckBox();
            this.checkBoxFastLightshow = new System.Windows.Forms.CheckBox();
            this.checkBoxMediumLightshow = new System.Windows.Forms.CheckBox();
            this.checkBoxSlowLightshow = new System.Windows.Forms.CheckBox();
            this.checkBoxBackgroundLight = new System.Windows.Forms.CheckBox();
            this.checkBoxWhiteLight = new System.Windows.Forms.CheckBox();
            this.checkBoxBlueLight = new System.Windows.Forms.CheckBox();
            this.textBoxBackgroundLight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWarning = new System.Windows.Forms.TextBox();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.checkBoxSteadyBlinkWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxSlowBlinkWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxFastBlinkWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxSteadyBlinkCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxSlowBlinkCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxFastBlinkCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBackgroundLight = new System.Windows.Forms.Button();
            this.checkBoxCustomLight = new System.Windows.Forms.CheckBox();
            this.buttonSelectSerial = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Panel v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Warning Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Error Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(15, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check Color";
            // 
            // textBoxError
            // 
            this.textBoxError.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxError.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxError.Location = new System.Drawing.Point(204, 65);
            this.textBoxError.MaxLength = 6;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(197, 39);
            this.textBoxError.TabIndex = 4;
            this.textBoxError.Tag = "";
            this.textBoxError.Text = "Color-Code(HEX)";
            this.textBoxError.Click += new System.EventHandler(this.textBoxError_Click);
            this.textBoxError.TextChanged += new System.EventHandler(this.textBoxError_TextChanged);
            this.textBoxError.Leave += new System.EventHandler(this.textBoxError_Leave);
            // 
            // buttonError
            // 
            this.buttonError.BackColor = System.Drawing.Color.Red;
            this.buttonError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonError.Location = new System.Drawing.Point(432, 62);
            this.buttonError.Margin = new System.Windows.Forms.Padding(0);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(47, 47);
            this.buttonError.TabIndex = 7;
            this.buttonError.UseVisualStyleBackColor = false;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            this.buttonError.MouseHover += new System.EventHandler(this.buttonError_MouseHover);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Green;
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.Location = new System.Drawing.Point(432, 180);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(47, 47);
            this.buttonCheck.TabIndex = 8;
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            this.buttonCheck.MouseHover += new System.EventHandler(this.buttonCheck_MouseHover);
            // 
            // buttonWarning
            // 
            this.buttonWarning.BackColor = System.Drawing.Color.Orange;
            this.buttonWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWarning.Location = new System.Drawing.Point(432, 122);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Size = new System.Drawing.Size(47, 47);
            this.buttonWarning.TabIndex = 9;
            this.buttonWarning.UseVisualStyleBackColor = false;
            this.buttonWarning.Click += new System.EventHandler(this.buttonWarning_Click);
            this.buttonWarning.MouseHover += new System.EventHandler(this.buttonWarning_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(600, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blink-Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(101, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color-Mode";
            // 
            // checkBoxFastBlinkError
            // 
            this.checkBoxFastBlinkError.AutoSize = true;
            this.checkBoxFastBlinkError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFastBlinkError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxFastBlinkError.Location = new System.Drawing.Point(556, 71);
            this.checkBoxFastBlinkError.Name = "checkBoxFastBlinkError";
            this.checkBoxFastBlinkError.Size = new System.Drawing.Size(84, 36);
            this.checkBoxFastBlinkError.TabIndex = 12;
            this.checkBoxFastBlinkError.Text = "fast";
            this.checkBoxFastBlinkError.UseVisualStyleBackColor = true;
            this.checkBoxFastBlinkError.CheckedChanged += new System.EventHandler(this.checkBoxFastBlinkError_CheckedChanged);
            // 
            // checkBoxSlowBlinkError
            // 
            this.checkBoxSlowBlinkError.AutoSize = true;
            this.checkBoxSlowBlinkError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSlowBlinkError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSlowBlinkError.Location = new System.Drawing.Point(670, 70);
            this.checkBoxSlowBlinkError.Name = "checkBoxSlowBlinkError";
            this.checkBoxSlowBlinkError.Size = new System.Drawing.Size(93, 36);
            this.checkBoxSlowBlinkError.TabIndex = 13;
            this.checkBoxSlowBlinkError.Text = "slow";
            this.checkBoxSlowBlinkError.UseVisualStyleBackColor = true;
            this.checkBoxSlowBlinkError.CheckedChanged += new System.EventHandler(this.checkBoxSlowBlinkError_CheckedChanged);
            // 
            // checkBoxSteadyBlinkError
            // 
            this.checkBoxSteadyBlinkError.AutoSize = true;
            this.checkBoxSteadyBlinkError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSteadyBlinkError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSteadyBlinkError.Location = new System.Drawing.Point(784, 70);
            this.checkBoxSteadyBlinkError.Name = "checkBoxSteadyBlinkError";
            this.checkBoxSteadyBlinkError.Size = new System.Drawing.Size(115, 36);
            this.checkBoxSteadyBlinkError.TabIndex = 14;
            this.checkBoxSteadyBlinkError.Text = "steady";
            this.checkBoxSteadyBlinkError.UseVisualStyleBackColor = true;
            this.checkBoxSteadyBlinkError.CheckedChanged += new System.EventHandler(this.checkBoxSteadyBlinkError_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 21;
            // 
            // checkBoxLightShow
            // 
            this.checkBoxLightShow.AutoSize = true;
            this.checkBoxLightShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLightShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxLightShow.Location = new System.Drawing.Point(22, 54);
            this.checkBoxLightShow.Name = "checkBoxLightShow";
            this.checkBoxLightShow.Size = new System.Drawing.Size(212, 36);
            this.checkBoxLightShow.TabIndex = 22;
            this.checkBoxLightShow.Text = "Start-Lightshow";
            this.checkBoxLightShow.UseVisualStyleBackColor = true;
            this.checkBoxLightShow.CheckedChanged += new System.EventHandler(this.checkBoxLightShow_CheckedChanged);
            // 
            // checkBoxFastLightshow
            // 
            this.checkBoxFastLightshow.AutoSize = true;
            this.checkBoxFastLightshow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBoxFastLightshow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxFastLightshow.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxFastLightshow.Location = new System.Drawing.Point(64, 96);
            this.checkBoxFastLightshow.Name = "checkBoxFastLightshow";
            this.checkBoxFastLightshow.Size = new System.Drawing.Size(84, 36);
            this.checkBoxFastLightshow.TabIndex = 23;
            this.checkBoxFastLightshow.Text = "fast";
            this.checkBoxFastLightshow.UseVisualStyleBackColor = true;
            this.checkBoxFastLightshow.CheckedChanged += new System.EventHandler(this.checkBoxFastLightshow_CheckedChanged);
            // 
            // checkBoxMediumLightshow
            // 
            this.checkBoxMediumLightshow.AutoSize = true;
            this.checkBoxMediumLightshow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxMediumLightshow.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxMediumLightshow.Location = new System.Drawing.Point(64, 136);
            this.checkBoxMediumLightshow.Name = "checkBoxMediumLightshow";
            this.checkBoxMediumLightshow.Size = new System.Drawing.Size(135, 36);
            this.checkBoxMediumLightshow.TabIndex = 24;
            this.checkBoxMediumLightshow.Text = "medium";
            this.checkBoxMediumLightshow.UseVisualStyleBackColor = true;
            this.checkBoxMediumLightshow.CheckedChanged += new System.EventHandler(this.checkBoxMediumLightshow_CheckedChanged);
            // 
            // checkBoxSlowLightshow
            // 
            this.checkBoxSlowLightshow.AutoSize = true;
            this.checkBoxSlowLightshow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSlowLightshow.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxSlowLightshow.Location = new System.Drawing.Point(64, 178);
            this.checkBoxSlowLightshow.Name = "checkBoxSlowLightshow";
            this.checkBoxSlowLightshow.Size = new System.Drawing.Size(93, 36);
            this.checkBoxSlowLightshow.TabIndex = 25;
            this.checkBoxSlowLightshow.Text = "slow";
            this.checkBoxSlowLightshow.UseVisualStyleBackColor = true;
            this.checkBoxSlowLightshow.CheckedChanged += new System.EventHandler(this.checkBoxSlowLightshow_CheckedChanged);
            // 
            // checkBoxBackgroundLight
            // 
            this.checkBoxBackgroundLight.AutoSize = true;
            this.checkBoxBackgroundLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxBackgroundLight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxBackgroundLight.Location = new System.Drawing.Point(273, 54);
            this.checkBoxBackgroundLight.Name = "checkBoxBackgroundLight";
            this.checkBoxBackgroundLight.Size = new System.Drawing.Size(236, 36);
            this.checkBoxBackgroundLight.TabIndex = 26;
            this.checkBoxBackgroundLight.Text = "Background-Light";
            this.checkBoxBackgroundLight.UseVisualStyleBackColor = true;
            this.checkBoxBackgroundLight.CheckedChanged += new System.EventHandler(this.checkBoxBackgroundLight_CheckedChanged);
            // 
            // checkBoxWhiteLight
            // 
            this.checkBoxWhiteLight.AutoSize = true;
            this.checkBoxWhiteLight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxWhiteLight.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxWhiteLight.Location = new System.Drawing.Point(310, 96);
            this.checkBoxWhiteLight.Name = "checkBoxWhiteLight";
            this.checkBoxWhiteLight.Size = new System.Drawing.Size(104, 36);
            this.checkBoxWhiteLight.TabIndex = 27;
            this.checkBoxWhiteLight.Text = "white";
            this.checkBoxWhiteLight.UseVisualStyleBackColor = true;
            this.checkBoxWhiteLight.CheckedChanged += new System.EventHandler(this.checkBoxWhiteLight_CheckedChanged);
            // 
            // checkBoxBlueLight
            // 
            this.checkBoxBlueLight.AutoSize = true;
            this.checkBoxBlueLight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxBlueLight.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxBlueLight.Location = new System.Drawing.Point(310, 136);
            this.checkBoxBlueLight.Name = "checkBoxBlueLight";
            this.checkBoxBlueLight.Size = new System.Drawing.Size(151, 36);
            this.checkBoxBlueLight.TabIndex = 28;
            this.checkBoxBlueLight.Text = "light-blue";
            this.checkBoxBlueLight.UseVisualStyleBackColor = true;
            this.checkBoxBlueLight.CheckedChanged += new System.EventHandler(this.checkBoxBlueLight_CheckedChanged);
            // 
            // textBoxBackgroundLight
            // 
            this.textBoxBackgroundLight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxBackgroundLight.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBackgroundLight.Location = new System.Drawing.Point(350, 181);
            this.textBoxBackgroundLight.MaxLength = 6;
            this.textBoxBackgroundLight.Name = "textBoxBackgroundLight";
            this.textBoxBackgroundLight.ReadOnly = true;
            this.textBoxBackgroundLight.Size = new System.Drawing.Size(199, 39);
            this.textBoxBackgroundLight.TabIndex = 29;
            this.textBoxBackgroundLight.Text = "Color-Code(HEX)";
            this.textBoxBackgroundLight.Click += new System.EventHandler(this.textBoxBackgroundLight_Click);
            this.textBoxBackgroundLight.TextChanged += new System.EventHandler(this.textBoxBackgroundLight_TextChanged);
            this.textBoxBackgroundLight.Leave += new System.EventHandler(this.textBoxBackgroundLight_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Version1.0";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(888, 677);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(158, 47);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(717, 677);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 47);
            this.button5.TabIndex = 32;
            this.button5.Text = "Dismiss";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(539, 677);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(158, 47);
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(66, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 32);
            this.label9.TabIndex = 34;
            this.label9.Text = "More Configuration";
            // 
            // textBoxWarning
            // 
            this.textBoxWarning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxWarning.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxWarning.Location = new System.Drawing.Point(204, 124);
            this.textBoxWarning.MaxLength = 6;
            this.textBoxWarning.Name = "textBoxWarning";
            this.textBoxWarning.Size = new System.Drawing.Size(197, 39);
            this.textBoxWarning.TabIndex = 35;
            this.textBoxWarning.Tag = "";
            this.textBoxWarning.Text = "Color-Code(HEX)";
            this.textBoxWarning.Click += new System.EventHandler(this.textBoxWarning_Click);
            this.textBoxWarning.TextChanged += new System.EventHandler(this.textBoxWarning_TextChanged);
            this.textBoxWarning.Leave += new System.EventHandler(this.textBoxWarning_Leave);
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCheck.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxCheck.Location = new System.Drawing.Point(204, 182);
            this.textBoxCheck.MaxLength = 6;
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(197, 39);
            this.textBoxCheck.TabIndex = 36;
            this.textBoxCheck.Tag = "";
            this.textBoxCheck.Text = "Color-Code(HEX)";
            this.textBoxCheck.Click += new System.EventHandler(this.textBoxCheck_Click);
            this.textBoxCheck.TextChanged += new System.EventHandler(this.textBoxCheck_TextChanged);
            this.textBoxCheck.Leave += new System.EventHandler(this.textBoxCheck_Leave);
            // 
            // checkBoxSteadyBlinkWarning
            // 
            this.checkBoxSteadyBlinkWarning.AutoSize = true;
            this.checkBoxSteadyBlinkWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSteadyBlinkWarning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSteadyBlinkWarning.Location = new System.Drawing.Point(784, 128);
            this.checkBoxSteadyBlinkWarning.Name = "checkBoxSteadyBlinkWarning";
            this.checkBoxSteadyBlinkWarning.Size = new System.Drawing.Size(115, 36);
            this.checkBoxSteadyBlinkWarning.TabIndex = 39;
            this.checkBoxSteadyBlinkWarning.Text = "steady";
            this.checkBoxSteadyBlinkWarning.UseVisualStyleBackColor = true;
            this.checkBoxSteadyBlinkWarning.CheckedChanged += new System.EventHandler(this.checkBoxSteadyBlinkWarning_CheckedChanged);
            // 
            // checkBoxSlowBlinkWarning
            // 
            this.checkBoxSlowBlinkWarning.AutoSize = true;
            this.checkBoxSlowBlinkWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSlowBlinkWarning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSlowBlinkWarning.Location = new System.Drawing.Point(670, 126);
            this.checkBoxSlowBlinkWarning.Name = "checkBoxSlowBlinkWarning";
            this.checkBoxSlowBlinkWarning.Size = new System.Drawing.Size(93, 36);
            this.checkBoxSlowBlinkWarning.TabIndex = 38;
            this.checkBoxSlowBlinkWarning.Text = "slow";
            this.checkBoxSlowBlinkWarning.UseVisualStyleBackColor = true;
            this.checkBoxSlowBlinkWarning.CheckedChanged += new System.EventHandler(this.checkBoxSlowBlinkWarning_CheckedChanged);
            // 
            // checkBoxFastBlinkWarning
            // 
            this.checkBoxFastBlinkWarning.AutoSize = true;
            this.checkBoxFastBlinkWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFastBlinkWarning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxFastBlinkWarning.Location = new System.Drawing.Point(556, 127);
            this.checkBoxFastBlinkWarning.Name = "checkBoxFastBlinkWarning";
            this.checkBoxFastBlinkWarning.Size = new System.Drawing.Size(84, 36);
            this.checkBoxFastBlinkWarning.TabIndex = 37;
            this.checkBoxFastBlinkWarning.Text = "fast";
            this.checkBoxFastBlinkWarning.UseVisualStyleBackColor = true;
            this.checkBoxFastBlinkWarning.CheckedChanged += new System.EventHandler(this.checkBoxFastBlinkWarning_CheckedChanged);
            // 
            // checkBoxSteadyBlinkCheck
            // 
            this.checkBoxSteadyBlinkCheck.AutoSize = true;
            this.checkBoxSteadyBlinkCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSteadyBlinkCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSteadyBlinkCheck.Location = new System.Drawing.Point(784, 185);
            this.checkBoxSteadyBlinkCheck.Name = "checkBoxSteadyBlinkCheck";
            this.checkBoxSteadyBlinkCheck.Size = new System.Drawing.Size(115, 36);
            this.checkBoxSteadyBlinkCheck.TabIndex = 42;
            this.checkBoxSteadyBlinkCheck.Text = "steady";
            this.checkBoxSteadyBlinkCheck.UseVisualStyleBackColor = true;
            this.checkBoxSteadyBlinkCheck.CheckedChanged += new System.EventHandler(this.checkBoxSteadyBlinkCheck_CheckedChanged);
            // 
            // checkBoxSlowBlinkCheck
            // 
            this.checkBoxSlowBlinkCheck.AutoSize = true;
            this.checkBoxSlowBlinkCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSlowBlinkCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSlowBlinkCheck.Location = new System.Drawing.Point(670, 185);
            this.checkBoxSlowBlinkCheck.Name = "checkBoxSlowBlinkCheck";
            this.checkBoxSlowBlinkCheck.Size = new System.Drawing.Size(93, 36);
            this.checkBoxSlowBlinkCheck.TabIndex = 41;
            this.checkBoxSlowBlinkCheck.Text = "slow";
            this.checkBoxSlowBlinkCheck.UseVisualStyleBackColor = true;
            this.checkBoxSlowBlinkCheck.CheckedChanged += new System.EventHandler(this.checkBoxSlowBlinkCheck_CheckedChanged);
            // 
            // checkBoxFastBlinkCheck
            // 
            this.checkBoxFastBlinkCheck.AutoSize = true;
            this.checkBoxFastBlinkCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFastBlinkCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxFastBlinkCheck.Location = new System.Drawing.Point(556, 186);
            this.checkBoxFastBlinkCheck.Name = "checkBoxFastBlinkCheck";
            this.checkBoxFastBlinkCheck.Size = new System.Drawing.Size(84, 36);
            this.checkBoxFastBlinkCheck.TabIndex = 40;
            this.checkBoxFastBlinkCheck.Text = "fast";
            this.checkBoxFastBlinkCheck.UseVisualStyleBackColor = true;
            this.checkBoxFastBlinkCheck.CheckedChanged += new System.EventHandler(this.checkBoxFastBlinkCheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSteadyBlinkCheck);
            this.groupBox1.Controls.Add(this.checkBoxSlowBlinkCheck);
            this.groupBox1.Controls.Add(this.checkBoxFastBlinkCheck);
            this.groupBox1.Controls.Add(this.checkBoxSteadyBlinkWarning);
            this.groupBox1.Controls.Add(this.checkBoxSlowBlinkWarning);
            this.groupBox1.Controls.Add(this.checkBoxFastBlinkWarning);
            this.groupBox1.Controls.Add(this.textBoxCheck);
            this.groupBox1.Controls.Add(this.textBoxWarning);
            this.groupBox1.Controls.Add(this.checkBoxSteadyBlinkError);
            this.groupBox1.Controls.Add(this.checkBoxSlowBlinkError);
            this.groupBox1.Controls.Add(this.buttonError);
            this.groupBox1.Controls.Add(this.checkBoxFastBlinkError);
            this.groupBox1.Controls.Add(this.buttonCheck);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonWarning);
            this.groupBox1.Controls.Add(this.textBoxError);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 269);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBackgroundLight);
            this.groupBox2.Controls.Add(this.checkBoxCustomLight);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxBackgroundLight);
            this.groupBox2.Controls.Add(this.checkBoxBlueLight);
            this.groupBox2.Controls.Add(this.checkBoxWhiteLight);
            this.groupBox2.Controls.Add(this.checkBoxBackgroundLight);
            this.groupBox2.Controls.Add(this.checkBoxSlowLightshow);
            this.groupBox2.Controls.Add(this.checkBoxMediumLightshow);
            this.groupBox2.Controls.Add(this.checkBoxFastLightshow);
            this.groupBox2.Controls.Add(this.checkBoxLightShow);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(60, 408);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(942, 236);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // buttonBackgroundLight
            // 
            this.buttonBackgroundLight.BackColor = System.Drawing.Color.White;
            this.buttonBackgroundLight.Location = new System.Drawing.Point(555, 181);
            this.buttonBackgroundLight.Name = "buttonBackgroundLight";
            this.buttonBackgroundLight.Size = new System.Drawing.Size(47, 47);
            this.buttonBackgroundLight.TabIndex = 43;
            this.buttonBackgroundLight.UseVisualStyleBackColor = false;
            this.buttonBackgroundLight.Click += new System.EventHandler(this.buttonBackgroundLight_Click);
            this.buttonBackgroundLight.MouseHover += new System.EventHandler(this.buttonBackgroundLight_MouseHover);
            // 
            // checkBoxCustomLight
            // 
            this.checkBoxCustomLight.AutoSize = true;
            this.checkBoxCustomLight.Location = new System.Drawing.Point(310, 185);
            this.checkBoxCustomLight.Name = "checkBoxCustomLight";
            this.checkBoxCustomLight.Size = new System.Drawing.Size(28, 27);
            this.checkBoxCustomLight.TabIndex = 35;
            this.checkBoxCustomLight.UseVisualStyleBackColor = true;
            this.checkBoxCustomLight.CheckedChanged += new System.EventHandler(this.checkBoxCustomLight_CheckedChanged);
            // 
            // buttonSelectSerial
            // 
            this.buttonSelectSerial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSelectSerial.Location = new System.Drawing.Point(765, 51);
            this.buttonSelectSerial.Name = "buttonSelectSerial";
            this.buttonSelectSerial.Size = new System.Drawing.Size(187, 41);
            this.buttonSelectSerial.TabIndex = 45;
            this.buttonSelectSerial.Text = "SELECT";
            this.buttonSelectSerial.UseVisualStyleBackColor = true;
            this.buttonSelectSerial.Click += new System.EventHandler(this.buttonSelectSerial_Click);
            // 
            // PortBox
            // 
            this.PortBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(520, 52);
            this.PortBox.MaxDropDownItems = 15;
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(227, 40);
            this.PortBox.Sorted = true;
            this.PortBox.TabIndex = 46;
            this.PortBox.Text = "select Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 739);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.buttonSelectSerial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Panel v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonWarning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxFastBlinkError;
        private System.Windows.Forms.CheckBox checkBoxSlowBlinkError;
        private System.Windows.Forms.CheckBox checkBoxSteadyBlinkError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxLightShow;
        private System.Windows.Forms.CheckBox checkBoxFastLightshow;
        private System.Windows.Forms.CheckBox checkBoxMediumLightshow;
        private System.Windows.Forms.CheckBox checkBoxSlowLightshow;
        private System.Windows.Forms.CheckBox checkBoxBackgroundLight;
        private System.Windows.Forms.CheckBox checkBoxWhiteLight;
        private System.Windows.Forms.CheckBox checkBoxBlueLight;
        private System.Windows.Forms.TextBox textBoxBackgroundLight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWarning;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.CheckBox checkBoxSteadyBlinkWarning;
        private System.Windows.Forms.CheckBox checkBoxSlowBlinkWarning;
        private System.Windows.Forms.CheckBox checkBoxFastBlinkWarning;
        private System.Windows.Forms.CheckBox checkBoxSteadyBlinkCheck;
        private System.Windows.Forms.CheckBox checkBoxSlowBlinkCheck;
        private System.Windows.Forms.CheckBox checkBoxFastBlinkCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSelectSerial;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.CheckBox checkBoxCustomLight;
        private System.Windows.Forms.Button buttonBackgroundLight;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

