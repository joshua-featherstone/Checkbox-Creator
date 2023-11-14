
namespace Checkbox_Creator
{
    partial class Form1
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
            this.numCheckboxTextbox = new System.Windows.Forms.TextBox();
            this.userPrompt = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.newLineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numCheckboxTextbox
            // 
            this.numCheckboxTextbox.Location = new System.Drawing.Point(12, 37);
            this.numCheckboxTextbox.Name = "numCheckboxTextbox";
            this.numCheckboxTextbox.Size = new System.Drawing.Size(100, 20);
            this.numCheckboxTextbox.TabIndex = 0;
            // 
            // userPrompt
            // 
            this.userPrompt.AutoSize = true;
            this.userPrompt.Location = new System.Drawing.Point(12, 9);
            this.userPrompt.Name = "userPrompt";
            this.userPrompt.Size = new System.Drawing.Size(231, 13);
            this.userPrompt.TabIndex = 1;
            this.userPrompt.Text = "Enter the number of checkboxes you would like";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(118, 35);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newLineButton
            // 
            this.newLineButton.Location = new System.Drawing.Point(199, 34);
            this.newLineButton.Name = "newLineButton";
            this.newLineButton.Size = new System.Drawing.Size(75, 23);
            this.newLineButton.TabIndex = 3;
            this.newLineButton.Text = "New Line";
            this.newLineButton.UseVisualStyleBackColor = true;
            this.newLineButton.Click += new System.EventHandler(this.newLineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newLineButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.userPrompt);
            this.Controls.Add(this.numCheckboxTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numCheckboxTextbox;
        private System.Windows.Forms.Label userPrompt;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button newLineButton;
    }
}

