﻿namespace InClassAssignment4
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
            this.box2 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2.ForeColor = System.Drawing.Color.White;
            this.box2.Location = new System.Drawing.Point(531, 54);
            this.box2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(303, 175);
            this.box2.TabIndex = 0;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.ForeColor = System.Drawing.Color.White;
            this.box1.Location = new System.Drawing.Point(57, 54);
            this.box1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(307, 175);
            this.box1.TabIndex = 1;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(312, 297);
            this.result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(260, 122);
            this.result.TabIndex = 2;
            this.result.Text = "Roll Dice";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.box2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label box2;
        private System.Windows.Forms.Label box1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label label1;
    }
}

