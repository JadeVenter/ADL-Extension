namespace DefinitionExtension
{
    partial class frmTypeDefUI
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
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnDefine = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTypes
            // 
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.Location = new System.Drawing.Point(14, 14);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(203, 212);
            this.lstTypes.TabIndex = 0;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(235, 54);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(169, 20);
            this.txtType.TabIndex = 1;
            this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtType_KeyDown);
            // 
            // btnDefine
            // 
            this.btnDefine.Location = new System.Drawing.Point(235, 89);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(169, 29);
            this.btnDefine.TabIndex = 2;
            this.btnDefine.Text = "Add Type";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(236, 136);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Type";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(235, 198);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(168, 28);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // frmTypeDefUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 243);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDefine);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lstTypes);
            this.Name = "frmTypeDefUI";
            this.Text = "Type Definitions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDone;
    }
}