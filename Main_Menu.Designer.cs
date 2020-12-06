namespace Pizza_Ordering_System
{
    partial class Main_Menu
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
            this.logged_in_label = new System.Windows.Forms.Label();
            this.signinLabel = new System.Windows.Forms.Label();
            this.create_order_button = new System.Windows.Forms.Button();
            this.view_orders_bttn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.logout_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logged_in_label
            // 
            this.logged_in_label.AutoSize = true;
            this.logged_in_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logged_in_label.Location = new System.Drawing.Point(1176, 11);
            this.logged_in_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logged_in_label.Name = "logged_in_label";
            this.logged_in_label.Size = new System.Drawing.Size(181, 25);
            this.logged_in_label.TabIndex = 0;
            this.logged_in_label.Text = "Currently logged in:";
            // 
            // signinLabel
            // 
            this.signinLabel.AutoSize = true;
            this.signinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.signinLabel.Location = new System.Drawing.Point(1200, 46);
            this.signinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signinLabel.Name = "signinLabel";
            this.signinLabel.Size = new System.Drawing.Size(136, 25);
            this.signinLabel.TabIndex = 1;
            this.signinLabel.Text = "Timothy Davis";
            // 
            // create_order_button
            // 
            this.create_order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.create_order_button.Location = new System.Drawing.Point(632, 303);
            this.create_order_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create_order_button.Name = "create_order_button";
            this.create_order_button.Size = new System.Drawing.Size(284, 135);
            this.create_order_button.TabIndex = 3;
            this.create_order_button.Text = "Create Order";
            this.create_order_button.UseVisualStyleBackColor = true;
            this.create_order_button.Click += new System.EventHandler(this.create_order_button_Click);
            // 
            // view_orders_bttn
            // 
            this.view_orders_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_orders_bttn.Location = new System.Drawing.Point(1181, 135);
            this.view_orders_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_orders_bttn.Name = "view_orders_bttn";
            this.view_orders_bttn.Size = new System.Drawing.Size(176, 53);
            this.view_orders_bttn.TabIndex = 4;
            this.view_orders_bttn.Text = "View Orders";
            this.view_orders_bttn.UseVisualStyleBackColor = true;
            this.view_orders_bttn.Click += new System.EventHandler(this.view_orders_bttn_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.SystemColors.Info;
            this.logo.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Red;
            this.logo.Location = new System.Drawing.Point(303, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(792, 97);
            this.logo.TabIndex = 9;
            this.logo.Text = "Tony\'s Tantalizing Treats";
            // 
            // logout_bttn
            // 
            this.logout_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_bttn.Location = new System.Drawing.Point(1203, 85);
            this.logout_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_bttn.Name = "logout_bttn";
            this.logout_bttn.Size = new System.Drawing.Size(133, 36);
            this.logout_bttn.TabIndex = 10;
            this.logout_bttn.Text = "Log out";
            this.logout_bttn.UseVisualStyleBackColor = true;
            this.logout_bttn.Click += new System.EventHandler(this.logout_bttn_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 786);
            this.Controls.Add(this.logout_bttn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.view_orders_bttn);
            this.Controls.Add(this.create_order_button);
            this.Controls.Add(this.signinLabel);
            this.Controls.Add(this.logged_in_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Menu";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logged_in_label;
        private System.Windows.Forms.Label signinLabel;
        private System.Windows.Forms.Button create_order_button;
        private System.Windows.Forms.Button view_orders_bttn;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button logout_bttn;
    }
}