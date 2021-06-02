
namespace ContactTracingForm_MiguelGonzalez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name_Label = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.Label();
            this.MiddleName_TextBox = new System.Windows.Forms.TextBox();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.ContactNumber_TextBox = new System.Windows.Forms.TextBox();
            this.HomeAddress = new System.Windows.Forms.Label();
            this.HomeAddress_TextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.NameDisp_TB = new System.Windows.Forms.TextBox();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Age_Tb = new System.Windows.Forms.TextBox();
            this.Birthday_Label = new System.Windows.Forms.Label();
            this.Birthday_Tb = new System.Windows.Forms.TextBox();
            this.PersonalInfo_GB = new System.Windows.Forms.GroupBox();
            this.Questions_GB = new System.Windows.Forms.GroupBox();
            this.Q1_GroupBox = new System.Windows.Forms.GroupBox();
            this.Q1_Tb = new System.Windows.Forms.TextBox();
            this.Ques1_Label = new System.Windows.Forms.Label();
            this.Q3_GroupBox = new System.Windows.Forms.GroupBox();
            this.Q3_Tb = new System.Windows.Forms.TextBox();
            this.Ques3_Label = new System.Windows.Forms.Label();
            this.Q2_GroupBox = new System.Windows.Forms.GroupBox();
            this.Q2_Tb = new System.Windows.Forms.TextBox();
            this.Ques2_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalInfo_GB.SuspendLayout();
            this.Questions_GB.SuspendLayout();
            this.Q1_GroupBox.SuspendLayout();
            this.Q3_GroupBox.SuspendLayout();
            this.Q2_GroupBox.SuspendLayout();
            this.SuspendLayout();



            // 
            // NameDisp_TB
            // 
            this.NameDisp_TB.Enabled = false;
            this.NameDisp_TB.Location = new System.Drawing.Point(50, 85);
            this.NameDisp_TB.Name = "NameDisp_TB";
            this.NameDisp_TB.Size = new System.Drawing.Size(261, 23);
            this.NameDisp_TB.TabIndex = 0;
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Location = new System.Drawing.Point(39, 83);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(31, 15);
            this.Age_Label.Text = "Age:";
            // 
            // Age_Tb
            // 
            this.Age_Tb.Location = new System.Drawing.Point(33, 52);
            this.Age_Tb.Name = "Age_Tb";
            this.Age_Tb.Size = new System.Drawing.Size(62, 23);
            this.Age_Tb.TabIndex = 0;
            // 
            // Birthday_Label
            // 
            this.Birthday_Label.AutoSize = true;
            this.Birthday_Label.Location = new System.Drawing.Point(155, 83);
            this.Birthday_Label.Name = "Birthday_Label";
            this.Birthday_Label.Size = new System.Drawing.Size(54, 15);
            this.Birthday_Label.Text = "Birthday:";
            // 
            // Birthday_Tb
            // 
            this.Birthday_Tb.Location = new System.Drawing.Point(172, 52);
            this.Birthday_Tb.Name = "Birthday_Tb";
            this.Birthday_Tb.Size = new System.Drawing.Size(62, 23);
            this.Birthday_Tb.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(39, 121);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(42, 15);

            this.Name_Label.Text = "Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(63, 152);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(66, 15);

            this.LastName.Text = "Last Name:";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(135, 144);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(213, 23);
            this.LastName_TextBox.TabIndex = 3;
            this.LastName_TextBox.TextChanged += new System.EventHandler(this.LastName_TextBox_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(63, 188);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(67, 15);

            this.FirstName.Text = "First Name:";
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(135, 180);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(213, 23);
            this.FirstName_TextBox.TabIndex = 4;
            this.FirstName_TextBox.TextChanged += new System.EventHandler(this.FirstName_TextBox_TextChanged);
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(47, 221);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(82, 15);

            this.MiddleName.Text = "Middle Name:";
            // 
            // MiddleName_TextBox
            // 
            this.MiddleName_TextBox.Location = new System.Drawing.Point(135, 213);
            this.MiddleName_TextBox.Name = "MiddleName_TextBox";
            this.MiddleName_TextBox.Size = new System.Drawing.Size(213, 23);
            this.MiddleName_TextBox.TabIndex = 5;
            this.MiddleName_TextBox.TextChanged += new System.EventHandler(this.MiddleName_TextBox_TextChanged);
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.Location = new System.Drawing.Point(39, 259);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(99, 15);

            this.ContactNumber.Text = "Contact Number:";
            // 
            // ContactNumber_TextBox
            // 
            this.ContactNumber_TextBox.Location = new System.Drawing.Point(144, 256);
            this.ContactNumber_TextBox.Name = "ContactNumber_TextBox";
            this.ContactNumber_TextBox.Size = new System.Drawing.Size(204, 23);
            this.ContactNumber_TextBox.TabIndex = 6;
            // 
            // HomeAddress
            // 
            this.HomeAddress.AutoSize = true;
            this.HomeAddress.Location = new System.Drawing.Point(39, 288);
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.Size = new System.Drawing.Size(88, 15);

            this.HomeAddress.Text = "Home Address:";
            // 
            // HomeAddress_TextBox
            // 
            this.HomeAddress_TextBox.Location = new System.Drawing.Point(144, 285);
            this.HomeAddress_TextBox.Name = "HomeAddress_TextBox";
            this.HomeAddress_TextBox.Size = new System.Drawing.Size(204, 23);
            this.HomeAddress_TextBox.TabIndex = 7;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(619, 335);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 16;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(37, 335);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset Form";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            
            // 
            // PersonalInfo_GB
            // 
            this.PersonalInfo_GB.Controls.Add(this.NameDisp_TB);
            this.PersonalInfo_GB.Controls.Add(this.Birthday_Tb);
            this.PersonalInfo_GB.Controls.Add(this.Age_Tb);
            this.PersonalInfo_GB.Location = new System.Drawing.Point(37, 28);
            this.PersonalInfo_GB.Name = "PersonalInfo_GB";
            this.PersonalInfo_GB.Size = new System.Drawing.Size(321, 301);
            this.PersonalInfo_GB.TabIndex = 0;
            this.PersonalInfo_GB.TabStop = false;
            this.PersonalInfo_GB.Text = "Personal Info Section";
            // 
            // Questions_GB
            // 
            this.Questions_GB.Controls.Add(this.Q1_GroupBox);
            this.Questions_GB.Controls.Add(this.Q3_GroupBox);
            this.Questions_GB.Controls.Add(this.Q2_GroupBox);
            this.Questions_GB.Location = new System.Drawing.Point(373, 28);
            this.Questions_GB.Name = "Questions_GB";
            this.Questions_GB.Size = new System.Drawing.Size(321, 301);
            this.Questions_GB.TabIndex = 8;
            this.Questions_GB.TabStop = false;
            this.Questions_GB.Text = "Questions";
            // 
            // Q1_GroupBox
            // 
            this.Q1_GroupBox.Controls.Add(this.Q1_Tb);
            this.Q1_GroupBox.Controls.Add(this.Ques1_Label);
            this.Q1_GroupBox.Location = new System.Drawing.Point(14, 22);
            this.Q1_GroupBox.Name = "Q1_GroupBox";
            this.Q1_GroupBox.Size = new System.Drawing.Size(293, 86);
            this.Q1_GroupBox.TabIndex = 9;
            this.Q1_GroupBox.TabStop = false;
            this.Q1_GroupBox.Text = "Question # 1";
            // 
            // Q1_Tb
            // 
            this.Q1_Tb.Location = new System.Drawing.Point(9, 53);
            this.Q1_Tb.Name = "Q1_Tb";
            this.Q1_Tb.Size = new System.Drawing.Size(279, 23);
            this.Q1_Tb.TabIndex = 10;
            // 
            // Ques1_Label
            // 
            this.Ques1_Label.AutoSize = true;
            this.Ques1_Label.Location = new System.Drawing.Point(8, 19);
            this.Ques1_Label.Name = "Ques1_Label";
            this.Ques1_Label.Size = new System.Drawing.Size(233, 30);
            this.Ques1_Label.Text = "Do you have any history of travel recently? \r\nIf yes, where?\r\n";
            // 
            // Q3_GroupBox
            // 
            this.Q3_GroupBox.Controls.Add(this.Q3_Tb);
            this.Q3_GroupBox.Controls.Add(this.Ques3_Label);
            this.Q3_GroupBox.Location = new System.Drawing.Point(14, 202);
            this.Q3_GroupBox.Name = "Q3_GroupBox";
            this.Q3_GroupBox.Size = new System.Drawing.Size(293, 93);
            this.Q3_GroupBox.TabIndex = 13;
            this.Q3_GroupBox.TabStop = false;
            this.Q3_GroupBox.Text = "Question # 3";
            // 
            // Q3_Tb
            // 
            this.Q3_Tb.Location = new System.Drawing.Point(9, 55);
            this.Q3_Tb.Name = "Q3_Tb";
            this.Q3_Tb.Size = new System.Drawing.Size(270, 23);
            this.Q3_Tb.TabIndex = 14;
            // 
            // Ques3_Label
            // 
            this.Ques3_Label.AutoSize = true;
            this.Ques3_Label.Location = new System.Drawing.Point(6, 19);
            this.Ques3_Label.Name = "Ques3_Label";
            this.Ques3_Label.Size = new System.Drawing.Size(283, 30);
            this.Ques3_Label.Text = "Have you been exposed to someone diagnosed with\r\nCOVID19 recently? \r\n";
            // 
            // Q2_GroupBox
            // 
            this.Q2_GroupBox.Controls.Add(this.Q2_Tb);
            this.Q2_GroupBox.Controls.Add(this.Ques2_Label);
            this.Q2_GroupBox.Location = new System.Drawing.Point(14, 112);
            this.Q2_GroupBox.Name = "Q2_GroupBox";
            this.Q2_GroupBox.Size = new System.Drawing.Size(293, 86);
            this.Q2_GroupBox.TabIndex = 11;
            this.Q2_GroupBox.TabStop = false;
            this.Q2_GroupBox.Text = "Question # 2";
            // 
            // Q2_Tb
            // 
            this.Q2_Tb.Location = new System.Drawing.Point(9, 53);
            this.Q2_Tb.Name = "Q2_Tb";
            this.Q2_Tb.Size = new System.Drawing.Size(273, 23);
            this.Q2_Tb.TabIndex = 12;
            // 
            // Ques2_Label
            // 
            this.Ques2_Label.AutoSize = true;
            this.Ques2_Label.Location = new System.Drawing.Point(8, 19);
            this.Ques2_Label.Name = "Ques2_Label";
            this.Ques2_Label.Size = new System.Drawing.Size(269, 30);
            this.Ques2_Label.Text = "Have you experienced any symptoms of COVID19\r\nrecently? If yes, please state the " +
    "symptoms below.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 390);
            this.Controls.Add(this.Questions_GB);
            this.Controls.Add(this.Birthday_Label);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.HomeAddress_TextBox);
            this.Controls.Add(this.HomeAddress);
            this.Controls.Add(this.ContactNumber_TextBox);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.MiddleName_TextBox);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName_TextBox);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.PersonalInfo_GB);
            this.Name = "Form1";
            this.Text = "COVID Contact Tracing Form";
            this.PersonalInfo_GB.ResumeLayout(false);
            this.PersonalInfo_GB.PerformLayout();
            this.Questions_GB.ResumeLayout(false);
            this.Q1_GroupBox.ResumeLayout(false);
            this.Q1_GroupBox.PerformLayout();
            this.Q3_GroupBox.ResumeLayout(false);
            this.Q3_GroupBox.PerformLayout();
            this.Q2_GroupBox.ResumeLayout(false);
            this.Q2_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.TextBox MiddleName_TextBox;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.TextBox ContactNumber_TextBox;
        private System.Windows.Forms.Label HomeAddress;
        private System.Windows.Forms.TextBox HomeAddress_TextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox NameDisp_TB;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.TextBox Age_Tb;
        private System.Windows.Forms.Label Birthday_Label;
        private System.Windows.Forms.TextBox Birthday_Tb;
        private System.Windows.Forms.GroupBox PersonalInfo_GB;
        private System.Windows.Forms.GroupBox Questions_GB;
        private System.Windows.Forms.GroupBox Q3_GroupBox;
        private System.Windows.Forms.GroupBox Q2_GroupBox;
        private System.Windows.Forms.TextBox Q3_Tb;
        private System.Windows.Forms.Label Ques3_Label;
        private System.Windows.Forms.TextBox Q2_Tb;
        private System.Windows.Forms.Label Ques2_Label;
        private System.Windows.Forms.TextBox Q1_Tb;
        private System.Windows.Forms.Label Ques1_Label;
        private System.Windows.Forms.GroupBox Q1_GroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

