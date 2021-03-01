namespace LoginAndRegistrationForm2
{
    partial class frmTimetable
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxTimeTable = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.flowLayoutPanel1.Controls.Add(this.listBoxTimeTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(338, 267);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listBoxTimeTable
            // 
            this.listBoxTimeTable.FormattingEnabled = true;
            this.listBoxTimeTable.Items.AddRange(new object[] {
            "",
            "7.30 - 8.30",
            "8.30 - 9.30",
            "9.30 - 10.30",
            "10.30 - 11.30",
            "11.30 - 12.30",
            "12.30 - 1.30",
            "1.30 - 2.30",
            "2.30 - 3.30",
            "3.30 - 4.30",
            "4.30 - 5.30",
            "5.30 - 6.30",
            "6.30 - 7.30"});
            this.listBoxTimeTable.Location = new System.Drawing.Point(3, 3);
            this.listBoxTimeTable.Name = "listBoxTimeTable";
            this.listBoxTimeTable.Size = new System.Drawing.Size(323, 251);
            this.listBoxTimeTable.TabIndex = 0;
            this.listBoxTimeTable.SelectedIndexChanged += new System.EventHandler(this.listBoxTimeTable_SelectedIndexChanged);
            // 
            // frmTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 774);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmTimetable";
            this.Text = "frmTimetable";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxTimeTable;
    }
}