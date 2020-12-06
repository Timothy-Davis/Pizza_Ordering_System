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
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.cvvTextBox = new System.Windows.Forms.TextBox();
            this.expirationDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.total_label.Location = new System.Drawing.Point(306, 60);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(173, 24);
            this.total_label.TabIndex = 1;
            this.total_label.Text = "Grand Total: $10.00";
            // 
            // place_order_button
            // 
            this.place_order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.place_order_button.Location = new System.Drawing.Point(310, 267);
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
            this.return_button.Location = new System.Drawing.Point(226, 356);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(157, 82);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "Go Back";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancel_button.Location = new System.Drawing.Point(400, 356);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(157, 82);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.Location = new System.Drawing.Point(247, 112);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.cardNameTextBox.TabIndex = 5;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(247, 151);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(270, 20);
            this.cardNumberTextBox.TabIndex = 6;
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Location = new System.Drawing.Point(235, 187);
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(100, 20);
            this.cvvTextBox.TabIndex = 7;
            // 
            // expirationDateTextBox
            // 
            this.expirationDateTextBox.Location = new System.Drawing.Point(435, 187);
            this.expirationDateTextBox.Name = "expirationDateTextBox";
            this.expirationDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.expirationDateTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name on Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Expriation Date";
            // 
            // Finalize_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expirationDateTextBox);
            this.Controls.Add(this.cvvTextBox);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.cardNameTextBox);
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
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox cvvTextBox;
        private System.Windows.Forms.TextBox expirationDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}