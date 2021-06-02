using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your response has been recorded, thank you!");
            SubmitFunct();
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now reset.");
            ResetForm_Disp();
        }


        public void ChangeName_Disp ()
        {
            NameDisp_TB.Text = LNTb_Text + ", " + FNTb_Text + ", " + MNTb_Text;
        }

        public void ResetForm_Disp ()
        {
            LastName_TextBox.Text = "";
            FirstName_TextBox.Text = "";
            MiddleName_TextBox.Text = "";
            HomeAddress_TextBox.Text = "";
            ContactNumber_TextBox.Text = "";
            Age_Tb.Text = "";
            Birthday_Tb.Text = "";
            Q1_Tb.Text = "";
            Q2_Tb.Text = "";
            Q3_Tb.Text = "";
            MessageBox.Show("The form is now reset!");
        }

        public void SubmitFunct()
        {
            StreamWriter ContTracForm;
            ContTracForm = File.CreateText(@"D:\CARL\1User Files\Contact Tracing Form.txt");
            ContTracForm.WriteLine(LastName.Text);
            ContTracForm.Write(LastName_TextBox.Text);
            ContTracForm.WriteLine(FirstName.Text);
            ContTracForm.Write(FirstName_TextBox.Text);
            ContTracForm.WriteLine(MiddleName.Text);
            ContTracForm.Write(MiddleName_TextBox.Text);
            ContTracForm.WriteLine(Age_Label.Text);
            ContTracForm.Write(Age_Tb.Text);
            ContTracForm.WriteLine(Birthday_Label.Text);
            ContTracForm.Write(Birthday_Tb.Text);
            ContTracForm.WriteLine(Ques1_Label.Text);
            ContTracForm.Write(Q1_Tb.Text);
            ContTracForm.WriteLine(Ques2_Label.Text);
            ContTracForm.Write(Q2_Tb.Text);
            ContTracForm.WriteLine(Ques3_Label.Text);
            ContTracForm.Write(Q3_Tb.Text);
            ContTracForm.Close();
        }

    }
}
