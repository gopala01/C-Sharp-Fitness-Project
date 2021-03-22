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
            this.labelDietOfTheDay = new System.Windows.Forms.Label();
            this.buttonDotD = new System.Windows.Forms.Button();
            this.labelEotD = new System.Windows.Forms.Label();
            this.buttonEotD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTimetable
            // 
            this.buttonTimetable.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.buttonTimetable.ForeColor = System.Drawing.Color.Black;
            this.buttonTimetable.Location = new System.Drawing.Point(126, 23);
            this.buttonTimetable.Name = "buttonTimetable";
            this.buttonTimetable.Size = new System.Drawing.Size(252, 98);
            this.buttonTimetable.TabIndex = 0;
            this.buttonTimetable.Text = "Timetable";
            this.buttonTimetable.UseVisualStyleBackColor = true;
            this.buttonTimetable.Click += new System.EventHandler(this.buttonTimetable_Click);
            // 
            // buttonP
            // 
            this.buttonP.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.buttonP.Location = new System.Drawing.Point(126, 460);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(252, 89);
            this.buttonP.TabIndex = 1;
            this.buttonP.Text = "Progress";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // labelDietOfTheDay
            // 
            this.labelDietOfTheDay.AutoSize = true;
            this.labelDietOfTheDay.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDietOfTheDay.ForeColor = System.Drawing.Color.White;
            this.labelDietOfTheDay.Location = new System.Drawing.Point(12, 211);
            this.labelDietOfTheDay.Name = "labelDietOfTheDay";
            this.labelDietOfTheDay.Size = new System.Drawing.Size(195, 28);
            this.labelDietOfTheDay.TabIndex = 3;
            this.labelDietOfTheDay.Text = "Diet For The Day:";
            // 
            // buttonDotD
            // 
            this.buttonDotD.Location = new System.Drawing.Point(12, 242);
            this.buttonDotD.Name = "buttonDotD";
            this.buttonDotD.Size = new System.Drawing.Size(205, 88);
            this.buttonDotD.TabIndex = 2;
            this.buttonDotD.UseVisualStyleBackColor = true;
            this.buttonDotD.Click += new System.EventHandler(this.buttonDotD_Click);
            // 
            // labelEotD
            // 
            this.labelEotD.AutoSize = true;
            this.labelEotD.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEotD.ForeColor = System.Drawing.Color.White;
            this.labelEotD.Location = new System.Drawing.Point(279, 211);
            this.labelEotD.Name = "labelEotD";
            this.labelEotD.Size = new System.Drawing.Size(235, 28);
            this.labelEotD.TabIndex = 5;
            this.labelEotD.Text = "Exercise For The Day:";
            this.labelEotD.Click += new System.EventHandler(this.labelEotD_Click);
            // 
            // buttonEotD
            // 
            this.buttonEotD.Location = new System.Drawing.Point(279, 242);
            this.buttonEotD.Name = "buttonEotD";
            this.buttonEotD.Size = new System.Drawing.Size(205, 88);
            this.buttonEotD.TabIndex = 4;
            this.buttonEotD.UseVisualStyleBackColor = true;
            this.buttonEotD.Click += new System.EventHandler(this.buttonDoD_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(535, 675);
            this.Controls.Add(this.labelEotD);
            this.Controls.Add(this.buttonEotD);
            this.Controls.Add(this.labelDietOfTheDay);
            this.Controls.Add(this.buttonDotD);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonTimetable);
            this.Name = "frmMainMenu";
            this.Text = "Text";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTimetable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Label labelDietOfTheDay;
        private System.Windows.Forms.Button buttonDotD;
        private System.Windows.Forms.Label labelEotD;
        private System.Windows.Forms.Button buttonEotD;
    }
}