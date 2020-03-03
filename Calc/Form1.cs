using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is a calculator program that was made to add, subtract,
//multiply, and divide both positive and negative numbers

namespace Calc
{
    

    public partial class Form1 : Form
    {
        //Here is two things, first the value of a 
        //double, then a boolean eqation for an on 
        //and off for an operator click
        private SpeechSynthesizer synth;
        Double value = 0;
        string operation = "";

        Boolean operation_pressed = false;
        public Form1()
        {
            synth = new SpeechSynthesizer();
            InitializeComponent();
            DeliverSpeakingIntro();
        }

        private void DeliverSpeakingIntro()
        {
            //This is an example of how to use a voice in a program
            synth.SelectVoiceByHints(VoiceGender.Male);
            synth.Speak("Welcome to the amazing calculator that talks to you for some reason.");

            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Speak("Now I have the voice of a woman. Yay gender equality"); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //This is whats called when an operator is clicked
        private void operator_Click(object sender, EventArgs e)
        {
            Button operatorInput = (Button)sender;
            operation = operatorInput.Text;
            value = Double.Parse(Display.Text);
            operation_pressed = true;
            if (operation_pressed)
            {
                Display.Clear();
            }
        }

        //This is whats called when a number is clicked
        private void NumButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string str = button.Text;
            Display.Text = Display.Text + str;

        }
        
        //This is to clear the entire entry
        private void ClearEntryBTN_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        //This section is for the equal button and how all
        //the calculations are done
        private void EqualBTN_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Display.Text = (value + Double.Parse(Display.Text)).ToString();
                    break;
                case "-":
                    Display.Text = (value - Double.Parse(Display.Text)).ToString();
                    break;
                case "*":
                    Display.Text = (value * Double.Parse(Display.Text)).ToString();
                    break;
                case "/":
                    Display.Text = (value / Double.Parse(Display.Text)).ToString();
                    break;
            }
            operation_pressed = false;
        }


        //This clears the current entry
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            Display.Clear();
            value = 0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        

        }

        //This makes the number negative when pressed before 
        private void PosNegBTN_Click(object sender, EventArgs e)
        {
            Display.Text = "-";
        }
        

        //This section is for the << button and removes the last
        //digit or operator entered
        private void BackBTN_Click(object sender, EventArgs e)
        {

            if ((String.Compare(Display.Text, " ") < 0))
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1 + 1);
            }
            else
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }




        }
    }
   
}
    
    

