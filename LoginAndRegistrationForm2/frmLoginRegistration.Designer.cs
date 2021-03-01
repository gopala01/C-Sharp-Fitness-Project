namespace LoginAndRegistrationForm2
{
    partial class frmLogin
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
            this.goToRegister = new System.Windows.Forms.Button();
            this.goToLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordL = new System.Windows.Forms.TextBox();
            this.textBoxUsernameL = new System.Windows.Forms.TextBox();
            this.labelPasswordL = new System.Windows.Forms.Label();
            this.labelUsernameL = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordR = new System.Windows.Forms.TextBox();
            this.textBoxUsernameR = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPasswordR = new System.Windows.Forms.Label();
            this.labelUsernameR = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // goToRegister
            // 
            this.goToRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.goToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goToRegister.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToRegister.ForeColor = System.Drawing.Color.White;
            this.goToRegister.Location = new System.Drawing.Point(18, 16);
            this.goToRegister.Name = "goToRegister";
            this.goToRegister.Size = new System.Drawing.Size(257, 86);
            this.goToRegister.TabIndex = 0;
            this.goToRegister.Text = "REGISTER";
            this.goToRegister.UseVisualStyleBackColor = false;
            this.goToRegister.Click += new System.EventHandler(this.goToRegister_Click);
            // 
            // goToLogin
            // 
            this.goToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.goToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goToLogin.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLogin.ForeColor = System.Drawing.Color.White;
            this.goToLogin.Location = new System.Drawing.Point(361, 16);
            this.goToLogin.Name = "goToLogin";
            this.goToLogin.Size = new System.Drawing.Size(256, 86);
            this.goToLogin.TabIndex = 1;
            this.goToLogin.Text = "LOGIN";
            this.goToLogin.UseVisualStyleBackColor = false;
            this.goToLogin.Click += new System.EventHandler(this.goToLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panelLogin.Controls.Add(this.flowLayoutPanel1);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPasswordL);
            this.panelLogin.Controls.Add(this.textBoxUsernameL);
            this.panelLogin.Controls.Add(this.labelPasswordL);
            this.panelLogin.Controls.Add(this.labelUsernameL);
            this.panelLogin.Location = new System.Drawing.Point(18, 118);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(599, 322);
            this.panelLogin.TabIndex = 5;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(523, 218);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Orange;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(170, 194);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(235, 65);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordL
            // 
            this.textBoxPasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordL.Location = new System.Drawing.Point(286, 111);
            this.textBoxPasswordL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswordL.Multiline = true;
            this.textBoxPasswordL.Name = "textBoxPasswordL";
            this.textBoxPasswordL.PasswordChar = '*';
            this.textBoxPasswordL.Size = new System.Drawing.Size(275, 43);
            this.textBoxPasswordL.TabIndex = 4;
            // 
            // textBoxUsernameL
            // 
            this.textBoxUsernameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameL.Location = new System.Drawing.Point(286, 42);
            this.textBoxUsernameL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsernameL.Multiline = true;
            this.textBoxUsernameL.Name = "textBoxUsernameL";
            this.textBoxUsernameL.Size = new System.Drawing.Size(275, 43);
            this.textBoxUsernameL.TabIndex = 3;
            this.textBoxUsernameL.TextChanged += new System.EventHandler(this.textBoxUsernameL_TextChanged);
            // 
            // labelPasswordL
            // 
            this.labelPasswordL.AutoSize = true;
            this.labelPasswordL.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordL.ForeColor = System.Drawing.Color.White;
            this.labelPasswordL.Location = new System.Drawing.Point(51, 111);
            this.labelPasswordL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordL.Name = "labelPasswordL";
            this.labelPasswordL.Size = new System.Drawing.Size(208, 42);
            this.labelPasswordL.TabIndex = 1;
            this.labelPasswordL.Text = "PASSWORD";
            // 
            // labelUsernameL
            // 
            this.labelUsernameL.AutoSize = true;
            this.labelUsernameL.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameL.ForeColor = System.Drawing.Color.White;
            this.labelUsernameL.Location = new System.Drawing.Point(51, 42);
            this.labelUsernameL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsernameL.Name = "labelUsernameL";
            this.labelUsernameL.Size = new System.Drawing.Size(204, 42);
            this.labelUsernameL.TabIndex = 0;
            this.labelUsernameL.Text = "USERNAME";
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.textBoxConfirmPassword);
            this.panelRegister.Controls.Add(this.textBoxPasswordR);
            this.panelRegister.Controls.Add(this.textBoxUsernameR);
            this.panelRegister.Controls.Add(this.textBoxLastName);
            this.panelRegister.Controls.Add(this.textBoxFirstName);
            this.panelRegister.Controls.Add(this.labelConfirmPassword);
            this.panelRegister.Controls.Add(this.labelPasswordR);
            this.panelRegister.Controls.Add(this.labelUsernameR);
            this.panelRegister.Controls.Add(this.labelLastName);
            this.panelRegister.Controls.Add(this.labelFirstName);
            this.panelRegister.Location = new System.Drawing.Point(16, 118);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(601, 324);
            this.panelRegister.TabIndex = 2;
            this.panelRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegister_Paint);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LightBlue;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(181, 250);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(235, 65);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(314, 197);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxConfirmPassword.Multiline = true;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(275, 43);
            this.textBoxConfirmPassword.TabIndex = 15;
            // 
            // textBoxPasswordR
            // 
            this.textBoxPasswordR.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordR.Location = new System.Drawing.Point(314, 149);
            this.textBoxPasswordR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswordR.Multiline = true;
            this.textBoxPasswordR.Name = "textBoxPasswordR";
            this.textBoxPasswordR.PasswordChar = '*';
            this.textBoxPasswordR.Size = new System.Drawing.Size(275, 43);
            this.textBoxPasswordR.TabIndex = 14;
            // 
            // textBoxUsernameR
            // 
            this.textBoxUsernameR.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameR.Location = new System.Drawing.Point(314, 104);
            this.textBoxUsernameR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsernameR.Multiline = true;
            this.textBoxUsernameR.Name = "textBoxUsernameR";
            this.textBoxUsernameR.Size = new System.Drawing.Size(275, 43);
            this.textBoxUsernameR.TabIndex = 13;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(314, 58);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(275, 43);
            this.textBoxLastName.TabIndex = 12;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(314, 10);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(275, 43);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Location = new System.Drawing.Point(29, 197);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(270, 42);
            this.labelConfirmPassword.TabIndex = 10;
            this.labelConfirmPassword.Text = "CONFIRM PASS";
            // 
            // labelPasswordR
            // 
            this.labelPasswordR.AutoSize = true;
            this.labelPasswordR.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordR.ForeColor = System.Drawing.Color.White;
            this.labelPasswordR.Location = new System.Drawing.Point(29, 149);
            this.labelPasswordR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordR.Name = "labelPasswordR";
            this.labelPasswordR.Size = new System.Drawing.Size(208, 42);
            this.labelPasswordR.TabIndex = 9;
            this.labelPasswordR.Text = "PASSWORD";
            // 
            // labelUsernameR
            // 
            this.labelUsernameR.AutoSize = true;
            this.labelUsernameR.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameR.ForeColor = System.Drawing.Color.White;
            this.labelUsernameR.Location = new System.Drawing.Point(29, 104);
            this.labelUsernameR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsernameR.Name = "labelUsernameR";
            this.labelUsernameR.Size = new System.Drawing.Size(204, 42);
            this.labelUsernameR.TabIndex = 8;
            this.labelUsernameR.Text = "USERNAME";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.White;
            this.labelLastName.Location = new System.Drawing.Point(29, 58);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(211, 42);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "LAST NAME";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.White;
            this.labelFirstName.Location = new System.Drawing.Point(29, 10);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(220, 42);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "FIRST NAME";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(633, 469);
            this.Controls.Add(this.goToLogin);
            this.Controls.Add(this.goToRegister);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelRegister);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login and Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goToRegister;
        private System.Windows.Forms.Button goToLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswordL;
        private System.Windows.Forms.TextBox textBoxUsernameL;
        private System.Windows.Forms.Label labelPasswordL;
        private System.Windows.Forms.Label labelUsernameL;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPasswordR;
        private System.Windows.Forms.TextBox textBoxUsernameR;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelPasswordR;
        private System.Windows.Forms.Label labelUsernameR;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

