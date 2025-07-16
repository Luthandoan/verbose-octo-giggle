namespace GymS1
{
    partial class MainForm
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
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(49, 43);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(75, 23);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.Location = new System.Drawing.Point(157, 43);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(75, 23);
            this.btnClasses.TabIndex = 1;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.Location = new System.Drawing.Point(270, 43);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(75, 23);
            this.btnPrograms.TabIndex = 2;
            this.btnPrograms.Text = "Programs";
            this.btnPrograms.UseVisualStyleBackColor = true;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrograms);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.btnMembers);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnPrograms;
    }
}