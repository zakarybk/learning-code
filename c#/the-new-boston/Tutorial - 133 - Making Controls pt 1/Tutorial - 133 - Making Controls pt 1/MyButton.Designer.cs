﻿namespace Tutorial___133___Making_Controls_pt_1
{
    partial class MyButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MyButton";
            this.Size = new System.Drawing.Size(118, 39);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MyButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyButton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MyButton_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
