using System;
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


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your response has been recorded! Thank you for answering!");
        }
    }
}
