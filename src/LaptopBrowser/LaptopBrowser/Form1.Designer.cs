namespace LaptopBrowser
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
            comboBoxModels = new ComboBox();
            labelTitle = new Label();
            pictureBoxLaptop = new PictureBox();
            labelPrice = new Label();
            labelProcessor = new Label();
            labelMemory = new Label();
            labelDisplay = new Label();
            labelGraphics = new Label();
            buttonBuy = new Button();
            checkBoxBackpack = new CheckBox();
            checkBoxOS = new CheckBox();
            checkBoxPayment = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaptop).BeginInit();
            SuspendLayout();
            // 
            // comboBoxModels
            // 
            comboBoxModels.FormattingEnabled = true;
            comboBoxModels.Location = new Point(12, 12);
            comboBoxModels.Name = "comboBoxModels";
            comboBoxModels.Size = new Size(151, 28);
            comboBoxModels.TabIndex = 0;
            comboBoxModels.SelectedIndexChanged += comboBoxModels_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(334, 85);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(97, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Laptop name";
            // 
            // pictureBoxLaptop
            // 
            pictureBoxLaptop.Location = new Point(334, 127);
            pictureBoxLaptop.Name = "pictureBoxLaptop";
            pictureBoxLaptop.Size = new Size(395, 286);
            pictureBoxLaptop.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLaptop.TabIndex = 2;
            pictureBoxLaptop.TabStop = false;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(777, 375);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(81, 38);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "price";
            labelPrice.Click += buttonBuy_Click;
            // 
            // labelProcessor
            // 
            labelProcessor.AutoSize = true;
            labelProcessor.Location = new Point(334, 432);
            labelProcessor.Name = "labelProcessor";
            labelProcessor.Size = new Size(36, 20);
            labelProcessor.TabIndex = 5;
            labelProcessor.Text = "CPU";
            // 
            // labelMemory
            // 
            labelMemory.AutoSize = true;
            labelMemory.Location = new Point(334, 465);
            labelMemory.Name = "labelMemory";
            labelMemory.Size = new Size(41, 20);
            labelMemory.TabIndex = 7;
            labelMemory.Text = "RAM";
            // 
            // labelDisplay
            // 
            labelDisplay.AutoSize = true;
            labelDisplay.Location = new Point(334, 494);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(58, 20);
            labelDisplay.TabIndex = 9;
            labelDisplay.Text = "Display";
            // 
            // labelGraphics
            // 
            labelGraphics.AutoSize = true;
            labelGraphics.Location = new Point(334, 524);
            labelGraphics.Name = "labelGraphics";
            labelGraphics.Size = new Size(66, 20);
            labelGraphics.TabIndex = 11;
            labelGraphics.Text = "Graphics";
            // 
            // buttonBuy
            // 
            buttonBuy.Location = new Point(944, 442);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(94, 29);
            buttonBuy.TabIndex = 12;
            buttonBuy.Text = "Купи";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // checkBoxBackpack
            // 
            checkBoxBackpack.AutoSize = true;
            checkBoxBackpack.Location = new Point(777, 136);
            checkBoxBackpack.Name = "checkBoxBackpack";
            checkBoxBackpack.Size = new Size(131, 24);
            checkBoxBackpack.TabIndex = 13;
            checkBoxBackpack.Text = "Раница +15лв.";
            checkBoxBackpack.UseVisualStyleBackColor = true;
            // 
            // checkBoxOS
            // 
            checkBoxOS.AutoSize = true;
            checkBoxOS.Location = new Point(777, 166);
            checkBoxOS.Name = "checkBoxOS";
            checkBoxOS.Size = new Size(141, 24);
            checkBoxOS.TabIndex = 14;
            checkBoxOS.Text = "Windows +15лв.";
            checkBoxOS.UseVisualStyleBackColor = true;
            // 
            // checkBoxPayment
            // 
            checkBoxPayment.AutoSize = true;
            checkBoxPayment.Location = new Point(777, 196);
            checkBoxPayment.Name = "checkBoxPayment";
            checkBoxPayment.Size = new Size(223, 24);
            checkBoxPayment.TabIndex = 16;
            checkBoxPayment.Text = "На изплащане 12мес. +20%";
            checkBoxPayment.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 623);
            Controls.Add(checkBoxPayment);
            Controls.Add(checkBoxOS);
            Controls.Add(checkBoxBackpack);
            Controls.Add(buttonBuy);
            Controls.Add(labelGraphics);
            Controls.Add(labelDisplay);
            Controls.Add(labelMemory);
            Controls.Add(labelProcessor);
            Controls.Add(labelPrice);
            Controls.Add(pictureBoxLaptop);
            Controls.Add(labelTitle);
            Controls.Add(comboBoxModels);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaptop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxModels;
        private Label labelTitle;
        private PictureBox pictureBoxLaptop;
        private Label labelPrice;
        private Label labelProcessor;
        private Label labelMemory;
        private Label labelDisplay;
        private Label labelGraphics;
        private Button buttonBuy;
        private CheckBox checkBoxBackpack;
        private CheckBox checkBoxOS;
        private CheckBox checkBoxPayment;
    }
}
