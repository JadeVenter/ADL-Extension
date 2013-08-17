using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeDefinitionExtension
{
    public partial class frmTypeDefUI : Form
    {
        public List<string> types = new List<string>();

        public frmTypeDefUI()
        {
            InitializeComponent();
        }

        public frmTypeDefUI(List<string> types)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.types = types;
            if (types != null)
                lstTypes.Items.AddRange(types.ToArray());
            txtType.Focus();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            lstTypes.Items.Add(txtType.Text);
            types.Add(txtType.Text);
            txtType.Clear();
            txtType.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            types.Remove(types.Find(delegate(String x) { return x.Equals(lstTypes.SelectedItem.ToString()); }));
            lstTypes.Items.Remove(lstTypes.SelectedItem);
        }

        private void txtType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDefine_Click(this, null);
        }
    }
}
