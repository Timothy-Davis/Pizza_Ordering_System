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
            this.cancel_button = new System.Windows.Forms.Button();
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
            this.total_label.Location = new System.Drawing.Point(306, 91);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(173, 24);
            this.total_label.TabIndex = 1;
            this.total_label.Text = "Grand Total: $10.00";
            // 
            // place_order_button
            // 
            this.place_order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.place_order_button.Location = new System.Drawing.Point(104, 195);
            this.place_order_button.Name = "place_order_button";
            this.place_order_button.Size = new System.Drawing.Size(157, 82);
            this.place_order_button.TabIndex = 2;
            this.place_order_button.Text = "Place Order";
            this.place_order_button.UseVisualStyleBackColor = true;
            this.place_order_button.Click += new System.EventHandler(this.place_order_button_Click);
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.return_button.Location = new System.Drawing.Point(310, 195);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(157, 82);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "Go Back";
            this.return_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancel_button.Location = new System.Drawing.Point(519, 195);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(157, 82);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // Finalize_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_button);
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
        private System.Windows.Forms.Button cancel_button;
    }
}