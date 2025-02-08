namespace LaptopBrowser
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Laptop>? laptops;

        public Form1()
        {
            Text = "Продажба на лаптопи";
            Size = new Size(600, 500);

            InitializeComponent();
            InitializeLaptops();
            SelectFirstLaptop();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxQuantity.Items.Add(i);
            }

            comboBoxQuantity.SelectedIndex = 0;
        }

        private void InitializeLaptops()
        {
            string imagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            laptops = new Dictionary<string, Laptop>
            {
                { "Dell XPS 13",
                    new Laptop("Dell XPS 13", Path.Combine(imagesPath, "dell"), 3789, "Intel i7", "16GB", 13.3, "Intel Iris") },
                { "HP Spectre x360",
                    new Laptop("HP Spectre x360", Path.Combine(imagesPath, "hp"), 3149, "Intel i5", "8GB", 14, "Intel UHD") }
            };

            foreach (var model in laptops.Keys)
            {
                comboBoxModels.Items.Add(model);
            }
        }

        private void SelectFirstLaptop()
        {
            if (comboBoxModels.Items.Count > 0)
            {
                comboBoxModels.SelectedIndex = 0;
            }
        }

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModels.SelectedItem is string selectedModel && laptops!.ContainsKey(selectedModel))
            {
                var laptop = laptops[selectedModel];
                labelTitle.Text = laptop.Name;
                labelPrice.Text = $"Цена: {laptop.Price} лв.";
                labelProcessor.Text = $"Процесор: {laptop.Processor}";
                labelMemory.Text = $"Памет: {laptop.Memory}";
                labelDisplay.Text = $"Дисплей: {laptop.Display}";
                labelGraphics.Text = $"Видео карта: {laptop.GraphicsCard}";

                string[] imageFiles = Directory.GetFiles(laptop.ImageFolder, "*.jpg");
                if (imageFiles.Length == 0)
                {
                    MessageBox.Show("No images found in the folder: " + laptop.ImageFolder);
                    return;
                }

                try
                {
                    pictureBoxLaptop.Image = Image.FromFile(imageFiles[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {imageFiles[0]}\n{ex.Message}");
                }

                for (int i = 0; i <= 3; i++)
                {
                    int picNum = i + 1;
                    PictureBox thumbnailBox = (PictureBox)Controls.Find("smallPictureBox" + picNum, true)[0];
                    try
                    {
                        thumbnailBox.Image = Image.FromFile(imageFiles[i]);
                        thumbnailBox.Tag = imageFiles[i];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading thumbnail: {imageFiles[i]}\n{ex.Message}");
                    }
                }
            }
        }

        private void SmallPicture_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = (PictureBox)sender;
            if (clickedBox.Tag is string imagePath && File.Exists(imagePath))
            {
                pictureBoxLaptop.Image = Image.FromFile(imagePath);
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxModels.SelectedItem is string selectedModel && laptops!.ContainsKey(selectedModel))
            {
                var laptop = laptops[selectedModel];
                decimal finalPrice = laptop.Price;

                int quantity = comboBoxQuantity.SelectedItem is int ? (int)comboBoxQuantity.SelectedItem : 1;
                finalPrice = laptop.Price * quantity;

                if (checkBoxBackpack.Checked) finalPrice += 30;
                if (checkBoxOS.Checked) finalPrice += 15;

                string paymentMethod;
                if (checkBoxPayment.Checked)
                {
                    finalPrice *= 1.2m;
                    decimal monthlyPayment = finalPrice / 12;
                    paymentMethod = $"На изплащане (Месечна вноска: {monthlyPayment:F2} лв.)";
                }
                else
                {
                    paymentMethod = "Еднократно";
                }

                string message = $"Закупихте: {laptop.Name}\nЦена: {finalPrice} лв.\nНачин на плащане: {paymentMethod}";
                MessageBox.Show(message, "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
