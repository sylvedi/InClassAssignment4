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
            this.SuspendLayout();
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2.ForeColor = System.Drawing.Color.White;
            this.box2.Location = new System.Drawing.Point(573, 68);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(262, 219);
            this.box2.TabIndex = 0;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.ForeColor = System.Drawing.Color.White;
            this.box1.Location = new System.Drawing.Point(152, 68);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(262, 219);
            this.box1.TabIndex = 1;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(308, 369);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(346, 153);
            this.result.TabIndex = 2;
            this.result.Text = "Roll Dice";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 622);
            this.Controls.Add(this.result);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.box2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label box2;
        private System.Windows.Forms.Label box1;
        private System.Windows.Forms.Button result;
    }
}

