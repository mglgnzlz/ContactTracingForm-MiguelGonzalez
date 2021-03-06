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
          //Assigns LastName_TextBox.Text value to LNTb_Text
           LNTb_Text = LastName_TextBox.Text;
          //Updates the last name part in the ChangeName_Disp
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
            //Calls submit function
            SubmitFunct();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now reset.");
            ResetForm_Disp();
        }

        private void ReadFile_Button_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Once the dialog pops up, press any button to show the file");
            Form2 Frm2 = new Form2();

            //Shows Form2 which will read the output file of the user.
            Frm2.Show();
        }



        //FUNCTIONS//

        public void ChangeName_Disp ()
        {
            //Updates NameDisp_TB.Text value to whatever the user enters in the Name section.
            NameDisp_TB.Text = LNTb_Text + ", " + FNTb_Text + ", " + MNTb_Text;
        }

        private void ResetForm_Disp ()
        {
            //Clears the string inside the boxes where the user fills in information.
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


        private void SubmitFunct()
        {
            //Outputs file into selected directory (*manually coded*)
            StreamWriter ContTracForm;
            ContTracForm = File.AppendText(@"D:\CARL\1User Files\Contact Tracing Form.txt");
            ContTracForm.WriteLine("--------------------");
            ContTracForm.WriteLine(LastName.Text);
            ContTracForm.WriteLine(LastName_TextBox.Text);
            ContTracForm.WriteLine(FirstName.Text);
            ContTracForm.WriteLine(FirstName_TextBox.Text);
            ContTracForm.WriteLine(MiddleName.Text);
            ContTracForm.WriteLine(MiddleName_TextBox.Text);
            ContTracForm.WriteLine(Age_Label.Text);
            ContTracForm.WriteLine(Age_Tb.Text);
            ContTracForm.WriteLine(Birthday_Label.Text);
            ContTracForm.WriteLine(Birthday_Tb.Text);
            ContTracForm.WriteLine(ContactNumber.Text);
            ContTracForm.WriteLine(ContactNumber_TextBox.Text);
            ContTracForm.WriteLine(Ques1_Label.Text);
            ContTracForm.WriteLine(Q1_Tb.Text);
            ContTracForm.WriteLine(Ques2_Label.Text);
            ContTracForm.WriteLine(Q2_Tb.Text);
            ContTracForm.WriteLine(Ques3_Label.Text);
            ContTracForm.WriteLine(Q3_Tb.Text);
            ContTracForm.WriteLine("--------------------");
            ContTracForm.Close();
        }


    }
}
