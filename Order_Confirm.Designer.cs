namespace Pizza_Ordering_System
{
    partial class Order_Confirm
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
            this.order_label = new System.Windows.Forms.Label();
            this.order_info = new System.Windows.Forms.RichTextBox();
            this.subtotal_label = new System.Windows.Forms.Label();
            this.checkout_button = new System.Windows.Forms.Button();
            this.go_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.order_label.Location = new System.Drawing.Point(13, 13);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(91, 20);
            this.order_label.TabIndex = 0;
            this.order_label.Text = "Your Order:";
            // 
            // order_info
            // 
            this.order_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.order_info.Location = new System.Drawing.Point(110, 15);
            this.order_info.Name = "order_info";
            this.order_info.Size = new System.Drawing.Size(346, 77);
            this.order_info.TabIndex = 2;
            this.order_info.Text = "";
            // 
            // subtotal_label
            // 
            this.subtotal_label.AutoSize = true;
            this.subtotal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subtotal_label.Location = new System.Drawing.Point(333, 107);
            this.subtotal_label.Name = "subtotal_label";
            this.subtotal_label.Size = new System.Drawing.Size(123, 20);
            this.subtotal_label.TabIndex = 3;
            this.subtotal_label.Text = "subtotal: $10.00";
            // 
            // checkout_button
            // 
            this.checkout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkout_button.Location = new System.Drawing.Point(169, 159);
            this.checkout_button.Name = "checkout_button";
            this.checkout_button.Size = new System.Drawing.Size(237, 57);
            this.checkout_button.TabIndex = 35;
            this.checkout_button.Text = "Proceed to Checkout";
            this.checkout_button.UseVisualStyleBackColor = true;
            this.checkout_button.Click += new System.EventHandler(this.checkout_button_Click);
            // 
            // go_back_button
            // 
            this.go_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.go_back_button.Location = new System.Drawing.Point(240, 222);
            this.go_back_button.Name = "go_back_button";
            this.go_back_button.Size = new System.Drawing.Size(91, 34);
            this.go_back_button.TabIndex = 36;
            this.go_back_button.Text = "Go Back";
            this.go_back_button.UseVisualStyleBackColor = true;
            this.go_back_button.Click += new System.EventHandler(this.go_back_button_Click);
            // 
            // Order_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 297);
            this.Controls.Add(this.go_back_button);
            this.Controls.Add(this.checkout_button);
            this.Controls.Add(this.subtotal_label);
            this.Controls.Add(this.order_info);
            this.Controls.Add(this.order_label);
            this.Name = "Order_Confirm";
            this.Text = "Order_Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.RichTextBox order_info;
        private System.Windows.Forms.Label subtotal_label;
        private System.Windows.Forms.Button checkout_button;
        private System.Windows.Forms.Button go_back_button;
    }
}