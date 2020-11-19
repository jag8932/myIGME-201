namespace Unit_Test_3_Question3
{
    partial class Form3
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
            this.Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hack = new System.Windows.Forms.Button();
            this.hackBox = new System.Windows.Forms.TextBox();
            this.security = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(100, 9);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(110, 44);
            this.Error.TabIndex = 0;
            this.Error.Text = "Error";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your form is not complete. Please fill out the entire form.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Return To Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Return_To_Form);
            // 
            // hack
            // 
            this.hack.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hack.Location = new System.Drawing.Point(56, 203);
            this.hack.Name = "hack";
            this.hack.Size = new System.Drawing.Size(190, 36);
            this.hack.TabIndex = 3;
            this.hack.Text = "Attempt To Hack";
            this.hack.UseVisualStyleBackColor = true;
            this.hack.Click += new System.EventHandler(this.Attempt_Hack);
            // 
            // hackBox
            // 
            this.hackBox.Enabled = false;
            this.hackBox.Location = new System.Drawing.Point(56, 257);
            this.hackBox.Name = "hackBox";
            this.hackBox.Size = new System.Drawing.Size(190, 20);
            this.hackBox.TabIndex = 4;
            // 
            // security
            // 
            this.security.AutoSize = true;
            this.security.Location = new System.Drawing.Point(56, 299);
            this.security.Name = "security";
            this.security.Size = new System.Drawing.Size(178, 17);
            this.security.TabIndex = 5;
            this.security.Text = "Use Code and Override Security";
            this.security.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 348);
            this.Controls.Add(this.security);
            this.Controls.Add(this.hackBox);
            this.Controls.Add(this.hack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Error);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hack;
        private System.Windows.Forms.TextBox hackBox;
        private System.Windows.Forms.CheckBox security;
    }
}