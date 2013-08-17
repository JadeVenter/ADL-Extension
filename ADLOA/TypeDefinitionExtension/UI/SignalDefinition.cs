using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeDefinitionExtension.UI
{
    public partial class frmSignalDefinition : Form
    {

        public List<String> rules = new List<string>();


        public frmSignalDefinition()
        {
            InitializeComponent();
        }

        public frmSignalDefinition(List<string> rules)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.rules = rules;
            if (rules != null)
                lstRules.Items.AddRange(rules.ToArray());
            txtRule.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstRules.Items.Add(txtRule.Text);
            rules.Add(txtRule.Text);
            txtRule.Clear();
            txtRule.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            //rules.Remove(rules.Find(delegate(String x) { return (x.Equals(txtRule.Text)); }));
            String toRem = (from x in rules where x.Equals(lstRules.SelectedItem.ToString()) select x).SingleOrDefault();
            MessageBox.Show("Trying to remove: " + toRem);
            rules.Remove(toRem);
            lstRules.Items.Remove(lstRules.SelectedItem);
        }
    }
}
