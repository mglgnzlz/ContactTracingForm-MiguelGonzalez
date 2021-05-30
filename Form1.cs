using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingForm_MiguelGonzalez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string LNTb_Text,
               FNTb_Text,
               MNTb_Text;

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now proceed to the questions part.");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now reset.");
        }

        private void LastName_TextBox_TextChanged(object sender, EventArgs e)
        {
           LNTb_Text = LastName_TextBox.Text;
           ChangeName_Disp();
        }

        private void FirstName_TextBox_TextChanged(object sender, EventArgs e)
        {
            FNTb_Text = FirstName_TextBox.Text;
            ChangeName_Disp();
        }

        private void MiddleName_TextBox_TextChanged(object sender, EventArgs e)
        {
            MNTb_Text = MiddleName_TextBox.Text;
            ChangeName_Disp();
        }

        public void ChangeName_Disp ()
        {
            NameDisp_TB.Text = LNTb_Text + "," + FNTb_Text + "," + MNTb_Text;
        }
    }
}
