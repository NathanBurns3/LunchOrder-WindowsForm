namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMainCourse = new System.Windows.Forms.GroupBox();
            this.gbOrderTotal = new System.Windows.Forms.GroupBox();
            this.gbAddOnItems = new System.Windows.Forms.GroupBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.gbMainCourse.SuspendLayout();
            this.gbOrderTotal.SuspendLayout();
            this.gbAddOnItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMainCourse
            // 
            this.gbMainCourse.Controls.Add(this.radSalad);
            this.gbMainCourse.Controls.Add(this.radPizza);
            this.gbMainCourse.Controls.Add(this.radHamburger);
            this.gbMainCourse.Location = new System.Drawing.Point(39, 38);
            this.gbMainCourse.Name = "gbMainCourse";
            this.gbMainCourse.Size = new System.Drawing.Size(400, 200);
            this.gbMainCourse.TabIndex = 0;
            this.gbMainCourse.TabStop = false;
            this.gbMainCourse.Text = "Main Course";
            // 
            // gbOrderTotal
            // 
            this.gbOrderTotal.Controls.Add(this.txtTotal);
            this.gbOrderTotal.Controls.Add(this.txtTax);
            this.gbOrderTotal.Controls.Add(this.txtSubtotal);
            this.gbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.gbOrderTotal.Controls.Add(this.lblTax);
            this.gbOrderTotal.Controls.Add(this.lblSubtotal);
            this.gbOrderTotal.Location = new System.Drawing.Point(39, 287);
            this.gbOrderTotal.Name = "gbOrderTotal";
            this.gbOrderTotal.Size = new System.Drawing.Size(503, 247);
            this.gbOrderTotal.TabIndex = 1;
            this.gbOrderTotal.TabStop = false;
            this.gbOrderTotal.Text = "Order Total";
            // 
            // gbAddOnItems
            // 
            this.gbAddOnItems.Controls.Add(this.chk3);
            this.gbAddOnItems.Controls.Add(this.chk2);
            this.gbAddOnItems.Controls.Add(this.chk1);
            this.gbAddOnItems.Location = new System.Drawing.Point(501, 38);
            this.gbAddOnItems.Name = "gbAddOnItems";
            this.gbAddOnItems.Size = new System.Drawing.Size(400, 200);
            this.gbAddOnItems.TabIndex = 2;
            this.gbAddOnItems.TabStop = false;
            this.gbAddOnItems.Text = "Add-on Items ($.75/each)";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(669, 321);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 46);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(669, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(21, 65);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(108, 32);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(21, 127);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(137, 32);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(21, 193);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(138, 32);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(178, 62);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(200, 39);
            this.txtSubtotal.TabIndex = 3;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(178, 124);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(200, 39);
            this.txtTax.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 190);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 39);
            this.txtTotal.TabIndex = 5;
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Checked = true;
            this.radHamburger.Location = new System.Drawing.Point(21, 51);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(247, 36);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(21, 104);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(179, 36);
            this.radPizza.TabIndex = 1;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(21, 158);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(190, 36);
            this.radSalad.TabIndex = 2;
            this.radSalad.Text = "Salad - $ 4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(18, 51);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(344, 36);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "Lettuce, tomato, and onions";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(18, 104);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(351, 36);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "Ketchup, mustard, and mayo";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(18, 158);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(170, 36);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "French fries";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 618);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gbAddOnItems);
            this.Controls.Add(this.gbOrderTotal);
            this.Controls.Add(this.gbMainCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbMainCourse.ResumeLayout(false);
            this.gbMainCourse.PerformLayout();
            this.gbOrderTotal.ResumeLayout(false);
            this.gbOrderTotal.PerformLayout();
            this.gbAddOnItems.ResumeLayout(false);
            this.gbAddOnItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbMainCourse;
        private RadioButton radSalad;
        private RadioButton radPizza;
        private RadioButton radHamburger;
        private GroupBox gbOrderTotal;
        private TextBox txtTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Label lblOrderTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private GroupBox gbAddOnItems;
        private CheckBox chk3;
        private CheckBox chk2;
        private CheckBox chk1;
        private Button btnPlaceOrder;
        private Button btnExit;
    }
}