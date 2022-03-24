namespace CS311_Project3_ASG
{
    partial class mnForm
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
            this.lblPizzaPlace = new System.Windows.Forms.Label();
            this.pictPizza = new System.Windows.Forms.PictureBox();
            this.cboPizzaSize = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbJalapeno = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.rtfOrderSummary = new System.Windows.Forms.RichTextBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPizzaPlace
            // 
            this.lblPizzaPlace.AutoSize = true;
            this.lblPizzaPlace.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPizzaPlace.Location = new System.Drawing.Point(301, 84);
            this.lblPizzaPlace.Name = "lblPizzaPlace";
            this.lblPizzaPlace.Size = new System.Drawing.Size(533, 114);
            this.lblPizzaPlace.TabIndex = 0;
            this.lblPizzaPlace.Text = "Gordy\'s Pizza Place\r\n\r\n";
            // 
            // pictPizza
            // 
            this.pictPizza.Image = global::CS311_Project3_ASG.Properties.Resources.pizza;
            this.pictPizza.Location = new System.Drawing.Point(12, 34);
            this.pictPizza.Name = "pictPizza";
            this.pictPizza.Size = new System.Drawing.Size(290, 180);
            this.pictPizza.TabIndex = 1;
            this.pictPizza.TabStop = false;
            // 
            // cboPizzaSize
            // 
            this.cboPizzaSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboPizzaSize.FormattingEnabled = true;
            this.cboPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboPizzaSize.Location = new System.Drawing.Point(83, 22);
            this.cboPizzaSize.Name = "cboPizzaSize";
            this.cboPizzaSize.Size = new System.Drawing.Size(121, 27);
            this.cboPizzaSize.TabIndex = 2;
            this.cboPizzaSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbMushroom);
            this.groupBox1.Controls.Add(this.ckbExtraCheese);
            this.groupBox1.Controls.Add(this.ckbJalapeno);
            this.groupBox1.Controls.Add(this.ckbBananaPeppers);
            this.groupBox1.Controls.Add(this.ckbGreenOlives);
            this.groupBox1.Controls.Add(this.ckbBlackOlives);
            this.groupBox1.Controls.Add(this.ckbGreenPepper);
            this.groupBox1.Controls.Add(this.ckbOnion);
            this.groupBox1.Controls.Add(this.ckbSpicyItalianSausage);
            this.groupBox1.Controls.Add(this.ckbCanadianBacon);
            this.groupBox1.Controls.Add(this.ckbSausage);
            this.groupBox1.Controls.Add(this.ckbPepperoni);
            this.groupBox1.Controls.Add(this.lblToppings);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblPizzaSize);
            this.groupBox1.Controls.Add(this.cboPizzaSize);
            this.groupBox1.Location = new System.Drawing.Point(78, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(466, 180);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(93, 20);
            this.ckbMushroom.TabIndex = 17;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbExtraCheese.Location = new System.Drawing.Point(466, 156);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(111, 20);
            this.ckbExtraCheese.TabIndex = 16;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            this.ckbJalapeno.AutoSize = true;
            this.ckbJalapeno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbJalapeno.Location = new System.Drawing.Point(466, 130);
            this.ckbJalapeno.Name = "ckbJalapeno";
            this.ckbJalapeno.Size = new System.Drawing.Size(83, 20);
            this.ckbJalapeno.TabIndex = 15;
            this.ckbJalapeno.Text = "Jalapeno";
            this.ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBananaPeppers.Location = new System.Drawing.Point(466, 104);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(131, 20);
            this.ckbBananaPeppers.TabIndex = 14;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenOlives.Location = new System.Drawing.Point(304, 182);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(106, 20);
            this.ckbGreenOlives.TabIndex = 13;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBlackOlives.Location = new System.Drawing.Point(304, 156);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(101, 20);
            this.ckbBlackOlives.TabIndex = 12;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenPepper.Location = new System.Drawing.Point(304, 130);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(114, 20);
            this.ckbGreenPepper.TabIndex = 11;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(304, 104);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(62, 20);
            this.ckbOnion.TabIndex = 10;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(110, 182);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(164, 20);
            this.ckbSpicyItalianSausage.TabIndex = 9;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage\r\n";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbCanadianBacon.Location = new System.Drawing.Point(110, 156);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(128, 20);
            this.ckbCanadianBacon.TabIndex = 8;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            this.ckbCanadianBacon.CheckedChanged += new System.EventHandler(this.ckbCanadianBacon_CheckedChanged);
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(110, 130);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(81, 20);
            this.ckbSausage.TabIndex = 7;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbPepperoni.Location = new System.Drawing.Point(110, 104);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(91, 20);
            this.ckbPepperoni.TabIndex = 6;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            this.ckbPepperoni.CheckedChanged += new System.EventHandler(this.ckbPepperoni_CheckedChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(16, 79);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(116, 22);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "Toppings:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoRegular);
            this.groupBox2.Controls.Add(this.rdoThick);
            this.groupBox2.Controls.Add(this.lblCrustType);
            this.groupBox2.Controls.Add(this.rdoThin);
            this.groupBox2.Location = new System.Drawing.Point(222, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 40);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoRegular.Location = new System.Drawing.Point(353, 7);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(75, 20);
            this.rdoRegular.TabIndex = 6;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            this.rdoRegular.CheckedChanged += new System.EventHandler(this.rboRegular_CheckedChanged);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThick.Location = new System.Drawing.Point(244, 7);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(57, 20);
            this.rdoThick.TabIndex = 5;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rboThick_CheckedChanged);
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrustType.Location = new System.Drawing.Point(0, 11);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(136, 22);
            this.lblCrustType.TabIndex = 4;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThin.Location = new System.Drawing.Point(154, 7);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(51, 20);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.Text = "Thin\r\n";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoThin_CheckedChanged);
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPizzaSize.Location = new System.Drawing.Point(16, 23);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(61, 22);
            this.lblPizzaSize.TabIndex = 3;
            this.lblPizzaSize.Text = "Size:";
            // 
            // rtfOrderSummary
            // 
            this.rtfOrderSummary.Location = new System.Drawing.Point(216, 458);
            this.rtfOrderSummary.Name = "rtfOrderSummary";
            this.rtfOrderSummary.Size = new System.Drawing.Size(373, 133);
            this.rtfOrderSummary.TabIndex = 4;
            this.rtfOrderSummary.Text = "";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderSummary.Location = new System.Drawing.Point(24, 458);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(186, 22);
            this.lblOrderSummary.TabIndex = 6;
            this.lblOrderSummary.Text = "Order Summary:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(606, 561);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 28);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(681, 457);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(96, 23);
            this.txtSubTotal.TabIndex = 8;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(587, 461);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(88, 19);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "SubTotal:";
            this.lblSubTotal.Click += new System.EventHandler(this.lblSubTotal_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(629, 493);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(46, 19);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(681, 494);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(96, 23);
            this.txtTax.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(681, 532);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 23);
            this.txtTotal.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(629, 531);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 19);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Tax:";
            // 
            // mnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 615);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.rtfOrderSummary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictPizza);
            this.Controls.Add(this.lblPizzaPlace);
            this.Name = "mnForm";
            this.Text = "Gordy\'s Pizza Palace";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label lblPizzaPlace;
        private PictureBox pictPizza;
        private ComboBox cboPizzaSize;
        private GroupBox groupBox1;
        private Label lblPizzaSize;
        private GroupBox groupBox2;
        private RadioButton rdoThin;
        private RadioButton rdoThick;
        private Label lblCrustType;
        private RadioButton rdoRegular;
        private CheckBox ckbMushroom;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbJalapeno;
        private CheckBox ckbBananaPeppers;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbPepperoni;
        private Label lblToppings;
        private RichTextBox rtfOrderSummary;
        private Label lblOrderSummary;
        private Button btnCalculate;
        private TextBox txtSubTotal;
        private Label lblSubTotal;
        private Label lblTax;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Label lblTotal;
    }
}