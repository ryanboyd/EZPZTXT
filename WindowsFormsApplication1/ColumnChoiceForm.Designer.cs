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
            this.FolderTextbox = new System.Windows.Forms.TextBox();
            this.FilenameTextbox = new System.Windows.Forms.TextBox();
            this.TextColTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.FilenameListbox.Size = new System.Drawing.Size(197, 238);
            this.FilenameListbox.TabIndex = 0;
            this.FilenameListbox.ThreeDCheckBoxes = true;
            this.FilenameListbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FilenameListbox_ItemCheck);
            // 
            // FoldernameListbox
            // 
            this.FoldernameListbox.CheckOnClick = true;
            this.FoldernameListbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoldernameListbox.FormattingEnabled = true;
            this.FoldernameListbox.HorizontalScrollbar = true;
            this.FoldernameListbox.Location = new System.Drawing.Point(16, 42);
            this.FoldernameListbox.Name = "FoldernameListbox";
            this.FoldernameListbox.Size = new System.Drawing.Size(197, 238);
            this.FoldernameListbox.TabIndex = 1;
            this.FoldernameListbox.ThreeDCheckBoxes = true;
            this.FoldernameListbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FoldernameListbox_ItemCheck);
            // 
            // TextColumnListbox
            // 
            this.TextColumnListbox.CheckOnClick = true;
            this.TextColumnListbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextColumnListbox.FormattingEnabled = true;
            this.TextColumnListbox.HorizontalScrollbar = true;
            this.TextColumnListbox.Location = new System.Drawing.Point(466, 42);
            this.TextColumnListbox.Name = "TextColumnListbox";
            this.TextColumnListbox.Size = new System.Drawing.Size(197, 238);
            this.TextColumnListbox.TabIndex = 2;
            this.TextColumnListbox.ThreeDCheckBoxes = true;
            this.TextColumnListbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TextColumnListbox_ItemCheck);
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
            this.label3.Location = new System.Drawing.Point(462, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Columns with Text:";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(350, 369);
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
            this.CancelButton.Location = new System.Drawing.Point(180, 369);
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
            this.FilenameAutofixCheckbox.Location = new System.Drawing.Point(196, 340);
            this.FilenameAutofixCheckbox.Name = "FilenameAutofixCheckbox";
            this.FilenameAutofixCheckbox.Size = new System.Drawing.Size(287, 20);
            this.FilenameAutofixCheckbox.TabIndex = 8;
            this.FilenameAutofixCheckbox.Text = "Automatically fix invalid filenames and paths";
            this.FilenameAutofixCheckbox.UseVisualStyleBackColor = true;
            // 
            // FolderTextbox
            // 
            this.FolderTextbox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.FolderTextbox.Location = new System.Drawing.Point(16, 306);
            this.FolderTextbox.MaxLength = 2147483647;
            this.FolderTextbox.Name = "FolderTextbox";
            this.FolderTextbox.ReadOnly = true;
            this.FolderTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FolderTextbox.Size = new System.Drawing.Size(197, 20);
            this.FolderTextbox.TabIndex = 9;
            this.FolderTextbox.WordWrap = false;
            // 
            // FilenameTextbox
            // 
            this.FilenameTextbox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.FilenameTextbox.Location = new System.Drawing.Point(241, 306);
            this.FilenameTextbox.MaxLength = 2147483647;
            this.FilenameTextbox.Name = "FilenameTextbox";
            this.FilenameTextbox.ReadOnly = true;
            this.FilenameTextbox.Size = new System.Drawing.Size(197, 20);
            this.FilenameTextbox.TabIndex = 10;
            // 
            // TextColTextbox
            // 
            this.TextColTextbox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextColTextbox.Location = new System.Drawing.Point(466, 306);
            this.TextColTextbox.MaxLength = 2147483647;
            this.TextColTextbox.Name = "TextColTextbox";
            this.TextColTextbox.ReadOnly = true;
            this.TextColTextbox.Size = new System.Drawing.Size(197, 20);
            this.TextColTextbox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subfolder Structure:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Filename Structure:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Text Output Order:";
            // 
            // ColumnChoiceForm
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(679, 417);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextColTextbox);
            this.Controls.Add(this.FilenameTextbox);
            this.Controls.Add(this.FolderTextbox);
            this.Controls.Add(this.FilenameAutofixCheckbox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextColumnListbox);
            this.Controls.Add(this.FoldernameListbox);
            this.Controls.Add(this.FilenameListbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(695, 456);
            this.MinimumSize = new System.Drawing.Size(695, 456);
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
        private System.Windows.Forms.TextBox FolderTextbox;
        private System.Windows.Forms.TextBox FilenameTextbox;
        private System.Windows.Forms.TextBox TextColTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}