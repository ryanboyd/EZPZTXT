using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPZTXT
{
    public partial class ColumnChoiceForm : Form
    {


        public int[] FilenameCols {get;set;}
        public int[] FolderCols { get; set; }
        public int[] TextCols { get; set; }
        public bool AutofixFilenames { get; set; }

        public ColumnChoiceForm()
        {
            InitializeComponent();
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
                this.FilenameCols = GetCheckedListBoxSelections(FilenameListbox);
                this.FolderCols = GetCheckedListBoxSelections(FoldernameListbox);
                this.TextCols = GetCheckedListBoxSelections(TextColumnListbox);
                this.AutofixFilenames = FilenameAutofixCheckbox.Checked;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }



        //borrowed and modified from here
        //https://stackoverflow.com/a/33242986
        public int[] GetCheckedListBoxSelections(CheckedListBox chkList)
        {
            List<int> selectedIndices = new List<int>();

            foreach (object itemChecked in chkList.CheckedItems)
            {

               selectedIndices.Add(chkList.Items.IndexOf(itemChecked));
            }

            return selectedIndices.ToArray();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }




        







    }
}
