namespace EZPZTXT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.StartButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadCSVPreview_BGWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HeaderRowDropdown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReloadCSVButton = new System.Windows.Forms.Button();
            this.EnclosedInQuotesDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DelimiterTextBox = new System.Windows.Forms.TextBox();
            this.RegexTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadCSVButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubfolderCountTextBox = new System.Windows.Forms.TextBox();
            this.FilenameDelimiterTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SeparateFilesPerColumnDropdown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AppendOrOverwriteDropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FilenameDisplayBox = new System.Windows.Forms.TextBox();
            this.IncludeRowNumberInNameCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerSupportsCancellation = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(81, 242);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 34);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Write Text Files";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FilenameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilenameLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameLabel.Location = new System.Drawing.Point(12, 551);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(973, 23);
            this.FilenameLabel.TabIndex = 6;
            this.FilenameLabel.Text = "Waiting to parse data/spreadsheet file...";
            this.FilenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data File Preview (Up to the First 1000 Rows)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncodingDropdown
            // 
            this.EncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodingDropdown.FormattingEnabled = true;
            this.EncodingDropdown.Location = new System.Drawing.Point(124, 120);
            this.EncodingDropdown.Name = "EncodingDropdown";
            this.EncodingDropdown.Size = new System.Drawing.Size(171, 24);
            this.EncodingDropdown.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "File Encoding:";
            // 
            // LoadCSVPreview_BGWorker
            // 
            this.LoadCSVPreview_BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadCSVPreview_BGWorker_DoWork);
            this.LoadCSVPreview_BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadCSVPreview_BGWorker_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HeaderRowDropdown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ReloadCSVButton);
            this.groupBox1.Controls.Add(this.EnclosedInQuotesDropdown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EncodingDropdown);
            this.groupBox1.Controls.Add(this.DelimiterTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(673, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 203);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options for Reading Data File";
            // 
            // HeaderRowDropdown
            // 
            this.HeaderRowDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "True",
            "False"});
            this.HeaderRowDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeaderRowDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderRowDropdown.FormattingEnabled = true;
            this.HeaderRowDropdown.Items.AddRange(new object[] {
            "True",
            "False"});
            this.HeaderRowDropdown.Location = new System.Drawing.Point(208, 90);
            this.HeaderRowDropdown.MaxDropDownItems = 2;
            this.HeaderRowDropdown.Name = "HeaderRowDropdown";
            this.HeaderRowDropdown.Size = new System.Drawing.Size(87, 24);
            this.HeaderRowDropdown.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data has a header row?";
            // 
            // ReloadCSVButton
            // 
            this.ReloadCSVButton.Enabled = false;
            this.ReloadCSVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadCSVButton.Location = new System.Drawing.Point(69, 158);
            this.ReloadCSVButton.Name = "ReloadCSVButton";
            this.ReloadCSVButton.Size = new System.Drawing.Size(175, 34);
            this.ReloadCSVButton.TabIndex = 16;
            this.ReloadCSVButton.Text = "Reload Data Preview";
            this.ReloadCSVButton.UseVisualStyleBackColor = true;
            this.ReloadCSVButton.Click += new System.EventHandler(this.ReloadCSVButton_Click);
            // 
            // EnclosedInQuotesDropdown
            // 
            this.EnclosedInQuotesDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "True",
            "False"});
            this.EnclosedInQuotesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnclosedInQuotesDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnclosedInQuotesDropdown.FormattingEnabled = true;
            this.EnclosedInQuotesDropdown.Items.AddRange(new object[] {
            "True",
            "False"});
            this.EnclosedInQuotesDropdown.Location = new System.Drawing.Point(208, 59);
            this.EnclosedInQuotesDropdown.MaxDropDownItems = 2;
            this.EnclosedInQuotesDropdown.Name = "EnclosedInQuotesDropdown";
            this.EnclosedInQuotesDropdown.Size = new System.Drawing.Size(87, 24);
            this.EnclosedInQuotesDropdown.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fields enclosed in quotes?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data column delimiter(s):";
            // 
            // DelimiterTextBox
            // 
            this.DelimiterTextBox.AcceptsTab = true;
            this.DelimiterTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelimiterTextBox.Location = new System.Drawing.Point(195, 28);
            this.DelimiterTextBox.Name = "DelimiterTextBox";
            this.DelimiterTextBox.Size = new System.Drawing.Size(100, 23);
            this.DelimiterTextBox.TabIndex = 14;
            this.DelimiterTextBox.TabStop = false;
            this.DelimiterTextBox.Text = ",";
            this.DelimiterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RegexTextBox
            // 
            this.RegexTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegexTextBox.Location = new System.Drawing.Point(138, 180);
            this.RegexTextBox.MaxLength = 999999999;
            this.RegexTextBox.Name = "RegexTextBox";
            this.RegexTextBox.Size = new System.Drawing.Size(157, 23);
            this.RegexTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "RegEx Removal:";
            // 
            // LoadCSVButton
            // 
            this.LoadCSVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCSVButton.Location = new System.Drawing.Point(502, 501);
            this.LoadCSVButton.Name = "LoadCSVButton";
            this.LoadCSVButton.Size = new System.Drawing.Size(152, 34);
            this.LoadCSVButton.TabIndex = 12;
            this.LoadCSVButton.Text = "Select Data File";
            this.LoadCSVButton.UseVisualStyleBackColor = true;
            this.LoadCSVButton.Click += new System.EventHandler(this.GeneratePreviewButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text-based Spreadsheet Files (*.csv; *.tsv; *.txt) | *.csv; *.tsv; *.txt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(642, 457);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IncludeRowNumberInNameCheckbox);
            this.groupBox2.Controls.Add(this.SubfolderCountTextBox);
            this.groupBox2.Controls.Add(this.FilenameDelimiterTextbox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.SeparateFilesPerColumnDropdown);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.AppendOrOverwriteDropdown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RegexTextBox);
            this.groupBox2.Controls.Add(this.StartButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(673, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 285);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options for Writing Text Files";
            // 
            // SubfolderCountTextBox
            // 
            this.SubfolderCountTextBox.AcceptsTab = true;
            this.SubfolderCountTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubfolderCountTextBox.Location = new System.Drawing.Point(217, 119);
            this.SubfolderCountTextBox.MaxLength = 10;
            this.SubfolderCountTextBox.Name = "SubfolderCountTextBox";
            this.SubfolderCountTextBox.Size = new System.Drawing.Size(78, 23);
            this.SubfolderCountTextBox.TabIndex = 27;
            this.SubfolderCountTextBox.TabStop = false;
            this.SubfolderCountTextBox.Text = "0";
            this.SubfolderCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SubfolderCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubfolderCountTextBox_KeyPress);
            // 
            // FilenameDelimiterTextbox
            // 
            this.FilenameDelimiterTextbox.AcceptsTab = true;
            this.FilenameDelimiterTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameDelimiterTextbox.Location = new System.Drawing.Point(233, 150);
            this.FilenameDelimiterTextbox.MaxLength = 1;
            this.FilenameDelimiterTextbox.Name = "FilenameDelimiterTextbox";
            this.FilenameDelimiterTextbox.Size = new System.Drawing.Size(62, 23);
            this.FilenameDelimiterTextbox.TabIndex = 21;
            this.FilenameDelimiterTextbox.TabStop = false;
            this.FilenameDelimiterTextbox.Text = ";";
            this.FilenameDelimiterTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Filename delimiting character:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "New subfolder every N files:";
            // 
            // SeparateFilesPerColumnDropdown
            // 
            this.SeparateFilesPerColumnDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "True",
            "False"});
            this.SeparateFilesPerColumnDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeparateFilesPerColumnDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparateFilesPerColumnDropdown.FormattingEnabled = true;
            this.SeparateFilesPerColumnDropdown.Items.AddRange(new object[] {
            "True",
            "False"});
            this.SeparateFilesPerColumnDropdown.Location = new System.Drawing.Point(174, 75);
            this.SeparateFilesPerColumnDropdown.MaxDropDownItems = 2;
            this.SeparateFilesPerColumnDropdown.Name = "SeparateFilesPerColumnDropdown";
            this.SeparateFilesPerColumnDropdown.Size = new System.Drawing.Size(121, 24);
            this.SeparateFilesPerColumnDropdown.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "SepFilesLabel";
            // 
            // AppendOrOverwriteDropdown
            // 
            this.AppendOrOverwriteDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "True",
            "False"});
            this.AppendOrOverwriteDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppendOrOverwriteDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppendOrOverwriteDropdown.FormattingEnabled = true;
            this.AppendOrOverwriteDropdown.Items.AddRange(new object[] {
            "Overwrite",
            "Append"});
            this.AppendOrOverwriteDropdown.Location = new System.Drawing.Point(174, 34);
            this.AppendOrOverwriteDropdown.MaxDropDownItems = 2;
            this.AppendOrOverwriteDropdown.Name = "AppendOrOverwriteDropdown";
            this.AppendOrOverwriteDropdown.Size = new System.Drawing.Size(121, 24);
            this.AppendOrOverwriteDropdown.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Append or Overwrite?";
            // 
            // FilenameDisplayBox
            // 
            this.FilenameDisplayBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilenameDisplayBox.BackColor = System.Drawing.Color.LightGray;
            this.FilenameDisplayBox.Enabled = false;
            this.FilenameDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameDisplayBox.ForeColor = System.Drawing.Color.Black;
            this.FilenameDisplayBox.Location = new System.Drawing.Point(12, 506);
            this.FilenameDisplayBox.MaxLength = 9999999;
            this.FilenameDisplayBox.Name = "FilenameDisplayBox";
            this.FilenameDisplayBox.ReadOnly = true;
            this.FilenameDisplayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FilenameDisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FilenameDisplayBox.Size = new System.Drawing.Size(484, 26);
            this.FilenameDisplayBox.TabIndex = 14;
            this.FilenameDisplayBox.TabStop = false;
            this.FilenameDisplayBox.Text = "No file selected...";
            this.FilenameDisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IncludeRowNumberInNameCheckbox
            // 
            this.IncludeRowNumberInNameCheckbox.AutoSize = true;
            this.IncludeRowNumberInNameCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeRowNumberInNameCheckbox.Location = new System.Drawing.Point(14, 212);
            this.IncludeRowNumberInNameCheckbox.Name = "IncludeRowNumberInNameCheckbox";
            this.IncludeRowNumberInNameCheckbox.Size = new System.Drawing.Size(229, 20);
            this.IncludeRowNumberInNameCheckbox.TabIndex = 28;
            this.IncludeRowNumberInNameCheckbox.Text = "Append Row Number to Filename";
            this.IncludeRowNumberInNameCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(999, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FilenameDisplayBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadCSVButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1015, 620);
            this.MinimumSize = new System.Drawing.Size(1015, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZPZTXT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BgWorker;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EncodingDropdown;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker LoadCSVPreview_BGWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RegexTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadCSVButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DelimiterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EnclosedInQuotesDropdown;
        private System.Windows.Forms.Button ReloadCSVButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox HeaderRowDropdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SeparateFilesPerColumnDropdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AppendOrOverwriteDropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FilenameDisplayBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SubfolderCountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FilenameDelimiterTextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox IncludeRowNumberInNameCheckbox;
    }
}

