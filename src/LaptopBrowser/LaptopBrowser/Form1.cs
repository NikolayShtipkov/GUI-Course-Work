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
        }

        private void InitializeLaptops()
        {
            laptops = new Dictionary<string, Laptop>
            {
                { "Dell XPS 13",
                    new Laptop("Dell XPS 13", "dell.jpg", 2000, "Intel i7", "16GB", 13.3, "Intel Iris") },
                { "HP Spectre x360",
                    new Laptop("HP Spectre x360", "hp.jpg", 1800, "Intel i5", "8GB", 14, "Intel UHD") }
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
                pictureBoxLaptop.ImageLocation = laptop.ImagePath;
                labelPrice.Text = $"Цена: {laptop.Price} лв.";
                labelProcessor.Text = $"Процесор: {laptop.Processor}";
                labelMemory.Text = $"Памет: {laptop.Memory}";
                labelDisplay.Text = $"Дисплей: {laptop.Display}";
                labelGraphics.Text = $"Видео карта: {laptop.GraphicsCard}";

                if (File.Exists(laptop.ImagePath))
                {
                    pictureBoxLaptop.Image = Image.FromFile(laptop.ImagePath);
                }
                else
                {
                    pictureBoxLaptop.Image = null; // Set a default image or leave blank
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxModels.SelectedItem is string selectedModel && laptops!.ContainsKey(selectedModel))
            {
                var laptop = laptops[selectedModel];
                decimal finalPrice = laptop.Price;

                if (checkBoxBackpack.Checked) finalPrice += 15;
                if (checkBoxOS.Checked) finalPrice += 15;

                string paymentMethod;
                if (checkBoxPayment.Checked)
                {
                    finalPrice *= 1.2m; // Увеличение с 20%
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
