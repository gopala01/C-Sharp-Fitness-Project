namespace LoginAndRegistrationForm2
{
    partial class FormTimetableMainMenu
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
            this.buttonTimetableMenuBack = new System.Windows.Forms.Button();
            this.buttonDisplayTimetable = new System.Windows.Forms.Button();
            this.buttonSetTimetable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTimetableMenuBack
            // 
            this.buttonTimetableMenuBack.Location = new System.Drawing.Point(274, 261);
            this.buttonTimetableMenuBack.Name = "buttonTimetableMenuBack";
            this.buttonTimetableMenuBack.Size = new System.Drawing.Size(235, 55);
            this.buttonTimetableMenuBack.TabIndex = 10;
            this.buttonTimetableMenuBack.Text = "Back";
            this.buttonTimetableMenuBack.UseVisualStyleBackColor = true;
            // 
            // buttonDisplayTimetable
            // 
            this.buttonDisplayTimetable.Location = new System.Drawing.Point(293, 165);
            this.buttonDisplayTimetable.Name = "buttonDisplayTimetable";
            this.buttonDisplayTimetable.Size = new System.Drawing.Size(197, 38);
            this.buttonDisplayTimetable.TabIndex = 9;
            this.buttonDisplayTimetable.Text = "Display Timetable";
            this.buttonDisplayTimetable.UseVisualStyleBackColor = true;
            this.buttonDisplayTimetable.Click += new System.EventHandler(this.buttonDisplayTimetable_Click);
            // 
            // buttonSetTimetable
            // 
            this.buttonSetTimetable.Location = new System.Drawing.Point(291, 107);
            this.buttonSetTimetable.Name = "buttonSetTimetable";
            this.buttonSetTimetable.Size = new System.Drawing.Size(199, 38);
            this.buttonSetTimetable.TabIndex = 7;
            this.buttonSetTimetable.Text = "Set Timetable";
            this.buttonSetTimetable.UseVisualStyleBackColor = true;
            this.buttonSetTimetable.Click += new System.EventHandler(this.buttonSetTimetable_Click);
            // 
            // FormTimetableMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTimetableMenuBack);
            this.Controls.Add(this.buttonDisplayTimetable);
            this.Controls.Add(this.buttonSetTimetable);
            this.Name = "FormTimetableMainMenu";
            this.Text = "FormTimetableMainMenu";
            this.Load += new System.EventHandler(this.FormTimetableMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTimetableMenuBack;
        private System.Windows.Forms.Button buttonDisplayTimetable;
        private System.Windows.Forms.Button buttonSetTimetable;
    }
}