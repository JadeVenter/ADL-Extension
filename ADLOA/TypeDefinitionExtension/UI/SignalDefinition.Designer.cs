namespace DefinitionExtension.UI
{
    partial class frmSignalDefinition
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
            this.lstRules = new System.Windows.Forms.ListBox();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRules
            // 
            this.lstRules.FormattingEnabled = true;
            this.lstRules.Location = new System.Drawing.Point(17, 19);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(348, 173);
            this.lstRules.TabIndex = 0;
            // 
            // txtRule
            // 
            this.txtRule.Location = new System.Drawing.Point(17, 198);
            this.txtRule.Name = "txtRule";
            this.txtRule.Size = new System.Drawing.Size(348, 20);
            this.txtRule.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 22);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Rule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(220, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(145, 22);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Rule";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmSignalDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 269);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.lstRules);
            this.Name = "frmSignalDefinition";
            this.Text = "SignalDefinition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRules;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}