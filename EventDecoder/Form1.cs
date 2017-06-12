using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.UI;
using System.Runtime.InteropServices;
using System.Web.Util;

namespace EventDecoder
{
  public partial class Form1 : Form
  {
    ArrayList _arrayList;

    public Form1()
    {
      InitializeComponent();
    }
    
    /// <summary>
    /// This method will take the unique id and value and create the unique hash code that __EVENTVALIDATION would use.
    /// For fields like ViewState, uniqueId is not used, just the value is used.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {
      int uniqueId = 0;
      int itemValue = 0;

      itemValue = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.GetStringHashCodeValue(txtInput2.Text);

      if (txtInput.Text.Length > 0)
      {
        //value = GetStringHashCode(txtInput.Text);  // Removed to use the new dll.
        uniqueId = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.GetStringHashCodeValue(txtInput.Text);
        txtOutput.Text = (uniqueId ^ itemValue).ToString();
      }
      else
      {
        txtOutput.Text = itemValue.ToString();
      }
       
      if (lstItems.Items.Count > 0)
      {
        for (int x = 0; x < lstItems.Items.Count; x++)
        {
          if (txtOutput.Text == lstItems.Items[x].ToString())
          {
            MessageBox.Show("found");
            break;
          }
        }
      }

      #region OLD CODE
      //txtOutput.Text = value.ToString();
      //value2 = GetStringHashCode(txtInput2.Text); // Removed to use the new dll
      
      //ObjectStateFormatter _formatter = new ObjectStateFormatter();
      //Object test = _formatter.Deserialize(txtBox.Text);
      //value = _formatter.Serialize(_arrayList);
      //_arrayList = new ArrayList();
      //ObjectStateFormatter _formatter = new ObjectStateFormatter();
      //_arrayList = (ArrayList)_formatter.Deserialize(txtInput.Text);
      //WriteArray(_arrayList);
      //_arrayList.Add(1090532978);

      //Console.WriteLine("Modified");
      //txtOutput.Text = _formatter.Serialize(_arrayList);

      //_arrayList = (ArrayList)_formatter.Deserialize(txtOutput.Text);
      //WriteArray(_arrayList);
      #endregion
    }

    private void WriteArray(ArrayList _array)
    {
      for (int i = 0; i < _array.Count; i++)
        Console.WriteLine(_array[i]);
    }

    /// <summary>
    /// This button takes in the raw __EVENTVALIDATION string and deserializes it into an array list of hash codes.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button2_Click(object sender, EventArgs e)
    {
      // Start from scratch here if we are loading a new __EVENTVALIDATION value.
      this._arrayList = new ArrayList();
      this._arrayList.Add(txtInput.Text);
      lstItems.Items.Clear();

             this._arrayList = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.DeSerializeStringToArray2(txtOriginalEventString.Text);
            //this._arrayList = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.DeserializeFrom(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(txtOriginalEventString.Text)));
            for (int i = 0;i < _arrayList.Count;i++)
      {
        lstItems.Items.Add(_arrayList[i]);
      }

      #region OLD CODE
      /*  //This code was commented out to use the new dll.
      ObjectStateFormatter _formatter = new ObjectStateFormatter();
      _arrayList = (ArrayList)_formatter.Deserialize(txtOriginalEventString.Text);
         * */
      //WriteArray(_arrayList);
      //_arrayList.Add(1090532978);
      //Console.WriteLine("Modified");
      //txtModifiedEventString.Text = _formatter.Serialize(_arrayList);

      //_arrayList = (ArrayList)_formatter.Deserialize(txtModifiedEventString.Text);
      //WriteArray(_arrayList);
      #endregion
    }

    /// <summary>
    /// This method serializes the lstItems containing the hash codes into the string that is used for __EVENTVALIDATION.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button3_Click(object sender, EventArgs e)
    {
      _arrayList.Clear();
      for (int i = 0; i < lstItems.Items.Count; i++)
      {
        _arrayList.Add(Int32.Parse(lstItems.Items[i].ToString()));
      }
        
      txtModifiedEventString.Text = JSI.SecurityTools.EventValidationHandler.EventValidationHandler.SerializeArrayToString(_arrayList);

      #region OLD CODE
      /* // This was commented out to be replaced by the new dll.
      ObjectStateFormatter _formatter = new ObjectStateFormatter();
      txtModifiedEventString.Text = _formatter.Serialize(_arrayList);
         */
      #endregion

    }

    /// <summary>
    /// This method adds a newly created value to the lstItems collection.  If 
    /// the value is for the viewstate, it has to be the first item in the list.  Any other 
    /// value can be added to the end of the list.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button4_Click(object sender, EventArgs e)
    {
      if (chkViewState.Checked)
        lstItems.Items[0] = txtOutput.Text;
      else
        lstItems.Items.Add(txtOutput.Text);
    }

      /* // This was commented out to be used in the new DLL
    internal static unsafe int GetStringHashCode(string s)
    {
      fixed (char* str = s)
      {
        char* chPtr = str;
        int num = 0x15051505;
        int num2 = num;
        int* numPtr = (int*)chPtr;
        for (int i = s.Length; i > 0; i -= 4)
        {
          num = (((num << 5) + num) + (num >> 0x1b)) ^ numPtr[0];
          if (i <= 2)
          {
            break;
          }
          num2 = (((num2 << 5) + num2) + (num2 >> 0x1b)) ^ numPtr[1];
          numPtr += 2;
        }
        return (num + (num2 * 0x5d588b65));
      }
    }
       */

    //internal unsafe static int GetStringHashCode2(string s)
    //{
    //  IntPtr arg_0F_0;
    //  int num;
    //  int num2;
    //  fixed (char* myString = s)
    //  {
    //    //IntPtr expr_06 = arg_0F_0 = Marshal.StringToHGlobalUni(s);
    //    IntPtr expr_06 = arg_0F_0 = (IntPtr)myString;
    //    if ((int)expr_06 != 0)
    //    {
    //      arg_0F_0 = (IntPtr)((int)expr_06 + 8);
    //    }
    //    char* ptr = (char*)arg_0F_0;
    //    num = 352654597;
    //    num2 = num;
    //    int* ptr2 = (int*)ptr;
    //    for (int i = s.Length; i > 0; i -= 4)
    //    {
    //      num = ((num << 5) + num + (num >> 27) ^ *ptr2);
    //      if (i <= 2)
    //      {
    //        break;
    //      }
    //      num2 = ((num2 << 5) + num2 + (num2 >> 27) ^ ptr2[(int)((IntPtr)4) / 4]);
    //      ptr2 += (int)((IntPtr)8) / 4;
    //    }
    //  }
    //  return num + num2 * 1566083941;
    //}

    private void label2_Click(object sender, EventArgs e)
    {

    }

      /// <summary>
      /// This is used to try and brute force the values.  This didn't work out that well.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
    private void button5_Click(object sender, EventArgs e)
    {
      _arrayList = new ArrayList();
      for (int i = 0; i < int.MaxValue / 2; i++)
      {
        _arrayList.Add(i);
      }
      ObjectStateFormatter _formatter = new ObjectStateFormatter();
      txtModifiedEventString.Text = _formatter.Serialize(_arrayList);
    }

    private void cmdViewStateTest_Click(object sender, EventArgs e)
    {
      string viewState = txtOriginalEventString.Text;

      ObjectStateFormatter _formatter = new ObjectStateFormatter();
      object _v = _formatter.Deserialize(viewState);
      Pair _parent = (System.Web.UI.Pair)((System.Web.UI.Pair)_v).First;
      Pair _second = (System.Web.UI.Pair)_parent.Second;
      ArrayList _third = (ArrayList)_second.Second;
      Console.WriteLine("hello");
    }






  }
}
