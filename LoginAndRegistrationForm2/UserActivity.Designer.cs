
namespace LoginAndRegistrationForm2
{
    partial class UserActivity
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
            this.mainMenu = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ForeColor = System.Drawing.Color.White;
            this.mainMenu.Location = new System.Drawing.Point(139, 159);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(259, 84);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "MAIN MENU";
            this.mainMenu.UseVisualStyleBackColor = false;
            // 
            // Quiz
            // 
            this.Quiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz.ForeColor = System.Drawing.Color.White;
            this.Quiz.Location = new System.Drawing.Point(525, 155);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(199, 87);
            this.Quiz.TabIndex = 1;
            this.Quiz.Text = "QUIZ";
            this.Quiz.UseVisualStyleBackColor = false;
            this.Quiz.Click += new System.EventHandler(this.Quiz_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(139, 300);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(259, 84);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(525, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 87);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(995, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.mainMenu);
            this.Name = "UserActivity";
            this.Text = "User Activity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserActivity_FormClosed);
            this.Load += new System.EventHandler(this.UserActivity_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button Quiz;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button1;
    }
}