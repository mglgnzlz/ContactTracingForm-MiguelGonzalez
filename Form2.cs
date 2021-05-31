﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactTracingForm_MiguelGonzalez
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string Age_TB,
               Birthday_TB,
               Q1_TB,
               Q2_TB,
               Q3_TB;

        private void Q1_TextBox_TextChanged(object sender, EventArgs e)
        {
            Q1_TB = Q1_TextBox.Text;
        }

        private void Q2_TextBox_TextChanged(object sender, EventArgs e)
        {
            Q2_TB = Q2_TextBox.Text;
        }

        private void Q3_TextBox_TextChanged(object sender, EventArgs e)
        {
            Q3_TB = Q3_TextBox.Text;
        }

        private void BirthdayTextBox_TextChanged(object sender, EventArgs e)
        {
            Birthday_TB = BirthdayTextBox.Text;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            Age_TB = AgeTextBox.Text;
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your response has been recorded! Thank you for answering!");
            Application.Exit();
        }
        private void ResetForm2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form will now reset.");
            ResetForm_Disp();
        }

        public void ResetForm_Disp()
        {
            Age_TB = "";
            Birthday_TB = "";
            Q1_TB = "";
            Q2_TB = "";
            Q3_TB = "";
            MessageBox.Show("The form is now reset!");

        }

    }
}
