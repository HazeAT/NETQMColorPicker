using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt_Praktikum_NETQM_3
{
    public partial class Form1 : Form
    {
        string information = "";

        //Base Colors
        System.Drawing.Color ColorError = System.Drawing.Color.FromArgb(int.Parse("ff0000", NumberStyles.HexNumber));
        System.Drawing.Color ColorWarning = System.Drawing.Color.FromArgb(int.Parse("ffff00", NumberStyles.HexNumber));
        System.Drawing.Color ColorCheck = System.Drawing.Color.FromArgb(int.Parse("00ff00", NumberStyles.HexNumber));
        System.Drawing.Color BackgroundColor = System.Drawing.Color.FromArgb(int.Parse("fffff", NumberStyles.HexNumber));
        public Form1()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PortBox.Items.Clear();
            PortBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        //textBoxError
        private void textBoxError_TextChanged(object sender, EventArgs e)
        {
            string textError = textBoxError.Text;
            try
            {
                if (textError.Length == 6)
                {
                    int ColorAsInt = int.Parse(textError, NumberStyles.HexNumber);
                    System.Drawing.Color MyColor = System.Drawing.Color.FromArgb(ColorAsInt);
                    ColorError = MyColor;
                    buttonError.BackColor = Color.FromArgb(MyColor.R, MyColor.G, MyColor.B);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxError_Click(object sender, EventArgs e)
        {
            textBoxError.ForeColor = Color.Black;
            if (textBoxError.Text.Length > 6)
            {
                textBoxError.Text = "";
            }
        }
        private void textBoxError_Leave(object sender, EventArgs e)
        {
            if (textBoxError.Text == "")
            {
                textBoxError.ForeColor = Color.Gray;
                textBoxError.Text = "Color-Code(HEX)";
            }
        }

        //textBoxWarning
        private void textBoxWarning_TextChanged(object sender, EventArgs e)
        {
            string textWarning = textBoxWarning.Text;
            try
            {
                if (textWarning.Length == 6)
                {
                    int ColorAsInt = int.Parse(textWarning, NumberStyles.HexNumber);
                    System.Drawing.Color MyColor = System.Drawing.Color.FromArgb(ColorAsInt);
                    ColorWarning = MyColor;
                    buttonWarning.BackColor = Color.FromArgb(MyColor.R, MyColor.G, MyColor.B);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxWarning_Click(object sender, EventArgs e)
        {
            textBoxWarning.ForeColor = Color.Black;
            if (textBoxWarning.Text.Length > 6)
            {
                textBoxWarning.Text = "";
            }
        }
        private void textBoxWarning_Leave(object sender, EventArgs e)
        {
            if (textBoxWarning.Text == "")
            {
                textBoxWarning.ForeColor = Color.Gray;
                textBoxWarning.Text = "Color-Code(HEX)";
            }
        }

        //textBoxCheck 
        private void textBoxCheck_TextChanged(object sender, EventArgs e)
        {
            string textCheck = textBoxCheck.Text;
            try
            {
                if (textCheck.Length == 6)
                {
                    int ColorAsInt = int.Parse(textCheck, NumberStyles.HexNumber);
                    System.Drawing.Color MyColor = System.Drawing.Color.FromArgb(ColorAsInt);
                    ColorCheck = MyColor;
                    buttonCheck.BackColor = Color.FromArgb(MyColor.R, MyColor.G, MyColor.B);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void textBoxCheck_Click(object sender, EventArgs e)
        {
            textBoxCheck.ForeColor = Color.Black;
            if (textBoxCheck.Text.Length > 6)
            {
                textBoxCheck.Text = "";
            }
        }
        private void textBoxCheck_Leave(object sender, EventArgs e)
        {
            if (textBoxCheck.Text == "")
            {
                textBoxCheck.ForeColor = Color.Gray;
                textBoxCheck.Text = "Color-Code(HEX)";
            }
        }

        //textBoxBackground
        private void textBoxBackgroundLight_TextChanged(object sender, EventArgs e)
        {
            string textBackground = textBoxBackgroundLight.Text;
            try
            {
                if (textBackground.Length == 6)
                {
                    int ColorAsInt = int.Parse(textBackground, NumberStyles.HexNumber);
                    System.Drawing.Color MyColor = System.Drawing.Color.FromArgb(ColorAsInt);
                    buttonBackgroundLight.BackColor = Color.FromArgb(MyColor.R, MyColor.G, MyColor.B);
                    BackgroundColor = MyColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxBackgroundLight_Click(object sender, EventArgs e)
        {
            textBoxBackgroundLight.ForeColor = Color.Black;
            if (textBoxBackgroundLight.Text.Length > 6)
            {
                textBoxBackgroundLight.Text = "";
            }
        }
        private void textBoxBackgroundLight_Leave(object sender, EventArgs e)
        {
            if (textBoxBackgroundLight.Text == "")
            {
                textBoxBackgroundLight.ForeColor = Color.Gray;
                textBoxBackgroundLight.Text = "Color-Code(HEX)";
            }
        }

        //CloseButton   
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Blink-Mode-Error
        private void checkBoxFastBlinkError_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFastBlinkError.Checked == true)
            {
                checkBoxSlowBlinkError.Checked = false;
                checkBoxSteadyBlinkError.Checked = false;
                checkBoxFastBlinkError.Checked = true;
            }
        }
        private void checkBoxSlowBlinkError_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSlowBlinkError.Checked == true)
            {
                checkBoxFastBlinkError.Checked = false;
                checkBoxSteadyBlinkError.Checked = false;
                checkBoxSlowBlinkError.Checked = true;
            }
        }
        private void checkBoxSteadyBlinkError_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSteadyBlinkError.Checked == true)
            {
                checkBoxSlowBlinkError.Checked = false;
                checkBoxFastBlinkError.Checked = false;
                checkBoxSteadyBlinkError.Checked = true;
            }
        }

        //Blink-Mode-Warning
        private void checkBoxFastBlinkWarning_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFastBlinkWarning.Checked == true)
            {
                checkBoxSlowBlinkWarning.Checked = false;
                checkBoxSteadyBlinkWarning.Checked = false;
                checkBoxFastBlinkWarning.Checked = true;
            }
        }
        private void checkBoxSlowBlinkWarning_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSlowBlinkWarning.Checked == true)
            {
                checkBoxFastBlinkWarning.Checked = false;
                checkBoxSteadyBlinkWarning.Checked = false;
                checkBoxSlowBlinkWarning.Checked = true;
            }
        }
        private void checkBoxSteadyBlinkWarning_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSteadyBlinkWarning.Checked == true)
            {
                checkBoxSlowBlinkWarning.Checked = false;
                checkBoxFastBlinkWarning.Checked = false;
                checkBoxSteadyBlinkWarning.Checked = true;
            }
        }

        //Blink-Mode-Check
        private void checkBoxFastBlinkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFastBlinkCheck.Checked == true)
            {
                checkBoxSlowBlinkCheck.Checked = false;
                checkBoxSteadyBlinkCheck.Checked = false;
                checkBoxFastBlinkCheck.Checked = true;
            }
        }
        private void checkBoxSlowBlinkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSlowBlinkCheck.Checked == true)
            {
                checkBoxFastBlinkCheck.Checked = false;
                checkBoxSteadyBlinkCheck.Checked = false;
                checkBoxSlowBlinkCheck.Checked = true;
            }
        }
        private void checkBoxSteadyBlinkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSteadyBlinkCheck.Checked == true)
            {
                checkBoxSlowBlinkCheck.Checked = false;
                checkBoxFastBlinkCheck.Checked = false;
                checkBoxSteadyBlinkCheck.Checked = true;
            }
        }

        //Save Button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (PortBox.Text.Length < 11)
            {
                //Color Error
                information = ColorError.R.ToString() + "/" + ColorError.G.ToString() + "/" + ColorError.B.ToString() + "/";
                information += ColorWarning.R.ToString() + "/" + ColorWarning.G.ToString() + "/" + ColorWarning.B.ToString() + "/";
                information += ColorCheck.R.ToString() + "/" + ColorCheck.G.ToString() + "/" + ColorCheck.B.ToString() + "/";
                //Blink-Mode //Lightshow //Background
                try
                {
                    //BlinkModeError
                    if (checkBoxFastBlinkError.Checked == true){information += "1/";}
                    else if (checkBoxSlowBlinkError.Checked == true){information += "2/";}
                    else{information += "0/";}

                    //BlinkModeWarning
                    if (checkBoxFastBlinkWarning.Checked == true){ information += "1/"; }
                    else if (checkBoxSlowBlinkWarning.Checked == true){ information += "2/"; }
                    else { information += "0/"; }

                    //BlinkModeCheck
                    if (checkBoxFastBlinkCheck.Checked == true){information += "1/";}
                    else if (checkBoxSlowBlinkCheck.Checked == true){information += "2/";}
                    else{information += "0/";}

                    //LightShow
                    if (checkBoxLightShow.Checked == true) { information += "1" + "/"; }
                    else if (checkBoxLightShow.Checked == false) { information += "0" + "/"; }
                    if (checkBoxFastLightshow.Checked == true) { information += "1" + "/"; }
                    else if (checkBoxMediumLightshow.Checked == true) { information += "2" + "/"; }
                    else if (checkBoxSlowLightshow.Checked == true) { information += "3" + "/"; }
                    else { information += "0" + "/"; }

                    //BackgroundLight
                    if (checkBoxBackgroundLight.Checked == true) { information += "1" + "/"; }
                    else if (checkBoxBackgroundLight.Checked == false) { information += "2" + "/"; }
                    if (checkBoxBlueLight.Checked == true) { information += "2" +"/"; }
                    else if (checkBoxWhiteLight.Checked == true) { information += "1" + "/"; }
                    else if (checkBoxCustomLight.Checked == true) { information += "3" + "/"; }
                    else { information += "0" + "/"; }
                    information += BackgroundColor.R.ToString() + "/";
                    information += BackgroundColor.G.ToString() + "/";
                    information += BackgroundColor.B.ToString() + "/";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select Port");
            }
            try
            {
                //WriteToSerialPort
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);
                serialPort1.Open();
                serialPort1.Write(information);
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Lightshow
        private void checkBoxLightShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLightShow.Checked == true)
            {
                checkBoxFastLightshow.Cursor = Cursors.Hand;
                checkBoxFastLightshow.ForeColor = Color.Black;
                checkBoxMediumLightshow.Cursor = Cursors.Hand;
                checkBoxMediumLightshow.ForeColor = Color.Black;
                checkBoxSlowLightshow.Cursor = Cursors.Hand;
                checkBoxSlowLightshow.ForeColor = Color.Black;
            }
            else
            {
                checkBoxFastLightshow.Cursor = Cursors.Default;
                checkBoxFastLightshow.ForeColor = Color.Gray;
                checkBoxFastLightshow.Checked = false;
                checkBoxMediumLightshow.Cursor = Cursors.Default;
                checkBoxMediumLightshow.ForeColor = Color.Gray;
                checkBoxMediumLightshow.Checked = false;
                checkBoxSlowLightshow.Cursor = Cursors.Default;
                checkBoxSlowLightshow.ForeColor = Color.Gray;
                checkBoxSlowLightshow.Checked = false;
            }
        }
        private void checkBoxFastLightshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLightShow.Checked != true)
            {
                checkBoxFastLightshow.Checked = false;
            }
            if (checkBoxFastLightshow.Checked == true)
            {
                checkBoxSlowLightshow.Checked = false;
                checkBoxMediumLightshow.Checked = false;
                checkBoxFastLightshow.Checked = true;
            }
        }
        private void checkBoxMediumLightshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLightShow.Checked != true)
            {
                checkBoxMediumLightshow.Checked = false;
            }
            if (checkBoxMediumLightshow.Checked == true)
            {
                checkBoxSlowLightshow.Checked = false;
                checkBoxFastLightshow.Checked = false;
                checkBoxMediumLightshow.Checked = true;
            }
        }
        private void checkBoxSlowLightshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLightShow.Checked != true)
            {
                checkBoxSlowLightshow.Checked = false;
            }
            if (checkBoxSlowLightshow.Checked == true)
            {
                checkBoxFastLightshow.Checked = false;
                checkBoxMediumLightshow.Checked = false;
                checkBoxSlowLightshow.Checked = true;
            }
        }

        //BackgroundLight
        private void checkBoxBackgroundLight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackgroundLight.Checked == true)
            {
                checkBoxWhiteLight.Cursor = Cursors.Hand;
                checkBoxWhiteLight.ForeColor = Color.Black;
                checkBoxBlueLight.Cursor = Cursors.Hand;
                checkBoxBlueLight.ForeColor = Color.Black;
                checkBoxCustomLight.Cursor = Cursors.Hand;
                textBoxBackgroundLight.ReadOnly = false;
            }
            else
            {
                checkBoxWhiteLight.Cursor = Cursors.Default;
                checkBoxWhiteLight.ForeColor = Color.Gray;
                checkBoxWhiteLight.Checked = false;
                checkBoxBlueLight.Cursor = Cursors.Default;
                checkBoxBlueLight.ForeColor = Color.Gray;
                checkBoxBlueLight.Checked = false;
                checkBoxCustomLight.Cursor = Cursors.Default;
                checkBoxCustomLight.Checked = false;
            }
        }
        private void checkBoxWhiteLight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackgroundLight.Checked == false)
            {
                checkBoxWhiteLight.Checked = false;
            }
            if (checkBoxWhiteLight.Checked == true)
            {
                checkBoxBlueLight.Checked = false;
                checkBoxCustomLight.Checked = false;
                checkBoxWhiteLight.Checked = true;
            }
        }
        private void checkBoxBlueLight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackgroundLight.Checked == false)
            {
                checkBoxBlueLight.Checked = false;
            }
            if (checkBoxBlueLight.Checked == true)
            {
                checkBoxWhiteLight.Checked = false;
                checkBoxCustomLight.Checked = false;
                checkBoxBlueLight.Checked = true;
            }
        }
        private void checkBoxCustomLight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackgroundLight.Checked == false)
            {
                checkBoxCustomLight.Checked = false;
            }
            if (checkBoxCustomLight.Checked == true)
            {
                checkBoxBlueLight.Checked = false;
                checkBoxWhiteLight.Checked = false;
                checkBoxCustomLight.Checked = true;
            }
        }

        //Select SerialPort
        private void buttonSelectSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (PortBox.Text.Length < 11)
                {
                    serialPort1.PortName = PortBox.Text;
                }
                else
                {
                    MessageBox.Show("Select Port");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Dismiss Button
        private void button5_Click(object sender, EventArgs e)
        {
            //Reset textbox
            textBoxError.Text = "Color-Code(HEX)";
            textBoxWarning.Text = "Color-Code(HEX)";
            textBoxCheck.Text = "Color-Code(HEX)";
            //reset BlinkmodeError
            checkBoxFastBlinkError.Checked = false;
            checkBoxSlowBlinkError.Checked = false;
            checkBoxSteadyBlinkError.Checked = false;
            //reset BlinkmodeWarning
            checkBoxFastBlinkWarning.Checked = false;
            checkBoxSlowBlinkWarning.Checked = false;
            checkBoxSteadyBlinkWarning.Checked = false;
            //reset BlinkmodeCheck
            checkBoxFastBlinkCheck.Checked = false;
            checkBoxSlowBlinkCheck.Checked = false;
            checkBoxSteadyBlinkCheck.Checked = false;
            //reset Lightshow
            checkBoxLightShow.Checked = false;
            checkBoxFastLightshow.Checked = false;
            checkBoxMediumLightshow.Checked = false;
            checkBoxSlowLightshow.Checked = false;
            //reset BackgroundColor
            checkBoxBackgroundLight.Checked = false;
            checkBoxWhiteLight.Checked = false;
            checkBoxWhiteLight.Checked = false;
            checkBoxCustomLight.Checked = false;
            textBoxBackgroundLight.Text = "Color-Code(HEX)";
            //reset Button Colors
            buttonError.BackColor = Color.Red;
            buttonWarning.BackColor = Color.Orange;
            buttonCheck.BackColor = Color.Green;
            buttonBackgroundLight.BackColor = Color.White;
            //reset PortBox
            PortBox.Text = "select Port";
         }

        //Error Button
        private void buttonError_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorError = colorDialog1.Color;
                buttonError.BackColor = ColorError;
            }
        }
        private void buttonError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonError, "Select Color");
        }

        //Warning Button
        private void buttonWarning_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorWarning = colorDialog1.Color;
                buttonWarning.BackColor = ColorWarning;
            }
        }
        private void buttonWarning_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonWarning, "Select Color");
        }
        //Check Button
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorCheck= colorDialog1.Color;
                buttonCheck.BackColor = ColorCheck;
            }
        }
        private void buttonCheck_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonCheck, "Select Color");
        }
        // Background Custom Light Button
        private void buttonBackgroundLight_Click(object sender, EventArgs e)
        {
            if (checkBoxBackgroundLight.Checked)
            {
                Cursor = Cursors.Hand;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    BackgroundColor = colorDialog1.Color;
                    buttonBackgroundLight.BackColor = BackgroundColor;
                }
            }
        }
        private void buttonBackgroundLight_MouseHover(object sender, EventArgs e)
        {
            if (checkBoxBackgroundLight.Checked)
            {
                toolTip1.SetToolTip(buttonBackgroundLight, "Select Color");
            } else
            {
                toolTip1.SetToolTip(buttonBackgroundLight, "");
            }
        }
    }
}