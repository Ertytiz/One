﻿namespace Gittest
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
            photo1 = new Button();
            photo2 = new Button();
            SuspendLayout();
            // 
            // photo1
            // 
            photo1.Location = new Point(61, 363);
            photo1.Name = "photo1";
            photo1.Size = new Size(98, 48);
            photo1.TabIndex = 0;
            photo1.Text = "болт";
            photo1.UseVisualStyleBackColor = true;
            photo1.Click += photo1_Click;
            // 
            // photo2
            // 
            photo2.Location = new Point(474, 363);
            photo2.Name = "photo2";
            photo2.Size = new Size(98, 48);
            photo2.TabIndex = 1;
            photo2.Text = "саморез";
            photo2.UseVisualStyleBackColor = true;
            photo2.Click += photo2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(photo2);
            Controls.Add(photo1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button photo1;
        private Button photo2;
    }
}
