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
            this.label1 = new System.Windows.Forms.Label();
            this.pizzeria_header = new System.Windows.Forms.Label();
            this.create_order_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logged_in_label
            // 
            this.logged_in_label.AutoSize = true;
            this.logged_in_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logged_in_label.Location = new System.Drawing.Point(882, 9);
            this.logged_in_label.Name = "logged_in_label";
            this.logged_in_label.Size = new System.Drawing.Size(144, 20);
            this.logged_in_label.TabIndex = 0;
            this.logged_in_label.Text = "Currently logged in:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(900, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timothy Davis";
            // 
            // pizzeria_header
            // 
            this.pizzeria_header.AutoSize = true;
            this.pizzeria_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.pizzeria_header.Location = new System.Drawing.Point(12, 9);
            this.pizzeria_header.Name = "pizzeria_header";
            this.pizzeria_header.Size = new System.Drawing.Size(629, 63);
            this.pizzeria_header.TabIndex = 2;
            this.pizzeria_header.Text = "Tony\'s Tentalizing Treats";
            // 
            // create_order_button
            // 
            this.create_order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.create_order_button.Location = new System.Drawing.Point(428, 269);
            this.create_order_button.Name = "create_order_button";
            this.create_order_button.Size = new System.Drawing.Size(213, 110);
            this.create_order_button.TabIndex = 3;
            this.create_order_button.Text = "Create Order";
            this.create_order_button.UseVisualStyleBackColor = true;
            this.create_order_button.Click += new System.EventHandler(this.create_order_button_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 639);
            this.Controls.Add(this.create_order_button);
            this.Controls.Add(this.pizzeria_header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logged_in_label);
            this.Name = "Main_Menu";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logged_in_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pizzeria_header;
        private System.Windows.Forms.Button create_order_button;
    }
}