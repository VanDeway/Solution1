﻿namespace XMLDaClient
{
  partial class Form1
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
      this.btnRead = new System.Windows.Forms.Button();
      this.btnWrite = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnRead
      // 
      this.btnRead.Location = new System.Drawing.Point(212, 96);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(97, 52);
      this.btnRead.TabIndex = 0;
      this.btnRead.Text = "Read";
      this.btnRead.UseVisualStyleBackColor = true;
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // btnWrite
      // 
      this.btnWrite.Location = new System.Drawing.Point(450, 96);
      this.btnWrite.Name = "btnWrite";
      this.btnWrite.Size = new System.Drawing.Size(97, 52);
      this.btnWrite.TabIndex = 1;
      this.btnWrite.Text = "Write";
      this.btnWrite.UseVisualStyleBackColor = true;
      this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnWrite);
      this.Controls.Add(this.btnRead);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.Button btnWrite;
  }
}

