﻿namespace LettertypeChaos
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
            this.btnVerander = new System.Windows.Forms.Button();
            this.rtbIO = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnVerander
            // 
            this.btnVerander.Location = new System.Drawing.Point(365, 415);
            this.btnVerander.Name = "btnVerander";
            this.btnVerander.Size = new System.Drawing.Size(75, 23);
            this.btnVerander.TabIndex = 1;
            this.btnVerander.Text = "Verander";
            this.btnVerander.UseVisualStyleBackColor = true;
            this.btnVerander.Click += new System.EventHandler(this.btnVerander_Click);
            // 
            // rtbIO
            // 
            this.rtbIO.Location = new System.Drawing.Point(12, 12);
            this.rtbIO.Name = "rtbIO";
            this.rtbIO.Size = new System.Drawing.Size(776, 397);
            this.rtbIO.TabIndex = 2;
            this.rtbIO.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbIO);
            this.Controls.Add(this.btnVerander);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerander;
        private System.Windows.Forms.RichTextBox rtbIO;
    }
}

