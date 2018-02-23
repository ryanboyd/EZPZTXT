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
    public partial class Conditionals : Form
    {
        public ushort NumberOfRules = 1;

        public Conditionals()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            NumberOfRules++;

            ComboBox TargetToAdd = new ComboBox();
            ComboBox ConditionalToAdd = new ComboBox();
            TextBox CriterionToAdd = new TextBox();

            string RuleNumString = NumberOfRules.ToString();

            TargetToAdd.Name = "TargetCombobox" + RuleNumString;
            ConditionalToAdd.Name = "ConditionalCombobox" + RuleNumString;
            CriterionToAdd.Name = "CriterionTextbox" + RuleNumString;

            TargetToAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            ConditionalToAdd.DropDownStyle = ComboBoxStyle.DropDownList;

            TargetToAdd.Items.AddRange(TargetCombobox1.Items.OfType<string>().ToArray());
            ConditionalToAdd.Items.AddRange(ConditionalCombobox1.Items.OfType<string>().ToArray());

            TargetToAdd.Size = TargetCombobox1.Size;
            ConditionalToAdd.Size = ConditionalCombobox1.Size;
            CriterionToAdd.Size = CriterionTextbox1.Size;

            TargetToAdd.Font = TargetCombobox1.Font;
            ConditionalToAdd.Font = ConditionalCombobox1.Font;
            CriterionToAdd.Font = CriterionTextbox1.Font;

            TargetToAdd.Location = new Point(10, 30 * (NumberOfRules - 1) + 4);
            ConditionalToAdd.Location = new Point(223, 30 * (NumberOfRules - 1) + 4);
            CriterionToAdd.Location = new Point(371, 30 * (NumberOfRules - 1) + 5);

            TargetToAdd.SelectedIndex = 0;
            ConditionalToAdd.SelectedIndex = 0;

            

            ConditionalPanel.Controls.Add(TargetToAdd);
            ConditionalPanel.Controls.Add(ConditionalToAdd);
            ConditionalPanel.Controls.Add(CriterionToAdd);

        }
    }
}
