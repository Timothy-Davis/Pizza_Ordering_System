namespace Pizza_Ordering_System
{
    partial class Sign_In
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
            this.sign_in_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.sign_in_submit_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sign_in_label
            // 
            this.sign_in_label.AutoSize = true;
            this.sign_in_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.sign_in_label.Location = new System.Drawing.Point(542, 179);
            this.sign_in_label.Name = "sign_in_label";
            this.sign_in_label.Size = new System.Drawing.Size(143, 46);
            this.sign_in_label.TabIndex = 1;
            this.sign_in_label.Text = "Sign In";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.username_label.Location = new System.Drawing.Point(425, 248);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(102, 25);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.password_label.Location = new System.Drawing.Point(425, 303);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(98, 25);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(533, 248);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(185, 20);
            this.UsernameBox.TabIndex = 4;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(533, 303);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(185, 20);
            this.PasswordBox.TabIndex = 5;
            // 
            // sign_in_submit_button
            // 
            this.sign_in_submit_button.Location = new System.Drawing.Point(570, 347);
            this.sign_in_submit_button.Name = "sign_in_submit_button";
            this.sign_in_submit_button.Size = new System.Drawing.Size(100, 35);
            this.sign_in_submit_button.TabIndex = 6;
            this.sign_in_submit_button.Text = "Submit";
            this.sign_in_submit_button.UseVisualStyleBackColor = true;
            this.sign_in_submit_button.Click += new System.EventHandler(this.sign_in_submit_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(570, 398);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(100, 35);
            this.register_button.TabIndex = 7;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.SystemColors.Info;
            this.logo.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Red;
            this.logo.Location = new System.Drawing.Point(296, 7);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(633, 79);
            this.logo.TabIndex = 8;
            this.logo.Text = "Tony\'s Tantalizing Treats";
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 545);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.sign_in_submit_button);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.sign_in_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sign_In";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sign_in_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button sign_in_submit_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label logo;
    }
}

