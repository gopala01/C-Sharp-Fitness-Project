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
            this.components = new System.ComponentModel.Container();
            this.numericUpDownCurrentWeight = new System.Windows.Forms.NumericUpDown();
            this.labelProgressCurrentWeight = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nEAAppDbDataSet1 = new LoginAndRegistrationForm2.NEAAppDbDataSet1();
            this.progress1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progress1TableAdapter = new LoginAndRegistrationForm2.NEAAppDbDataSet1TableAdapters.progress1TableAdapter();
            this.setDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdateProgress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEAAppDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress1BindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.setDateDataGridViewTextBoxColumn,
            this.currentWeightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.progress1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(177, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 221);
            this.dataGridView1.TabIndex = 2;
            // 
            // nEAAppDbDataSet1
            // 
            this.nEAAppDbDataSet1.DataSetName = "NEAAppDbDataSet1";
            this.nEAAppDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // progress1BindingSource
            // 
            this.progress1BindingSource.DataMember = "progress1";
            this.progress1BindingSource.DataSource = this.nEAAppDbDataSet1;
            // 
            // progress1TableAdapter
            // 
            this.progress1TableAdapter.ClearBeforeFill = true;
            // 
            // setDateDataGridViewTextBoxColumn
            // 
            this.setDateDataGridViewTextBoxColumn.DataPropertyName = "setDate";
            this.setDateDataGridViewTextBoxColumn.HeaderText = "setDate";
            this.setDateDataGridViewTextBoxColumn.Name = "setDateDataGridViewTextBoxColumn";
            // 
            // currentWeightDataGridViewTextBoxColumn
            // 
            this.currentWeightDataGridViewTextBoxColumn.DataPropertyName = "currentWeight";
            this.currentWeightDataGridViewTextBoxColumn.HeaderText = "currentWeight";
            this.currentWeightDataGridViewTextBoxColumn.Name = "currentWeightDataGridViewTextBoxColumn";
            // 
            // buttonUpdateProgress
            // 
            this.buttonUpdateProgress.Location = new System.Drawing.Point(283, 157);
            this.buttonUpdateProgress.Name = "buttonUpdateProgress";
            this.buttonUpdateProgress.Size = new System.Drawing.Size(147, 43);
            this.buttonUpdateProgress.TabIndex = 5;
            this.buttonUpdateProgress.Text = "Update";
            this.buttonUpdateProgress.UseVisualStyleBackColor = true;
            this.buttonUpdateProgress.Click += new System.EventHandler(this.buttonUpdateProgress_Click);
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.buttonUpdateProgress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelProgressCurrentWeight);
            this.Controls.Add(this.numericUpDownCurrentWeight);
            this.Name = "frmProgress";
            this.Text = "frmProgress";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEAAppDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCurrentWeight;
        private System.Windows.Forms.Label labelProgressCurrentWeight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NEAAppDbDataSet1 nEAAppDbDataSet1;
        private System.Windows.Forms.BindingSource progress1BindingSource;
        private NEAAppDbDataSet1TableAdapters.progress1TableAdapter progress1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn setDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdateProgress;
    }
}