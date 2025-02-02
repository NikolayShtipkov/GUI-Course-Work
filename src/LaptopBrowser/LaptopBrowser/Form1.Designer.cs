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
            labelTitle.Location = new Point(334, 133);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(97, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Laptop name";
            // 
            // pictureBoxLaptop
            // 
            pictureBoxLaptop.Location = new Point(334, 195);
            pictureBoxLaptop.Name = "pictureBoxLaptop";
            pictureBoxLaptop.Size = new Size(180, 103);
            pictureBoxLaptop.TabIndex = 2;
            pictureBoxLaptop.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 623);
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
    }
}
