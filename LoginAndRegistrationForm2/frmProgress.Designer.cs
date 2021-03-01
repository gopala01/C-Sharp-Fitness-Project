namespace LoginAndRegistrationForm2
{
    partial class frmProgress
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
            this.numericUpDownCurrentWeight = new System.Windows.Forms.NumericUpDown();
            this.labelProgressCurrentWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCurrentWeight
            // 
            this.numericUpDownCurrentWeight.Location = new System.Drawing.Point(199, 115);
            this.numericUpDownCurrentWeight.Name = "numericUpDownCurrentWeight";
            this.numericUpDownCurrentWeight.Size = new System.Drawing.Size(297, 20);
            this.numericUpDownCurrentWeight.TabIndex = 0;
            this.numericUpDownCurrentWeight.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelProgressCurrentWeight
            // 
            this.labelProgressCurrentWeight.AutoSize = true;
            this.labelProgressCurrentWeight.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.labelProgressCurrentWeight.ForeColor = System.Drawing.Color.White;
            this.labelProgressCurrentWeight.Location = new System.Drawing.Point(113, 53);
            this.labelProgressCurrentWeight.Name = "labelProgressCurrentWeight";
            this.labelProgressCurrentWeight.Size = new System.Drawing.Size(549, 42);
            this.labelProgressCurrentWeight.TabIndex = 1;
            this.labelProgressCurrentWeight.Text = "Please enter your current weight";
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProgressCurrentWeight);
            this.Controls.Add(this.numericUpDownCurrentWeight);
            this.Name = "frmProgress";
            this.Text = "frmProgress";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCurrentWeight;
        private System.Windows.Forms.Label labelProgressCurrentWeight;
    }
}