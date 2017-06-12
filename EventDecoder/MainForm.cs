using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventDecoder
{
  public partial class MainForm : Form
  {
    ArrayList _arrayList;
    public MainForm()
    {
      InitializeComponent();
    }

    private void cmdDecode_Click(object sender, EventArgs e)
    {
      this._arrayList = new ArrayList();
      lstItems.Items.Clear();

            this._arrayList = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.DeSerializeStringToArray(txtOriginalEV.Text);
            //this._arrayList = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.DeserializeFrom(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(txtOriginalEV.Text)));
            for (int i = 0; i < _arrayList.Count; i++)
      {
        lstItems.Items.Add(_arrayList[i]);
      }

      UpdateMessage("");
    }

    private void cmdCalculate_Click(object sender, EventArgs e)
    {
      UpdateMessage("");
      int uniqueId = 0;
      int itemValue = 0;

      itemValue = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.GetStringHashCodeValue(this.txtValue.Text);

      if (this.txtUniqueId.Text.Length > 0)
      {
        //value = GetStringHashCode(txtInput.Text);  // Removed to use the new dll.
        uniqueId = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.GetStringHashCodeValue(this.txtUniqueId.Text);
        this.txtEVHash.Text = (uniqueId ^ itemValue).ToString();
      }
      else
      {
        this.txtEVHash.Text = itemValue.ToString();
      }

      if (lstItems.Items.Count > 0)
      {
        for (int x = 0; x < lstItems.Items.Count; x++)
        {
          if (txtEVHash.Text == lstItems.Items[x].ToString())
          {
            UpdateMessage("The item exists in the list!");
            break;
          }
        }
      }
    }

    private void cmdInsertInList_Click(object sender, EventArgs e)
    {
      if (chkViewState.Checked)
        lstItems.Items[0] = txtEVHash.Text;
      else
        lstItems.Items.Add(txtEVHash.Text);

      UpdateMessage("");
    }

    private void cmdEncode_Click(object sender, EventArgs e)
    {
      _arrayList.Clear();
      for (int i = 0; i < lstItems.Items.Count; i++)
      {
        _arrayList.Add(Int32.Parse(lstItems.Items[i].ToString()));
      }

      txtModifiedEV.Text = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.SerializeArrayToString(_arrayList);

      UpdateMessage("");
    }

    private void UpdateMessage(string Msg)
    {
      lblMessage.Text = Msg;
    }

  }
}
