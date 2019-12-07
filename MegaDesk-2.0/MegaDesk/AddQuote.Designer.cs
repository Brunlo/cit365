namespace MegaDesk
{
    partial class AddQuote
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
            this.Cancel = new System.Windows.Forms.Button();
            this.getQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.numberOfDrawers = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.deliveryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shippingCost = new System.Windows.Forms.Label();
            this.structCost = new System.Windows.Forms.Label();
            this.surfCost = new System.Windows.Forms.Label();
            this.finalCost = new System.Windows.Forms.Label();
            this.surfaceCostlbl = new System.Windows.Forms.Label();
            this.structCostlbl = new System.Windows.Forms.Label();
            this.shippingCostlbl = new System.Windows.Forms.Label();
            this.finalCostlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(490, 262);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(190, 46);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Button2_Click);
            // 
            // getQuote
            // 
            this.getQuote.Location = new System.Drawing.Point(91, 262);
            this.getQuote.Name = "getQuote";
            this.getQuote.Size = new System.Drawing.Size(190, 46);
            this.getQuote.TabIndex = 2;
            this.getQuote.Text = "Get Quote";
            this.getQuote.UseVisualStyleBackColor = true;
            this.getQuote.Click += new System.EventHandler(this.GetQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers Name";
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(256, 60);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(424, 30);
            this.customerName.TabIndex = 4;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(140, 123);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(50, 20);
            this.width.TabIndex = 5;
            this.width.Text = "Width";
            this.width.Click += new System.EventHandler(this.Label2_Click);
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.AutoSize = true;
            this.numberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDrawers.Location = new System.Drawing.Point(384, 114);
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(149, 20);
            this.numberOfDrawers.TabIndex = 6;
            this.numberOfDrawers.Text = "Number Of Drawers";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(134, 200);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(56, 20);
            this.height.TabIndex = 7;
            this.height.Text = "Height";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterial.Location = new System.Drawing.Point(408, 155);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(125, 20);
            this.surfaceMaterial.TabIndex = 8;
            this.surfaceMaterial.Text = "Surface Material";
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.Location = new System.Drawing.Point(469, 200);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(64, 20);
            this.delivery.TabIndex = 9;
            this.delivery.Text = "Delivery";
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.Location = new System.Drawing.Point(215, 123);
            this.WidthUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthUpDown.Name = "WidthUpDown";
            this.WidthUpDown.Size = new System.Drawing.Size(66, 20);
            this.WidthUpDown.TabIndex = 10;
            this.WidthUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // HeightUpDown
            // 
            this.HeightUpDown.Location = new System.Drawing.Point(215, 203);
            this.HeightUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.HeightUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HeightUpDown.Name = "HeightUpDown";
            this.HeightUpDown.Size = new System.Drawing.Size(66, 20);
            this.HeightUpDown.TabIndex = 11;
            this.HeightUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDownDrawers
            // 
            this.numericUpDownDrawers.Location = new System.Drawing.Point(559, 114);
            this.numericUpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDrawers.Name = "numericUpDownDrawers";
            this.numericUpDownDrawers.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownDrawers.TabIndex = 12;
            this.numericUpDownDrawers.ValueChanged += new System.EventHandler(this.NumericUpDownDrawers_ValueChanged);
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Vaneer",
            "Pine"});
            this.materialBox.Location = new System.Drawing.Point(559, 157);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 21);
            this.materialBox.TabIndex = 13;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // deliveryBox
            // 
            this.deliveryBox.FormattingEnabled = true;
            this.deliveryBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.deliveryBox.Location = new System.Drawing.Point(559, 202);
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(121, 21);
            this.deliveryBox.TabIndex = 14;
            this.deliveryBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Add New Quote";
            this.label2.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // shippingCost
            // 
            this.shippingCost.AutoSize = true;
            this.shippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingCost.Location = new System.Drawing.Point(429, 337);
            this.shippingCost.Name = "shippingCost";
            this.shippingCost.Size = new System.Drawing.Size(108, 20);
            this.shippingCost.TabIndex = 16;
            this.shippingCost.Text = "ShippingCost:\r\n";
            this.shippingCost.Click += new System.EventHandler(this.ShippingCost_Click);
            // 
            // structCost
            // 
            this.structCost.AutoSize = true;
            this.structCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.structCost.Location = new System.Drawing.Point(74, 396);
            this.structCost.Name = "structCost";
            this.structCost.Size = new System.Drawing.Size(116, 20);
            this.structCost.TabIndex = 17;
            this.structCost.Text = "Structure Cost:";
            this.structCost.Click += new System.EventHandler(this.Label4_Click);
            // 
            // surfCost
            // 
            this.surfCost.AutoSize = true;
            this.surfCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfCost.Location = new System.Drawing.Point(84, 337);
            this.surfCost.Name = "surfCost";
            this.surfCost.Size = new System.Drawing.Size(106, 20);
            this.surfCost.TabIndex = 18;
            this.surfCost.Text = "Surface Cost:";
            this.surfCost.Click += new System.EventHandler(this.Label5_Click);
            // 
            // finalCost
            // 
            this.finalCost.AutoSize = true;
            this.finalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalCost.Location = new System.Drawing.Point(449, 396);
            this.finalCost.Name = "finalCost";
            this.finalCost.Size = new System.Drawing.Size(84, 20);
            this.finalCost.TabIndex = 19;
            this.finalCost.Text = "Final Cost:";
            // 
            // surfaceCostlbl
            // 
            this.surfaceCostlbl.AutoSize = true;
            this.surfaceCostlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceCostlbl.Location = new System.Drawing.Point(196, 337);
            this.surfaceCostlbl.Name = "surfaceCostlbl";
            this.surfaceCostlbl.Size = new System.Drawing.Size(0, 20);
            this.surfaceCostlbl.TabIndex = 20;
            this.surfaceCostlbl.Click += new System.EventHandler(this.Label3_Click);
            // 
            // structCostlbl
            // 
            this.structCostlbl.AutoSize = true;
            this.structCostlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.structCostlbl.Location = new System.Drawing.Point(196, 396);
            this.structCostlbl.Name = "structCostlbl";
            this.structCostlbl.Size = new System.Drawing.Size(0, 20);
            this.structCostlbl.TabIndex = 21;
            // 
            // shippingCostlbl
            // 
            this.shippingCostlbl.AutoSize = true;
            this.shippingCostlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingCostlbl.Location = new System.Drawing.Point(555, 337);
            this.shippingCostlbl.Name = "shippingCostlbl";
            this.shippingCostlbl.Size = new System.Drawing.Size(0, 20);
            this.shippingCostlbl.TabIndex = 22;
            // 
            // finalCostlbl
            // 
            this.finalCostlbl.AutoSize = true;
            this.finalCostlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalCostlbl.Location = new System.Drawing.Point(555, 396);
            this.finalCostlbl.Name = "finalCostlbl";
            this.finalCostlbl.Size = new System.Drawing.Size(0, 20);
            this.finalCostlbl.TabIndex = 23;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalCostlbl);
            this.Controls.Add(this.shippingCostlbl);
            this.Controls.Add(this.structCostlbl);
            this.Controls.Add(this.surfaceCostlbl);
            this.Controls.Add(this.finalCost);
            this.Controls.Add(this.surfCost);
            this.Controls.Add(this.structCost);
            this.Controls.Add(this.shippingCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliveryBox);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.numericUpDownDrawers);
            this.Controls.Add(this.HeightUpDown);
            this.Controls.Add(this.WidthUpDown);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.height);
            this.Controls.Add(this.numberOfDrawers);
            this.Controls.Add(this.width);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getQuote);
            this.Controls.Add(this.Cancel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button getQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label numberOfDrawers;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.NumericUpDown HeightUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawers;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.ComboBox deliveryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label shippingCost;
        private System.Windows.Forms.Label structCost;
        private System.Windows.Forms.Label surfCost;
        private System.Windows.Forms.Label finalCost;
        private System.Windows.Forms.Label surfaceCostlbl;
        private System.Windows.Forms.Label structCostlbl;
        private System.Windows.Forms.Label shippingCostlbl;
        private System.Windows.Forms.Label finalCostlbl;
    }
}