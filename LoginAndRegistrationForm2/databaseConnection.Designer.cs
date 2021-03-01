namespace LoginAndRegistrationForm2
{
    partial class databaseConnection
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
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.SQLString = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxSetDate = new System.Windows.Forms.TextBox();
            this.textBoxSetTime = new System.Windows.Forms.TextBox();
            this.textBoxSetActivity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Location = new System.Drawing.Point(29, 12);
            this.textBoxConnection.Multiline = true;
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(444, 182);
            this.textBoxConnection.TabIndex = 0;
            this.textBoxConnection.TextChanged += new System.EventHandler(this.textBoxConnection_TextChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(502, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(116, 53);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(642, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(116, 53);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // SQLString
            // 
            this.SQLString.Location = new System.Drawing.Point(29, 213);
            this.SQLString.Multiline = true;
            this.SQLString.Name = "SQLString";
            this.SQLString.Size = new System.Drawing.Size(444, 182);
            this.SQLString.TabIndex = 3;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(502, 213);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(256, 53);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // textBoxSetDate
            // 
            this.textBoxSetDate.Location = new System.Drawing.Point(870, 357);
            this.textBoxSetDate.Name = "textBoxSetDate";
            this.textBoxSetDate.Size = new System.Drawing.Size(292, 20);
            this.textBoxSetDate.TabIndex = 5;
            this.textBoxSetDate.TextChanged += new System.EventHandler(this.textBoxSetDate_TextChanged);
            // 
            // textBoxSetTime
            // 
            this.textBoxSetTime.Location = new System.Drawing.Point(870, 404);
            this.textBoxSetTime.Name = "textBoxSetTime";
            this.textBoxSetTime.Size = new System.Drawing.Size(292, 20);
            this.textBoxSetTime.TabIndex = 6;
            // 
            // textBoxSetActivity
            // 
            this.textBoxSetActivity.Location = new System.Drawing.Point(870, 456);
            this.textBoxSetActivity.Name = "textBoxSetActivity";
            this.textBoxSetActivity.Size = new System.Drawing.Size(292, 20);
            this.textBoxSetActivity.TabIndex = 7;
            // 
            // databaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 796);
            this.Controls.Add(this.textBoxSetActivity);
            this.Controls.Add(this.textBoxSetTime);
            this.Controls.Add(this.textBoxSetDate);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.SQLString);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxConnection);
            this.Name = "databaseConnection";
            this.Text = "databaseConnection";
            this.Load += new System.EventHandler(this.databaseConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox SQLString;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxSetDate;
        private System.Windows.Forms.TextBox textBoxSetTime;
        private System.Windows.Forms.TextBox textBoxSetActivity;
    }
}