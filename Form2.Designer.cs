
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.FileDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(13, 413);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(120, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FileDisplay
            // 
            this.FileDisplay.Location = new System.Drawing.Point(13, 12);
            this.FileDisplay.Multiline = true;
            this.FileDisplay.Name = "FileDisplay";
            this.FileDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileDisplay.Size = new System.Drawing.Size(536, 378);
            this.FileDisplay.TabIndex = 0;
            this.FileDisplay.TextChanged += new System.EventHandler(this.FileDisplay_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.FileDisplay);
            this.Controls.Add(this.CloseButton);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "COVID Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox FileDisplay;
    }
}