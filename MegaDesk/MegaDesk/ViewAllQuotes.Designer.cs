﻿namespace MegaDesk
{
  partial class ViewAllQuotes
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
      this.BtnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnExit
      // 
      this.BtnExit.Location = new System.Drawing.Point(523, 367);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(75, 23);
      this.BtnExit.TabIndex = 0;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // ViewAllQuotes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnExit);
      this.Name = "ViewAllQuotes";
      this.Text = "ViewAllQuotes";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button BtnExit;
    }
}