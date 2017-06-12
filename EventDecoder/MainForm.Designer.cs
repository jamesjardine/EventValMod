namespace EventDecoder
{
  partial class MainForm
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
      this.gbOriginalEv = new System.Windows.Forms.GroupBox();
      this.cmdDecode = new System.Windows.Forms.Button();
      this.txtOriginalEV = new System.Windows.Forms.TextBox();
      this.gbModifiedEV = new System.Windows.Forms.GroupBox();
      this.txtModifiedEV = new System.Windows.Forms.TextBox();
      this.gbInputs = new System.Windows.Forms.GroupBox();
      this.lblItems = new System.Windows.Forms.Label();
      this.cmdInsertInList = new System.Windows.Forms.Button();
      this.cmdCalculate = new System.Windows.Forms.Button();
      this.txtEVHash = new System.Windows.Forms.TextBox();
      this.lblHash = new System.Windows.Forms.Label();
      this.cmdEncode = new System.Windows.Forms.Button();
      this.chkViewState = new System.Windows.Forms.CheckBox();
      this.lstItems = new System.Windows.Forms.ListBox();
      this.txtValue = new System.Windows.Forms.TextBox();
      this.lblValue = new System.Windows.Forms.Label();
      this.txtUniqueId = new System.Windows.Forms.TextBox();
      this.lblUniqueId = new System.Windows.Forms.Label();
      this.lblMessage = new System.Windows.Forms.Label();
      this.gbOriginalEv.SuspendLayout();
      this.gbModifiedEV.SuspendLayout();
      this.gbInputs.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbOriginalEv
      // 
      this.gbOriginalEv.Controls.Add(this.cmdDecode);
      this.gbOriginalEv.Controls.Add(this.txtOriginalEV);
      this.gbOriginalEv.Location = new System.Drawing.Point(13, 13);
      this.gbOriginalEv.Name = "gbOriginalEv";
      this.gbOriginalEv.Size = new System.Drawing.Size(478, 116);
      this.gbOriginalEv.TabIndex = 0;
      this.gbOriginalEv.TabStop = false;
      this.gbOriginalEv.Text = "Original Event Validation";
      // 
      // cmdDecode
      // 
      this.cmdDecode.Location = new System.Drawing.Point(376, 46);
      this.cmdDecode.Name = "cmdDecode";
      this.cmdDecode.Size = new System.Drawing.Size(75, 37);
      this.cmdDecode.TabIndex = 1;
      this.cmdDecode.Text = "Decode";
      this.cmdDecode.UseVisualStyleBackColor = true;
      this.cmdDecode.Click += new System.EventHandler(this.cmdDecode_Click);
      // 
      // txtOriginalEV
      // 
      this.txtOriginalEV.Location = new System.Drawing.Point(7, 20);
      this.txtOriginalEV.Multiline = true;
      this.txtOriginalEV.Name = "txtOriginalEV";
      this.txtOriginalEV.Size = new System.Drawing.Size(363, 90);
      this.txtOriginalEV.TabIndex = 0;
      // 
      // gbModifiedEV
      // 
      this.gbModifiedEV.Controls.Add(this.txtModifiedEV);
      this.gbModifiedEV.Location = new System.Drawing.Point(13, 241);
      this.gbModifiedEV.Name = "gbModifiedEV";
      this.gbModifiedEV.Size = new System.Drawing.Size(478, 116);
      this.gbModifiedEV.TabIndex = 2;
      this.gbModifiedEV.TabStop = false;
      this.gbModifiedEV.Text = "Modified Event Validation";
      // 
      // txtModifiedEV
      // 
      this.txtModifiedEV.Location = new System.Drawing.Point(7, 20);
      this.txtModifiedEV.Multiline = true;
      this.txtModifiedEV.Name = "txtModifiedEV";
      this.txtModifiedEV.Size = new System.Drawing.Size(363, 90);
      this.txtModifiedEV.TabIndex = 0;
      // 
      // gbInputs
      // 
      this.gbInputs.Controls.Add(this.lblItems);
      this.gbInputs.Controls.Add(this.cmdInsertInList);
      this.gbInputs.Controls.Add(this.cmdCalculate);
      this.gbInputs.Controls.Add(this.txtEVHash);
      this.gbInputs.Controls.Add(this.lblHash);
      this.gbInputs.Controls.Add(this.cmdEncode);
      this.gbInputs.Controls.Add(this.chkViewState);
      this.gbInputs.Controls.Add(this.lstItems);
      this.gbInputs.Controls.Add(this.txtValue);
      this.gbInputs.Controls.Add(this.lblValue);
      this.gbInputs.Controls.Add(this.txtUniqueId);
      this.gbInputs.Controls.Add(this.lblUniqueId);
      this.gbInputs.Location = new System.Drawing.Point(497, 13);
      this.gbInputs.Name = "gbInputs";
      this.gbInputs.Size = new System.Drawing.Size(215, 344);
      this.gbInputs.TabIndex = 3;
      this.gbInputs.TabStop = false;
      this.gbInputs.Text = "Event Validation Data";
      // 
      // lblItems
      // 
      this.lblItems.AutoSize = true;
      this.lblItems.Location = new System.Drawing.Point(10, 167);
      this.lblItems.Name = "lblItems";
      this.lblItems.Size = new System.Drawing.Size(126, 13);
      this.lblItems.TabIndex = 11;
      this.lblItems.Text = "Event Validation Hashes:";
      // 
      // cmdInsertInList
      // 
      this.cmdInsertInList.Location = new System.Drawing.Point(109, 122);
      this.cmdInsertInList.Name = "cmdInsertInList";
      this.cmdInsertInList.Size = new System.Drawing.Size(75, 23);
      this.cmdInsertInList.TabIndex = 10;
      this.cmdInsertInList.Text = "Insert";
      this.cmdInsertInList.UseVisualStyleBackColor = true;
      this.cmdInsertInList.Click += new System.EventHandler(this.cmdInsertInList_Click);
      // 
      // cmdCalculate
      // 
      this.cmdCalculate.Location = new System.Drawing.Point(69, 69);
      this.cmdCalculate.Name = "cmdCalculate";
      this.cmdCalculate.Size = new System.Drawing.Size(115, 23);
      this.cmdCalculate.TabIndex = 9;
      this.cmdCalculate.Text = "Calculate";
      this.cmdCalculate.UseVisualStyleBackColor = true;
      this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
      // 
      // txtEVHash
      // 
      this.txtEVHash.Location = new System.Drawing.Point(69, 97);
      this.txtEVHash.Name = "txtEVHash";
      this.txtEVHash.Size = new System.Drawing.Size(115, 20);
      this.txtEVHash.TabIndex = 8;
      // 
      // lblHash
      // 
      this.lblHash.AutoSize = true;
      this.lblHash.Location = new System.Drawing.Point(7, 100);
      this.lblHash.Name = "lblHash";
      this.lblHash.Size = new System.Drawing.Size(52, 13);
      this.lblHash.TabIndex = 7;
      this.lblHash.Text = "EV Hash:";
      // 
      // cmdEncode
      // 
      this.cmdEncode.Location = new System.Drawing.Point(134, 310);
      this.cmdEncode.Name = "cmdEncode";
      this.cmdEncode.Size = new System.Drawing.Size(75, 23);
      this.cmdEncode.TabIndex = 6;
      this.cmdEncode.Text = "Encode";
      this.cmdEncode.UseVisualStyleBackColor = true;
      this.cmdEncode.Click += new System.EventHandler(this.cmdEncode_Click);
      // 
      // chkViewState
      // 
      this.chkViewState.AutoSize = true;
      this.chkViewState.Location = new System.Drawing.Point(10, 128);
      this.chkViewState.Name = "chkViewState";
      this.chkViewState.Size = new System.Drawing.Size(80, 17);
      this.chkViewState.TabIndex = 5;
      this.chkViewState.Text = "ViewState?";
      this.chkViewState.UseVisualStyleBackColor = true;
      // 
      // lstItems
      // 
      this.lstItems.FormattingEnabled = true;
      this.lstItems.Location = new System.Drawing.Point(10, 186);
      this.lstItems.Name = "lstItems";
      this.lstItems.Size = new System.Drawing.Size(115, 147);
      this.lstItems.TabIndex = 4;
      // 
      // txtValue
      // 
      this.txtValue.Location = new System.Drawing.Point(69, 43);
      this.txtValue.Name = "txtValue";
      this.txtValue.Size = new System.Drawing.Size(115, 20);
      this.txtValue.TabIndex = 3;
      // 
      // lblValue
      // 
      this.lblValue.AutoSize = true;
      this.lblValue.Location = new System.Drawing.Point(7, 46);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(37, 13);
      this.lblValue.TabIndex = 2;
      this.lblValue.Text = "Value:";
      // 
      // txtUniqueId
      // 
      this.txtUniqueId.Location = new System.Drawing.Point(69, 17);
      this.txtUniqueId.Name = "txtUniqueId";
      this.txtUniqueId.Size = new System.Drawing.Size(115, 20);
      this.txtUniqueId.TabIndex = 1;
      // 
      // lblUniqueId
      // 
      this.lblUniqueId.AutoSize = true;
      this.lblUniqueId.Location = new System.Drawing.Point(7, 20);
      this.lblUniqueId.Name = "lblUniqueId";
      this.lblUniqueId.Size = new System.Drawing.Size(56, 13);
      this.lblUniqueId.TabIndex = 0;
      this.lblUniqueId.Text = "Unique Id:";
      // 
      // lblMessage
      // 
      this.lblMessage.Location = new System.Drawing.Point(12, 145);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(479, 61);
      this.lblMessage.TabIndex = 12;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(733, 494);
      this.Controls.Add(this.lblMessage);
      this.Controls.Add(this.gbInputs);
      this.Controls.Add(this.gbModifiedEV);
      this.Controls.Add(this.gbOriginalEv);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.gbOriginalEv.ResumeLayout(false);
      this.gbOriginalEv.PerformLayout();
      this.gbModifiedEV.ResumeLayout(false);
      this.gbModifiedEV.PerformLayout();
      this.gbInputs.ResumeLayout(false);
      this.gbInputs.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbOriginalEv;
    private System.Windows.Forms.Button cmdDecode;
    private System.Windows.Forms.TextBox txtOriginalEV;
    private System.Windows.Forms.GroupBox gbModifiedEV;
    private System.Windows.Forms.TextBox txtModifiedEV;
    private System.Windows.Forms.GroupBox gbInputs;
    private System.Windows.Forms.ListBox lstItems;
    private System.Windows.Forms.TextBox txtValue;
    private System.Windows.Forms.Label lblValue;
    private System.Windows.Forms.TextBox txtUniqueId;
    private System.Windows.Forms.Label lblUniqueId;
    private System.Windows.Forms.CheckBox chkViewState;
    private System.Windows.Forms.Button cmdEncode;
    private System.Windows.Forms.Button cmdCalculate;
    private System.Windows.Forms.TextBox txtEVHash;
    private System.Windows.Forms.Label lblHash;
    private System.Windows.Forms.Label lblItems;
    private System.Windows.Forms.Button cmdInsertInList;
    private System.Windows.Forms.Label lblMessage;
  }
}