
namespace ContactTracingForm_MiguelGonzalez
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.Question1Box = new System.Windows.Forms.GroupBox();
            this.Q1_TextBox = new System.Windows.Forms.TextBox();
            this.Q1_Label = new System.Windows.Forms.Label();
            this.Question2Box = new System.Windows.Forms.GroupBox();
            this.Q2_TextBox = new System.Windows.Forms.TextBox();
            this.Q2_Label = new System.Windows.Forms.Label();
            this.Question3Box = new System.Windows.Forms.GroupBox();
            this.Q3_TextBox = new System.Windows.Forms.TextBox();
            this.Q3_Label = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ResetForm2 = new System.Windows.Forms.Button();
            this.Question1Box.SuspendLayout();
            this.Question2Box.SuspendLayout();
            this.Question3Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 21);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(31, 15);
            this.AgeLabel.TabIndex = 0;
            this.AgeLabel.Text = "Age:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(12, 39);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(31, 23);
            this.AgeTextBox.TabIndex = 1;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(60, 21);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(54, 15);
            this.BirthdayLabel.TabIndex = 2;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Location = new System.Drawing.Point(60, 39);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.Size = new System.Drawing.Size(54, 23);
            this.BirthdayTextBox.TabIndex = 3;
            this.BirthdayTextBox.TextChanged += new System.EventHandler(this.BirthdayTextBox_TextChanged);
            // 
            // Question1Box
            // 
            this.Question1Box.Controls.Add(this.Q1_TextBox);
            this.Question1Box.Controls.Add(this.Q1_Label);
            this.Question1Box.Location = new System.Drawing.Point(15, 92);
            this.Question1Box.Name = "Question1Box";
            this.Question1Box.Size = new System.Drawing.Size(339, 78);
            this.Question1Box.TabIndex = 4;
            this.Question1Box.TabStop = false;
            this.Question1Box.Text = "Q#1";
            // 
            // Q1_TextBox
            // 
            this.Q1_TextBox.Location = new System.Drawing.Point(11, 39);
            this.Q1_TextBox.Name = "Q1_TextBox";
            this.Q1_TextBox.Size = new System.Drawing.Size(304, 23);
            this.Q1_TextBox.TabIndex = 1;
            this.Q1_TextBox.TextChanged += new System.EventHandler(this.Q1_TextBox_TextChanged);
            // 
            // Q1_Label
            // 
            this.Q1_Label.AutoSize = true;
            this.Q1_Label.Location = new System.Drawing.Point(9, 19);
            this.Q1_Label.Name = "Q1_Label";
            this.Q1_Label.Size = new System.Drawing.Size(258, 15);
            this.Q1_Label.TabIndex = 0;
            this.Q1_Label.Text = "Do you have any history of travel? If yes, where?";
            // 
            // Question2Box
            // 
            this.Question2Box.Controls.Add(this.Q2_TextBox);
            this.Question2Box.Controls.Add(this.Q2_Label);
            this.Question2Box.Location = new System.Drawing.Point(16, 174);
            this.Question2Box.Name = "Question2Box";
            this.Question2Box.Size = new System.Drawing.Size(339, 100);
            this.Question2Box.TabIndex = 5;
            this.Question2Box.TabStop = false;
            this.Question2Box.Text = "Q#2";
            // 
            // Q2_TextBox
            // 
            this.Q2_TextBox.Location = new System.Drawing.Point(10, 61);
            this.Q2_TextBox.Name = "Q2_TextBox";
            this.Q2_TextBox.Size = new System.Drawing.Size(304, 23);
            this.Q2_TextBox.TabIndex = 1;
            this.Q2_TextBox.TextChanged += new System.EventHandler(this.Q2_TextBox_TextChanged);
            // 
            // Q2_Label
            // 
            this.Q2_Label.AutoSize = true;
            this.Q2_Label.Location = new System.Drawing.Point(9, 19);
            this.Q2_Label.Name = "Q2_Label";
            this.Q2_Label.Size = new System.Drawing.Size(298, 30);
            this.Q2_Label.TabIndex = 0;
            this.Q2_Label.Text = "Have you interacted with someone who was diagnosed\r\nwith COVID recently?";
            // 
            // Question3Box
            // 
            this.Question3Box.Controls.Add(this.Q3_TextBox);
            this.Question3Box.Controls.Add(this.Q3_Label);
            this.Question3Box.Location = new System.Drawing.Point(15, 280);
            this.Question3Box.Name = "Question3Box";
            this.Question3Box.Size = new System.Drawing.Size(339, 100);
            this.Question3Box.TabIndex = 6;
            this.Question3Box.TabStop = false;
            this.Question3Box.Text = "Q#3";
            // 
            // Q3_TextBox
            // 
            this.Q3_TextBox.Location = new System.Drawing.Point(10, 61);
            this.Q3_TextBox.Name = "Q3_TextBox";
            this.Q3_TextBox.Size = new System.Drawing.Size(304, 23);
            this.Q3_TextBox.TabIndex = 1;
            this.Q3_TextBox.TextChanged += new System.EventHandler(this.Q3_TextBox_TextChanged);
            // 
            // Q3_Label
            // 
            this.Q3_Label.AutoSize = true;
            this.Q3_Label.Location = new System.Drawing.Point(9, 19);
            this.Q3_Label.Name = "Q3_Label";
            this.Q3_Label.Size = new System.Drawing.Size(307, 30);
            this.Q3_Label.TabIndex = 0;
            this.Q3_Label.Text = "Have you experienced any symptoms of COVID recently?\r\nIf yes, please state the sy" +
    "mptoms below.";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(255, 395);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 29);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ResetForm2
            // 
            this.ResetForm2.Location = new System.Drawing.Point(39, 395);
            this.ResetForm2.Name = "ResetForm2";
            this.ResetForm2.Size = new System.Drawing.Size(75, 29);
            this.ResetForm2.TabIndex = 8;
            this.ResetForm2.Text = "Reset Form";
            this.ResetForm2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 436);
            this.Controls.Add(this.ResetForm2);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Question3Box);
            this.Controls.Add(this.Question2Box);
            this.Controls.Add(this.Question1Box);
            this.Controls.Add(this.BirthdayTextBox);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "COVID Contact Tracing Form";
            this.Question1Box.ResumeLayout(false);
            this.Question1Box.PerformLayout();
            this.Question2Box.ResumeLayout(false);
            this.Question2Box.PerformLayout();
            this.Question3Box.ResumeLayout(false);
            this.Question3Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.TextBox BirthdayTextBox;
        private System.Windows.Forms.GroupBox Question1Box;
        private System.Windows.Forms.TextBox Q1_TextBox;
        private System.Windows.Forms.Label Q1_Label;
        private System.Windows.Forms.GroupBox Question2Box;
        private System.Windows.Forms.TextBox Q2_TextBox;
        private System.Windows.Forms.Label Q2_Label;
        private System.Windows.Forms.GroupBox Question3Box;
        private System.Windows.Forms.TextBox Q3_TextBox;
        private System.Windows.Forms.Label Q3_Label;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ResetForm2;
    }
}