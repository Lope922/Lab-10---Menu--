namespace Project_10
{
    partial class Form1
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxAddOns = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButtonHamburger = new System.Windows.Forms.RadioButton();
            this.radioButtonPizza = new System.Windows.Forms.RadioButton();
            this.radioButtonSalad = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.groupBoxAddOns.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(33, 233);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(148, 233);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxAddOns
            // 
            this.groupBoxAddOns.Controls.Add(this.panel1);
            this.groupBoxAddOns.Controls.Add(this.checkBox5);
            this.groupBoxAddOns.Controls.Add(this.checkBox4);
            this.groupBoxAddOns.Controls.Add(this.checkBox3);
            this.groupBoxAddOns.Controls.Add(this.checkBox2);
            this.groupBoxAddOns.Controls.Add(this.checkBox1);
            this.groupBoxAddOns.Location = new System.Drawing.Point(53, 82);
            this.groupBoxAddOns.Name = "groupBoxAddOns";
            this.groupBoxAddOns.Size = new System.Drawing.Size(275, 100);
            this.groupBoxAddOns.TabIndex = 5;
            this.groupBoxAddOns.TabStop = false;
            this.groupBoxAddOns.Text = "Add Ons:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(256, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 90);
            this.panel1.TabIndex = 11;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(139, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(139, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButtonHamburger
            // 
            this.radioButtonHamburger.AutoSize = true;
            this.radioButtonHamburger.Location = new System.Drawing.Point(45, 19);
            this.radioButtonHamburger.Name = "radioButtonHamburger";
            this.radioButtonHamburger.Size = new System.Drawing.Size(77, 17);
            this.radioButtonHamburger.TabIndex = 4;
            this.radioButtonHamburger.TabStop = true;
            this.radioButtonHamburger.Text = "Hamburger";
            this.radioButtonHamburger.UseVisualStyleBackColor = true;
            this.radioButtonHamburger.CheckedChanged += new System.EventHandler(this.radioButtonHamburger_CheckedChanged);
            // 
            // radioButtonPizza
            // 
            this.radioButtonPizza.AutoSize = true;
            this.radioButtonPizza.Location = new System.Drawing.Point(138, 19);
            this.radioButtonPizza.Name = "radioButtonPizza";
            this.radioButtonPizza.Size = new System.Drawing.Size(50, 17);
            this.radioButtonPizza.TabIndex = 5;
            this.radioButtonPizza.TabStop = true;
            this.radioButtonPizza.Text = "Pizza";
            this.radioButtonPizza.UseVisualStyleBackColor = true;
            this.radioButtonPizza.CheckedChanged += new System.EventHandler(this.radioButtonPizza_CheckedChanged);
            // 
            // radioButtonSalad
            // 
            this.radioButtonSalad.AutoSize = true;
            this.radioButtonSalad.Location = new System.Drawing.Point(199, 19);
            this.radioButtonSalad.Name = "radioButtonSalad";
            this.radioButtonSalad.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSalad.TabIndex = 6;
            this.radioButtonSalad.TabStop = true;
            this.radioButtonSalad.Text = "Salad";
            this.radioButtonSalad.UseVisualStyleBackColor = true;
            this.radioButtonSalad.CheckedChanged += new System.EventHandler(this.radioButtonSalad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonHamburger);
            this.groupBox2.Controls.Add(this.radioButtonPizza);
            this.groupBox2.Controls.Add(this.radioButtonSalad);
            this.groupBox2.Location = new System.Drawing.Point(40, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Dish Menu Items :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(321, 196);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 13);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "Tax :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(321, 219);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total :";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(321, 243);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(456, 290);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.groupBoxAddOns);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAddOns.ResumeLayout(false);
            this.groupBoxAddOns.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxAddOns;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButtonHamburger;
        private System.Windows.Forms.RadioButton radioButtonPizza;
        private System.Windows.Forms.RadioButton radioButtonSalad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
    }
}

