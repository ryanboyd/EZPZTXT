namespace EZPZTXT
{
    partial class ColumnChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnChoiceForm));
            this.FilenameListbox = new System.Windows.Forms.CheckedListBox();
            this.FoldernameListbox = new System.Windows.Forms.CheckedListBox();
            this.TextColumnListbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FilenameAutofixCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FilenameListbox
            // 
            this.FilenameListbox.CheckOnClick = true;
            this.FilenameListbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameListbox.FormattingEnabled = true;
            this.FilenameListbox.HorizontalScrollbar = true;
            this.FilenameListbox.Location = new System.Drawing.Point(241, 42);
            this.FilenameListbox.Name = "FilenameListbox";
            this.FilenameListbox.Size = new System.Drawing.Size(197, 274);
            this.FilenameListbox.TabIndex = 0;
            // 
            // FoldernameListbox
            // 
            this.FoldernameListbox.CheckOnClick = true;
            this.FoldernameListbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoldernameListbox.FormattingEnabled = true;
            this.FoldernameListbox.HorizontalScrollbar = true;
            this.FoldernameListbox.Location = new System.Drawing.Point(16, 42);
            this.FoldernameListbox.Name = "FoldernameListbox";
            this.FoldernameListbox.Size = new System.Drawing.Size(197, 274);
            this.FoldernameListbox.TabIndex = 1;
            // 
            // TextColumnListbox
            // 
            this.TextColumnListbox.CheckOnClick = true;
            this.TextColumnListbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextColumnListbox.FormattingEnabled = true;
            this.TextColumnListbox.HorizontalScrollbar = true;
            this.TextColumnListbox.Location = new System.Drawing.Point(469, 42);
            this.TextColumnListbox.Name = "TextColumnListbox";
            this.TextColumnListbox.Size = new System.Drawing.Size(197, 274);
            this.TextColumnListbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Filenames from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create Subfolders from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Columns with Text:";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(350, 365);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 34);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Begin Writing Files";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(180, 365);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(152, 34);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FilenameAutofixCheckbox
            // 
            this.FilenameAutofixCheckbox.AutoSize = true;
            this.FilenameAutofixCheckbox.Checked = true;
            this.FilenameAutofixCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilenameAutofixCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameAutofixCheckbox.Location = new System.Drawing.Point(196, 337);
            this.FilenameAutofixCheckbox.Name = "FilenameAutofixCheckbox";
            this.FilenameAutofixCheckbox.Size = new System.Drawing.Size(287, 20);
            this.FilenameAutofixCheckbox.TabIndex = 8;
            this.FilenameAutofixCheckbox.Text = "Automatically fix invalid filenames and paths";
            this.FilenameAutofixCheckbox.UseVisualStyleBackColor = true;
            // 
            // ColumnChoiceForm
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(681, 417);
            this.ControlBox = false;
            this.Controls.Add(this.FilenameAutofixCheckbox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextColumnListbox);
            this.Controls.Add(this.FoldernameListbox);
            this.Controls.Add(this.FilenameListbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(697, 456);
            this.MinimumSize = new System.Drawing.Size(697, 456);
            this.Name = "ColumnChoiceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Columns...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.CheckedListBox FilenameListbox;
        public System.Windows.Forms.CheckedListBox FoldernameListbox;
        public System.Windows.Forms.CheckedListBox TextColumnListbox;
        private System.Windows.Forms.CheckBox FilenameAutofixCheckbox;
    }
}