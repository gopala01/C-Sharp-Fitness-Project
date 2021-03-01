namespace LoginAndRegistrationForm2
{
    partial class frmMainMenu
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
            this.buttonTimetable = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTimetable
            // 
            this.buttonTimetable.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.buttonTimetable.ForeColor = System.Drawing.Color.Black;
            this.buttonTimetable.Location = new System.Drawing.Point(126, 44);
            this.buttonTimetable.Name = "buttonTimetable";
            this.buttonTimetable.Size = new System.Drawing.Size(252, 155);
            this.buttonTimetable.TabIndex = 0;
            this.buttonTimetable.Text = "Timetable";
            this.buttonTimetable.UseVisualStyleBackColor = true;
            this.buttonTimetable.Click += new System.EventHandler(this.buttonTimetable_Click);
            // 
            // buttonP
            // 
            this.buttonP.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.buttonP.Location = new System.Drawing.Point(126, 391);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(252, 158);
            this.buttonP.TabIndex = 1;
            this.buttonP.Text = "Progress";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(535, 675);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonTimetable);
            this.Name = "frmMainMenu";
            this.Text = "Text";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTimetable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonP;
    }
}