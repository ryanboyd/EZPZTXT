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
        public List<Tuple<int, string, string>> ConditionalRules_UserSet { get; set; }

        public ColumnChoiceForm()
        {
            InitializeComponent();
            FilenameCols = new List<int>();
            FolderCols = new List<int>();
            TextCols = new List<int>();
            ConditionalRules_UserSet = new List<Tuple<int, string, string>>();
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

        private void AddConditionalsButton_Click(object sender, EventArgs e)
        {

            ConditionalRules_UserSet = new List<Tuple<int, string, string>>();

            EZPZTXT.Conditionals AddConditionals = new EZPZTXT.Conditionals();

            
            //we have to set up our selection options using the dataset columns
            //here, we just rip them off out of what we already have in this form
            foreach (string item in FilenameListbox.Items)
            {
                AddConditionals.TargetCombobox1.Items.Add(item);
            }

            //a little more setup
            AddConditionals.ConditionalCombobox1.Items.Add("is");
            AddConditionals.ConditionalCombobox1.Items.Add("is not");
            AddConditionals.ConditionalCombobox1.Items.Add("contains");
            AddConditionals.ConditionalCombobox1.Items.Add("does not contain");
            AddConditionals.TargetCombobox1.SelectedIndex = 0;
            AddConditionals.ConditionalCombobox1.SelectedIndex = 0;

            //now, let's show the form as a dialog
            var result = AddConditionals.ShowDialog();

            //if everything is good... we want to save this all as a list
            if (result == DialogResult.OK)
            {
                for (ushort rule = 1; rule <= AddConditionals.NumberOfRules; rule++)
                {
                    ComboBox Target = (ComboBox)AddConditionals.ConditionalPanel.Controls.Find("TargetCombobox" + rule.ToString(), true)[0];
                    ComboBox Conditional = (ComboBox)AddConditionals.ConditionalPanel.Controls.Find("ConditionalCombobox" + rule.ToString(), true)[0];
                    TextBox Criterion = (TextBox)AddConditionals.ConditionalPanel.Controls.Find("CriterionTextbox" + rule.ToString(), true)[0];

                    int TargetNum = Target.SelectedIndex; ;
                    string ConditionalStatus = Conditional.SelectedItem.ToString();
                    string CriterionString = Criterion.Text.Trim();

                    ConditionalRules_UserSet.Add(new Tuple<int, string, string>(TargetNum, ConditionalStatus, CriterionString));


                }

                //gotta get rid of any duplicates
                ConditionalRules_UserSet = ConditionalRules_UserSet.Distinct().ToList();

                MessageBox.Show("Your conditionals have been set.", "Rules Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("You have selected the \"Cancel\" button. All rules have" + "\r\n" +
                                "been erased and will not be used.", "Rules Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
