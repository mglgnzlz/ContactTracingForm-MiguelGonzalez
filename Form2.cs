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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Closes Form2 when close button is clicked
            this.Close();
        }

        private void FileDisplay_TextChanged(object sender, EventArgs e)
        {
            StreamReader ContTractFormRead;
           
            //Reads file in selected directory(*manually coded*)
            ContTractFormRead = File.OpenText(@"D:\CARL\1User Files\Contact Tracing Form.txt");
            while (!ContTractFormRead.EndOfStream)
            {
                FileDisplay.Text = (ContTractFormRead.ReadToEnd());
            }
        }
    }
}
