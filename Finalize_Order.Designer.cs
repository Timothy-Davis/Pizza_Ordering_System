namespace Pizza_Ordering_System
{
    partial class Finalize_Order
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
            this.finalize_order_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.place_order_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.order_info = new System.Windows.Forms.RichTextBox();
            this.order_label = new System.Windows.Forms.Label();
            this.subtotal_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finalize_order_label
            // 
            this.finalize_order_label.AutoSize = true;
            this.finalize_order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.finalize_order_label.Location = new System.Drawing.Point(273, 9);
            this.finalize_order_label.Name = "finalize_order_label";
            this.finalize_order_label.Size = new System.Drawing.Size(244, 31);
            this.finalize_order_label.TabIndex = 0;
            this.finalize_order_label.Text = "Finalize your Order";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.total_label.Location = new System.Drawing.Point(319, 251);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(173, 24);
            this.total_label.TabIndex = 1;
            this.total_label.Text = "Grand Total: $10.00";
            // 
            // place_order_button
            // 
            this.place_order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.place_order_button.Location = new System.Drawing.Point(236, 319);
            this.place_order_button.Name = "place_order_button";
            this.place_order_button.Size = new System.Drawing.Size(157, 83);
            this.place_order_button.TabIndex = 2;
            this.place_order_button.Text = "Place Order";
            this.place_order_button.UseVisualStyleBackColor = true;
            this.place_order_button.Click += new System.EventHandler(this.place_order_button_Click);
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.return_button.Location = new System.Drawing.Point(425, 320);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(157, 82);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "Go Back";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // order_info
            // 
            this.order_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.order_info.Location = new System.Drawing.Point(236, 62);
            this.order_info.Name = "order_info";
            this.order_info.Size = new System.Drawing.Size(346, 77);
            this.order_info.TabIndex = 5;
            this.order_info.Text = "";
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.order_label.Location = new System.Drawing.Point(139, 60);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(91, 20);
            this.order_label.TabIndex = 4;
            this.order_label.Text = "Your Order:";
            // 
            // subtotal_label
            // 
            this.subtotal_label.AutoSize = true;
            this.subtotal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subtotal_label.Location = new System.Drawing.Point(459, 154);
            this.subtotal_label.Name = "subtotal_label";
            this.subtotal_label.Size = new System.Drawing.Size(123, 20);
            this.subtotal_label.TabIndex = 6;
            this.subtotal_label.Text = "subtotal: $10.00";
            // 
            // Finalize_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subtotal_label);
            this.Controls.Add(this.order_info);
            this.Controls.Add(this.order_label);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.place_order_button);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.finalize_order_label);
            this.Name = "Finalize_Order";
            this.Text = "Finalize_Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label finalize_order_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Button place_order_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.RichTextBox order_info;
        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.Label subtotal_label;
    }
}