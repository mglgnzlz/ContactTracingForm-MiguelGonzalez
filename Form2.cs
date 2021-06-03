using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ContactTracingForm_MiguelGonzalez
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

           
        private void ReadButton_Click(object sender, EventArgs e)
        {
            StreamReader ContTractFormRead;
            ContTractFormRead = File.OpenText(@"D:\CARL\1User Files\Contact Tracing Form.txt");
            while (!ContTractFormRead.EndOfStream)
            {
                FileDisplay.Text = (ContTractFormRead.ReadToEnd());
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
