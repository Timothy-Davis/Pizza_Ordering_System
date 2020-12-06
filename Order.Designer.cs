namespace Pizza_Ordering_System
{
    partial class Order
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
            this.menu_label = new System.Windows.Forms.Label();
            this.menuItem1 = new System.Windows.Forms.CheckBox();
            this.menuItem2 = new System.Windows.Forms.CheckBox();
            this.menuItem4 = new System.Windows.Forms.CheckBox();
            this.menuItem3 = new System.Windows.Forms.CheckBox();
            this.menuItem5 = new System.Windows.Forms.CheckBox();
            this.total_label = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.cancel_order_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.menu_label.Location = new System.Drawing.Point(353, 9);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(81, 31);
            this.menu_label.TabIndex = 0;
            this.menu_label.Text = "Menu";
            // 
            // menuItem1
            // 
            this.menuItem1.AutoSize = true;
            this.menuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuItem1.Location = new System.Drawing.Point(12, 68);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(307, 24);
            this.menuItem1.TabIndex = 1;
            this.menuItem1.Text = "El Diablo: Pizza with Jalapeno     $10.00";
            this.menuItem1.UseVisualStyleBackColor = true;
            this.menuItem1.CheckedChanged += new System.EventHandler(this.menuItem1_CheckedChanged);
            // 
            // menuItem2
            // 
            this.menuItem2.AutoSize = true;
            this.menuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuItem2.Location = new System.Drawing.Point(12, 109);
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(322, 24);
            this.menuItem2.TabIndex = 2;
            this.menuItem2.Text = "Classic: Pepperoni (can\'t go wrong)     $10\r\n";
            this.menuItem2.UseVisualStyleBackColor = true;
            this.menuItem2.CheckedChanged += new System.EventHandler(this.menuItem2_CheckedChanged);
            // 
            // menuItem4
            // 
            this.menuItem4.AutoSize = true;
            this.menuItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuItem4.Location = new System.Drawing.Point(12, 190);
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(322, 24);
            this.menuItem4.TabIndex = 4;
            this.menuItem4.Text = "Salty Fish Pizza: It has anchovies     $2.00";
            this.menuItem4.UseVisualStyleBackColor = true;
            this.menuItem4.CheckedChanged += new System.EventHandler(this.menuItem4_CheckedChanged);
            // 
            // menuItem3
            // 
            this.menuItem3.AutoSize = true;
            this.menuItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuItem3.Location = new System.Drawing.Point(12, 149);
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(344, 24);
            this.menuItem3.TabIndex = 3;
            this.menuItem3.Text = "Gucci Supreme: It\'s got everything     $10000";
            this.menuItem3.UseVisualStyleBackColor = true;
            this.menuItem3.CheckedChanged += new System.EventHandler(this.menuItem3_CheckedChanged);
            // 
            // menuItem5
            // 
            this.menuItem5.AutoSize = true;
            this.menuItem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuItem5.Location = new System.Drawing.Point(12, 230);
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(354, 24);
            this.menuItem5.TabIndex = 5;
            this.menuItem5.Text = "Three Meat: Pepperoni, Bacon, Ham     $10.00";
            this.menuItem5.UseVisualStyleBackColor = true;
            this.menuItem5.CheckedChanged += new System.EventHandler(this.menuItem5_CheckedChanged);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.total_label.Location = new System.Drawing.Point(671, 61);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(67, 31);
            this.total_label.TabIndex = 7;
            this.total_label.Text = "0.00";
            // 
            // confirm_button
            // 
            this.confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirm_button.Location = new System.Drawing.Point(231, 362);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(125, 46);
            this.confirm_button.TabIndex = 8;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // cancel_order_button
            // 
            this.cancel_order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancel_order_button.Location = new System.Drawing.Point(405, 362);
            this.cancel_order_button.Name = "cancel_order_button";
            this.cancel_order_button.Size = new System.Drawing.Size(125, 46);
            this.cancel_order_button.TabIndex = 9;
            this.cancel_order_button.Text = "Cancel";
            this.cancel_order_button.UseVisualStyleBackColor = true;
            this.cancel_order_button.Click += new System.EventHandler(this.cancel_order_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(569, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total: $";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_order_button);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.menuItem5);
            this.Controls.Add(this.menuItem4);
            this.Controls.Add(this.menuItem3);
            this.Controls.Add(this.menuItem2);
            this.Controls.Add(this.menuItem1);
            this.Controls.Add(this.menu_label);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.CheckBox menuItem1;
        private System.Windows.Forms.CheckBox menuItem2;
        private System.Windows.Forms.CheckBox menuItem4;
        private System.Windows.Forms.CheckBox menuItem3;
        private System.Windows.Forms.CheckBox menuItem5;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button cancel_order_button;
        private System.Windows.Forms.Label label1;
    }
}