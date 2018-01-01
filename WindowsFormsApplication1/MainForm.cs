using System;
using System.IO;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;





namespace EZPZTXT
{




    public partial class Form1 : Form
    {


        //this is what runs at initialization
        public Form1()
        {

            InitializeComponent();


            foreach (var encoding in Encoding.GetEncodings())
            {
                EncodingDropdown.Items.Add(encoding.Name);
            }

            
            try
            {
                EncodingDropdown.SelectedIndex = EncodingDropdown.FindStringExact("utf-8");
            }
            catch
            {
                EncodingDropdown.SelectedIndex = EncodingDropdown.FindStringExact(Encoding.Default.BodyName);
            }


            EnclosedInQuotesDropdown.SelectedIndex = 0;
            HeaderRowDropdown.SelectedIndex = 0;
            AppendOrOverwriteDropdown.SelectedIndex = 0;
            SeparateFilesPerColumnDropdown.SelectedIndex = 1;

            label8.Text = "Separate files for\r\neach text column?";

        }






//   _____ _ _      _       _____ _             _     ____        _   _              
//  / ____| (_)    | |     / ____| |           | |   |  _ \      | | | |             
// | |    | |_  ___| | __ | (___ | |_ __ _ _ __| |_  | |_) |_   _| |_| |_ ___  _ __  
// | |    | | |/ __| |/ /  \___ \| __/ _` | '__| __| |  _ <| | | | __| __/ _ \| '_ \ 
// | |____| | | (__|   <   ____) | || (_| | |  | |_  | |_) | |_| | |_| || (_) | | | |
//  \_____|_|_|\___|_|\_\ |_____/ \__\__,_|_|   \__| |____/ \__,_|\__|\__\___/|_| |_|
                                                                              
                                                                                   




        private void StartButton_Click(object sender, EventArgs e)
        {

            EZPZTXT.ColumnChoiceForm ColumnChooser = new EZPZTXT.ColumnChoiceForm();

            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                ColumnChooser.FilenameListbox.Items.Add(column.Name);
                ColumnChooser.FoldernameListbox.Items.Add(column.Name);
                ColumnChooser.TextColumnListbox.Items.Add(column.Name);
            }


            if (ValidateRegex(RegexTextBox.Text))
            {

                //validate the subfolder numbers
                ulong temp_number;
                if (!ulong.TryParse(SubfolderCountTextBox.Text, out temp_number) || temp_number < 0)
                {
                    MessageBox.Show("Your \"New Subfolder\" number does not appear to be a valid entry." + "\r\n" +
                                "Please review and revise your entry to make it a whole number >= 0." + "\r\n" +
                                "Note that a value of 0 will disable this feature.", "Subfolder Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                this.Enabled = false;

                var result = ColumnChooser.ShowDialog();

                if (result == DialogResult.OK)
                {


                    FolderBrowser.Description = "Please choose the OUTPUT location for your files";

                    FolderBrowser.SelectedPath = Path.GetDirectoryName(openFileDialog.FileName);


                    if (FolderBrowser.ShowDialog() != DialogResult.Cancel)
                    {


                        BgWorkerInformation BgData = new BgWorkerInformation();

                        BgData.InputFile = FilenameDisplayBox.Text;
                        BgData.OutputLocation = FolderBrowser.SelectedPath.ToString();
                        BgData.HasHeaders = HeaderRowDropdown.SelectedItem.ToString();
                        BgData.Delimiters = DelimiterTextBox.Text.ToString();
                        BgData.UsingQuotes = EnclosedInQuotesDropdown.SelectedItem.ToString();

                        BgData.FilenameCols = ColumnChooser.FilenameCols;
                        BgData.FolderCols = ColumnChooser.FolderCols;
                        BgData.TextCols = ColumnChooser.TextCols;

                        BgData.ColumnNames = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                         .Select(x => x.HeaderText)
                                         .ToArray();

                        if (AppendOrOverwriteDropdown.SelectedItem.ToString() == "Overwrite")
                        {
                            BgData.OverWriteFiles = true;
                        }
                        else
                        {
                            BgData.OverWriteFiles = false;
                        }

                        BgData.SeparateTextFilesPerColumn = Convert.ToBoolean(SeparateFilesPerColumnDropdown.SelectedItem.ToString());

                        BgData.regex = new Regex(RegexTextBox.Text, RegexOptions.Compiled);
                        BgData.FilenameDelimiter = FilenameDelimiterTextbox.Text;
                        BgData.AutofixFilenames = ColumnChooser.AutofixFilenames;

                        BgData.NewSubfolderNumber = ulong.Parse(SubfolderCountTextBox.Text);

                        DisableButtons();

                        BgWorker.RunWorkerAsync(BgData);

                    }

                }

            }

            this.Enabled = true;
           
        }





        //  _                     _   _____        _          ____        _   _              
        // | |                   | | |  __ \      | |        |  _ \      | | | |             
        // | |     ___   __ _  __| | | |  | | __ _| |_ __ _  | |_) |_   _| |_| |_ ___  _ __  
        // | |    / _ \ / _` |/ _` | | |  | |/ _` | __/ _` | |  _ <| | | | __| __/ _ \| '_ \ 
        // | |___| (_) | (_| | (_| | | |__| | (_| | || (_| | | |_) | |_| | |_| || (_) | | | |
        // |______\___/ \__,_|\__,_| |_____/ \__,_|\__\__,_| |____/ \__,_|\__|\__\___/|_| |_|
        //                                                                                   


        private void GeneratePreviewButton_Click(object sender, EventArgs e)
        {

            FilenameDisplayBox.Text = "No file selected...";

            dataGridView1.DataSource = null;

            openFileDialog.Title = "Please select you data file...";

                DialogResult InputFileDialog = openFileDialog.ShowDialog();

                if (InputFileDialog != DialogResult.Cancel)
                {
                    string InputFile = openFileDialog.FileName;

                    FilenameDisplayBox.Text = InputFile;

                    FilenameDisplayBox.Focus();
                    // Move the caret to the end of the text box
                    FilenameDisplayBox.Select(FilenameDisplayBox.Text.Length, 0);


                BgWorkerInformation BgData = new BgWorkerInformation();

                    BgData.InputFile = FilenameDisplayBox.Text;
                    BgData.HasHeaders = HeaderRowDropdown.SelectedItem.ToString();
                    BgData.Delimiters = DelimiterTextBox.Text.ToString();
                    BgData.UsingQuotes = EnclosedInQuotesDropdown.SelectedItem.ToString();

                    LoadCSVPreview_BGWorker.RunWorkerAsync(BgData);
                }
            else
            {
                FilenameDisplayBox.Text = "No file selected...";
                StartButton.Enabled = false;
                ReloadCSVButton.Enabled = false;
            }
        }





        //  _____      _                 _   _____        _          ______ _ _      
        // |  __ \    | |               | | |  __ \      | |        |  ____(_) |     
        // | |__) |___| | ___   __ _  __| | | |  | | __ _| |_ __ _  | |__   _| | ___ 
        // |  _  // _ \ |/ _ \ / _` |/ _` | | |  | |/ _` | __/ _` | |  __| | | |/ _ \
        // | | \ \  __/ | (_) | (_| | (_| | | |__| | (_| | || (_| | | |    | | |  __/
        // |_|  \_\___|_|\___/ \__,_|\__,_| |_____/ \__,_|\__\__,_| |_|    |_|_|\___|




        private void ReloadCSVButton_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            if (FilenameDisplayBox.Text != "No file selected...")
            {
                BgWorkerInformation BgData = new BgWorkerInformation();

                BgData.InputFile = FilenameDisplayBox.Text;
                BgData.HasHeaders = HeaderRowDropdown.SelectedItem.ToString();
                BgData.Delimiters = DelimiterTextBox.Text.ToString();
                BgData.UsingQuotes = EnclosedInQuotesDropdown.SelectedItem.ToString();

                LoadCSVPreview_BGWorker.RunWorkerAsync(BgData);
            }
        }







        //   _____                           _         _____                _               
        //  / ____|                         | |       |  __ \              (_)              
        // | |  __  ___ _ __   ___ _ __ __ _| |_ ___  | |__) | __ _____   ___  _____      __
        // | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \ |  ___/ '__/ _ \ \ / / |/ _ \ \ /\ / /
        // | |__| |  __/ | | |  __/ | | (_| | ||  __/ | |   | | |  __/\ V /| |  __/\ V  V / 
        //  \_____|\___|_| |_|\___|_|  \__,_|\__\___| |_|   |_|  \___| \_/ |_|\___| \_/\_/  
        //                                                                                                 






        private void LoadCSVPreview_BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {


            //here, we're basically unpacking and redefining all of the core information that was
            //passed to the background worker. it's a bit redundant and not super efficient, but the
            //loss of efficiency is more than made up for by the gains in readability

            BgWorkerInformation BgData = (BgWorkerInformation) e.Argument;

            Encoding SelectedEncoding = null;

            string InputFile = BgData.InputFile;
            bool HasHeaders = Convert.ToBoolean(BgData.HasHeaders);
            string[] Delimiters = BgData.Delimiters.ToCharArray().Select(c => c.ToString()).ToArray(); ;
            bool UsingQuotes = Convert.ToBoolean(BgData.UsingQuotes);




            this.Invoke((MethodInvoker)delegate ()
            {
                SelectedEncoding = Encoding.GetEncoding(EncodingDropdown.SelectedItem.ToString());
            });


            // a data table we'll use to hold the parsed data
            DataTable dt = new DataTable();


            try
            {
                // create the parser
                using (TextFieldParser parser = new TextFieldParser(InputFile, SelectedEncoding))
                {
                    // set the parser variables
                    parser.TrimWhiteSpace = true;
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(Delimiters);
                    parser.HasFieldsEnclosedInQuotes = UsingQuotes;

                    int LineNumber = 0;

                    bool firstLine = true;

                    //report what we're working on
                    FilenameLabel.Invoke((MethodInvoker)delegate
                    {
                        FilenameLabel.Text = "Preparing to read data file for preview...";
                    });


                    while (!parser.EndOfData)
                    {



                        //report what we're working on
                        FilenameLabel.Invoke((MethodInvoker)delegate
                        {
                            FilenameLabel.Text = "Loading data file for preview... Data Row #" + LineNumber.ToString();
                        });


                        //Processing row
                        string[] fields = parser.ReadFields();

                        LineNumber++;

                        // get the column headers
                        if (firstLine)
                        {

                            firstLine = false;

                            if (HasHeaders)
                            {
                                foreach (var val in fields)
                                {
                                    dt.Columns.Add(val);
                                }
                                LineNumber--;
                                continue;
                            }
                            else
                            {
                                for (int i = 1; i <= fields.Length; i++)
                                {
                                    dt.Columns.Add("v" + i.ToString());
                                }

                            }
                        }


                        // get the row data
                        dt.Rows.Add(fields);

                        if (LineNumber > 999)
                        {
                            break;
                        }

                    }

                }

                e.Result = dt;

                if (dt.Columns.Count < 1 || dt.Rows.Count < 1)
                {
                    MessageBox.Show("Your spreadsheet file could not be properly parsed" + "\r\n" +
                                "with the current settings. EZPZTXT could not find any" + "\r\n" +
                               "distinct columns and/or rows in your data file. This is" + "\r\n" +
                               "most often caused by using the wrong delimiter(s).", "Data Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                //what to do if there's an error
                e.Result = false;
            }

        }

        private void LoadCSVPreview_BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            FilenameLabel.Text = "Please wait while preview is being generated... (This might take a while for files with a large number of columns.)";
            FilenameLabel.Invalidate();
            FilenameLabel.Update();
            FilenameLabel.Refresh();
            Application.DoEvents();

            //bind the results to the datagridview
            try { 
                dataGridView1.DataSource = e.Result;
                ReloadCSVButton.Enabled = true;
                StartButton.Enabled = true;
            }
            catch
            {

                ReloadCSVButton.Enabled = false;
                StartButton.Enabled = false;

                MessageBox.Show("Your spreadsheet file could not be properly parsed" + "\r\n" +
                                "with the current settings. Please make sure that the" + "\r\n" +
                               "file is not open elsewhere, check your settings, and" + "\r\n" + 
                               "try again.", "Data Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FilenameLabel.Text = "Finished creating dataset preview.";

        }













        // __          __   _ _          ____        _               _     ______ _ _           
        // \ \        / /  (_) |        / __ \      | |             | |   |  ____(_) |          
        //  \ \  /\  / / __ _| |_ ___  | |  | |_   _| |_ _ __  _   _| |_  | |__   _| | ___  ___ 
        //   \ \/  \/ / '__| | __/ _ \ | |  | | | | | __| '_ \| | | | __| |  __| | | |/ _ \/ __|
        //    \  /\  /| |  | | ||  __/ | |__| | |_| | |_| |_) | |_| | |_  | |    | | |  __/\__ \
        //     \/  \/ |_|  |_|\__\___|  \____/ \__,_|\__| .__/ \__,_|\__| |_|    |_|_|\___||___/
        //                                              | |                                     
        //                                              |_|                                     





        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            //here, we're basically unpacking and redefining all of the core information that was
            //passed to the background worker. it's a bit redundant and not super efficient, but the
            //loss of efficiency is more than made up for by the gains in readability

            BgWorkerInformation BgData = (BgWorkerInformation)e.Argument;

            Encoding SelectedEncoding = null;

            string InputFile = BgData.InputFile;
            bool HasHeaders = Convert.ToBoolean(BgData.HasHeaders);
            string[] Delimiters = BgData.Delimiters.ToCharArray().Select(c => c.ToString()).ToArray(); ;
            bool UsingQuotes = Convert.ToBoolean(BgData.UsingQuotes);

            this.Invoke((MethodInvoker)delegate ()
            {
                SelectedEncoding = Encoding.GetEncoding(EncodingDropdown.SelectedItem.ToString());
            });



            // create the parser
            using (TextFieldParser parser = new TextFieldParser(InputFile, SelectedEncoding))
                {

                    // set the parser properties
                    parser.TrimWhiteSpace = true; //trim the whitespace to make sure that files/folder names don't end with a space, which will break the program
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(Delimiters);
                    parser.HasFieldsEnclosedInQuotes = UsingQuotes;


                    bool firstLine = true;
                    ulong LineNumber = 0;
                    ulong FolderNumber = 1;

                    //report what we're working on
                    FilenameLabel.Invoke((MethodInvoker)delegate
                    {
                        FilenameLabel.Text = "Preparing to write output files...";
                    });



                    //Loop through each row of the dataset
                    while (!parser.EndOfData)
                    {

                        //parse out the row
                        string[] fields = parser.ReadFields();

                        LineNumber++;

                        //report what row we're working on
                        if (LineNumber % 10 == 0) { 
                        FilenameLabel.Invoke((MethodInvoker)delegate
                            {
                                FilenameLabel.Text = "Currently writing text file(s) from row #" + LineNumber.ToString();
                            });
                        }
                        

                        // get the column headers
                        if (firstLine)
                            {
                                firstLine = false;
                                //essentially, if the first line of the dataset is headers, we'll just skip on to the next line
                                if (HasHeaders)
                                {
                                    LineNumber--;
                                    continue;
                                }
                            }

                        

                        




                    //first thing's first -- we need to set our base filename
                    string FilenameBase = fields[BgData.FilenameCols[0]];
                        //...then build out based on the user selections
                        for(int i = 1; i < BgData.FilenameCols.Length; i++)
                        {
                           FilenameBase = string.Join(BgData.FilenameDelimiter, new string[] { FilenameBase, fields[BgData.FilenameCols[i]]} );
                        }




                        //    _                               _          ___       _             _   
                        //   /_\  __ _ __ _ _ _ ___ __ _ __ _| |_ ___   / _ \ _  _| |_ _ __ _  _| |_ 
                        //  / _ \/ _` / _` | '_/ -_) _` / _` |  _/ -_) | (_) | || |  _| '_ \ || |  _|
                        // /_/ \_\__, \__, |_| \___\__, \__,_|\__\___|  \___/ \_,_|\__| .__/\_,_|\__|
                        //       |___/|___/        |___/                              |_|            

                        //now, what we want to do is set up an array that is going to contain all of our output data
                        //this will include the filenames as well as the text that's going to go in each file.
                        //
                        //if the user wants to output different text columns into separate files, then we'll be adding
                        //the text to separate sub-arrays (i.e., different dimensions of our 2D array).
                        //
                        //if they have multiple columns, but they want to just dump them all into a single file per row,
                        //then we just append everything into the same element of the array
                        //
                        //that way, once we get to the part where we're actually writing the files, the code will be the same
                        //for one output file per row as it would be for multiple output files per row. Simple!

                        List<string[]> OutputList = new List<string[]>();

                        for (int i = 0; i < BgData.TextCols.Length; i++)
                        {

                            if (BgData.SeparateTextFilesPerColumn)
                            {
                                //first, we create a new filename based on the FilenameBase. This essentially takes FilenameBase then
                                //adds in the column name of the current text column
                                OutputList.Add(new string[] { string.Join(BgData.FilenameDelimiter, new string[] { FilenameBase, BgData.ColumnNames[BgData.TextCols[i]] }) + ".txt",
                                    BgData.regex.Replace(fields[BgData.TextCols[i]], "") });
                            }

                            //if all of the text columns are going into the same output files
                            else
                            {

                                //if it's the first text column, then add a new list item
                                if (i == 0)
                                {
                                    OutputList.Add(new string[] { FilenameBase + ".txt", BgData.regex.Replace(fields[BgData.TextCols[i]], "") });
                                }
                                //if it's not the first text column, then append the text column to the already existing output string
                                else
                                {
                                    OutputList[0][1] += "\r\n" + BgData.regex.Replace(fields[BgData.TextCols[i]], "");
                                }
                            }


                        }


                    // __      __   _ _          ___       _             _     ___ _ _        
                    // \ \    / / _(_) |_ ___   / _ \ _  _| |_ _ __ _  _| |_  | __(_) |___ ___
                    //  \ \/\/ / '_| |  _/ -_) | (_) | || |  _| '_ \ || |  _| | _|| | / -_|_-<
                    //   \_/\_/|_| |_|\__\___|  \___/ \_,_|\__| .__/\_,_|\__| |_| |_|_\___/__/
                    //                                        |_|             


                    //setup the actual output file location
                    //then we'll make sure the directory exists
                    //THEN, we'll actually write the file
                    string OutputFileLocation = Path.Combine(BgData.OutputLocation, "EZPZTXT");


                    for (int i = 0; i < BgData.FolderCols.Length; i++)
                    {
                        string subfolder = fields[BgData.FolderCols[i]];
                        foreach (var c in Path.GetInvalidFileNameChars()) { subfolder = subfolder.Replace(c, '_'); }
                        OutputFileLocation = Path.Combine(OutputFileLocation, subfolder);
                    }


                    //make sure that we append our folder number
                    //...assuming that we're actually using subfolders
                    if (BgData.NewSubfolderNumber > 0) { 
                        OutputFileLocation = Path.Combine(OutputFileLocation, "Pt_" + (FolderNumber).ToString());

                        if (LineNumber % BgData.NewSubfolderNumber == 0)
                        {
                            FolderNumber++;
                        }
                    }


                    //try to create the output directory
                    try
                    {

                        //this actually doesn't work as well as one would hope. it won't catch things like ":" because, technically,
                        //colons are valid path characters for drive separators (e.g., C:\). Keeping the code here for now, but moved
                        //the validation to earlier using invalid filename chars
                        //if (BgData.AutofixFilenames)
                        //{
                        //    foreach (var c in Path.GetInvalidPathChars()) { OutputFileLocation = OutputFileLocation.Replace(c, '_'); }
                        //}

                        System.IO.Directory.CreateDirectory(OutputFileLocation);
                    }
                    catch
                    {
                        MessageBox.Show("EZPZTXT could not create your output folder:\r\n\r\n" + OutputFileLocation + "\r\n\r\n" +
                           "Is your output directory write protected? Is your folder name valid? Is the folder name too long?");
                            e.Cancel = true;
                            break;
                    }




                    //write each file
                    for (int i=0; i < OutputList.Count; i++)
                    {

                        //fix up filenames if necessary
                        if (BgData.AutofixFilenames)
                        {
                            foreach (var c in Path.GetInvalidFileNameChars()) { OutputList[i][0] = OutputList[i][0].Replace(c, '_'); }
                        }

                        string OutputFile = Path.Combine(OutputFileLocation, OutputList[i][0]);


                        //if it doesn't have a filename, we don't want to try to write it
                        //on second thought, this isn't possible. at the bare minimum, the filename will be ".txt", which can still be written.
                        //if (string.IsNullOrWhiteSpace(OutputFile)) break;


                        try
                        {
                            if (BgData.OverWriteFiles)
                            {
                                using (StreamWriter outputFile = new StreamWriter(new FileStream(OutputFile, FileMode.Create, FileAccess.Write), SelectedEncoding))
                                {
                                    outputFile.Write(OutputList[i][1]);
                                }
                            }
                            else
                            {
                                using (StreamWriter outputFile = new StreamWriter(new FileStream(OutputFile, FileMode.Append, FileAccess.Write), SelectedEncoding))
                                {
                                    outputFile.Write(OutputList[i][1]);
                                }
                            }
                        }
                         
                    catch
                    {
                        MessageBox.Show("EZPZTXT could not create your output file:\r\n\r\n" + OutputFile + "\r\n\r\n" +
                           "Is your output directory/file write protected? Is your filename valid? Is the folder+filename too long?");
                        e.Cancel = true;
                        break;
                    }

                }





                    





                }

            }



  

        }


        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableButtons();
            FilenameLabel.Text = "Finished!   :)";
            MessageBox.Show("EZPZTXT has finished writing your .txt files!", "Analysis Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




















        //borrowed from here:
        //https://stackoverflow.com/a/17546909
        private static DialogResult ShowInputDialog(ref string input, string DialogName)
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 70);
            Form inputBox = new Form();

            inputBox.StartPosition = FormStartPosition.CenterParent;

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            inputBox.ClientSize = size;
            inputBox.Text = DialogName;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }




        //validate regexes
        private static bool ValidateRegex(string RegexInBox)
        {

            bool IsRegexValid = true;

            try
            {
                Regex NewlineClean = new Regex(RegexInBox, RegexOptions.Compiled);
            }
            catch
            {
                IsRegexValid = false;
                MessageBox.Show("Your regular expression (RegEx) does not appear to be" + "\r\n" +
                                "a valid construction. Please review and revise your entry.", "RegEx Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return IsRegexValid;
        }






        //this override makes sure that we don't get errors thrown for fillweight violations.
        //it also sets the basic column width, which is useful for when it only finds one column
        //and looks like nothing is there with default settings
        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 1;
            e.Column.Width = 100;
        }


        public void DisableButtons()
        {
            LoadCSVButton.Enabled = false;
            ReloadCSVButton.Enabled = false;
            StartButton.Enabled = false;

            DelimiterTextBox.Enabled = false;
            EnclosedInQuotesDropdown.Enabled = false;
            HeaderRowDropdown.Enabled = false;
            EncodingDropdown.Enabled = false;

            AppendOrOverwriteDropdown.Enabled = false;
            SeparateFilesPerColumnDropdown.Enabled = false;
            SubfolderCountTextBox.Enabled = false;
            FilenameDelimiterTextbox.Enabled = false;
            RegexTextBox.Enabled = false;
        }

        public void EnableButtons()
        {
            LoadCSVButton.Enabled = true;
            ReloadCSVButton.Enabled = true;
            StartButton.Enabled = true;

            DelimiterTextBox.Enabled = true;
            EnclosedInQuotesDropdown.Enabled = true;
            HeaderRowDropdown.Enabled = true;
            EncodingDropdown.Enabled = true;

            AppendOrOverwriteDropdown.Enabled = true;
            SeparateFilesPerColumnDropdown.Enabled = true;
            SubfolderCountTextBox.Enabled = true;
            FilenameDelimiterTextbox.Enabled = true;
            RegexTextBox.Enabled = true;

        }




        public class BgWorkerInformation
        {
            public string InputFile { get; set; }
            public string OutputLocation { get; set; }
            public string HasHeaders { get; set; }
            public string Delimiters { get; set; }
            public string UsingQuotes { get; set; }

            public int MaxFilesPerFolder { get; set; }
            public bool OverWriteFiles { get; set; }
            public bool SeparateTextFilesPerColumn { get; set; }

            public int[] FilenameCols { get; set; }
            public int[] FolderCols { get; set; }
            public int[] TextCols { get; set; }
            public string[] ColumnNames { get; set; }

            //other options
            public Regex regex;
            public string FilenameDelimiter { get; set; }
            public bool AutofixFilenames { get; set; }
            public ulong NewSubfolderNumber { get; set; }

        }



        private void SubfolderCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
                 
        }
    }












    

}
