﻿namespace minigames
{
    partial class NicknameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NicknameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NicknameTextBox
            // 
            resources.ApplyResources(this.NicknameTextBox, "NicknameTextBox");
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.TextChanged += new System.EventHandler(this.NicknameTextBox_TextChanged);
            // 
            // button_submit
            // 
            resources.ApplyResources(this.button_submit, "button_submit");
            this.button_submit.Name = "button_submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // NicknameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.NicknameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NicknameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.Button button_submit;
    }
}