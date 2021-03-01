
namespace LoginAndRegistrationForm2
{
    partial class frmQuiz
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
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTargetWeight = new System.Windows.Forms.Label();
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.numCurrentWeight = new System.Windows.Forms.NumericUpDown();
            this.numTargetWeight = new System.Windows.Forms.NumericUpDown();
            this.saveUserDetailsNext = new System.Windows.Forms.Button();
            this.lblDiet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioVeg = new System.Windows.Forms.RadioButton();
            this.radioNonVeg = new System.Windows.Forms.RadioButton();
            this.radioVegan = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.White;
            this.lblDob.Location = new System.Drawing.Point(9, 21);
            this.lblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(270, 42);
            this.lblDob.TabIndex = 1;
            this.lblDob.Text = "DATE OF BIRTH";
            this.lblDob.Click += new System.EventHandler(this.labelUsernameL_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(9, 64);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(152, 42);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "GENDER";
            this.lblGender.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTargetWeight
            // 
            this.lblTargetWeight.AutoSize = true;
            this.lblTargetWeight.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetWeight.ForeColor = System.Drawing.Color.White;
            this.lblTargetWeight.Location = new System.Drawing.Point(9, 145);
            this.lblTargetWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetWeight.Name = "lblTargetWeight";
            this.lblTargetWeight.Size = new System.Drawing.Size(264, 42);
            this.lblTargetWeight.TabIndex = 4;
            this.lblTargetWeight.Text = "END GOAL (kg)";
            // 
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.AutoSize = true;
            this.lblCurrentWeight.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeight.ForeColor = System.Drawing.Color.White;
            this.lblCurrentWeight.Location = new System.Drawing.Point(9, 102);
            this.lblCurrentWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.Size = new System.Drawing.Size(340, 42);
            this.lblCurrentWeight.TabIndex = 3;
            this.lblCurrentWeight.Text = "START WEIGHT (kg)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1965, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(4, 10);
            this.radioMale.Margin = new System.Windows.Forms.Padding(2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 6;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(60, 10);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 7;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.radioOther.Location = new System.Drawing.Point(129, 10);
            this.radioOther.Margin = new System.Windows.Forms.Padding(2);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(51, 17);
            this.radioOther.TabIndex = 8;
            this.radioOther.Text = "Other";
            this.radioOther.UseVisualStyleBackColor = false;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.groupBoxGender.Controls.Add(this.radioMale);
            this.groupBoxGender.Controls.Add(this.radioFemale);
            this.groupBoxGender.Controls.Add(this.radioOther);
            this.groupBoxGender.ForeColor = System.Drawing.Color.White;
            this.groupBoxGender.Location = new System.Drawing.Point(370, 54);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGender.Size = new System.Drawing.Size(205, 38);
            this.groupBoxGender.TabIndex = 9;
            this.groupBoxGender.TabStop = false;
            // 
            // numCurrentWeight
            // 
            this.numCurrentWeight.DecimalPlaces = 2;
            this.numCurrentWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCurrentWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCurrentWeight.Location = new System.Drawing.Point(370, 114);
            this.numCurrentWeight.Margin = new System.Windows.Forms.Padding(2);
            this.numCurrentWeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numCurrentWeight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCurrentWeight.Name = "numCurrentWeight";
            this.numCurrentWeight.Size = new System.Drawing.Size(80, 30);
            this.numCurrentWeight.TabIndex = 10;
            this.numCurrentWeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numTargetWeight
            // 
            this.numTargetWeight.DecimalPlaces = 2;
            this.numTargetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTargetWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numTargetWeight.Location = new System.Drawing.Point(370, 149);
            this.numTargetWeight.Margin = new System.Windows.Forms.Padding(2);
            this.numTargetWeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numTargetWeight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTargetWeight.Name = "numTargetWeight";
            this.numTargetWeight.Size = new System.Drawing.Size(80, 30);
            this.numTargetWeight.TabIndex = 11;
            this.numTargetWeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTargetWeight.ValueChanged += new System.EventHandler(this.numTargetWeight_ValueChanged);
            // 
            // saveUserDetailsNext
            // 
            this.saveUserDetailsNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.saveUserDetailsNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveUserDetailsNext.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserDetailsNext.ForeColor = System.Drawing.Color.White;
            this.saveUserDetailsNext.Location = new System.Drawing.Point(274, 381);
            this.saveUserDetailsNext.Name = "saveUserDetailsNext";
            this.saveUserDetailsNext.Size = new System.Drawing.Size(144, 43);
            this.saveUserDetailsNext.TabIndex = 12;
            this.saveUserDetailsNext.Text = "NEXT";
            this.saveUserDetailsNext.UseVisualStyleBackColor = false;
            this.saveUserDetailsNext.Click += new System.EventHandler(this.saveUserDetails_Click);
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiet.ForeColor = System.Drawing.Color.White;
            this.lblDiet.Location = new System.Drawing.Point(9, 184);
            this.lblDiet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(182, 42);
            this.lblDiet.TabIndex = 13;
            this.lblDiet.Text = "DIET TYPE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.radioVeg);
            this.groupBox1.Controls.Add(this.radioNonVeg);
            this.groupBox1.Controls.Add(this.radioVegan);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(370, 191);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(205, 38);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioVeg
            // 
            this.radioVeg.AutoSize = true;
            this.radioVeg.Checked = true;
            this.radioVeg.Location = new System.Drawing.Point(4, 10);
            this.radioVeg.Margin = new System.Windows.Forms.Padding(2);
            this.radioVeg.Name = "radioVeg";
            this.radioVeg.Size = new System.Drawing.Size(44, 17);
            this.radioVeg.TabIndex = 6;
            this.radioVeg.TabStop = true;
            this.radioVeg.Text = "Veg";
            this.radioVeg.UseVisualStyleBackColor = true;
            // 
            // radioNonVeg
            // 
            this.radioNonVeg.AutoSize = true;
            this.radioNonVeg.Location = new System.Drawing.Point(55, 10);
            this.radioNonVeg.Margin = new System.Windows.Forms.Padding(2);
            this.radioNonVeg.Name = "radioNonVeg";
            this.radioNonVeg.Size = new System.Drawing.Size(67, 17);
            this.radioNonVeg.TabIndex = 7;
            this.radioNonVeg.Text = "Non-Veg";
            this.radioNonVeg.UseVisualStyleBackColor = true;
            this.radioNonVeg.CheckedChanged += new System.EventHandler(this.radioNonVeg_CheckedChanged);
            // 
            // radioVegan
            // 
            this.radioVegan.AutoSize = true;
            this.radioVegan.Location = new System.Drawing.Point(129, 10);
            this.radioVegan.Margin = new System.Windows.Forms.Padding(2);
            this.radioVegan.Name = "radioVegan";
            this.radioVegan.Size = new System.Drawing.Size(56, 17);
            this.radioVegan.TabIndex = 8;
            this.radioVegan.Text = "Vegan";
            this.radioVegan.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblDiet);
            this.panel1.Controls.Add(this.numTargetWeight);
            this.panel1.Controls.Add(this.numCurrentWeight);
            this.panel1.Controls.Add(this.groupBoxGender);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblTargetWeight);
            this.panel1.Controls.Add(this.lblCurrentWeight);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblDob);
            this.panel1.Location = new System.Drawing.Point(19, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 309);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(664, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveUserDetailsNext);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTargetWeight;
        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.NumericUpDown numCurrentWeight;
        private System.Windows.Forms.NumericUpDown numTargetWeight;
        private System.Windows.Forms.Button saveUserDetailsNext;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioVeg;
        private System.Windows.Forms.RadioButton radioNonVeg;
        private System.Windows.Forms.RadioButton radioVegan;
        private System.Windows.Forms.Panel panel1;
    }
}