namespace EZPZTXT
{
    partial class Conditionals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conditionals));
            this.ConditionalPanel = new System.Windows.Forms.Panel();
            this.CriterionTextbox1 = new System.Windows.Forms.TextBox();
            this.ConditionalCombobox1 = new System.Windows.Forms.ComboBox();
            this.TargetCombobox1 = new System.Windows.Forms.ComboBox();
            this.AddRule = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConditionalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConditionalPanel
            // 
            this.ConditionalPanel.AutoScroll = true;
            this.ConditionalPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConditionalPanel.Controls.Add(this.CriterionTextbox1);
            this.ConditionalPanel.Controls.Add(this.ConditionalCombobox1);
            this.ConditionalPanel.Controls.Add(this.TargetCombobox1);
            this.ConditionalPanel.Location = new System.Drawing.Point(12, 43);
            this.ConditionalPanel.Name = "ConditionalPanel";
            this.ConditionalPanel.Size = new System.Drawing.Size(584, 191);
            this.ConditionalPanel.TabIndex = 0;
            // 
            // CriterionTextbox1
            // 
            this.CriterionTextbox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterionTextbox1.Location = new System.Drawing.Point(371, 5);
            this.CriterionTextbox1.Name = "CriterionTextbox1";
            this.CriterionTextbox1.Size = new System.Drawing.Size(186, 23);
            this.CriterionTextbox1.TabIndex = 2;
            // 
            // ConditionalCombobox1
            // 
            this.ConditionalCombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConditionalCombobox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionalCombobox1.FormattingEnabled = true;
            this.ConditionalCombobox1.Location = new System.Drawing.Point(223, 4);
            this.ConditionalCombobox1.Name = "ConditionalCombobox1";
            this.ConditionalCombobox1.Size = new System.Drawing.Size(134, 24);
            this.ConditionalCombobox1.TabIndex = 1;
            // 
            // TargetCombobox1
            // 
            this.TargetCombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetCombobox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetCombobox1.FormattingEnabled = true;
            this.TargetCombobox1.Location = new System.Drawing.Point(10, 4);
            this.TargetCombobox1.Name = "TargetCombobox1";
            this.TargetCombobox1.Size = new System.Drawing.Size(199, 24);
            this.TargetCombobox1.TabIndex = 0;
            // 
            // AddRule
            // 
            this.AddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRule.Location = new System.Drawing.Point(51, 246);
            this.AddRule.Name = "AddRule";
            this.AddRule.Size = new System.Drawing.Size(164, 40);
            this.AddRule.TabIndex = 1;
            this.AddRule.Text = "Add Another Rule";
            this.AddRule.UseVisualStyleBackColor = true;
            this.AddRule.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(221, 246);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(164, 40);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(391, 246);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(164, 40);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Each row in your dataset will be written only if ALL conditions are met:";
            // 
            // Conditionals
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(608, 299);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddRule);
            this.Controls.Add(this.ConditionalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(624, 338);
            this.Name = "Conditionals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conditionals";
            this.TopMost = true;
            this.ConditionalPanel.ResumeLayout(false);
            this.ConditionalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddRule;
        private System.Windows.Forms.TextBox CriterionTextbox1;
        internal System.Windows.Forms.ComboBox TargetCombobox1;
        internal System.Windows.Forms.ComboBox ConditionalCombobox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.Panel ConditionalPanel;
        private System.Windows.Forms.Label label1;
    }
}