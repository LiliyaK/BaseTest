namespace CarsPriceListWindowsFormsApp
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Add_new_item = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.FormatConversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(121, 138);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(344, 238);
            this.listBox.TabIndex = 0;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(204, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(209, 47);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Add_new_item
            // 
            this.Add_new_item.Enabled = false;
            this.Add_new_item.Location = new System.Drawing.Point(12, 87);
            this.Add_new_item.Name = "Add_new_item";
            this.Add_new_item.Size = new System.Drawing.Size(138, 45);
            this.Add_new_item.TabIndex = 2;
            this.Add_new_item.Text = "Add new item";
            this.Add_new_item.UseVisualStyleBackColor = true;
            this.Add_new_item.Click += new System.EventHandler(this.Add_new_item_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(121, 382);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(138, 45);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Enabled = false;
            this.Update.Location = new System.Drawing.Point(517, 229);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(138, 45);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update File";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.Location = new System.Drawing.Point(327, 382);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(138, 45);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // FormatConversion
            // 
            this.FormatConversion.Enabled = false;
            this.FormatConversion.Location = new System.Drawing.Point(517, 280);
            this.FormatConversion.Name = "FormatConversion";
            this.FormatConversion.Size = new System.Drawing.Size(138, 45);
            this.FormatConversion.TabIndex = 6;
            this.FormatConversion.Text = "Write to other format";
            this.FormatConversion.UseVisualStyleBackColor = true;
            this.FormatConversion.Click += new System.EventHandler(this.FormatConversion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 447);
            this.Controls.Add(this.FormatConversion);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add_new_item);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Add_new_item;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button FormatConversion;
    }
}

