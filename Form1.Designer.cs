namespace pizza
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
            this.lTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lTotalPriceValue = new System.Windows.Forms.Label();
            this.lWhereToEatValue = new System.Windows.Forms.Label();
            this.lCrustTypeValue = new System.Windows.Forms.Label();
            this.lToppingsValue = new System.Windows.Forms.Label();
            this.lSizeValue = new System.Windows.Forms.Label();
            this.lTotalPrice = new System.Windows.Forms.Label();
            this.lWhereToEat = new System.Windows.Forms.Label();
            this.lCrustType = new System.Windows.Forms.Label();
            this.lToppings = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLargSize = new System.Windows.Forms.RadioButton();
            this.rbMeduimSize = new System.Windows.Forms.RadioButton();
            this.rbSmallSize = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbMashrooms = new System.Windows.Forms.CheckBox();
            this.chbExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbFormPizza = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbFormPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("UKIJ Diwani Tom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lTitle.Location = new System.Drawing.Point(255, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(327, 56);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Order your pizza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lTotalPriceValue);
            this.groupBox1.Controls.Add(this.lWhereToEatValue);
            this.groupBox1.Controls.Add(this.lCrustTypeValue);
            this.groupBox1.Controls.Add(this.lToppingsValue);
            this.groupBox1.Controls.Add(this.lSizeValue);
            this.groupBox1.Controls.Add(this.lTotalPrice);
            this.groupBox1.Controls.Add(this.lWhereToEat);
            this.groupBox1.Controls.Add(this.lCrustType);
            this.groupBox1.Controls.Add(this.lToppings);
            this.groupBox1.Controls.Add(this.lSize);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(587, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 310);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // lTotalPriceValue
            // 
            this.lTotalPriceValue.AutoSize = true;
            this.lTotalPriceValue.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lTotalPriceValue.Location = new System.Drawing.Point(113, 267);
            this.lTotalPriceValue.Name = "lTotalPriceValue";
            this.lTotalPriceValue.Size = new System.Drawing.Size(56, 33);
            this.lTotalPriceValue.TabIndex = 9;
            this.lTotalPriceValue.Text = "$20";
            // 
            // lWhereToEatValue
            // 
            this.lWhereToEatValue.AutoSize = true;
            this.lWhereToEatValue.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWhereToEatValue.Location = new System.Drawing.Point(130, 193);
            this.lWhereToEatValue.Name = "lWhereToEatValue";
            this.lWhereToEatValue.Size = new System.Drawing.Size(54, 20);
            this.lWhereToEatValue.TabIndex = 8;
            this.lWhereToEatValue.Text = "Eat in";
            // 
            // lCrustTypeValue
            // 
            this.lCrustTypeValue.AutoSize = true;
            this.lCrustTypeValue.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCrustTypeValue.Location = new System.Drawing.Point(115, 153);
            this.lCrustTypeValue.Name = "lCrustTypeValue";
            this.lCrustTypeValue.Size = new System.Drawing.Size(43, 20);
            this.lCrustTypeValue.TabIndex = 7;
            this.lCrustTypeValue.Text = "Thin";
            // 
            // lToppingsValue
            // 
            this.lToppingsValue.AutoSize = true;
            this.lToppingsValue.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToppingsValue.Location = new System.Drawing.Point(44, 94);
            this.lToppingsValue.MaximumSize = new System.Drawing.Size(221, 0);
            this.lToppingsValue.Name = "lToppingsValue";
            this.lToppingsValue.Size = new System.Drawing.Size(152, 20);
            this.lToppingsValue.TabIndex = 6;
            this.lToppingsValue.Text = "There is no Toppings";
            // 
            // lSizeValue
            // 
            this.lSizeValue.AutoSize = true;
            this.lSizeValue.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSizeValue.Location = new System.Drawing.Point(67, 33);
            this.lSizeValue.Name = "lSizeValue";
            this.lSizeValue.Size = new System.Drawing.Size(47, 20);
            this.lSizeValue.TabIndex = 5;
            this.lSizeValue.Text = "Small";
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPrice.Location = new System.Drawing.Point(23, 273);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(93, 20);
            this.lTotalPrice.TabIndex = 4;
            this.lTotalPrice.Text = "Total Price: ";
            // 
            // lWhereToEat
            // 
            this.lWhereToEat.AutoSize = true;
            this.lWhereToEat.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWhereToEat.Location = new System.Drawing.Point(23, 193);
            this.lWhereToEat.Name = "lWhereToEat";
            this.lWhereToEat.Size = new System.Drawing.Size(104, 20);
            this.lWhereToEat.TabIndex = 3;
            this.lWhereToEat.Text = "Where to eat: ";
            // 
            // lCrustType
            // 
            this.lCrustType.AutoSize = true;
            this.lCrustType.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCrustType.Location = new System.Drawing.Point(23, 153);
            this.lCrustType.Name = "lCrustType";
            this.lCrustType.Size = new System.Drawing.Size(93, 20);
            this.lCrustType.TabIndex = 2;
            this.lCrustType.Text = "Crust Type: ";
            // 
            // lToppings
            // 
            this.lToppings.AutoSize = true;
            this.lToppings.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToppings.Location = new System.Drawing.Point(23, 68);
            this.lToppings.Name = "lToppings";
            this.lToppings.Size = new System.Drawing.Size(80, 20);
            this.lToppings.TabIndex = 1;
            this.lToppings.Text = "Toppings: ";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.Location = new System.Drawing.Point(23, 32);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(46, 20);
            this.lSize.TabIndex = 0;
            this.lSize.Text = "Size: ";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOrderPizza.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.White;
            this.btnOrderPizza.Location = new System.Drawing.Point(263, 389);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(138, 47);
            this.btnOrderPizza.TabIndex = 10;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Gold;
            this.btnResetForm.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.White;
            this.btnResetForm.Location = new System.Drawing.Point(431, 389);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(138, 47);
            this.btnResetForm.TabIndex = 11;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLargSize);
            this.gbSize.Controls.Add(this.rbMeduimSize);
            this.gbSize.Controls.Add(this.rbSmallSize);
            this.gbSize.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(14, 18);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 149);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLargSize
            // 
            this.rbLargSize.AutoSize = true;
            this.rbLargSize.Location = new System.Drawing.Point(22, 113);
            this.rbLargSize.Name = "rbLargSize";
            this.rbLargSize.Size = new System.Drawing.Size(61, 24);
            this.rbLargSize.TabIndex = 4;
            this.rbLargSize.TabStop = true;
            this.rbLargSize.Tag = "35";
            this.rbLargSize.Text = "Larg";
            this.rbLargSize.UseVisualStyleBackColor = true;
            this.rbLargSize.CheckedChanged += new System.EventHandler(this.rbLargSize_CheckedChanged);
            // 
            // rbMeduimSize
            // 
            this.rbMeduimSize.AutoSize = true;
            this.rbMeduimSize.Location = new System.Drawing.Point(22, 72);
            this.rbMeduimSize.Name = "rbMeduimSize";
            this.rbMeduimSize.Size = new System.Drawing.Size(89, 24);
            this.rbMeduimSize.TabIndex = 3;
            this.rbMeduimSize.TabStop = true;
            this.rbMeduimSize.Tag = "30";
            this.rbMeduimSize.Text = "Meduim";
            this.rbMeduimSize.UseVisualStyleBackColor = true;
            this.rbMeduimSize.CheckedChanged += new System.EventHandler(this.rbMeduimSize_CheckedChanged);
            // 
            // rbSmallSize
            // 
            this.rbSmallSize.AutoSize = true;
            this.rbSmallSize.Checked = true;
            this.rbSmallSize.Location = new System.Drawing.Point(22, 31);
            this.rbSmallSize.Name = "rbSmallSize";
            this.rbSmallSize.Size = new System.Drawing.Size(69, 24);
            this.rbSmallSize.TabIndex = 2;
            this.rbSmallSize.TabStop = true;
            this.rbSmallSize.Tag = "20";
            this.rbSmallSize.Text = "Small";
            this.rbSmallSize.UseVisualStyleBackColor = true;
            this.rbSmallSize.CheckedChanged += new System.EventHandler(this.rbSmallSize_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(14, 188);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 112);
            this.gbCrustType.TabIndex = 5;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(22, 72);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(70, 24);
            this.rbThickCrust.TabIndex = 3;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "5";
            this.rbThickCrust.Text = "Thick";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(22, 31);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(64, 24);
            this.rbThinCrust.TabIndex = 2;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(243, 188);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(293, 112);
            this.gbWhereToEat.TabIndex = 6;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where to eat?";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(22, 72);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(91, 24);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(22, 31);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(75, 24);
            this.rbEatIn.TabIndex = 2;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chbGreenPeppers);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbOnion);
            this.gbToppings.Controls.Add(this.chbTomatoes);
            this.gbToppings.Controls.Add(this.chbMashrooms);
            this.gbToppings.Controls.Add(this.chbExtraCheese);
            this.gbToppings.Location = new System.Drawing.Point(243, 18);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(293, 149);
            this.gbToppings.TabIndex = 7;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbGreenPeppers
            // 
            this.chbGreenPeppers.AutoSize = true;
            this.chbGreenPeppers.Location = new System.Drawing.Point(155, 113);
            this.chbGreenPeppers.Name = "chbGreenPeppers";
            this.chbGreenPeppers.Size = new System.Drawing.Size(127, 24);
            this.chbGreenPeppers.TabIndex = 5;
            this.chbGreenPeppers.Tag = "2";
            this.chbGreenPeppers.Text = "Green Peppers";
            this.chbGreenPeppers.UseVisualStyleBackColor = true;
            this.chbGreenPeppers.CheckedChanged += new System.EventHandler(this.chbGreenPeppers_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(155, 72);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(73, 24);
            this.chbOlives.TabIndex = 4;
            this.chbOlives.Tag = "1";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(155, 31);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(74, 24);
            this.chbOnion.TabIndex = 3;
            this.chbOnion.Tag = "1";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(22, 114);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(94, 24);
            this.chbTomatoes.TabIndex = 2;
            this.chbTomatoes.Tag = "2";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbMashrooms
            // 
            this.chbMashrooms.AutoSize = true;
            this.chbMashrooms.Location = new System.Drawing.Point(22, 72);
            this.chbMashrooms.Name = "chbMashrooms";
            this.chbMashrooms.Size = new System.Drawing.Size(111, 24);
            this.chbMashrooms.TabIndex = 1;
            this.chbMashrooms.Tag = "3";
            this.chbMashrooms.Text = "Mushrooms";
            this.chbMashrooms.UseVisualStyleBackColor = true;
            this.chbMashrooms.CheckedChanged += new System.EventHandler(this.chbMashrooms_CheckedChanged);
            // 
            // chbExtraCheese
            // 
            this.chbExtraCheese.AutoSize = true;
            this.chbExtraCheese.Location = new System.Drawing.Point(22, 31);
            this.chbExtraCheese.Name = "chbExtraCheese";
            this.chbExtraCheese.Size = new System.Drawing.Size(120, 24);
            this.chbExtraCheese.TabIndex = 0;
            this.chbExtraCheese.Tag = "3";
            this.chbExtraCheese.Text = "Extra Cheese";
            this.chbExtraCheese.UseVisualStyleBackColor = true;
            this.chbExtraCheese.CheckedChanged += new System.EventHandler(this.chbExtraCheese_CheckedChanged);
            // 
            // gbFormPizza
            // 
            this.gbFormPizza.Controls.Add(this.gbSize);
            this.gbFormPizza.Controls.Add(this.gbToppings);
            this.gbFormPizza.Controls.Add(this.gbCrustType);
            this.gbFormPizza.Controls.Add(this.gbWhereToEat);
            this.gbFormPizza.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormPizza.Location = new System.Drawing.Point(22, 73);
            this.gbFormPizza.Name = "gbFormPizza";
            this.gbFormPizza.Size = new System.Drawing.Size(547, 310);
            this.gbFormPizza.TabIndex = 12;
            this.gbFormPizza.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 229);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 28);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "N. Pizza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pizza.Properties.Resources.pizza_bg;
            this.ClientSize = new System.Drawing.Size(910, 461);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.gbFormPizza);
            this.Name = "Form1";
            this.Text = "Order Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbFormPizza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lTotalPrice;
        private System.Windows.Forms.Label lWhereToEat;
        private System.Windows.Forms.Label lCrustType;
        private System.Windows.Forms.Label lToppings;
        private System.Windows.Forms.Label lSizeValue;
        private System.Windows.Forms.Label lTotalPriceValue;
        private System.Windows.Forms.Label lWhereToEatValue;
        private System.Windows.Forms.Label lCrustTypeValue;
        private System.Windows.Forms.Label lToppingsValue;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLargSize;
        private System.Windows.Forms.RadioButton rbMeduimSize;
        private System.Windows.Forms.RadioButton rbSmallSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbGreenPeppers;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMashrooms;
        private System.Windows.Forms.CheckBox chbExtraCheese;
        private System.Windows.Forms.GroupBox gbFormPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

