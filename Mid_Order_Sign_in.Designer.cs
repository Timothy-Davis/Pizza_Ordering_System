namespace Pizza_Ordering_System
{
    partial class Mid_Order_Sign_in
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
            this.register_button = new System.Windows.Forms.Button();
            this.sign_in_submit_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.sign_in_label = new System.Windows.Forms.Label();
            this.pizzeria_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(347, 353);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(100, 35);
            this.register_button.TabIndex = 15;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            // 
            // sign_in_submit_button
            // 
            this.sign_in_submit_button.Location = new System.Drawing.Point(347, 302);
            this.sign_in_submit_button.Name = "sign_in_submit_button";
            this.sign_in_submit_button.Size = new System.Drawing.Size(100, 35);
            this.sign_in_submit_button.TabIndex = 14;
            this.sign_in_submit_button.Text = "Submit";
            this.sign_in_submit_button.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 12;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.password_label.Location = new System.Drawing.Point(202, 258);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(98, 25);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.username_label.Location = new System.Drawing.Point(202, 203);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(102, 25);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "Username";
            // 
            // sign_in_label
            // 
            this.sign_in_label.AutoSize = true;
            this.sign_in_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.sign_in_label.Location = new System.Drawing.Point(319, 134);
            this.sign_in_label.Name = "sign_in_label";
            this.sign_in_label.Size = new System.Drawing.Size(143, 46);
            this.sign_in_label.TabIndex = 9;
            this.sign_in_label.Text = "Sign In";
            // 
            // pizzeria_header
            // 
            this.pizzeria_header.AutoSize = true;
            this.pizzeria_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.pizzeria_header.Location = new System.Drawing.Point(12, 9);
            this.pizzeria_header.Name = "pizzeria_header";
            this.pizzeria_header.Size = new System.Drawing.Size(776, 76);
            this.pizzeria_header.TabIndex = 8;
            this.pizzeria_header.Text = "Tony\'s Tentalizing Treats";
            // 
            // Mid_Order_Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.sign_in_submit_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.sign_in_label);
            this.Controls.Add(this.pizzeria_header);
            this.Name = "Mid_Order_Sign_in";
            this.Text = "Mid_Order_Sign_in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button sign_in_submit_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label sign_in_label;
        private System.Windows.Forms.Label pizzeria_header;
    }
}