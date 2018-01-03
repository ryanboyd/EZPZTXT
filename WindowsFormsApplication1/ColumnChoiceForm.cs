using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EZPZTXT
{
    public partial class ColumnChoiceForm : Form
    {


        public List<int> FilenameCols {get;set;}
        public List<int> FolderCols { get; set; }
        public List<int> TextCols { get; set; }
        public bool AutofixFilenames { get; set; }
        public string filenamedelimiter { get; set; }

        public ColumnChoiceForm()
        {
            InitializeComponent();
            FilenameCols = new List<int>();
            FolderCols = new List<int>();
            TextCols = new List<int>();
        }




        private void StartButton_Click(object sender, EventArgs e)
        {

            if (FilenameListbox.CheckedIndices.Count < 1 || TextColumnListbox.CheckedIndices.Count < 1)
            {
                MessageBox.Show("You must choose at least one column for your filenames and" + "\r\n" +
                                "at least one column that will contain your output texts.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //the old way of handling this. efficient, but doesn't account for order in
                //which boxes were checked
                //this.FilenameCols = GetCheckedListBoxSelections(FilenameListbox);
                //this.FolderCols = GetCheckedListBoxSelections(FoldernameListbox);
                //this.TextCols = GetCheckedListBoxSelections(TextColumnListbox);
                this.AutofixFilenames = FilenameAutofixCheckbox.Checked;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }



        //old way of doing this
        ////borrowed and modified from here
        ////https://stackoverflow.com/a/33242986
        //public int[] GetCheckedListBoxSelections(CheckedListBox chkList)
        //{
        //    List<int> selectedIndices = new List<int>();

        //    foreach (object itemChecked in chkList.CheckedItems)
        //    {

        //       selectedIndices.Add(chkList.Items.IndexOf(itemChecked));
        //    }

        //    return selectedIndices.ToArray();
        //}

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void FoldernameListbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in FoldernameListbox.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
            {
                checkedItems.Add(FoldernameListbox.Items[e.Index].ToString());
                FolderCols.Add(e.Index);
            }
            else
            {
                FolderCols.Remove(e.Index);
            }



            string textbox_text = "";
            foreach (int item in FolderCols)
            {
                textbox_text = Path.Combine(textbox_text, FoldernameListbox.Items[item].ToString());
            }

            FolderTextbox.Text = textbox_text;
            FolderTextbox.Focus();
            // Move the caret to the end of the text box
            FolderTextbox.Select(FolderTextbox.Text.Length, 0);

        }



        private void FilenameListbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in FilenameListbox.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
            {
                checkedItems.Add(FilenameListbox.Items[e.Index].ToString());
                FilenameCols.Add(e.Index);
            }
            else
            {
                FilenameCols.Remove(e.Index);
            }



            string textbox_text = "";
            foreach (int item in FilenameCols)
            {
                textbox_text += FilenameListbox.Items[item].ToString() + filenamedelimiter;
            }

            if (textbox_text.Length > 0) { 
                FilenameTextbox.Text = textbox_text.Substring(0, textbox_text.LastIndexOf(filenamedelimiter));
                FilenameTextbox.Focus();
                // Move the caret to the end of the text box
                FilenameTextbox.Select(FilenameTextbox.Text.Length, 0);
            }
            else
            {
                FilenameTextbox.Text = "";
            }
        }




        private void TextColumnListbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in TextColumnListbox.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
            {
                checkedItems.Add(TextColumnListbox.Items[e.Index].ToString());
                TextCols.Add(e.Index);
            }
            else
            {
                TextCols.Remove(e.Index);
            }



            string textbox_text = "";
            foreach (int item in TextCols)
            {
                textbox_text += TextColumnListbox.Items[item].ToString() + " || ";
            }

            if (textbox_text.Length > 0)
            {
                TextColTextbox.Text = textbox_text.Substring(0, textbox_text.LastIndexOf(" || "));
                TextColTextbox.Focus();
                // Move the caret to the end of the text box
                TextColTextbox.Select(TextColTextbox.Text.Length, 0);
            }
            else
            {
                TextColTextbox.Text = "";
            }
        }



    }
}
