
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
            this.Name_Display = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(13, 74);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(42, 15);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name:";
            // 
            // Name_Display
            // 
            this.Name_Display.AutoSize = true;
            this.Name_Display.Location = new System.Drawing.Point(61, 74);
            this.Name_Display.Name = "Name_Display";
            this.Name_Display.Size = new System.Drawing.Size(12, 15);
            this.Name_Display.TabIndex = 1;
            this.Name_Display.Text = "-";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(37, 105);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(66, 15);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name:";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(109, 97);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(213, 23);
            this.LastName_TextBox.TabIndex = 3;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(37, 141);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(67, 15);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "First Name:";
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(109, 133);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(213, 23);
            this.FirstName_TextBox.TabIndex = 5;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(21, 174);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(82, 15);
            this.MiddleName.TabIndex = 6;
            this.MiddleName.Text = "Middle Name:";
            // 
            // MiddleName_TextBox
            // 
            this.MiddleName_TextBox.Location = new System.Drawing.Point(109, 166);
            this.MiddleName_TextBox.Name = "MiddleName_TextBox";
            this.MiddleName_TextBox.Size = new System.Drawing.Size(213, 23);
            this.MiddleName_TextBox.TabIndex = 7;
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.Location = new System.Drawing.Point(13, 212);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(99, 15);
            this.ContactNumber.TabIndex = 8;
            this.ContactNumber.Text = "Contact Number:";
            // 
            // ContactNumber_TextBox
            // 
            this.ContactNumber_TextBox.Location = new System.Drawing.Point(118, 209);
            this.ContactNumber_TextBox.Name = "ContactNumber_TextBox";
            this.ContactNumber_TextBox.Size = new System.Drawing.Size(213, 23);
            this.ContactNumber_TextBox.TabIndex = 9;
            // 
            // HomeAddress
            // 
            this.HomeAddress.AutoSize = true;
            this.HomeAddress.Location = new System.Drawing.Point(13, 241);
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.Size = new System.Drawing.Size(88, 15);
            this.HomeAddress.TabIndex = 10;
            this.HomeAddress.Text = "Home Address:";
            // 
            // HomeAddress_TextBox
            // 
            this.HomeAddress_TextBox.Location = new System.Drawing.Point(118, 238);
            this.HomeAddress_TextBox.Name = "HomeAddress_TextBox";
            this.HomeAddress_TextBox.Size = new System.Drawing.Size(213, 23);
            this.HomeAddress_TextBox.TabIndex = 11;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(247, 335);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(37, 335);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset Form";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 390);
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
            this.Controls.Add(this.Name_Display);
            this.Controls.Add(this.Name_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Name_Display;
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
    }
}

