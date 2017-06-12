namespace EventDecoder
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
      this.txtInput = new System.Windows.Forms.TextBox();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.txtInput2 = new System.Windows.Forms.TextBox();
      this.lblUniqueId = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtOriginalEventString = new System.Windows.Forms.TextBox();
      this.txtModifiedEventString = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.lstItems = new System.Windows.Forms.ListBox();
      this.button4 = new System.Windows.Forms.Button();
      this.chkViewState = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(13, 25);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(143, 20);
      this.txtInput.TabIndex = 0;
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(299, 25);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(131, 20);
      this.txtOutput.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(436, 25);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Get Hash";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtInput2
      // 
      this.txtInput2.Location = new System.Drawing.Point(162, 25);
      this.txtInput2.Name = "txtInput2";
      this.txtInput2.Size = new System.Drawing.Size(131, 20);
      this.txtInput2.TabIndex = 3;
      // 
      // lblUniqueId
      // 
      this.lblUniqueId.AutoSize = true;
      this.lblUniqueId.Location = new System.Drawing.Point(13, 6);
      this.lblUniqueId.Name = "lblUniqueId";
      this.lblUniqueId.Size = new System.Drawing.Size(56, 13);
      this.lblUniqueId.TabIndex = 4;
      this.lblUniqueId.Text = "Unique Id:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(159, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Value:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(296, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Hash Code:";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // txtOriginalEventString
      // 
      this.txtOriginalEventString.Location = new System.Drawing.Point(13, 97);
      this.txtOriginalEventString.Name = "txtOriginalEventString";
      this.txtOriginalEventString.Size = new System.Drawing.Size(417, 20);
      this.txtOriginalEventString.TabIndex = 7;
      // 
      // txtModifiedEventString
      // 
      this.txtModifiedEventString.Location = new System.Drawing.Point(16, 322);
      this.txtModifiedEventString.Name = "txtModifiedEventString";
      this.txtModifiedEventString.Size = new System.Drawing.Size(417, 20);
      this.txtModifiedEventString.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 81);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(125, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Original Event Validation:";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(436, 97);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 11;
      this.button2.Text = "DeSerialize";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(454, 320);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 12;
      this.button3.Text = "Serialize";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 306);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(130, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Modified Event Validation:";
      // 
      // lstItems
      // 
      this.lstItems.FormattingEnabled = true;
      this.lstItems.Location = new System.Drawing.Point(16, 134);
      this.lstItems.Name = "lstItems";
      this.lstItems.Size = new System.Drawing.Size(120, 95);
      this.lstItems.TabIndex = 14;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(324, 51);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 15;
      this.button4.Text = "Add To Box";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // chkViewState
      // 
      this.chkViewState.AutoSize = true;
      this.chkViewState.Location = new System.Drawing.Point(13, 52);
      this.chkViewState.Name = "chkViewState";
      this.chkViewState.Size = new System.Drawing.Size(91, 17);
      this.chkViewState.TabIndex = 16;
      this.chkViewState.Text = "Is ViewState?";
      this.chkViewState.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 364);
      this.Controls.Add(this.chkViewState);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.lstItems);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtModifiedEventString);
      this.Controls.Add(this.txtOriginalEventString);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblUniqueId);
      this.Controls.Add(this.txtInput2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.txtInput);
      this.Name = "Form1";
      this.Text = "EventValidation Tool";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtInput2;
    private System.Windows.Forms.Label lblUniqueId;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtOriginalEventString;
    private System.Windows.Forms.TextBox txtModifiedEventString;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListBox lstItems;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.CheckBox chkViewState;
  }
}

