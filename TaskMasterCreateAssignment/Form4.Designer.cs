namespace TaskMasterCreateAssignment
{
    partial class Form4
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mondayRadioButton = new System.Windows.Forms.RadioButton();
            this.tuesdayRadioButton = new System.Windows.Forms.RadioButton();
            this.wednesdayRadioButton = new System.Windows.Forms.RadioButton();
            this.thursdayRadioButton = new System.Windows.Forms.RadioButton();
            this.fridayRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateEditButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.daysGroupBox = new System.Windows.Forms.GroupBox();
            this.sundayRadioButton = new System.Windows.Forms.RadioButton();
            this.saturdayRadioButton = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.daysGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.daysGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.checkedListBox1);
            this.splitContainer1.Panel2.Controls.Add(this.CreateEditButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 0;
            // 
            // mondayRadioButton
            // 
            this.mondayRadioButton.AutoSize = true;
            this.mondayRadioButton.Checked = true;
            this.mondayRadioButton.Location = new System.Drawing.Point(13, 63);
            this.mondayRadioButton.Name = "mondayRadioButton";
            this.mondayRadioButton.Size = new System.Drawing.Size(63, 17);
            this.mondayRadioButton.TabIndex = 0;
            this.mondayRadioButton.TabStop = true;
            this.mondayRadioButton.Text = "Monday";
            this.mondayRadioButton.UseVisualStyleBackColor = true;
            // 
            // tuesdayRadioButton
            // 
            this.tuesdayRadioButton.AutoSize = true;
            this.tuesdayRadioButton.Location = new System.Drawing.Point(13, 99);
            this.tuesdayRadioButton.Name = "tuesdayRadioButton";
            this.tuesdayRadioButton.Size = new System.Drawing.Size(66, 17);
            this.tuesdayRadioButton.TabIndex = 1;
            this.tuesdayRadioButton.Text = "Tuesday";
            this.tuesdayRadioButton.UseVisualStyleBackColor = true;
            // 
            // wednesdayRadioButton
            // 
            this.wednesdayRadioButton.AutoSize = true;
            this.wednesdayRadioButton.Location = new System.Drawing.Point(13, 139);
            this.wednesdayRadioButton.Name = "wednesdayRadioButton";
            this.wednesdayRadioButton.Size = new System.Drawing.Size(82, 17);
            this.wednesdayRadioButton.TabIndex = 2;
            this.wednesdayRadioButton.Text = "Wednesday";
            this.wednesdayRadioButton.UseVisualStyleBackColor = true;
            // 
            // thursdayRadioButton
            // 
            this.thursdayRadioButton.AutoSize = true;
            this.thursdayRadioButton.Location = new System.Drawing.Point(13, 175);
            this.thursdayRadioButton.Name = "thursdayRadioButton";
            this.thursdayRadioButton.Size = new System.Drawing.Size(69, 17);
            this.thursdayRadioButton.TabIndex = 3;
            this.thursdayRadioButton.Text = "Thursday";
            this.thursdayRadioButton.UseVisualStyleBackColor = true;
            // 
            // fridayRadioButton
            // 
            this.fridayRadioButton.AutoSize = true;
            this.fridayRadioButton.Location = new System.Drawing.Point(13, 208);
            this.fridayRadioButton.Name = "fridayRadioButton";
            this.fridayRadioButton.Size = new System.Drawing.Size(53, 17);
            this.fridayRadioButton.TabIndex = 4;
            this.fridayRadioButton.Text = "Friday";
            this.fridayRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateEditButton
            // 
            this.CreateEditButton.Location = new System.Drawing.Point(553, 3);
            this.CreateEditButton.Name = "CreateEditButton";
            this.CreateEditButton.Size = new System.Drawing.Size(97, 78);
            this.CreateEditButton.TabIndex = 0;
            this.CreateEditButton.Text = "Create/Edit Assignment";
            this.CreateEditButton.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(647, 274);
            this.checkedListBox1.TabIndex = 1;
            // 
            // daysGroupBox
            // 
            this.daysGroupBox.Controls.Add(this.saturdayRadioButton);
            this.daysGroupBox.Controls.Add(this.sundayRadioButton);
            this.daysGroupBox.Controls.Add(this.mondayRadioButton);
            this.daysGroupBox.Controls.Add(this.fridayRadioButton);
            this.daysGroupBox.Controls.Add(this.tuesdayRadioButton);
            this.daysGroupBox.Controls.Add(this.thursdayRadioButton);
            this.daysGroupBox.Controls.Add(this.wednesdayRadioButton);
            this.daysGroupBox.Location = new System.Drawing.Point(13, 73);
            this.daysGroupBox.Name = "daysGroupBox";
            this.daysGroupBox.Size = new System.Drawing.Size(101, 285);
            this.daysGroupBox.TabIndex = 2;
            this.daysGroupBox.TabStop = false;
            this.daysGroupBox.Text = "Assignment Days";
            this.daysGroupBox.Enter += new System.EventHandler(this.daysGroupBox_Enter);
            // 
            // sundayRadioButton
            // 
            this.sundayRadioButton.AutoSize = true;
            this.sundayRadioButton.Location = new System.Drawing.Point(13, 30);
            this.sundayRadioButton.Name = "sundayRadioButton";
            this.sundayRadioButton.Size = new System.Drawing.Size(61, 17);
            this.sundayRadioButton.TabIndex = 5;
            this.sundayRadioButton.TabStop = true;
            this.sundayRadioButton.Text = "Sunday";
            this.sundayRadioButton.UseVisualStyleBackColor = true;
            // 
            // saturdayRadioButton
            // 
            this.saturdayRadioButton.AutoSize = true;
            this.saturdayRadioButton.Location = new System.Drawing.Point(13, 243);
            this.saturdayRadioButton.Name = "saturdayRadioButton";
            this.saturdayRadioButton.Size = new System.Drawing.Size(67, 17);
            this.saturdayRadioButton.TabIndex = 6;
            this.saturdayRadioButton.TabStop = true;
            this.saturdayRadioButton.Text = "Saturday";
            this.saturdayRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(662, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(625, 16);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.daysGroupBox.ResumeLayout(false);
            this.daysGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton fridayRadioButton;
        private System.Windows.Forms.RadioButton thursdayRadioButton;
        private System.Windows.Forms.RadioButton wednesdayRadioButton;
        private System.Windows.Forms.RadioButton tuesdayRadioButton;
        private System.Windows.Forms.RadioButton mondayRadioButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button CreateEditButton;
        private System.Windows.Forms.GroupBox daysGroupBox;
        private System.Windows.Forms.RadioButton sundayRadioButton;
        private System.Windows.Forms.RadioButton saturdayRadioButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}